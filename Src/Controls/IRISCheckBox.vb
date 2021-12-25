Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports iRISTheme.Src.Animations
Imports iRISTheme.Src.Components.Designers
Imports iRISTheme.Src.Enums
Imports iRISTheme.Src.Extensions
Imports iRISTheme.Src.Interfaces
Imports iRISTheme.Src.Styles.Dark
Imports iRISTheme.Src.Utilities

Namespace Src.Controls
    <ToolboxItem(True)>
    <ToolboxBitmap(GetType(ComponentBitmap), "ButtonBitmap.bmp")>
    <Designer(GetType(IRISCheckBoxDesigner))>
    Public Class IRISCheckBox : Inherits CheckBox : Implements IRISControl
#Region "Fields"
        Private _IsEnabled As Boolean
        Private _EnableAnimations As Boolean
        Private _BorderRadius As Integer
        Private _HoveredTickColor As Color
        Private _HoveredBackgroundColor As Color
        Private _HoveredBorderColor As Color
        Private _HoveredBorderWidth As Integer
        Private _HoveredTextColor As Color
        Private _CheckedTickColor As Color
        Private _CheckedBackgroundColor As Color
        Private _CheckedBorderColor As Color
        Private _CheckedBorderWidth As Integer
        Private _CheckedTextColor As Color
        Private _DefaultBorderColor As Color
        Private _DefaultBorderWidth As Integer
        Private _DisabledBackgroundColor As Color
        Private _DisabledBorderColor As Color
        Private _DisabledBorderWidth As Integer
        Private _DisabledTextColor As Color
        Private MouseCurrentState As MouseState
        Private AnimationManager As AnimationManager
        Private HoverAnimationManager As AnimationManager
        Private BoxOffset As Integer
        Private BoxRectangle As Rectangle
#End Region
#Region "Constants"
        Private Const CHECKBOX_SIZE As Integer = 18
        Private Const CHECKBOX_SIZE_HALF As Integer = CHECKBOX_SIZE / 2
        Private Const TEXT_OFFSET As Integer = 22
#End Region
#Region "Properties"
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the Enabled property is invalid on IRISCheckBox.", True)>
        Public Overloads Property Enabled As Boolean
            Get
                Return MyBase.Enabled
            End Get
            Set(value As Boolean)
                Throw New AccessViolationException("Accessing the Enabled property is invalid on IRISCheckBox.")
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets if the button is enabled or disabled.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property IsEnabled As Boolean
            Get
                Return _IsEnabled
            End Get
            Set(value As Boolean)
                _IsEnabled = value
                Cursor = Cursors.Default
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value indicating whether to enable animations on IRISCheckBox.")>
        Public Property EnableAnimations As Boolean
            Get
                Return _EnableAnimations
            End Get
            Set(value As Boolean)
                _EnableAnimations = value
                AutoSize = AutoSize
                If value Then
                    Margin = New Padding(0)
                End If
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the back ground color of the IRISCheckBox.")>
        Public Overrides Property BackColor As Color
            Get
                Return MyBase.BackColor
            End Get
            Set(value As Color)
                MyBase.BackColor = value
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the text color of the IRISCheckBox.")>
        Public Overrides Property ForeColor As Color
            Get
                Return MyBase.ForeColor
            End Get
            Set(value As Color)
                MyBase.ForeColor = value
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the border radius to show a rounded corners of the IRISCheckBox.")>
        Public Property BorderRadius As Integer
            Get
                Return _BorderRadius
            End Get
            Set(value As Integer)
                _BorderRadius = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the hovered tick color of the IRISCheckBox.")>
        Public Property HoveredTickColor As Color
            Get
                Return _HoveredTickColor
            End Get
            Set(value As Color)
                _HoveredTickColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the hovered background color of the IRISCheckBox.")>
        Public Property HoveredBackgroundColor As Color
            Get
                Return _HoveredBackgroundColor
            End Get
            Set(value As Color)
                _HoveredBackgroundColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the hovered border color of the IRISCheckBox.")>
        Public Property HoveredBorderColor As Color
            Get
                Return _HoveredBorderColor
            End Get
            Set(value As Color)
                _HoveredBorderColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the hovered border width of the IRISCheckBox.")>
        Public Property HoveredBorderWidth As Integer
            Get
                Return _HoveredBorderWidth
            End Get
            Set(value As Integer)
                _HoveredBorderWidth = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the hovered text color of the IRISCheckBox.")>
        Public Property HoveredTextColor As Color
            Get
                Return _HoveredTextColor
            End Get
            Set(value As Color)
                _HoveredTextColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the checked tick color of the IRISCheckBox.")>
        Public Property CheckedTickColor As Color
            Get
                Return _CheckedTickColor
            End Get
            Set(value As Color)
                _CheckedTickColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the checked mark background color of the IRISCheckBox.")>
        Public Property CheckedBackgroundColor As Color
            Get
                Return _CheckedBackgroundColor
            End Get
            Set(value As Color)
                _CheckedBackgroundColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the checked state border color of the IRISCheckBox.")>
        Public Property CheckedBorderColor As Color
            Get
                Return _CheckedBorderColor
            End Get
            Set(value As Color)
                _CheckedBorderColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the checked state border width of the IRISCheckBox.")>
        Public Property CheckedBorderWidth As Integer
            Get
                Return _CheckedBorderWidth
            End Get
            Set(value As Integer)
                _CheckedBorderWidth = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the checked state text color of the IRISCheckBox.")>
        Public Property CheckedTextColor As Color
            Get
                Return _CheckedTextColor
            End Get
            Set(value As Color)
                _CheckedTextColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the default state border color of the IRISCheckBox.")>
        Public Property DefaultBorderColor As Color
            Get
                Return _DefaultBorderColor
            End Get
            Set(value As Color)
                _DefaultBorderColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the default state border width of the IRISCheckBox.")>
        Public Property DefaultBorderWidth As Integer
            Get
                Return _DefaultBorderWidth
            End Get
            Set(value As Integer)
                _DefaultBorderWidth = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the disabled backround color of the IRISCheckBox.")>
        Public Property DisabledBackgroundColor As Color
            Get
                Return _DisabledBackgroundColor
            End Get
            Set(value As Color)
                _DisabledBackgroundColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the disabled border color of the IRISCheckBox.")>
        Public Property DisabledBorderColor As Color
            Get
                Return _DisabledBorderColor
            End Get
            Set(value As Color)
                _DisabledBorderColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the disabled border width of the IRISCheckBox.")>
        Public Property DisabledBorderWidth As Integer
            Get
                Return _DisabledBorderWidth
            End Get
            Set(value As Integer)
                _DisabledBorderWidth = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the disabled text color of the IRISCheckBox.")>
        Public Property DisabledTextColor As Color
            Get
                Return _DisabledTextColor
            End Get
            Set(value As Color)
                _DisabledTextColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or set a value for the auto size of the IRISCheckBox.")>
        Public Overrides Property AutoSize As Boolean
            Get
                Return MyBase.AutoSize
            End Get
            Set(value As Boolean)
                MyBase.AutoSize = value
                If value = False Then
                    Size = New Size(10, 10)
                End If
            End Set
        End Property
#End Region
#Region "Constructors"
        Public Sub New()
            Initialize()
        End Sub
#End Region
#Region "Public Methods"
#End Region
#Region "Private Methods"
#Region "Initialization"
        Private Sub Initialize()
            IsEnabled = True
            Cursor = Cursors.Hand
            Name = "IRISCheckBox"
            Text = "IRIS CHECK BOX"
            Font = FontUtilities.Regular(10)
            EnableAnimations = True
            Checked = False
            BackColor = New DarkStyle().BackgroundColor
            ForeColor = New DarkStyle().OnBackgroundColor
            BorderRadius = 0
            HoveredTickColor = Color.White
            HoveredBackgroundColor = Color.FromArgb(64, 64, 64)
            HoveredTextColor = Color.White
            HoveredBorderColor = Color.WhiteSmoke
            HoveredBorderWidth = 1
            CheckedTickColor = Color.White
            CheckedBackgroundColor = New DarkStyle().PrimaryColor
            CheckedBorderColor = New DarkStyle().PrimaryColor
            CheckedBorderWidth = 1
            CheckedTextColor = New DarkStyle().OnPrimaryColor
            DefaultBorderColor = New DarkStyle().OnBackgroundColor
            DefaultBorderWidth = 1
            DisabledBackgroundColor = New DarkStyle().DisabledColor
            DisabledBorderColor = New DarkStyle().OnDisabledColor
            DisabledBorderWidth = 1
            DisabledTextColor = New DarkStyle().OnDisabledColor
            MouseCurrentState = MouseState.Normal
            AnimationManager = New AnimationManager(False) With
            {
                .AnimationType = AnimationType.Linear,
                .Increment = 0.1,
                .SecondaryIncrement = 0.08
            }
            HoverAnimationManager = New AnimationManager(True) With
            {
                .AnimationType = AnimationType.EaseInOut,
                .Increment = 0.05
            }
            AddHandler AnimationManager.OnAnimationProgress, AddressOf OnAnimateUpdateClick
            AddHandler HoverAnimationManager.OnAnimationProgress, AddressOf OnAnimateUpdateHover
            AddHandler CheckedChanged, Sub() AnimationManager.StartNewAnimation(IIf(Checked, AnimationDirection.In, AnimationDirection.Out))
        End Sub
#End Region
#Region "Animation Handlers"
        Private Sub OnAnimateUpdateClick(Sender As Object)
            Invalidate()
        End Sub
        Private Sub OnAnimateUpdateHover(Sender As Object)
            Invalidate()
        End Sub
#End Region
#Region "CheckBox Handlers"
        Private Function DrawCheckMarkBitmap(TickColor As Color) As Bitmap
            Dim CHECKMARK_LINE As Point() = {New Point(3, 8), New Point(7, 12), New Point(14, 5)}
            Dim CheckMark = New Bitmap(CHECKBOX_SIZE, CHECKBOX_SIZE)
            Dim G As Graphics = Graphics.FromImage(CheckMark)
            G.Clear(Color.Transparent)
            Using ArrowPen = New Pen(TickColor, 2)
                G.DrawLines(ArrowPen, CHECKMARK_LINE)
            End Using
            Return CheckMark
        End Function
#End Region
#End Region
#Region "Overrided Methods"
        Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
            Dim G As Graphics = pevent.Graphics.ToHighQuality()
            Dim CHECKBOX_CENTER As Integer = BoxOffset + CHECKBOX_SIZE_HALF - 1
            'Fill the surface with the back color.
            G.Clear(BackColor)

            'Creates a graphics paths for rectangular or rounded corners.
            Dim CheckBoxGraphicsPath As New GraphicsPath(FillMode.Winding)
            CheckBoxGraphicsPath.StartFigure()
            If BorderRadius > 0 Then
                CheckBoxGraphicsPath = GraphicsUtilities.RoundedRectangle(BoxRectangle, BorderRadius)
            Else
                CheckBoxGraphicsPath.AddRectangle(BoxRectangle)
            End If
            CheckBoxGraphicsPath.CloseFigure()

            'Draw if disabled.
            If Not IsEnabled Then
                Using DisabledBackgroundBrush As New SolidBrush(DisabledBackgroundColor), DisabledBorderPen As New Pen(DisabledBorderColor, DisabledBorderWidth)
                    G.FillPath(DisabledBackgroundBrush, CheckBoxGraphicsPath)
                    If DisabledBorderPen.Width > 0 Then
                        G.DrawPath(DisabledBorderPen, CheckBoxGraphicsPath)
                    End If
                End Using
                Using TextBrush As New SolidBrush(DisabledTextColor)
                    Dim TextSize As SizeF = G.MeasureString(Text, Font)
                    G.DrawString(Text, Font, TextBrush, BoxOffset + TEXT_OFFSET, Height / 2 - TextSize.Height / 2)
                End Using
            Else
                'Draw default states for checked or unchecked.
                If Checked Then
                    Using CheckedBackgroundBrush As New SolidBrush(CheckedBackgroundColor)
                        'Draws the hovered backgroumd
                        G.FillPath(CheckedBackgroundBrush, CheckBoxGraphicsPath)
                    End Using
                    Using CheckedBorderPen As New Pen(CheckedBorderColor, CheckedBorderWidth)
                        G.DrawPath(CheckedBorderPen, CheckBoxGraphicsPath)
                    End Using
                    Using CheckedTextBrush As New SolidBrush(CheckedTextColor)
                        Dim TextSize As SizeF = G.MeasureString(Text, Font)
                        G.DrawString(Text, Font, CheckedTextBrush, BoxOffset + TEXT_OFFSET, Height / 2 - TextSize.Height / 2)
                    End Using
                    G.DrawImageUnscaledAndClipped(DrawCheckMarkBitmap(CheckedTickColor), New Rectangle(BoxOffset, BoxOffset, 17, 17))
                Else
                    Using DefaultBackgroundBrush As New SolidBrush(BackColor)
                        'Draws the hovered backgroumd
                        G.FillPath(DefaultBackgroundBrush, CheckBoxGraphicsPath)
                    End Using
                    Using DefaultBorderPen As New Pen(DefaultBorderColor, DefaultBorderWidth)
                        G.DrawPath(DefaultBorderPen, CheckBoxGraphicsPath)
                    End Using
                    Using TextBrush As New SolidBrush(ForeColor)
                        Dim TextSize As SizeF = G.MeasureString(Text, Font)
                        G.DrawString(Text, Font, TextBrush, BoxOffset + TEXT_OFFSET, Height / 2 - TextSize.Height / 2)
                    End Using
                End If
                If EnableAnimations Then
                    Dim AnimationProgress As Double = HoverAnimationManager.GetProgress()
                    'Handle the hover drawing animation for Background Color, Border Color, and Text Color.
                    Using HoveredBackgroundBrush As New SolidBrush(Color.FromArgb(AnimationProgress * HoveredBackgroundColor.A, HoveredBackgroundColor.RemoveAlpha()))
                        'Draws the hovered backgroumd
                        G.FillPath(HoveredBackgroundBrush, CheckBoxGraphicsPath)
                    End Using
                    Using HoveredBorderPen As New Pen(Color.FromArgb(AnimationProgress * HoveredBorderColor.A, HoveredBorderColor.RemoveAlpha()), HoveredBorderWidth)
                        'Draws the hovered border
                        G.DrawPath(HoveredBorderPen, CheckBoxGraphicsPath)
                    End Using
                    Using HoveredTextBrush As New SolidBrush(Color.FromArgb(AnimationProgress * HoveredTextColor.A, HoveredTextColor.RemoveAlpha()))
                        Dim TextSize As SizeF = G.MeasureString(Text, Font)
                        'Draws the hovered text.
                        G.DrawString(Text, Font, HoveredTextBrush, BoxOffset + TEXT_OFFSET, Height / 2 - TextSize.Height / 2)
                    End Using
                    If Checked AndAlso (MouseCurrentState.Equals(MouseState.Hovered) OrElse MouseCurrentState.Equals(MouseState.Up)) Then
                        G.DrawImageUnscaledAndClipped(DrawCheckMarkBitmap(HoveredTickColor), New Rectangle(BoxOffset, BoxOffset, 17.0 * AnimationProgress, 17))
                    End If
                    'Handle the click drawing animation For Background Color, Border Color, And Text Color.
                    If AnimationManager.IsAnimating() Then
                        For i As Integer = 0 To AnimationManager.GetAnimationCount() - 1
                            Dim AnimationValue = AnimationManager.GetProgress(i)
                            Dim AnimationSource = New Point(CHECKBOX_CENTER, CHECKBOX_CENTER)
                            Using BackgroundBrush As Brush = New SolidBrush(Color.FromArgb(AnimationValue * 40, Color.White))
                                Dim RippleHeight = If(Height Mod 2 = 0, Height - 3, Height - 2)
                                Dim RippleSize = If(AnimationManager.GetDirection(i) = AnimationDirection.InOutIn, CInt(RippleHeight * (0.8R + (0.2R * AnimationValue))), RippleHeight)
                                G.FillEllipse(BackgroundBrush, New Rectangle(AnimationSource.X - RippleSize / 2, AnimationSource.Y - RippleSize / 2, RippleSize, RippleSize))
                            End Using
                        Next
                    End If
                Else
                    If MouseCurrentState.Equals(MouseState.Hovered) OrElse MouseCurrentState.Equals(MouseState.Up) Then
                        'Handle the hover drawing for Background Color, Border Color, and Text Color.
                        Using HoveredBackgroundBrush As New SolidBrush(HoveredBackgroundColor)
                            'Draws the hovered backgroumd
                            G.FillPath(HoveredBackgroundBrush, CheckBoxGraphicsPath)
                        End Using
                        Using HoveredBorderPen As New Pen(HoveredBorderColor, HoveredBorderWidth)
                            'Draws the hovered border
                            G.DrawPath(HoveredBorderPen, CheckBoxGraphicsPath)
                        End Using
                        Using HoveredTextBrush As New SolidBrush(HoveredTextColor)
                            Dim TextSize As SizeF = G.MeasureString(Text, Font)
                            'Draws the hovered text.
                            G.DrawString(Text, Font, HoveredTextBrush, BoxOffset + TEXT_OFFSET, Height / 2 - TextSize.Height / 2)
                        End Using
                        If Checked Then
                            G.DrawImageUnscaledAndClipped(DrawCheckMarkBitmap(HoveredTickColor), New Rectangle(BoxOffset, BoxOffset, 17, 17))
                        End If
                    End If
                End If
            End If
        End Sub
        Public Overrides Function GetPreferredSize(proposedSize As Size) As Size
            Dim CurrentWidth As Integer = BoxOffset + CHECKBOX_SIZE + 2 + CInt(CreateGraphics().MeasureString(Text, Font).Width)
            Return If(EnableAnimations, New Size(CurrentWidth, 30), New Size(CurrentWidth, 20))
        End Function
        Protected Overrides Sub OnSizeChanged(e As EventArgs)
            MyBase.OnSizeChanged(e)
            BoxOffset = Height / 2 - CHECKBOX_SIZE_HALF
            BoxRectangle = New Rectangle(BoxOffset, BoxOffset, CHECKBOX_SIZE - 1, CHECKBOX_SIZE - 1)
        End Sub
        Protected Overrides Sub OnMouseEnter(eventargs As EventArgs)
            MouseCurrentState = MouseState.Hovered
            If IsEnabled Then
                Cursor = Cursors.Hand
                If EnableAnimations Then
                    HoverAnimationManager.StartNewAnimation(AnimationDirection.In)
                End If
            Else
                Cursor = Cursors.Default
            End If
            Invalidate()
        End Sub
        Protected Overrides Sub OnMouseLeave(eventargs As EventArgs)
            MouseCurrentState = MouseState.Normal
            Cursor = Cursors.Default
            If IsEnabled Then
                If EnableAnimations Then
                    HoverAnimationManager.StartNewAnimation(AnimationDirection.Out)
                End If
            End If
            Invalidate()
        End Sub
        Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
            MouseCurrentState = MouseState.Down
            If mevent.Button.Equals(MouseButtons.Left) Then
                AnimationManager.SecondaryIncrement = 0
                AnimationManager.StartNewAnimation(AnimationDirection.InOutIn)
            End If
            Invalidate()
        End Sub
        Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
            MouseCurrentState = MouseState.Up
            If mevent.Button.Equals(MouseButtons.Left) Then
                CheckState = IIf(CheckState.Equals(CheckState.Checked), CheckState.Unchecked, CheckState.Checked)
            End If
            AnimationManager.SecondaryIncrement = 0.08
            Invalidate()
        End Sub
#End Region
    End Class
End Namespace