Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports iRISTheme.Src.Controls
Imports iRISTheme.Src.Helpers
Imports iRISTheme.Src.Styles.Dark

Namespace Src.Renders
    <TypeConverter(GetType(ExpandableObjectConverter))>
    Public Class IRISToolStripRender : Inherits ToolStripProfessionalRenderer
#Region "Fields"
        Private _SeparatorColor As Color
        Private _BorderColor As Color
        Private _ArrowColor As Color
        Private _SelectedArrowColor As Color
        Private _SelectedBackColor As Color
        Private _SelectedTextColor As Color
        Private _DisabledArrowColor As Color
        Private _DisabledTextColor As Color
        Private _TextRenderingHint As TextRenderingHint
        Private _TextAlign As HorizontalAlignment
        Private _ExtendItemWidth As Integer
        Private _TextOffset As Point
        Private _ImageOffset As Point
        Private _ImageMarginWidth As Integer
        Private _ImageMarginBorderColor As Color
        Private _ImageMarginBorderWidth As Integer
        Private _ImageMarginBackgroundColor As Color
        Private ReadOnly ContextMenu As IRISContextMenuStrip
#End Region
#Region "Properties"
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the ColorTable property is invalid on IRISToolStripRender", True)>
        Public Overloads Property ColorTable As ProfessionalColorTable
            Get
                Return Nothing
            End Get
            Set(value As ProfessionalColorTable)
                Throw New AccessViolationException("Accessing the ColorTable property is invalid on IRISToolStripRender")
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the separator color of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property SeparatorColor As Color
            Get
                Return _SeparatorColor
            End Get
            Set(value As Color)
                _SeparatorColor = value
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the border color of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property BorderColor As Color
            Get
                Return _BorderColor
            End Get
            Set(value As Color)
                _BorderColor = value
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the arrow color of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property ArrowColor As Color
            Get
                Return _ArrowColor
            End Get
            Set(value As Color)
                _ArrowColor = value
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the Selected arrow color of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property SelectedArrowColor As Color
            Get
                Return _SelectedArrowColor
            End Get
            Set(value As Color)
                _SelectedArrowColor = value
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the Selected back color of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property SelectedBackColor As Color
            Get
                Return _SelectedBackColor
            End Get
            Set(value As Color)
                _SelectedBackColor = value
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the Selected text color of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property SelectedTextColor As Color
            Get
                Return _SelectedTextColor
            End Get
            Set(value As Color)
                _SelectedTextColor = value
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled arrow color of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property DisabledArrowColor As Color
            Get
                Return _DisabledArrowColor
            End Get
            Set(value As Color)
                _DisabledArrowColor = value
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled text color of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property DisabledTextColor As Color
            Get
                Return _DisabledTextColor
            End Get
            Set(value As Color)
                _DisabledTextColor = value
                ContextMenu.Invalidate()
            End Set
        End Property

        <Category("IRIS Theme"), Description("Gets or sets the Text Rendering Hint of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property TextRenderingHint As TextRenderingHint
            Get
                Return _TextRenderingHint
            End Get
            Set(value As TextRenderingHint)
                _TextRenderingHint = value
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the text alignment of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property TextAlign As ContentAlignment
            Get
                Return _TextAlign
            End Get
            Set(value As ContentAlignment)
                _TextAlign = value
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the item width of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property ExtendItemWidth As Integer
            Get
                Return _ExtendItemWidth
            End Get
            Set(value As Integer)
                _ExtendItemWidth = value
                SetItemWidth(_ExtendItemWidth)
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the text offset of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property TextOffset As Point
            Get
                Return _TextOffset
            End Get
            Set(value As Point)
                _TextOffset = value
                ContextMenu.Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the image offset of the context menu.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property ImageOffset As Point
            Get
                Return _ImageOffset
            End Get
            Set(value As Point)
                _ImageOffset = value
                ContextMenu.Invalidate()
            End Set
        End Property
#End Region
#Region "Constructors"
        Public Sub New(ContextMenu As IRISContextMenuStrip)
            Me.ContextMenu = ContextMenu
            InitializeProperties()
        End Sub
#End Region
#Region "Private Methods"
#Region "Initialize"
        Private Sub InitializeProperties()
            SeparatorColor = New DarkStyle().PrimaryColor
            BorderColor = New DarkStyle().PrimaryColor
            ArrowColor = New DarkStyle().PrimaryColor
            SelectedArrowColor = New DarkStyle().OnPrimaryColor
            SelectedBackColor = Color.FromArgb(64, 64, 64)
            SelectedTextColor = New DarkStyle().OnBackgroundColor
            DisabledTextColor = New DarkStyle().OnDisabledColor
            DisabledArrowColor = New DarkStyle().OnDisabledColor
            TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            TextAlign = ContentAlignment.MiddleLeft
            ExtendItemWidth = 0
            TextOffset = New Point(0, 0)
            ImageOffset = New Point(0, 0)
        End Sub
#End Region
#Region "Helpers"
        Private Function GetItemBounds(Item As ToolStripItem)
            Return New Rectangle(0, Item.ContentRectangle.Y, Item.ContentRectangle.Width + 4, Item.ContentRectangle.Height)
        End Function
        Private Sub SetItemWidth(ExtendItemWidth As Integer)
            If ContextMenu IsNot Nothing Then
                Dim IsItemFound As Boolean = False
                Dim ItemIndex As Integer = -1
                For Each Item As ToolStripItem In ContextMenu.Items
                    If Item.Name.Equals("DummyOwnerToolStripMenuItem") Then
                        ItemIndex = ContextMenu.Items.IndexOf(Item)
                        IsItemFound = True
                    End If
                Next
                If IsItemFound Then
                    ContextMenu.Items.Item(ItemIndex).Text = StrDup(ExtendItemWidth, "#")
                Else
                    Dim OwnerItem As New ToolStripMenuItem With
                    {
                        .Name = "DummyOwnerToolStripMenuItem",
                        .Text = StrDup(ExtendItemWidth, "#"),
                        .Visible = False
                    }
                    ContextMenu.Items.Add(OwnerItem)
                End If
            End If
        End Sub
#End Region
#End Region
#Region "Overrided Methods"
        Protected Overrides Sub OnRenderArrow(e As ToolStripArrowRenderEventArgs)
            Dim G As Graphics = e.Graphics
            Const ARROW_SIZE As Integer = 4
            Dim ArrowMiddle = New Point(e.ArrowRectangle.X + e.ArrowRectangle.Width / 2, e.ArrowRectangle.Y + e.ArrowRectangle.Height / 2)
            Using ArrowPath = New GraphicsPath()
                ArrowPath.AddLines({New Point(ArrowMiddle.X - ARROW_SIZE, ArrowMiddle.Y - ARROW_SIZE), New Point(ArrowMiddle.X, ArrowMiddle.Y), New Point(ArrowMiddle.X - ARROW_SIZE, ArrowMiddle.Y + ARROW_SIZE)})
                ArrowPath.CloseFigure()
                If e.Item.Enabled Then
                    Using ArrowBrush As New SolidBrush(IIf(e.Item.Selected, ArrowColor, SelectedArrowColor))
                        G.FillPath(ArrowBrush, ArrowPath)
                    End Using
                Else
                    Using ArrowBrush As New SolidBrush(DisabledArrowColor)
                        G.FillPath(ArrowBrush, ArrowPath)
                    End Using
                End If
            End Using
        End Sub
        Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
            Dim G As Graphics = e.Graphics
            G.TextRenderingHint = TextRenderingHint
            Dim ItemBounds As Rectangle = e.TextRectangle
            If TextOffset.X < 0 OrElse TextOffset.Y < 0 Then
                MessageBox.Show("One of the axis is below zero, make sure it is greater or equal zero", "TextOffset Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ItemBounds.Offset(TextOffset.X, TextOffset.Y)
            End If
            Dim TextAlignment As StringFormat = GraphicsHelper.GetTextPosition(TextAlign)
            'Draw Item Text if it is enabled or disabled.
            If e.Item.Enabled Then
                Using FontBrush As New SolidBrush(IIf(e.Item.Selected, SelectedTextColor, ContextMenu.ForeColor))
                    G.DrawString(e.Item.Text, ContextMenu.Font, FontBrush, ItemBounds, TextAlignment)
                End Using
            Else
                Using FontBrush As New SolidBrush(DisabledTextColor)
                    G.DrawString(e.Item.Text, ContextMenu.Font, FontBrush, ItemBounds, TextAlignment)
                End Using
            End If
        End Sub
        Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
            With e.Graphics
                .SmoothingMode = SmoothingMode.AntiAlias
                .InterpolationMode = InterpolationMode.High
                .Clear(ContextMenu.BackColor)
            End With
        End Sub
        Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
            Dim G As Graphics = e.Graphics
            Dim ItemBounds As Rectangle = GetItemBounds(e.Item)
            'Draw Item Background On Hover or Selected or none.
            Using BackgroundBrush As New SolidBrush(IIf(e.Item.Selected AndAlso e.Item.Enabled, SelectedBackColor, ContextMenu.BackColor))
                G.FillRectangle(BackgroundBrush, ItemBounds)
            End Using
            If e.Item.Enabled Then
                Dim ToolStrip = TryCast(e.ToolStrip, IRISContextMenuStrip)
                If ToolStrip IsNot Nothing Then
                    'Draw Ripple Animation on Item Background
                    Dim AnimationManager = ToolStrip.AnimationManager
                    Dim AnimationSource = ToolStrip.AnimationSource
                    If ToolStrip.AnimationManager.IsAnimating() AndAlso e.Item.Bounds.Contains(AnimationSource) Then
                        For i As Integer = 0 To AnimationManager.GetAnimationCount() - 1
                            Dim AnimationValue = AnimationManager.GetProgress(i)
                            Dim RippleBrush = New SolidBrush(Color.FromArgb(101 - (AnimationValue * 100), New DarkStyle().OnPrimaryColor))
                            Dim RippleSize = CInt(AnimationValue * ItemBounds.Width * 2)
                            G.FillEllipse(RippleBrush, New Rectangle(AnimationSource.X - RippleSize / 2, AnimationSource.Y - RippleSize / 2, RippleSize, RippleSize))
                        Next
                    End If
                End If
            End If
        End Sub
        Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
            Dim G As Graphics = e.Graphics
            'Draw Item Separator
            Using BackgroundBrush As New SolidBrush(ContextMenu.BackColor), SeparatorPen As New Pen(SeparatorColor, 1)
                G.FillRectangle(BackgroundBrush, e.Item.Bounds)
                If ContextMenu.ShowImageMargin Then
                    G.DrawLine(SeparatorPen, New Point(33, e.Item.Bounds.Height / 2), New Point(e.Item.Bounds.Right, e.Item.Bounds.Height / 2))
                Else
                    G.DrawLine(SeparatorPen, New Point(e.Item.Bounds.Left, e.Item.Bounds.Height / 2), New Point(e.Item.Bounds.Right, e.Item.Bounds.Height / 2))
                End If
            End Using
        End Sub
        Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
            Dim G As Graphics = e.Graphics
            Dim BorderRectangle As New Rectangle(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1)
            'Draw Context Menu Border.
            Using BorderPen As New Pen(BorderColor, 1)
                G.DrawRectangle(BorderPen, BorderRectangle)
            End Using
        End Sub
        Protected Overrides Sub OnRenderImageMargin(e As ToolStripRenderEventArgs)
        End Sub
        Protected Overrides Sub OnRenderItemImage(e As ToolStripItemImageRenderEventArgs)
            MyBase.OnRenderItemImage(e)
        End Sub
        Protected Overrides Sub OnRenderItemCheck(e As ToolStripItemImageRenderEventArgs)
        End Sub
#End Region
    End Class
End Namespace