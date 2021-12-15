Imports System.ComponentModel

Namespace Src.BaseControls
    Partial Friend Class BaseInputBox : Inherits TextBox
#Region "Fields"
        Private _IsPlaceHolder As Boolean
        Private _PlaceHolderText As String
        Private _PlaceHolderTextColor As Color
        Private _PasswordChar As Char
        Private _UseSystemPasswordChar As Boolean
        Private _FakeCall As Boolean
#End Region

#Region "Properties"
        <Description("Gets if the place holder text is placed in the InputBox.")>
        <Category("IRIS Theme")>
        Public Property IsPlaceHolder As Boolean
            Get
                Return _IsPlaceHolder
            End Get
            Private Set(value As Boolean)
                If _IsPlaceHolder <> value Then
                    SetStyle(ControlStyles.UserMouse, value)
                    _IsPlaceHolder = value
                    Invalidate()
                End If
            End Set
        End Property
        <Description("Sets or gets the place holder text for the InputBox.")>
        <Category("IRIS Theme")>
        Public Property PlaceHolderText As String
            Get
                Return _PlaceHolderText
            End Get
            Set(value As String)
                _PlaceHolderText = value
                If IsPlaceHolder Then
                    Text = value
                End If
                Invalidate()
            End Set
        End Property
        <Description("Sets or gets the place holder text color for the InputBox.")>
        <Category("IRIS Theme")>
        Public Property PlaceHolderTextColor As Color
            Get
                Return _PlaceHolderTextColor
            End Get
            Set(value As Color)
                If Not _PlaceHolderTextColor.Equals(value) Then
                    _PlaceHolderTextColor = value
                    If IsPlaceHolder Then
                        ForeColor = value
                    End If
                    Invalidate()
                End If
            End Set
        End Property
        <Browsable(True)>
        Public Overrides Property Text As String
            Get
                If IsPlaceHolder AndAlso MyBase.Text.Equals(PlaceHolderText) Then
                    Return ""
                Else
                    Return MyBase.Text
                End If
            End Get
            Set(value As String)
                MyBase.Text = value
            End Set
        End Property
        <Browsable(True)>
        Public Overrides Property ForeColor As Color
            Get
                If IsPlaceHolder Then
                    Return PlaceHolderTextColor
                Else
                    Return MyBase.ForeColor
                End If
            End Get
            Set(value As Color)
                MyBase.ForeColor = value
            End Set
        End Property
        Public Overrides ReadOnly Property TextLength As Integer
            Get
                Return IIf(IsPlaceHolder, 0, MyBase.TextLength)
            End Get
        End Property
        <Category("IRIS Theme")>
        <Description("The Password character of this component, which is used to encode the text into it.")>
        Public Overloads Property PasswordChar As Char
            Get
                Return _PasswordChar
            End Get
            Set(value As Char)
                _PasswordChar = value
                If Not IsPlaceHolder Then
                    MyBase.PasswordChar = value
                End If
            End Set
        End Property
        <Category("IRIS Theme")>
        <Description("The UseSystemPasswordChar of this component, which is used to allow if the text should be encoded to the PasswordCharacter.")>
        Public Overloads Property UseSystemPasswordChar As Boolean
            Get
                Return _UseSystemPasswordChar
            End Get
            Set(value As Boolean)
                _UseSystemPasswordChar = value
                If Not IsPlaceHolder Then
                    MyBase.UseSystemPasswordChar = value
                End If
            End Set
        End Property
#End Region

#Region "Constructors"
        Public Sub New()
            Initialize()
        End Sub
#End Region

#Region "Private Methods"
#Region "Initialization"
        Private Sub Initialize()
            SetStyle(ControlStyles.UserMouse, True)
            DoubleBuffered = True
            UpdateStyles()
            IsPlaceHolder = True
            PlaceHolderText = "Enter Text"
            PlaceHolderTextColor = SystemColors.InactiveCaption
            Text = PlaceHolderText
            UseSystemPasswordChar = False
            PasswordChar = "*"
            _FakeCall = False
        End Sub
#End Region
#Region "PlaceHolder Methods"
        Private Sub SetPlaceHolder()
            If Not IsPlaceHolder Then
                IsPlaceHolder = True
                ForeColor = PlaceHolderTextColor
                Text = PlaceHolderText
                MyBase.Select(0, 0)
            End If
        End Sub
#End Region
#End Region

#Region "Overrided Methods"
        Protected Overrides Sub WndProc(ByRef m As Message)
            If Not IsPlaceHolder OrElse m.Msg <> 177 Then
                MyBase.WndProc(m)
            End If
        End Sub
        Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
            If IsPlaceHolder Then
                If e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Home OrElse e.KeyCode = Keys.[End] OrElse e.KeyCode = Keys.Back Then
                    e.SuppressKeyPress = True
                End If
                If e.KeyCode = Keys.A AndAlso e.Control Then
                    e.SuppressKeyPress = True
                End If
            End If
            MyBase.OnKeyDown(e)
        End Sub
        Protected Overrides Sub OnTextChanged(e As EventArgs)
            If Not IsPlaceHolder AndAlso String.IsNullOrEmpty(Text) Then
                If MyBase.UseSystemPasswordChar Then
                    _FakeCall = True
                    MyBase.UseSystemPasswordChar = False
                End If
                If MyBase.PasswordChar > vbNullChar Then
                    MyBase.PasswordChar = vbNullChar
                End If
                SetPlaceHolder()
            ElseIf IsPlaceHolder AndAlso Text.Length > 0 Then
                IsPlaceHolder = False
                If _UseSystemPasswordChar Then
                    _FakeCall = True
                    MyBase.UseSystemPasswordChar = True
                End If
                If _PasswordChar > vbNullChar Then
                    MyBase.PasswordChar = _PasswordChar
                End If
                If Text.EndsWith(PlaceHolderText) Then
                    Text = Text.Substring(0, TextLength - PlaceHolderText.Length)
                End If
                MyBase.Select(TextLength, 0)
            End If
            MyBase.OnTextChanged(e)
        End Sub
        Protected Overrides Sub OnGotFocus(e As EventArgs)
            If _FakeCall Then
                _FakeCall = False
                Return
            End If
            MyBase.OnGotFocus(e)
        End Sub
        Protected Overrides Sub OnLostFocus(e As EventArgs)
            If _FakeCall Then
                _FakeCall = False
                Return
            End If
            MyBase.OnLostFocus(e)
        End Sub
#End Region
    End Class
End Namespace