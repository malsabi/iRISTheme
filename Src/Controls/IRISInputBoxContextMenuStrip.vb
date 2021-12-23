Imports System.ComponentModel
Imports iRISTheme.Src.BaseControls

Namespace Src.Controls
    Public Class IRISInputBoxContextMenuStrip : Inherits IRISContextMenuStrip
#Region "Fields"
        Public ReadOnly Undo As ToolStripItem = New IRISToolStripMenuItem With {.Text = "Undo"}
        Public ReadOnly Seperator1 As ToolStripItem = New ToolStripSeparator()
        Public ReadOnly Cut As ToolStripItem = New IRISToolStripMenuItem With {.Text = "Cut"}
        Public ReadOnly Copy As ToolStripItem = New IRISToolStripMenuItem With {.Text = "Copy"}
        Public ReadOnly Paste As ToolStripItem = New IRISToolStripMenuItem With {.Text = "Paste"}
        Public ReadOnly Delete As ToolStripItem = New IRISToolStripMenuItem With {.Text = "Delete"}
        Public ReadOnly Seperator2 As ToolStripItem = New ToolStripSeparator()
        Public ReadOnly SelectAll As ToolStripItem = New IRISToolStripMenuItem With {.Text = "Select All"}
#End Region
#Region "Properties"
#End Region
#Region "Constructors"
        Public Sub New()
            Name = "TextBoxContextMenuStrip"
            ShowImageMargin = False
            ShowCheckMargin = False
            Items.AddRange({Undo, Seperator1, Cut, Copy, Paste, Delete, Seperator2, SelectAll})
            AddHandler Opening, AddressOf ContextMenuStripOnOpening
            AddHandler OnItemClickStart, AddressOf ContextMenuStripOnItemClickStart
        End Sub
#End Region
#Region "Events & Handlers"
        Private Sub ContextMenuStripOnItemClickStart(sender As Object, toolStripItemClickedEventArgs As ToolStripItemClickedEventArgs)
            If IRISInputBox() IsNot Nothing Then
                Select Case toolStripItemClickedEventArgs.ClickedItem.Text
                    Case "Undo"
                        IRISInputBox().Undo()
                    Case "Cut"
                        IRISInputBox().Cut()
                    Case "Copy"
                        IRISInputBox().Copy()
                    Case "Paste"
                        IRISInputBox().Paste()
                    Case "Delete"
                        IRISInputBox().Delete()
                    Case "Select All"
                        IRISInputBox().SelectAll()
                End Select
            End If
        End Sub
        Private Sub ContextMenuStripOnOpening(sender As Object, cancelEventArgs As CancelEventArgs)
            Dim MenuStrip As IRISInputBoxContextMenuStrip = TryCast(sender, IRISInputBoxContextMenuStrip)
            If MenuStrip IsNot Nothing AndAlso IRISInputBox() IsNot Nothing Then
                MenuStrip.Undo.Enabled = IRISInputBox().CanUndo
                MenuStrip.Cut.Enabled = Not String.IsNullOrEmpty(IRISInputBox().SelectedText)
                MenuStrip.Copy.Enabled = Not String.IsNullOrEmpty(IRISInputBox().SelectedText)
                MenuStrip.Paste.Enabled = Clipboard.ContainsText()
                MenuStrip.Delete.Enabled = Not String.IsNullOrEmpty(IRISInputBox().SelectedText)
                MenuStrip.SelectAll.Enabled = Not String.IsNullOrEmpty(IRISInputBox().Text)
            End If
        End Sub
#End Region
#Region "Private Methods"
        Private Function IsSourceControlBaseInputBox() As Boolean
            If SourceControl Is Nothing Then
                Return False
            Else
                If (TypeOf SourceControl Is BaseInputBox) Then
                    Return True
                Else
                    Return False
                End If
            End If
        End Function
        Private Function IsSourceControlInputBox() As Boolean
            If SourceControl Is Nothing Then
                Return False
            Else
                If (TypeOf SourceControl Is IRISInputBox) Then
                    Return True
                Else
                    Return False
                End If
            End If
        End Function
        Private Function IRISInputBox()
            If IsSourceControlInputBox() Then
                Return CType(SourceControl, IRISInputBox)
            ElseIf IsSourceControlBaseInputBox() Then
                Return CType(SourceControl, BaseInputBox)
            Else
                Return Nothing
            End If
        End Function
#End Region
    End Class
End Namespace