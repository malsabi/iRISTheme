Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms.Design

Namespace Src.Components.Editor
    Public Class FileNamesEditor : Inherits UITypeEditor

        Private FD As OpenFileDialog

        Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
            Return UITypeEditorEditStyle.Modal
        End Function

        Public Overrides Function EditValue(context As ITypeDescriptorContext, provider As IServiceProvider, value As Object) As Object
            If context Is Nothing OrElse provider Is Nothing Then Return MyBase.EditValue(context, provider, value)
            Dim editorService = CType(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
            If editorService Is Nothing Then Return MyBase.EditValue(context, provider, value)
            FD = New OpenFileDialog With
            {
                .Filter = "Xml File (*.xml)|*.xml"
            }
            Return If(FD.ShowDialog() = DialogResult.OK, FD.FileName, MyBase.EditValue(context, provider, value))
        End Function
    End Class
End Namespace