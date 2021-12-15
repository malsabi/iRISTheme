Imports iRISTheme.Src.Interfaces

Namespace Src.Styles.Dark
    Public Class DarkButtonStyle : Implements IRISButtonTheme
#Region "Fields"
        Private ReadOnly DarkStyle As DarkStyle
#End Region
        Public Sub New()
            DarkStyle = New DarkStyle()
        End Sub
#Region "Properties"
        Public ReadOnly Property DisabledColor As Color Implements IRISButtonTheme.DisabledColor
            Get
                Return DarkStyle.DisabledColor
            End Get
        End Property
        Public ReadOnly Property OnDisabledColor As Color Implements IRISButtonTheme.OnDisabledColor
            Get
                Return DarkStyle.OnDisabledColor
            End Get
        End Property
        Public ReadOnly Property DisabledBorderColor As Color Implements IRISButtonTheme.DisabledBorderColor
            Get
                Return DarkStyle.DisabledColor
            End Get
        End Property
        Public ReadOnly Property NormalColor As Color Implements IRISButtonTheme.NormalColor
            Get
                Return DarkStyle.PrimaryColor
            End Get
        End Property
        Public ReadOnly Property OnNormalColor As Color Implements IRISButtonTheme.OnNormalColor
            Get
                Return DarkStyle.OnPrimaryColor
            End Get
        End Property
        Public ReadOnly Property NormalBorderColor As Color Implements IRISButtonTheme.NormalBorderColor
            Get
                Return DarkStyle.PrimaryColor
            End Get
        End Property
        Public ReadOnly Property PressedColor As Color Implements IRISButtonTheme.PressedColor
            Get
                Dim P As Color = DarkStyle.PrimaryColor
                Return Color.FromArgb(P.R - 20, P.G - 20, P.B - 20)
            End Get
        End Property
        Public ReadOnly Property OnPressedColor As Color Implements IRISButtonTheme.OnPressedColor
            Get
                Dim OP As Color = DarkStyle.OnPrimaryColor
                Return Color.FromArgb(OP.R - 20, OP.G - 20, OP.B - 20)
            End Get
        End Property
        Public ReadOnly Property HoveredColor As Color Implements IRISButtonTheme.HoveredColor
            Get
                Dim P As Color = DarkStyle.PrimaryColor
                Return Color.FromArgb(P.R + 20, P.G + 20, P.B + 20)
            End Get
        End Property
        Public ReadOnly Property OnHoveredColor As Color Implements IRISButtonTheme.OnHoveredColor
            Get
                Dim OP As Color = DarkStyle.OnPrimaryColor
                Return Color.FromArgb(OP.R - 20, OP.G - 20, OP.B - 20)
            End Get
        End Property
#End Region
    End Class
End Namespace