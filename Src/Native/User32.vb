Imports System.Runtime.InteropServices

Namespace Src.Native
    Public Class User32
#Region "API"
        <DllImport("user32.dll", CharSet:=CharSet.Auto)>
        Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As String) As IntPtr
        End Function
        <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
        Public Shared Function LoadCursor(hInstance As IntPtr, lpCursorName As Integer) As IntPtr
        End Function
        <DllImport("user32.dll", CharSet:=CharSet.Auto)>
        Public Shared Function SetCursor(hCursor As IntPtr) As IntPtr
        End Function
#End Region

#Region "Constants"
        Public Const WM_SETCURSOR As Integer = &H20
        Public Const IDC_HAND As Integer = 32649
#End Region
    End Class
End Namespace