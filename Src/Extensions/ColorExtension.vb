Imports System.Runtime.CompilerServices

Namespace Src.Extensions
    Module ColorExtension
        <Extension()>
        Function RemoveAlpha(color As Color) As Color
            Return Color.FromArgb(color.R, color.G, color.B)
        End Function
    End Module
End Namespace