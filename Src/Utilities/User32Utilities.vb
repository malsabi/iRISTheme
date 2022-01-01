Imports iRISTheme.Src.Native

Namespace Src.Utilities
    Public Class User32Utilities
        ''' <summary>
        ''' Sets the smoothness for hand cursor that is mostly used in hovering.
        ''' </summary>
        ''' <param name="message">Represents the message received from the windows api.</param>
        Public Shared Sub SmoothCursor(ByRef message As Message)
            If message.Msg <> User32.WM_SETCURSOR Then Return
            User32.SetCursor(User32.LoadCursor(IntPtr.Zero, User32.IDC_HAND))
            message.Result = IntPtr.Zero
        End Sub
    End Class
End Namespace