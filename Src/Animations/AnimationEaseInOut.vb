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
        Private Function EaseInOutBack(x As Double) As Double
            Dim c1 As Double = 1.70158
            Dim c2 As Double = c1 * 1.525
            Return IIf(x < 0.5, Math.Pow(2 * x, 2) * ((c2 + 1) * 2 * x - c2) / 2, Math.Pow(2 * x - 2, 2) * ((c2 + 1) * (x * 2 - 2) + c2) + 2 / 2)
        End Function
        Private Function EaseInOutCubic(x As Double) As Double
            Return IIf(x < 0.5, 4 * x * x * x, 1 - Math.Pow(-2 * x + 2, 3) / 2)
        End Function
    End Module
End Namespace