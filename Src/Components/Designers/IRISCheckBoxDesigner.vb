Imports System.Windows.Forms.Design
Namespace Src.Components.Designers
    Public Class IRISCheckBoxDesigner : Inherits ControlDesigner
        Protected DefaultDesigner As ControlDesigner
        Private ReadOnly PropertiesToRemove As String() = {"BackgroundImage", "BackgroundImageLayout", "Appearance", "CheckAlign", "Cursor", "FlatAppearance", "FlatStyle", "Image", "ImageAlign", "ImageIndex", "ImageKey", "ImageList", "RightToLeft", "TextAlign", "TextImageRelation", "UseMnemonic", "UseVisualStyleBackColor", "UseWaitCursor", "AllowDrop", "AutoCheck", "AutoEllipsis", "ContextMenuStrip", "TabIndex", "ThreeState", "UseCompatibleTextRendering"}
        Protected Overrides Sub PostFilterProperties(properties As IDictionary)
            For Each Prop As String In PropertiesToRemove
                properties.Remove(Prop)
            Next
            MyBase.PostFilterProperties(properties)
        End Sub
    End Class
End Namespace