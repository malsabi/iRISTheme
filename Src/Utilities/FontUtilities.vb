Namespace Src.Utilities
    Public Class FontUtilities
        Public Shared Function Regular(Size As Single) As Font
            Return New Font("Segoe UI", Size)
        End Function
        Public Shared Function Normal(Font As String, Size As Single) As Font
            Return New Font(Font, Size)
        End Function
        Public Shared Function Light(Size As Single) As Font
            Return New Font("Segoe UI Light", Size)
        End Function
        Public Shared Function Italic(Size As Single) As Font
            Return New Font("Segoe UI", Size, FontStyle.Italic)
        End Function
        Public Shared Function SemiBold(Size As Single) As Font
            Return New Font("Segoe UI semibold", Size)
        End Function
        Public Shared Function Bold(Size As Single) As Font
            Return New Font("Segoe UI", Size, FontStyle.Bold)
        End Function
    End Class
End Namespace