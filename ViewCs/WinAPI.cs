
using System.Runtime.InteropServices;

namespace  ViewCs  {

public  class  WinAPI
{

[DllImport("gdi32.dll")]
public  static  extern  int  BitBlt(
    System.IntPtr hDestDC,
    int X, int Y,
    int nWidth, int nHeight,
    System.IntPtr hSrcDC,
    int xSrc, int ySrc,
    int dwRop
);

}   //  End class  WinAPI

}   //  End of namespace  ViewCs
