Imports iRISTheme.Src.Enums

Namespace Src.Animations
    Public Class AnimationManager
#Region "Fields"
        Private AnimationProgresses As List(Of Double)
        Private AnimationSources As List(Of Point)
        Private AnimationDirections As List(Of AnimationDirection)
        Private AnimationDatas As List(Of Object())
        Private WithEvents AnimationTimer As Timer
#End Region
#Region "Properties"
        Public Property InterruptAnimation As Boolean
        Public Property Increment As Double
        Public Property SecondaryIncrement As Double
        Public Property AnimationType As AnimationType
        Public Property Singular As Boolean
#End Region
#Region "Events & Handlers"
        Public Delegate Sub OnAnimationFinishedDelegate(Sender As Object)
        Public Event OnAnimationFinished As OnAnimationFinishedDelegate
        Private Sub SetOnAnimationFinished(Sender As Object)
            RaiseEvent OnAnimationFinished(Sender)
        End Sub
        Public Delegate Sub OnAnimationProgressDelegate(Sender As Object)
        Public Event OnAnimationProgress As OnAnimationProgressDelegate
        Private Sub SetOnAnimationProgress(Sender As Object)
            RaiseEvent OnAnimationProgress(Sender)
        End Sub
#End Region
#Region "Constants"
        Private Const MIN_VALUE As Double = 0.0
        Private Const MAX_VALUE As Double = 1.0
#End Region
#Region "Constructors"
        Public Sub New(Optional Singular As Boolean = True)
            Me.Singular = Singular
            Initialize()
        End Sub
#End Region
#Region "Private Methods"
        Private Sub Initialize()
            AnimationProgresses = New List(Of Double)()
            AnimationSources = New List(Of Point)()
            AnimationDirections = New List(Of AnimationDirection)()
            AnimationDatas = New List(Of Object())()
            AnimationTimer = New Timer With {.Interval = 5, .Enabled = False}

            Increment = 0.03
            SecondaryIncrement = 0.03
            AnimationType = AnimationType.Linear
            InterruptAnimation = True

            If Singular Then
                AnimationProgresses.Add(0)
                AnimationSources.Add(New Point(0, 0))
                AnimationDirections.Add(AnimationDirection.[In])
            End If
        End Sub
        Private Sub AnimationTimerOnTick(sender As Object, eventArgs As EventArgs) Handles AnimationTimer.Tick
            For Each Item In AnimationProgresses.ToList()
                Dim i As Integer = AnimationProgresses.IndexOf(Item)
                UpdateProgress(i)
                If Not Singular Then
                    If AnimationDirections(i) = AnimationDirection.InOutIn And AnimationProgresses(i) = MAX_VALUE Then
                        AnimationDirections(i) = AnimationDirection.InOutOut
                    ElseIf AnimationDirections(i) = AnimationDirection.InOutRepeatingIn And AnimationProgresses(i) = MIN_VALUE Then
                        AnimationDirections(i) = AnimationDirection.InOutRepeatingOut
                    ElseIf AnimationDirections(i) = AnimationDirection.InOutRepeatingOut And AnimationProgresses(i) = MIN_VALUE Then
                        AnimationDirections(i) = AnimationDirection.InOutRepeatingIn
                    ElseIf (AnimationDirections(i) = AnimationDirection.[In] And AnimationProgresses(i) = MAX_VALUE) Or (AnimationDirections(i) = AnimationDirection.Out And AnimationProgresses(i) = MIN_VALUE) Or (AnimationDirections(i) = AnimationDirection.InOutOut And AnimationProgresses(i) = MIN_VALUE) Then
                        AnimationProgresses.RemoveAt(i)
                        AnimationSources.RemoveAt(i)
                        AnimationDirections.RemoveAt(i)
                        AnimationDatas.RemoveAt(i)
                    End If
                Else
                    If AnimationDirections(i) = AnimationDirection.InOutIn And AnimationProgresses(i) = MAX_VALUE Then
                        AnimationDirections(i) = AnimationDirection.InOutOut
                    ElseIf AnimationDirections(i) = AnimationDirection.InOutRepeatingIn And AnimationProgresses(i) = MAX_VALUE Then
                        AnimationDirections(i) = AnimationDirection.InOutRepeatingOut
                    ElseIf AnimationDirections(i) = AnimationDirection.InOutRepeatingOut And AnimationProgresses(i) = MIN_VALUE Then
                        AnimationDirections(i) = AnimationDirection.InOutRepeatingIn
                    End If
                End If
            Next
            RaiseEvent OnAnimationProgress(Me)
        End Sub
        Private Sub UpdateProgress(Index As Integer)
            Select Case AnimationDirections(Index)
                Case AnimationDirection.InOutRepeatingIn, AnimationDirection.InOutIn, AnimationDirection.[In]
                    IncrementProgress(Index)
                Case AnimationDirection.InOutRepeatingOut, AnimationDirection.InOutOut, AnimationDirection.Out
                    DecrementProgress(Index)
                Case Else
                    Throw New Exception("No AnimationDirection has been set")
            End Select
        End Sub
        Private Sub IncrementProgress(Index As Integer)
            AnimationProgresses(Index) += Increment

            If AnimationProgresses(Index) > MAX_VALUE Then
                AnimationProgresses(Index) = MAX_VALUE

                For i As Integer = 0 To GetAnimationCount() - 1
                    If AnimationDirections(i) = AnimationDirection.InOutIn Then
                        Return
                    End If
                    If AnimationDirections(i) = AnimationDirection.InOutRepeatingIn Then
                        Return
                    End If
                    If AnimationDirections(i) = AnimationDirection.InOutRepeatingOut Then
                        Return
                    End If
                    If AnimationDirections(i) = AnimationDirection.InOutOut And AnimationProgresses(i) <> MAX_VALUE Then
                        Return
                    End If
                    If AnimationDirections(i) = AnimationDirection.[In] And AnimationProgresses(i) <> MAX_VALUE Then
                        Return
                    End If
                Next
                AnimationTimer.Stop()
                RaiseEvent OnAnimationFinished(Me)
            End If
        End Sub
        Private Sub DecrementProgress(Index As Integer)
            AnimationProgresses(Index) -= If(AnimationDirections(Index) = AnimationDirection.InOutOut Or AnimationDirections(Index) = AnimationDirection.InOutRepeatingOut, SecondaryIncrement, Increment)
            If AnimationProgresses(Index) < MIN_VALUE Then
                AnimationProgresses(Index) = MIN_VALUE
                For i As Integer = 0 To GetAnimationCount() - 1
                    If AnimationDirections(i) = AnimationDirection.InOutIn Then
                        Return
                    End If
                    If AnimationDirections(i) = AnimationDirection.InOutRepeatingIn Then
                        Return
                    End If
                    If AnimationDirections(i) = AnimationDirection.InOutRepeatingOut Then
                        Return
                    End If
                    If AnimationDirections(i) = AnimationDirection.InOutOut And AnimationProgresses(i) <> MIN_VALUE Then
                        Return
                    End If
                    If AnimationDirections(i) = AnimationDirection.Out And AnimationProgresses(i) <> MIN_VALUE Then
                        Return
                    End If
                Next
                AnimationTimer.Stop()
                RaiseEvent OnAnimationFinished(Me)
            End If
        End Sub
#End Region
#Region "Public Methods"
        Public Function IsAnimating() As Boolean
            Return AnimationTimer.Enabled
        End Function
        Public Sub StartNewAnimation(animationDirection As AnimationDirection, Optional data As Object() = Nothing)
            StartNewAnimation(animationDirection, New Point(0, 0), data)
        End Sub
        Public Sub StartNewAnimation(animationDirection As AnimationDirection, animationSource As Point, Optional data As Object() = Nothing)
            If Not IsAnimating() Or InterruptAnimation Then
                If Singular And AnimationDirections.Count > 0 Then
                    AnimationDirections(0) = animationDirection
                Else
                    AnimationDirections.Add(animationDirection)
                End If
                If Singular And AnimationSources.Count > 0 Then
                    AnimationSources(0) = animationSource
                Else
                    AnimationSources.Add(animationSource)
                End If
                If Not (Singular And AnimationProgresses.Count > 0) Then
                    Select Case AnimationDirections(AnimationDirections.Count - 1)
                        Case AnimationDirection.InOutRepeatingIn, AnimationDirection.InOutIn, AnimationDirection.[In]
                            AnimationProgresses.Add(MIN_VALUE)
                        Case AnimationDirection.InOutRepeatingOut, AnimationDirection.InOutOut, AnimationDirection.Out
                            AnimationProgresses.Add(MAX_VALUE)
                        Case Else
                            Throw New Exception("Invalid AnimationDirection")
                    End Select
                End If
                If Singular And AnimationDatas.Count > 0 Then
                    AnimationDatas(0) = If(data, New Object() {})
                Else
                    AnimationDatas.Add(If(data, New Object() {}))
                End If
            End If
            AnimationTimer.Start()
        End Sub
        Public Function GetProgress() As Double
            If Not Singular Then
                Throw New Exception("Animation is not set to Singular.")
            End If
            If AnimationProgresses.Count = 0 Then
                Throw New Exception("Invalid animation")
            End If
            Return GetProgress(0)
        End Function
        Public Function GetProgress(Index As Integer) As Double
            If Not Index < GetAnimationCount() Then
                Throw New IndexOutOfRangeException("Invalid animation index")
            End If
            Select Case AnimationType
                Case AnimationType.Linear
                    Return AnimationLinear.CalculateProgress(AnimationProgresses(Index))
                Case AnimationType.EaseInOut
                    Return AnimationEaseInOut.CalculateProgress(AnimationProgresses(Index))
                Case AnimationType.EaseOut
                    Return AnimationEaseOut.CalculateProgress(AnimationProgresses(Index))
                Case AnimationType.CustomQuadratic
                    Return AnimationCustomQuadratic.CalculateProgress(AnimationProgresses(Index))
                Case Else
                    Throw New NotImplementedException("The given AnimationType is not implemented")
            End Select
        End Function
        Public Function GetSource(Index As Integer) As Point
            If Not Index < GetAnimationCount() Then
                Throw New IndexOutOfRangeException("Invalid animation index")
            End If
            Return AnimationSources(Index)
        End Function
        Public Function GetSource() As Point
            If Not Singular Then
                Throw New Exception("Animation is not set to Singular.")
            End If
            If AnimationSources.Count = 0 Then
                Throw New Exception("Invalid animation")
            End If
            Return AnimationSources(0)
        End Function
        Public Function GetDirection() As AnimationDirection
            If Not Singular Then
                Throw New Exception("Animation is not set to Singular.")
            End If
            If AnimationDirections.Count = 0 Then
                Throw New Exception("Invalid animation")
            End If
            Return AnimationDirections(0)
        End Function
        Public Function GetDirection(Index As Integer) As AnimationDirection
            If Not Index < AnimationDirections.Count Then
                Throw New IndexOutOfRangeException("Invalid animation index")
            End If
            Return AnimationDirections(Index)
        End Function
        Public Function GetData() As Object()
            If Not Singular Then
                Throw New Exception("Animation is not set to Singular.")
            End If
            If AnimationDatas.Count = 0 Then
                Throw New Exception("Invalid animation")
            End If
            Return AnimationDatas(0)
        End Function
        Public Function GetData(Index As Integer) As Object()
            If Not Index < AnimationDatas.Count Then
                Throw New IndexOutOfRangeException("Invalid animation index")
            End If
            Return AnimationDatas(Index)
        End Function
        Public Function GetAnimationCount() As Integer
            Return AnimationProgresses.Count
        End Function
        Public Sub SetProgress(progress As Double)
            If Not Singular Then
                Throw New Exception("Animation is not set to Singular.")
            End If
            If AnimationProgresses.Count = 0 Then
                Throw New Exception("Invalid animation")
            End If
            AnimationProgresses(0) = progress
        End Sub
        Public Sub SetDirection(Direction As AnimationDirection)
            If Not Singular Then
                Throw New Exception("Animation is not set to Singular.")
            End If
            If AnimationProgresses.Count = 0 Then
                Throw New Exception("Invalid animation")
            End If
            AnimationDirections(0) = Direction
        End Sub
        Public Sub SetData(Data As Object())
            If Not Singular Then
                Throw New Exception("Animation is not set to Singular.")
            End If
            If AnimationDatas.Count = 0 Then
                Throw New Exception("Invalid animation")
            End If
            AnimationDatas(0) = Data
        End Sub
#End Region
    End Class
End Namespace