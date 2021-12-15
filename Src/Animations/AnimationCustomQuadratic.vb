Namespace Src.Animations
    Module AnimationCustomQuadratic
        Function CalculateProgress(Progress As Double) As Double
            Dim kickoff = 0.6
            Return 1 - Math.Cos((Math.Max(Progress, kickoff) - kickoff) * Math.PI / (2 - (2 * kickoff)))
        End Function
    End Module
End Namespace