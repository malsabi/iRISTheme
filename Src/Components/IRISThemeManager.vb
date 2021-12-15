Imports iRISTheme.Src.Enums
Imports iRISTheme.Src.Components.Designers
Imports iRISTheme.Src.Components.Editor
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Imports iRISTheme.Src.Styles.Dark
Imports iRISTheme.Src.Styles.Light
Imports iRISTheme.Src.Interfaces
Imports iRISTheme.Src.Styles.Custom

Namespace Src.Components
    ''' <summary>
    ''' Manages the style and the font of all controls.
    ''' Provides custom style that is added by xml file.
    ''' All controls are validated once there is a change in the font or style to see the result in 
    ''' design time and run time.
    ''' </summary>
    <Designer(GetType(IRISThemeManagerDesigner))>
    <DefaultProperty("ThemeStyle")>
    <ToolboxItem(True)>
    <ToolboxBitmap(GetType(ComponentBitmap), "ThemeManagerBitmap.bmp")>
    Public Class IRISThemeManager : Inherits Component
#Region "Properties"
        Private _style As IRISThemeStyle
        <Category("IRIS Theme"), Description("Gets or sets the style for all controls.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property ThemeStyle() As IRISThemeStyle
            Get
                Return _style
            End Get
            Set(Value As IRISThemeStyle)
                FireChanging()
                If Not Value.Equals(IRISThemeStyle.CustomStyle) Then
                    CustomStyle = String.Empty
                    _style = Value
                Else
                    _style = Value
                End If
                UpdateFormControls()
                FireChanged()
            End Set
        End Property

        Private _Themefont As Font
        <Category("IRIS Theme"), Description("Gets or sets the font for all controls.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property ThemeFont() As Font
            Get
                Return _Themefont
            End Get
            Set(Value As Font)
                FireChanging()
                _Themefont = Value
                UpdateFormControls()
                FireChanged()
            End Set
        End Property

        Private _customStyle As String
        <Editor(GetType(FileNamesEditor), GetType(UITypeEditor)), Category("IRIS Theme"), Description("Gets or sets the custom theme file for all controls.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property CustomStyle() As String
            Get
                Return _customStyle
            End Get
            Set(Value As String)
                FireChanging()
                If (ThemeStyle.Equals(IRISThemeStyle.CustomStyle)) Then
                    _customStyle = Value
                Else
                    _customStyle = "N/A"
                End If
                UpdateFormControls()
                FireChanged()
            End Set
        End Property

        Private _ownerForm As Form
        <Category("IRIS Theme"), Description("Gets or sets the owner form for the theme manager.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property OwnerForm() As Form
            Get
                Return _ownerForm
            End Get
            Set(value As Form)
                FireChanging()
                _ownerForm = value
                If _ownerForm IsNot Nothing Then
                    AddHandler _ownerForm.ControlAdded, AddressOf ControlAdded
                End If
                FireChanged()
            End Set
        End Property

        Public ReadOnly Property ButtonTheme As IRISButtonTheme
            Get
                If ThemeStyle.Equals(IRISThemeStyle.CustomStyle) Then
                    Return New CustomButtonStyle()
                ElseIf ThemeStyle.Equals(IRISThemeStyle.DarkStyle) Then
                    Return New DarkButtonStyle()
                ElseIf ThemeStyle.Equals(IRISThemeStyle.LightStyle) Then
                    Return New LightButtonStyle()
                Else
                    Return Nothing
                End If
            End Get
        End Property
#End Region
#Region "Constructors"
        Public Sub New()
            MyBase.New()
            ThemeStyle = IRISThemeStyle.DarkStyle
            ThemeFont = New Font("Segoe UI", 10, FontStyle.Regular)
            CustomStyle = String.Empty
        End Sub

        Public Sub New(ThemeStyle As IRISThemeStyle, ThemeFont As Font)
            MyBase.New()
            Me.ThemeStyle = ThemeStyle
            Me.ThemeFont = ThemeFont
            CustomStyle = String.Empty
        End Sub

        Public Sub New(CustomStyle As String, ThemeFont As Font)
            MyBase.New()
            Me.ThemeFont = ThemeFont
            Me.CustomStyle = CustomStyle
            ThemeStyle = IRISThemeStyle.None
        End Sub
#End Region
#Region "Private Methods"
#Region "Component Design-Time Handling"
        Private Sub FireChanging()
            Dim service As IComponentChangeService = GetComponentChangeService()
            If service IsNot Nothing Then service.OnComponentChanging(Me, Nothing)
        End Sub
        Private Sub FireChanged()
            Dim service As IComponentChangeService = GetComponentChangeService()
            If service IsNot Nothing Then service.OnComponentChanged(Me, Nothing, Nothing, Nothing)
        End Sub
        Private Function GetComponentChangeService() As IComponentChangeService
            Return TryCast(GetService(GetType(IComponentChangeService)), IComponentChangeService)
        End Function
#End Region
#Region "Form-Controls Management"
        Private Sub UpdateFormControls()
            If OwnerForm IsNot Nothing Then
                'For Each Ctrl As Control In OwnerForm.Controls
                '    If TypeOf Ctrl Is IRISControl Then
                '        Dim IRISCtrl As IRISControl = CType(Ctrl, IRISControl)
                '        If IRISCtrl.IRISThemeManager Is Nothing Then
                '            IRISCtrl.IRISThemeManager = Me
                '        End If
                '    End If
                '    For Each ChildCtrl As Control In Ctrl.Controls
                '        If TypeOf ChildCtrl Is IRISControl Then
                '            Dim ChildIRISCtrl As IRISControl = CType(ChildCtrl, IRISControl)
                '            If ChildIRISCtrl.IRISThemeManager Is Nothing Then
                '                ChildIRISCtrl.IRISThemeManager = Me
                '                ChildCtrl.Invalidate()
                '            End If
                '        End If
                '    Next
                'Next
                OwnerForm.Refresh()
            End If
        End Sub
#End Region
#Region "Form-Controls Event"
        Private Sub ControlAdded(Sender As Object, Args As ControlEventArgs)
            If DesignMode Then
                UpdateFormControls()
            End If
        End Sub
#End Region
#End Region
    End Class
End Namespace