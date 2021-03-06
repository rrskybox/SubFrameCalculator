﻿Module background

    Public Const CCDGain = 0.87         'STXL 11000M
    Public Const CCDReadNoise = 11.0    'STXL 11000M

    Public Overview As String = "" +
"Simple sub-exposure strategies concentrate exclusively on optimization against random internal noise sources.  Such " +
"calculations utilize fixed parameters from one's CCD specification like read noise, dark current, etc.  However, they " +
"fail to compensate for the envioronmental non-random sources of noise such as light pollution, sky glow, turbulence which " +
"vary from night to night and location to location.  These critical factors can only be accurately derived from an " +
"appropriate reference image.  Three authors have developed optimal sub-frame exposure algorithms that account for noise " +
"contribution from both internal (equipment) sources and external (atmospheric) sources. " +
vbCrLf + vbCrLf +
 "Smith's analysis and algorithm considers both of the two sources of noise in images – random noise and non-random noise. " +
"His method produces a longer total exposure times but assumes a little more image processing complexity on the back end, " +
"e.g. dithered image acquisition and outlier-rejection combining algorithms.  The key operative variable for Smith the is " +
"the maximum Read Noise percentage contribution to the acquired image. " +
vbCrLf + vbCrLf +
"Cannestra's algorithm is a variation on Smith's.  Whereas Smith's approach is to optimize the length of each sub-frame " +
"Cannestra 's algorithm looks to optimize the signal to noise ratio of the final, stacked image.  The operative parameter " +
"here is that target SNR for the collection.  The calculated sub-frame exposure, however, remains in the ballpark with Smith. " +
vbCrLf + vbCrLf +
"Anstey mostly rejects the SNR-only approach based on his experience with much longer sub-frame exposures than " +
"Smith's algorithm would recommend.  He asserts that a sub-frame exposure must account first for acquisition of the faintest " +
"target desired, then on SNR considerations.  Thus his operative variable is a value for the faintest target acquisition in " +
"the accumulated image.  Accordingly, his sub-frame exposure produces a value significantly longer than Smith and Cannestra " +
"for the same reference image and criteria. " +
vbCrLf + vbCrLf +
"This miniapp gives the user an opportunity to compare the results of all three as derived from a 'real-time' reference image. " +
"Then, based on which analysis seems most reasonable and appropriate, make a choice for that night's imaging. " +
 vbCrLf + vbCrLf +
 "See:" + vbCrLf + vbCrLf +
 "   '   John Smith: http://www.hiddenloft.com/notes/SubExposures.pdf" + vbCrLf +
 "   '   Charles Anstey: http://www.cloudynights.com/item.php?item_id=1622" + vbCrLf +
 "   '   Steve Cannistra: http://www.starrywonders.com/snr.html"


End Module
