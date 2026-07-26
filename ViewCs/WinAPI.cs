
using System.Runtime.InteropServices;

namespace  ViewCs.WinAPI  {

[DllImport("gdi32.dll")]
public  static  extern  int  BitBlt(
    IntPtr hDestDC,
    int X, int Y,
    int nWidth, int nHeight,
    IntPtr hSrcDC,
    int xSrc, int ySrc,
    int dwRop
);

}   //  End of namespace  ViewCs.WinAPI
