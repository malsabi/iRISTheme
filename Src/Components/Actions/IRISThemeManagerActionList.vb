Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Imports iRISTheme.Src.Components.Editor
Imports iRISTheme.Src.Enums

Namespace Src.Components.Actions
    Public Class IRISThemeManagerActionList : Inherits DesignerActionList
        Private ReadOnly ThemeManager As IRISThemeManager

        Public Sub New(component As IComponent)
            MyBase.New(component)
            ThemeManager = CType(component, IRISThemeManager)
        End Sub

        <Category("IRIS Theme"), Description("Gets or sets the style for all controls.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property ThemeStyle() As IRISThemeStyle
            Get
                Return ThemeManager.ThemeStyle
            End Get
            Set(Value As IRISThemeStyle)
                ThemeManager.ThemeStyle = Value
            End Set
        End Property

        <Category("IRIS Theme"), Description("Gets or sets the font for all controls.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property ThemeFont() As Font
            Get
                Return ThemeManager.ThemeFont
            End Get
            Set(Value As Font)
                ThemeManager.ThemeFont = Value
            End Set
        End Property

        <Editor(GetType(FileNamesEditor), GetType(UITypeEditor)), Category("IRIS Theme"), Description("Gets or sets the custom theme file for all controls.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property CustomStyle() As String
            Get
                Return ThemeManager.CustomStyle
            End Get
            Set(Value As String)
                If (ThemeStyle.Equals(IRISThemeStyle.CustomStyle)) Then
                    ThemeManager.CustomStyle = Value
                Else
                    ThemeManager.CustomStyle = "N/A"
                End If
            End Set
        End Property

        <Category("IRIS Theme"), Description("Gets or sets the owner form for the theme manager.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property OwnerForm() As Form
            Get
                Return ThemeManager.OwnerForm
            End Get
            Set(value As Form)
                ThemeManager.OwnerForm = value
            End Set
        End Property

        Public Overrides Function GetSortedActionItems() As DesignerActionItemCollection

            Dim items = New DesignerActionItemCollection From
            {
                New DesignerActionHeaderItem("IRIS Theme"),
                New DesignerActionPropertyItem("ThemeStyle", "ThemeStyle", "IRIS Theme", "Gets or sets the style for all controls."),
                New DesignerActionPropertyItem("ThemeFont", "ThemeFont", "IRIS Theme", "Gets or sets the font for all controls."),
                New DesignerActionPropertyItem("CustomStyle", "CustomStyle", "IRIS Theme", "Gets or sets the custom theme file for all controls."),
                New DesignerActionPropertyItem("OwnerForm", "OwnerForm", "IRIS Theme", "Gets or sets the owner form for the theme manager.")
            }
            Return items
        End Function
    End Class
End Namespace