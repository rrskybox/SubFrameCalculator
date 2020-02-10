# SubFrameCalculator
Seeing-based exposure calculator for astroimaging

Subframe Calculator Description

This Windows Form applet uses the TSX Image Link functions to determine the optimum subframe exposure length for the current seeing and light pollution qualities using the TSX Camera Add-On.

The app takes a 60 second exposure then produces a recommendation window to display computed optimal exposure length and duration for a 60 minute image stack, based on average background noise.  The results, based on noise analysis by three different authors, are presented for comparison.

 

Requirements:  

Subframe Analyzer is a Windows Forms executable, written in Visual Basic.  The application runs as an uncertified, standalone application under Windows 7, 8 and 10.  The application uses the TSX Camera Add On capability.

Installation:  

Download the SubframeAnalyzer_Exe.zip and open.  Run the Setup application.  Upon completion, an application icon will have been added to the start menu under the category TSXToolkit with the name 
Subframe Analyzer.  This application can be pinned to the Start if desired.

Operation:  

The algorithms are based on work by ... 

John Smith: http://www.hiddenloft.com/notes/SubExposures.pdf
Charles Anstey: http://www.cloudynights.com/item.php?item_id=1622
Steve Cannistra: http://www.starrywonders.com/snr.html

The algorithms require the following imaging parameters, most of which are currently supplied by TSX.  For details, see the above articles.

Gain:  electrons per ADU for the CCD
Readout Noise:  read out noise in electrons
Maximum Noise Factor:  Maximum tolerable contribution of readout noise
Exposure Reduction:  Exposure reduction factor
SLambda:  Faint target ADU minimum
SNR Target: Fraction of maximum achievable signal to noise ratio (Cannistra)
Pedestal:  base pedestal

Simple sub-exposure strategies concentrate exclusively on optimization against random internal noise sources.  Such calculations utilize fixed parameters from ones CCD specification like read noise, dark current, etc.  However, they  fail to compensate for the environmental non-random sources of noise such as light pollution, sky glow, turbulence which vary from night to night and location to location.  These critical factors can only be accurately derived from an appropriate reference image.  Three authors have developed optimal sub-frame exposure algorithms that account for noise contribution from both internal (equipment) sources and external (atmospheric) sources.  
 
Smith’s analysis and algorithm considers both of the two sources of noise in images – random noise and non-random noise.  His method produces a longer total exposure times but assumes a little more image processing complexity on the back end, e.g. dithered image acquisition and outlier-rejection combining algorithms.  The key operative variable for Smith the is the maximum Read Noise percentage contribution to the acquired image.  
 
Cannestra’s algorithm is a variation on Smith’s.  Whereas Smith’s approach is to optimize the length of each sub-frame Cannestra’s algorithm looks to optimize the signal to noise ratio of the final, stacked image.  The operative parameter here is that target SNR for the collection.  The calculated sub-frame exposure, however, remains in the ballpark with Smith.  
 
Anstey mostly rejects the SNR-only approach based on his experience with much longer sub-frame exposures than Smith’s algorithm would recommend.  He asserts that a sub-frame exposure must account first for acquisition of the faintest target desired, then on SNR considerations.  Thus his operative variable is a value for the faintest target acquisition in the accumulated image.  Accordingly, his sub-frame exposure produces a value significantly longer than Smith and Cannestra for the same reference image and criteria.  
 
This miniapp gives the user an opportunity to compare the results of all three as derived from a real-time reference image. Then, based on which analysis seems most reasonable and appropriate, make a choice for that nights imaging.  

Support:  

This application was written for the public domain and as such is unsupported. The developer wishes you his best and hopes everything works out, but recommends learning Visual Basic (its really not hard and the tools are free from Microsoft) if you find a problem or want to add features.  The source is supplied as a Visual Studio project.
