Imports System.Windows.Forms.Design
Namespace Src.Components.Designers
    Friend Class IRISButtonDesigner : Inherits ControlDesigner
        Private ReadOnly PropertiesToRemove As String() = {"BackgroundImage", "BackgroundImageLayout", "ForeColor", "RightToLeft", "ImeMode", "Enable"}
        Protected Overrides Sub PostFilterProperties(properties As IDictionary)
            For Each Prop As String In PropertiesToRemove
                properties.Remove(Prop)
            Next
            MyBase.PostFilterProperties(properties)
        End Sub
    End Class
End Namespace