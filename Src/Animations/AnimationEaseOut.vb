Namespace Src.Animations
    Module AnimationEaseOut
        Function CalculateProgress(Progress As Double) As Double
            Return -1 * Progress * (Progress - 2)
        End Function
    End Module
End Namespace