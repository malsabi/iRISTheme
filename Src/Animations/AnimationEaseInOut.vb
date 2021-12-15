Namespace Src.Animations
    Public Module AnimationEaseInOut
        Public Const PI As Double = Math.PI
        Public Const PI_HALF As Double = Math.PI / 2
        Function CalculateProgress(progress As Double) As Double
            Return EaseInOut(progress)
        End Function
        Private Function EaseInOut(s As Double) As Double
            Return s - Math.Sin(s * 2 * PI) / (2 * PI)
        End Function
    End Module
End Namespace