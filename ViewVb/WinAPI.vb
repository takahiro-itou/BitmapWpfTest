
Imports System.Runtime.InteropServices

Module WinAPI

Public Const SRCAND As Integer = &H8800C6
Public Const SRCCOPY As Integer = &HCC0020
Public Const SRCPAINT As Integer = &HEE0086

<DllImport("gdi32.dll")> _
Public Function BitBlt(ByVal hDestDC As IntPtr, _
    ByVal X As Integer, ByVal Y As Integer, _
    ByVal nWidth As Integer, ByVal nHeight As Integer, _
    ByVal hSrcDC As IntPtr, _
    ByVal xSrc As Integer, ByVal ySrc As Integer, _
    ByVal dwRop As Integer) As Integer
End Function

End Module
