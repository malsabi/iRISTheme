Imports System.ComponentModel.Design
Imports System.Reflection

Namespace Src.Components.Designers
    Public Class IRISContextMenuStripDesigner : Inherits ComponentDesigner
        Protected DefaultDesigner As ComponentDesigner
        Private ReadOnly PropertiesToRemove As String() = {"BackgroundImage", "BackgroundImageLayout", "", "RightToLeft", "", "UseWaitCursor", "AllowDrop", "AllowMerge", "AutoClose", "ImeMode", "", "TabStop", "AutoSize", "LayoutStyle", "DropShadowEnabled"}
        Protected Overrides Sub PostFilterProperties(properties As IDictionary)
            For Each Prop As String In PropertiesToRemove
                properties.Remove(Prop)
            Next
            MyBase.PostFilterProperties(properties)
        End Sub
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                If DefaultDesigner IsNot Nothing Then
                    DefaultDesigner.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Public Overrides Sub Initialize(component As System.ComponentModel.IComponent)
            Dim TypeDesigner As Type = Type.[GetType]("System.Windows.Forms.Design.ToolStripDropDownDesigner, System.Design")
            DefaultDesigner = CType(Activator.CreateInstance(TypeDesigner, BindingFlags.Instance Or BindingFlags.[Public], Nothing, Nothing, Nothing), ComponentDesigner)
            DefaultDesigner.Initialize(component)
            MyBase.Initialize(component)
        End Sub
        Public Overrides Sub InitializeNewComponent(defaultValues As IDictionary)
            MyBase.InitializeNewComponent(defaultValues)
            DefaultDesigner.InitializeNewComponent(defaultValues)
        End Sub
    End Class
End Namespace