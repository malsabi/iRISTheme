Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports iRISTheme.Src.Controls
Imports iRISTheme.Src.Enums

Namespace Src.Components.Actions
    Public Class IRISButtonActionList : Inherits DesignerActionList
        Private ReadOnly IRISButton As IRISButton
        Public Sub New(component As IComponent)
            MyBase.New(component)
            IRISButton = CType(component, IRISButton)
        End Sub
        '<Category("IRIS Theme"), Description("Gets or sets the theme manager that is associated with the button.")>
        '<RefreshProperties(RefreshProperties.All)>
        '<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        'Public Property IRISThemeManager As IRISThemeManager
        '    Get
        '        Return IRISButton.IRISThemeManager
        '    End Get
        '    Set(value As IRISThemeManager)
        '        IRISButton.IRISThemeManager = value
        '    End Set
        'End Property
        <Category("IRIS Theme"), Description("Gets or sets the text of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property Text As String
            Get
                Return IRISButton.Text
            End Get
            Set(value As String)
                IRISButton.Text = value
            End Set
        End Property
        Public Overrides Function GetSortedActionItems() As DesignerActionItemCollection
            'New DesignerActionPropertyItem("IRISThemeManager", "IRISThemeManager", "IRIS Theme", "Gets or sets the theme manager that is associated with the button."),
            Dim items = New DesignerActionItemCollection From
            {
                New DesignerActionHeaderItem("IRIS Theme"),
                New DesignerActionPropertyItem("Text", "Text", "IRIS Theme", "Gets or sets the The text associated with the control.")
            }
            Return items
        End Function
    End Class
End Namespace