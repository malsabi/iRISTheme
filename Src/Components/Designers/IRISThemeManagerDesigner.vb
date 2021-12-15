Imports System.ComponentModel.Design
Imports iRISTheme.Src.Components.Actions

Namespace Src.Components.Designers
    Public Class IRISThemeManagerDesigner : Inherits ComponentDesigner
        Private ActionListCollection As DesignerActionListCollection = Nothing
        Public Overrides ReadOnly Property ActionLists As DesignerActionListCollection
            Get
                If ActionListCollection Is Nothing Then
                    ActionListCollection = New DesignerActionListCollection()
                    ActionListCollection.Add(New IRISThemeManagerActionList(Component))
                End If
                Return ActionListCollection
            End Get
        End Property
    End Class
End Namespace