Public Class SubFrameCalculatorForm

    ' Windows Visual Basic Windows Form Application: SubFrame Calculator
    ' 
    ' ------------------------------------------------------------------------
    '
    '               Author: R.McAlister (2014) Adapted for tool kit 2016
    '
    ' ------------------------------------------------------------------------
    '
    'The purpose of this tool is to determine the optimum subframe exposure length for the current
    '  seeing and light pollution qualities using TSX Camera Add-On.
    '
    'The app takes a 60 second exposure then produces a recommendation window to display computed
    '   optimal exposure length and duration for a one hour shoot, based on average background noise.
    '
    ' The algorithms are based on work by ... 
    '   John Smith: http://www.hiddenloft.com/notes/SubExposures.pdf
    '   Charles Anstey: http://www.cloudynights.com/item.php?item_id=1622
    '   Steve Cannistra: http://www.starrywonders.com/snr.html
    '
    '  The algorithms require the following imaging parameters, Most of which are currently supplied by TSX.
    '    For details, see the above articles.
    '
    '  Gain:  electrons per ADU for the CCD
    '  Readout Noise:  read out noise in electrons
    '  Maximum Noise Factor:  Maximum tolerable contribution of readout noise
    '  Exposure Reduction:  Exposure reduction factor
    '  SLambda:  Faint target ADU minimum
    '  SNR Target: Fraction of maximum achievable signal to noise ratio (Cannistra)
    '  Pedestal:  base pedestal
    '


    Private Sub SubFrameCalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the gain and read noise defaults from the background module, until I figure out something better
        GainBox.Value = CCDGain
        RNoiseBox.Value = CCDReadNoise
        Return

    End Sub

    Private Sub ImageButton_Click(sender As Object, e As EventArgs) Handles ImageButton.Click
        TakeImage()
        Return
    End Sub


    Private Sub AnalyzeButton_Click(sender As Object, e As EventArgs) Handles AnalyzeButton.Click
        AnalyzeExposure()
        Return
    End Sub


    Public Sub TakeImage()

        'Open camera control and connect it to hardware
        Dim tsx_cc = CreateObject("theskyx.ccdsoftcamera")
        Try
            tsx_cc.Connect()
        Catch ex As Exception
            MsgBox("Camera Connect Error: " + ex.Message)
        End Try
        'turn on autosave
        tsx_cc.autosaveon = 1
        'Set for 60 second exposure, light frame with autodark
        tsx_cc.ExposureTime = 60
        tsx_cc.Frame = theskyxLib.ccdsoftImageFrame.cdLight
        tsx_cc.ImageReduction = theskyxLib.ccdsoftImageReduction.cdAutoDark
        tsx_cc.FilterIndexZeroBased = 3     'Assumed Lumescent, but change accordingly
        tsx_cc.Delay = 5                    'Possible filter change = 5 sec delay
        tsx_cc.Asynchronous = True          'Going to do a wait loop
        tsx_cc.TakeImage()
        Do While tsx_cc.state = theskyxLib.ccdsoftCameraState.cdStateTakePicture
            System.Threading.Thread.Sleep(1000)
        Loop
        Return

    End Sub

    Public Sub AnalyzeExposure()

        Dim totalexp As Integer     'Minutes for total exposure sequence
        Dim gain As Double          'electrons per ADU:  .37 for SBIG STF8000M, .87 for SBIG 11002
        Dim rnoise As Double        'read out noise in electrons: 9.3 for SBIG STF8300M, 11 for SBIG 11002
        Dim noisefac As Double      'maximum tolerable contribution of readout noise
        'Dim expfac As Double       'Exposure reduction factor -- Not used at this time
        Dim slambda As Double       'Faint target ADU minimum
        Dim snrtgt As Double        'fraction of maximum achievable signal to noise ratio (Cannistra)
        Dim filters As Integer      'Number of filters to be imaged

        'Create image object
        Dim tsx_im = CreateObject("TheSkyX.ccdsoftImage")
        Dim imgerr As Integer = 0
        'Open the active image, if any
        Try
            imgerr = tsx_im.AttachToActive()
        Catch ex As Exception
            MsgBox("No Image Available:  " & Str(imgerr))
            tsx_im = Nothing
            Return
        End Try

        gain = GainBox.Value                        'electrons per ADU:  .37 for SBIG STF8000M, .87 for SBIG 11002
        rnoise = RNoiseBox.Value                    'read out noise in electrons: 9.3 for SBIG STF8300M, 11 for SBIG 11002
        noisefac = MaxNoiseBox.Value / 100          'maximum tolerable contribution of readout noise (%)
        ' expfac  = ReductionBox.Value              'Exposure reduction factor -- Not used at this time
        slambda = SLambdaBox.Value                  'Faint target ADU minimum
        snrtgt = SNRTgtBox.Value                    'fraction of maximum achievable signal to noise ratio (Cannistra)
        filters = filtersBox.Value                  'Number of filters to be imaged
        totalexp = AvailableHoursBox.Value * 60     'Minutes for total exposure sequence

        Dim pedestal As Integer    'base pedestal
        Dim px As Integer
        Dim py As Integer
        Dim pxbin As Integer
        Dim pybin As Integer

        Dim exptime As Double

        Dim avgABU As Double
        Dim esky As Double
        Dim torn As Double

        'Presumably an Image Link has already been performed
        'Check on this is TBD

        Try
            pedestal = tsx_im.FITSKeyword("PEDESTAL")
        Catch ex As Exception
            pedestal = 0
        End Try
        px = tsx_im.FITSKeyword("NAXIS1")
        py = tsx_im.FITSKeyword("NAXIS2")
        pxbin = tsx_im.FITSKeyword("XBINNING")
        pybin = tsx_im.FITSKeyword("YBINNING")
        'gain = tsx_im.FITSKeyword("EGAIN")
        exptime = tsx_im.FITSKeyword("EXPTIME")

        px = px - 1
        py = py - 1

        avgABU = tsx_im.averagePixelValue()
        esky = ((avgABU + pedestal) * gain) / exptime
        torn = (rnoise ^ 2) / ((((1 + noisefac) ^ 2) - 1) * esky)

        Dim exp1 As Integer = Int(torn / 2)
        Dim reps1 As Integer = Int((((totalexp * 60) / torn) - 1) * 2)

        Dim exp2 As Integer = Int((slambda * Math.Sqrt(totalexp * 60)) / (2 * Math.Sqrt(avgABU / exptime)))
        Dim reps2 As Integer = Int((totalexp * 60) / exp2 / filters)

        Dim exp3 As Integer = Int((snrtgt ^ 2) * (rnoise ^ 2)) / ((esky) * (1 - (snrtgt ^ 2)))
        Dim reps3 As Integer = Int((totalexp * 60) / exp3 / filters)

        SmExpLabel.Text = Str(exp1)
        SmExpCntLabel.Text = Str(reps1)
        AnExpLabel.Text = Str(exp2)
        AnExpCntLabel.Text = Str(reps2)
        CaExpLabel.Text = Str(exp3)
        CaExpCntLabel.Text = Str(reps3)

        'Clean up
        tsx_im = Nothing
        Return
    End Sub


    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'Clean up and close application

        Close()
        Return

    End Sub

   
    Private Sub OverviewButton_Click(sender As Object, e As EventArgs) Handles OverviewButton.Click
        MsgBox(Overview)
        Return
    End Sub

  
End Class
