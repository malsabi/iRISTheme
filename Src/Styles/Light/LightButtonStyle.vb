Imports iRISTheme.Src.Interfaces

Namespace Src.Styles.Light
    Public Class LightButtonStyle : Implements IRISButtonTheme
#Region "Fields"
        Private ReadOnly LightStyle As LightStyle
#End Region
        Public Sub New()
            LightStyle = New LightStyle()
        End Sub
#Region "Properties"
        Public ReadOnly Property DisabledColor As Color Implements IRISButtonTheme.DisabledColor
            Get
                Return LightStyle.DisabledColor
            End Get
        End Property
        Public ReadOnly Property OnDisabledColor As Color Implements IRISButtonTheme.OnDisabledColor
            Get
                Return LightStyle.OnDisabledColor
            End Get
        End Property
        Public ReadOnly Property DisabledBorderColor As Color Implements IRISButtonTheme.DisabledBorderColor
            Get
                Return LightStyle.DisabledBorderColor
            End Get
        End Property
        Public ReadOnly Property NormalColor As Color Implements IRISButtonTheme.NormalColor
            Get
                Return LightStyle.PrimaryColor
            End Get
        End Property
        Public ReadOnly Property OnNormalColor As Color Implements IRISButtonTheme.OnNormalColor
            Get
                Return LightStyle.OnPrimaryColor
            End Get
        End Property
        Public ReadOnly Property NormalBorderColor As Color Implements IRISButtonTheme.NormalBorderColor
            Get
                Return LightStyle.SecondaryColor
            End Get
        End Property
        Public ReadOnly Property PressedColor As Color Implements IRISButtonTheme.PressedColor
            Get
                Return LightStyle.PressedColor
            End Get
        End Property
        Public ReadOnly Property OnPressedColor As Color Implements IRISButtonTheme.OnPressedColor
            Get
                Return LightStyle.OnPressedColor
            End Get
        End Property
        Public ReadOnly Property HoveredColor As Color Implements IRISButtonTheme.HoveredColor
            Get
                Return LightStyle.HoveredColor
            End Get
        End Property
        Public ReadOnly Property OnHoveredColor As Color Implements IRISButtonTheme.OnHoveredColor
            Get
                Return LightStyle.OnHoveredColor
            End Get
        End Property
#End Region
    End Class
End Namespace