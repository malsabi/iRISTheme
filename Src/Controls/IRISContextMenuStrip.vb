Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports iRISTheme.Src.Animations
Imports iRISTheme.Src.Components.Designers
Imports iRISTheme.Src.Enums
Imports iRISTheme.Src.Interfaces
Imports iRISTheme.Src.Renders
Imports iRISTheme.Src.Styles.Dark
Imports iRISTheme.Src.Utilities

Namespace Src.Controls
    <ComVisible(True)>
    <ToolboxItem(True)>
    <ToolboxBitmap(GetType(ComponentBitmap), "ContextMenuStrip.bmp")>
    <Designer(GetType(IRISContextMenuStripDesigner))>
    Public Class IRISContextMenuStrip : Inherits ContextMenuStrip : Implements IRISControl
#Region "Fields"
        Private _RenderStyle As IRISToolStripRender
        Private DelayesArgs As ToolStripItemClickedEventArgs
        Protected Friend AnimationManager As AnimationManager
        Protected Friend AnimationSource As Point
#End Region
#Region "Properties"
        <EditorBrowsable(EditorBrowsableState.Never)>
        <Browsable(False)>
        Public ReadOnly Property IsDesignMode
            Get
                Return DesignMode
            End Get
        End Property
        <Category("IRIS Theme")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Property RenderStyle As IRISToolStripRender
            Get
                Return _RenderStyle
            End Get
            Set(value As IRISToolStripRender)
                _RenderStyle = value
                Invalidate()
            End Set
        End Property
        <Category("Appearance")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads Property ForeColor As Color
            Get
                Return MyBase.ForeColor
            End Get
            Set(value As Color)
                MyBase.ForeColor = value
            End Set
        End Property
#End Region
#Region "Events & Handlers"
        Public Delegate Sub OnItemClickStartDelegate(Sender As Object, e As ToolStripItemClickedEventArgs)
        Public Event OnItemClickStart As OnItemClickStartDelegate
#End Region
#Region "Constructors"
        Public Sub New()
            AnimationManager = New AnimationManager(False) With
            {
                .AnimationType = AnimationType.EaseOut,
                .Increment = 0.06
            }
            AddHandler AnimationManager.OnAnimationProgress, AddressOf OnAnimateUpdateClick
            AddHandler AnimationManager.OnAnimationFinished, AddressOf OnAnimateUpdateFinished
            Name = "IRISContextMenuStrip"
            ShowImageMargin = True
            ShowCheckMargin = False
            Font = FontUtilities.Regular(12)
            BackColor = New DarkStyle().BackgroundColor
            ForeColor = New DarkStyle().OnBackgroundColor
            RenderStyle = New IRISToolStripRender(Me)
            Renderer = RenderStyle
        End Sub
#End Region
#Region "Private Methods"
#Region "Animation Handlers"
        Private Sub OnAnimateUpdateClick(Sender As Object)
            Invalidate()
        End Sub
        Private Sub OnAnimateUpdateFinished(Sender As Object)
            OnItemClicked(DelayesArgs)
        End Sub
#End Region
#Region "ImageMargin & CheckMargin Helpers"
        'Public Sub HideImageMarginsAndCheckMargins(ContextMenuStrip As IRISContextMenuStrip)
        '    HideImageMarginsAndCheckMargins(ContextMenuStrip.Items.OfType(Of ToolStripMenuItem)().ToList())
        'End Sub
        'Private Sub HideImageMarginsAndCheckMargins(ToolStripMenuItems As List(Of ToolStripMenuItem))
        '    For Each Item As ToolStripMenuItem In ToolStripMenuItems
        '        Dim Dropdown As ToolStripDropDownMenu
        '        If TryCast(Item.DropDown, ToolStripDropDownMenu) Is Nothing Then
        '            Return
        '        Else
        '            Dropdown = TryCast(Item.DropDown, ToolStripDropDownMenu)
        '        End If
        '        Dropdown.ShowImageMargin = True
        '        Dropdown.ShowCheckMargin = False
        '        HideImageMarginsAndCheckMargins(Item.DropDownItems.OfType(Of ToolStripMenuItem)().ToList())
        '    Next
        'End Sub
        'Public Sub ShowImageMargins(ContextMenuStrip As IRISContextMenuStrip)
        '    ShowImageMargins(ContextMenuStrip.Items.OfType(Of ToolStripMenuItem)().ToList())
        'End Sub
        'Private Sub ShowImageMargins(ToolStripMenuItems As List(Of ToolStripMenuItem))
        '    For Each Item As ToolStripMenuItem In ToolStripMenuItems
        '        Dim Dropdown As ToolStripDropDownMenu
        '        If TryCast(Item.DropDown, ToolStripDropDownMenu) Is Nothing Then
        '            Return
        '        Else
        '            Dropdown = TryCast(Item.DropDown, ToolStripDropDownMenu)
        '        End If
        '        Dropdown.ShowImageMargin = True
        '        ShowImageMargins(Item.DropDownItems.OfType(Of ToolStripMenuItem)().ToList())
        '    Next
        'End Sub
#End Region
#End Region
#Region "Overrided Methods"
        Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
            MyBase.OnControlAdded(e)
        End Sub
        Protected Overrides Sub OnMouseHover(e As EventArgs)
            MyBase.OnMouseHover(e)
            Invalidate()
        End Sub
        Protected Overrides Sub OnMouseMove(mea As MouseEventArgs)
            MyBase.OnMouseMove(mea)
            'Handle Enable Cursor Style.
            For Each Item As ToolStripItem In Items
                If Item.Bounds.Contains(mea.Location) AndAlso Not (TypeOf Item Is ToolStripSeparator) Then
                    If Item.Enabled Then
                        Cursor = Cursors.Hand
                    Else
                        Cursor = Cursors.Default
                    End If
                End If
            Next
        End Sub
        Protected Overrides Sub OnMouseUp(mea As MouseEventArgs)
            MyBase.OnMouseUp(mea)
            AnimationSource = mea.Location
            'Handle Enable Cursor Style.
            For Each Item As ToolStripItem In Items
                If Item.Bounds.Contains(AnimationSource) AndAlso Not (TypeOf Item Is ToolStripSeparator) Then
                    If Item.Enabled Then
                        Cursor = Cursors.Hand
                    Else
                        Cursor = Cursors.Default
                    End If
                End If
            Next
            Invalidate()
        End Sub
        Protected Overrides Sub OnItemClicked(e As ToolStripItemClickedEventArgs)
            If e.ClickedItem IsNot Nothing AndAlso Not (TypeOf e.ClickedItem Is ToolStripSeparator) AndAlso e.ClickedItem.Enabled Then
                If e Is DelayesArgs Then
                    MyBase.OnItemClicked(e)
                Else
                    DelayesArgs = e
                    RaiseEvent OnItemClickStart(Me, e)
                    AnimationManager.StartNewAnimation(AnimationDirection.In)
                End If
            End If
        End Sub
#End Region
    End Class
    Public Class IRISToolStripMenuItem : Inherits ToolStripMenuItem
        Public Sub New()
            Name = "IRISToolStripMenuItem"
        End Sub
        Protected Overrides Sub OnDropDownShow(e As EventArgs)
            If Owner.Items.Count > 0 Then
                For Each Item As ToolStripItem In Owner.Items
                    Item.Padding = New Padding(4, Item.Padding.Top, Item.Padding.Right, Item.Padding.Bottom)
                Next
            End If
            MyBase.OnDropDownShow(e)
        End Sub
        Protected Overrides Function CreateDefaultDropDown() As ToolStripDropDown
            Dim baseDropDown = MyBase.CreateDefaultDropDown()
            If DesignMode Then Return baseDropDown
            Dim defaultDropDown = New IRISContextMenuStrip()
            defaultDropDown.Items.AddRange(baseDropDown.Items)
            Return defaultDropDown
        End Function
    End Class
End Namespace