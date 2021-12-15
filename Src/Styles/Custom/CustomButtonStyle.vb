Imports iRISTheme.Src.Interfaces

Namespace Src.Styles.Custom
    Public Class CustomButtonStyle : Implements IRISButtonTheme
#Region "Fields"
        Private ReadOnly CustomStyle As CustomStyle
#End Region
        Public Sub New()
            CustomStyle = New CustomStyle()
        End Sub
#Region "Properties"
        Public ReadOnly Property DisabledColor As Color Implements IRISButtonTheme.DisabledColor
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        Public ReadOnly Property OnDisabledColor As Color Implements IRISButtonTheme.OnDisabledColor
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        Public ReadOnly Property DisabledBorderColor As Color Implements IRISButtonTheme.DisabledBorderColor
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        Public ReadOnly Property NormalColor As Color Implements IRISButtonTheme.NormalColor
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        Public ReadOnly Property OnNormalColor As Color Implements IRISButtonTheme.OnNormalColor
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        Public ReadOnly Property NormalBorderColor As Color Implements IRISButtonTheme.NormalBorderColor
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        Public ReadOnly Property PressedColor As Color Implements IRISButtonTheme.PressedColor
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        Public ReadOnly Property OnPressedColor As Color Implements IRISButtonTheme.OnPressedColor
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        Public ReadOnly Property HoveredColor As Color Implements IRISButtonTheme.HoveredColor
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        Public ReadOnly Property OnHoveredColor As Color Implements IRISButtonTheme.OnHoveredColor
            Get
                Throw New NotImplementedException()
            End Get
        End Property
#End Region
    End Class
End Namespace