Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports iRISTheme.Src.Animations
Imports iRISTheme.Src.BaseControls
Imports iRISTheme.Src.Enums
Imports iRISTheme.Src.Extensions
Imports iRISTheme.Src.Interfaces
Imports iRISTheme.Src.Styles.Dark
Imports iRISTheme.Src.Utilities

Namespace Src.Controls
    <ToolboxItem(True)>
    <ToolboxBitmap(GetType(ComponentBitmap), "InputBox.bmp")>
    Public Class IRISInputBox : Inherits ContainerControl : Implements IRISControl
#Region "Fields"
        Private _IsEnabled As Boolean
        Private _TextColor As Color
        Private _BorderRadius As Integer
        Private _DefaultBorderColor As Color
        Private _DefaultBorderWidth As Single
        Private _FocusedBorderColor As Color
        Private _FocusedBorderWidth As Integer
        Private _UnderlinedStyle As Boolean
        Private _DefaultBackgroundColor As Color
        Private _HoverBackgroundColor As Color
        Private _HoverTextColor As Color
        Private _HoverBorderColor As Color
        Private _HoverBorderWidth As Integer
        Private _FocusedBackgroundColor As Color
        Private _FocusedTextColor As Color
        Private _DisabledBackgroundColor As Color
        Private _DisabledTextColor As Color
        Private _DisabledBorderColor As Color
        Private _DisabledBorderWidth As Integer
        Private _EnableAnimations As Boolean
        Private MouseCurrentState As MouseState
        Private AnimationManager As AnimationManager
        Private HoverAnimationManager As AnimationManager
        Private WithEvents InnerTextBox As New BaseInputBox()
#End Region
#Region "Properties"
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the BackColor property is invalid on IRISInputBox", True)>
        Public Overrides Property BackColor As Color
            Get
                Return MyBase.BackColor
            End Get
            Set(value As Color)
                Throw New AccessViolationException("Accessing the BackColor property is invalid on IRISInputBox")
            End Set
        End Property
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the ForeColor property is invalid on IRISInputBox", True)>
        Public Overrides Property ForeColor As Color
            Get
                Return MyBase.ForeColor
            End Get
            Set(value As Color)
                Throw New AccessViolationException("Accessing the ForeColor property is invalid on IRISInputBox")
            End Set
        End Property
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the Enabled property is invalid on IRISInputBox", True)>
        Public Overloads Property Enabled As Boolean
            Get
                Return MyBase.Enabled
            End Get
            Set(value As Boolean)
                Throw New AccessViolationException("Accessing the Enabled property is invalid on IRISInputBox")
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets if the InputBox is enabled or disabled.")>
        Public Property IsEnabled As Boolean
            Get
                Return _IsEnabled
            End Get
            Set(value As Boolean)
                _IsEnabled = value
                InnerTextBox.Enabled = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Sets or gets the IRISContextMenuStrip for the InputBox.")>
        Public Overrides Property ContextMenuStrip As ContextMenuStrip
            Get
                Return MyBase.ContextMenuStrip
            End Get
            Set(value As ContextMenuStrip)
                MyBase.ContextMenuStrip = value
                InnerTextBox.ContextMenuStrip = value
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets a value indicating whether the text in InputBox control should appear as the default password character.")>
        Public Property UseSystemPasswordChar As Boolean
            Get
                Return InnerTextBox.UseSystemPasswordChar
            End Get
            Set(value As Boolean)
                InnerTextBox.UseSystemPasswordChar = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the password character that is used to hige the text.")>
        Public Property PasswordChar As Char
            Get
                Return InnerTextBox.PasswordChar
            End Get
            Set(value As Char)
                InnerTextBox.PasswordChar = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the font of the InputBox.")>
        Public Overrides Property Font As Font
            Get
                Return MyBase.Font
            End Get
            Set(value As Font)
                MyBase.Font = value
                InnerTextBox.Font = Font
                OnResize(Nothing)
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the text of the InputBox.")>
        Public Overrides Property Text As String
            Get
                Return InnerTextBox.Text
            End Get
            Set(value As String)
                InnerTextBox.Text = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the text-alignment of the InputBox.")>
        Public Property TextAlign As HorizontalAlignment
            Get
                Return InnerTextBox.TextAlign
            End Get
            Set(value As HorizontalAlignment)
                InnerTextBox.TextAlign = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the text color of the InputBox.")>
        Public Property TextColor As Color
            Get
                Return _TextColor
            End Get
            Set(value As Color)
                _TextColor = value
                InnerTextBox.ForeColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the text color of the InputBox.")>
        Public Property SelectedText As String
            Get
                Return InnerTextBox.SelectedText
            End Get
            Set(value As String)
                InnerTextBox.SelectedText = value
                Invalidate()
            End Set
        End Property

        <Category("IRIS Theme"), Description("Gets or sets the place holder of the InputBox.")>
        Public Property PlaceHolderText As String
            Get
                Return InnerTextBox.PlaceHolderText
            End Get
            Set(value As String)
                InnerTextBox.PlaceHolderText = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the place holder color of the InputBox.")>
        Public Property PlaceHolderTextColor As Color
            Get
                Return InnerTextBox.PlaceHolderTextColor
            End Get
            Set(value As Color)
                InnerTextBox.PlaceHolderTextColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the border radius of the InputBox.")>
        Public Property BorderRadius As Integer
            Get
                Return _BorderRadius
            End Get
            Set(value As Integer)
                _BorderRadius = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the border color of the InputBox.")>
        Public Property DefaultBorderColor As Color
            Get
                Return _DefaultBorderColor
            End Get
            Set(value As Color)
                _DefaultBorderColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the border width of the InputBox.")>
        Public Property DefaultBorderWidth As Single
            Get
                Return _DefaultBorderWidth
            End Get
            Set(value As Single)
                _DefaultBorderWidth = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the focused border color of the InputBox.")>
        Public Property FocusedBorderColor As Color
            Get
                Return _FocusedBorderColor
            End Get
            Set(value As Color)
                _FocusedBorderColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the focused border width of the InputBox.")>
        Public Property FocusedBorderWidth As Integer
            Get
                Return _FocusedBorderWidth
            End Get
            Set(value As Integer)
                _FocusedBorderWidth = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the underlined style of the InputBox.")>
        Public Property UnderlinedStyle As Boolean
            Get
                Return _UnderlinedStyle
            End Get
            Set(value As Boolean)
                _UnderlinedStyle = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the background color of the InputBox.")>
        Public Property DefaultBackgroundColor As Color
            Get
                Return _DefaultBackgroundColor
            End Get
            Set(value As Color)
                _DefaultBackgroundColor = value
                InnerTextBox.BackColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the hover color of the InputBox.")>
        Public Property HoverBackgroundColor As Color
            Get
                Return _HoverBackgroundColor
            End Get
            Set(value As Color)
                _HoverBackgroundColor = value
                If MouseCurrentState.Equals(MouseState.Hovered) Then
                    InnerTextBox.BackColor = value
                End If
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the hover text color of the InputBox.")>
        Public Property HoverTextColor As Color
            Get
                Return _HoverTextColor
            End Get
            Set(value As Color)
                _HoverTextColor = value
                If MouseCurrentState.Equals(MouseState.Hovered) Then
                    InnerTextBox.ForeColor = value
                End If
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the hover border color of the InputBox.")>
        Public Property HoverBorderColor As Color
            Get
                Return _HoverBorderColor
            End Get
            Set(value As Color)
                _HoverBorderColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the hover border width of the InputBox.")>
        Public Property HoverBorderWidth As Integer
            Get
                Return _HoverBorderWidth
            End Get
            Set(value As Integer)
                _HoverBorderWidth = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the focused color of the InputBox.")>
        Public Property FocusedBackgroundColor As Color
            Get
                Return _FocusedBackgroundColor
            End Get
            Set(value As Color)
                _FocusedBackgroundColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the focused text color of the InputBox.")>
        Public Property FocusedTextColor As Color
            Get
                Return _FocusedTextColor
            End Get
            Set(value As Color)
                _FocusedTextColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled background color of the InputBox.")>
        Public Property DisabledBackgroundColor As Color
            Get
                Return _DisabledBackgroundColor
            End Get
            Set(value As Color)
                _DisabledBackgroundColor = value
                If Not IsEnabled Then
                    InnerTextBox.BackColor = value
                End If
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled text color of the InputBox.")>
        Public Property DisabledTextColor As Color
            Get
                Return _DisabledTextColor
            End Get
            Set(value As Color)
                _DisabledTextColor = value
                If Not IsEnabled Then
                    InnerTextBox.ForeColor = value
                End If
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled border color of the InputBox.")>
        Public Property DisabledBorderColor As Color
            Get
                Return _DisabledBorderColor
            End Get
            Set(value As Color)
                _DisabledBorderColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled border width of the InputBox.")>
        Public Property DisabledBorderWidth As Integer
            Get
                Return _DisabledBorderWidth
            End Get
            Set(value As Integer)
                _DisabledBorderWidth = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the animation manager to show or to hide.")>
        Public Property EnableAnimations As Boolean
            Get
                Return _EnableAnimations
            End Get
            Set(value As Boolean)
                _EnableAnimations = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the multi line of the InputBox.")>
        Public Property MultiLine As Boolean
            Get
                Return InnerTextBox.Multiline
            End Get
            Set(value As Boolean)
                InnerTextBox.Multiline = value
                OnResize(Nothing)
                Invalidate()
            End Set
        End Property
#End Region
#Region "Events & Handlers"
        Public Delegate Sub InputTextChangedDelegate(Sender As Object)
        Public Event InputTextChanged As InputTextChangedDelegate
        Private Sub InputBoxMouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
            MouseCurrentState = MouseState.Hovered
            If EnableAnimations AndAlso IsEnabled Then
                HoverAnimationManager.StartNewAnimation(AnimationDirection.In)
            End If
            Invalidate()
        End Sub
        Private Sub InputBoxMouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
            MouseCurrentState = MouseState.Normal
            If EnableAnimations AndAlso IsEnabled Then
                HoverAnimationManager.StartNewAnimation(AnimationDirection.Out)
            End If
            Invalidate()
        End Sub
#End Region
#Region "Constructors"
        Public Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            DoubleBuffered = True
            UpdateStyles()
            Initialize()
            InitializeInnerTextBox()
        End Sub
#End Region
#Region "Private Methods"
#Region "Initialization"
        Private Sub Initialize()
            IsEnabled = True
            Font = FontUtilities.SemiBold(12)
            Name = "IRISInputBox"
            TextAlign = HorizontalAlignment.Left
            TextColor = New DarkButtonStyle().OnNormalColor
            BorderRadius = 30
            DefaultBorderColor = New DarkButtonStyle().NormalBorderColor
            DefaultBorderWidth = 1
            FocusedBorderColor = New DarkButtonStyle().NormalBorderColor
            FocusedBorderWidth = 1
            UnderlinedStyle = True
            DefaultBackgroundColor = New DarkButtonStyle().NormalColor
            HoverBackgroundColor = New DarkButtonStyle().HoveredColor
            HoverTextColor = New DarkButtonStyle().OnHoveredColor
            HoverBorderColor = New DarkButtonStyle().NormalBorderColor
            HoverBorderWidth = 1
            FocusedBackgroundColor = New DarkButtonStyle().PressedColor
            FocusedTextColor = New DarkButtonStyle().OnPressedColor
            DisabledBackgroundColor = New DarkButtonStyle().DisabledColor
            DisabledTextColor = New DarkButtonStyle().OnDisabledColor
            DisabledBorderColor = New DarkButtonStyle().DisabledBorderColor
            DisabledBorderWidth = 1
            EnableAnimations = True
            MultiLine = False
            UseSystemPasswordChar = False
            PasswordChar = "*"
            MouseCurrentState = MouseState.Normal
            Size = New Size(140, 40)
            Padding = New Padding(10, 5, 10, 5)
            Font = New Font("Verdana", 10, FontStyle.Regular)
            Cursor = Cursors.IBeam
            AnimationManager = New AnimationManager(True) With
            {
                .Increment = 0.07,
                .AnimationType = AnimationType.EaseInOut,
                .InterruptAnimation = False
            }
            HoverAnimationManager = New AnimationManager(True) With
            {
                .Increment = 0.03,
                .AnimationType = AnimationType.Linear
            }
            AddHandler AnimationManager.OnAnimationProgress, AddressOf OnAnimateUpdateClick
            AddHandler HoverAnimationManager.OnAnimationProgress, AddressOf OnAnimateUpdateHover
            InnerTextBox.TabStop = True
            TabStop = False
        End Sub
        Private Sub InitializeInnerTextBox()
            With InnerTextBox
                .Text = Text
                .TextAlign = TextAlign
                .Multiline = MultiLine
                .Cursor = Cursors.IBeam
                .BackColor = DefaultBackgroundColor
                .ForeColor = TextColor
                .BorderStyle = Windows.Forms.BorderStyle.None
                .Font = Font
                .UseSystemPasswordChar = UseSystemPasswordChar
                .PasswordChar = PasswordChar
            End With
        End Sub
#End Region
#Region "InnerTextBox Events Handler"
        Private Sub InnerTextBoxEnableChanged(sender As Object, e As EventArgs) Handles InnerTextBox.EnabledChanged
            If InnerTextBox.Enabled AndAlso IsEnabled Then
                Cursor = Cursors.IBeam
                InnerTextBox.Cursor = Cursors.IBeam
                InnerTextBox.BackColor = DefaultBackgroundColor
                InnerTextBox.ForeColor = TextColor
            Else
                Cursor = Cursors.Default
                InnerTextBox.Cursor = Cursors.Default
                InnerTextBox.BackColor = DisabledBackgroundColor
                InnerTextBox.ForeColor = DisabledTextColor
            End If
        End Sub
        Private Sub InnerTextBoxGotFocus(sender As Object, e As EventArgs) Handles InnerTextBox.GotFocus
            MouseCurrentState = MouseState.Down
            If EnableAnimations AndAlso IsEnabled Then
                AnimationManager.StartNewAnimation(AnimationDirection.In)
            End If
            Invalidate()
        End Sub
        Private Sub InnerTextBoxLostFocus(sender As Object, e As EventArgs) Handles InnerTextBox.LostFocus
            MouseCurrentState = MouseState.Normal
            If EnableAnimations AndAlso IsEnabled Then
                AnimationManager.StartNewAnimation(AnimationDirection.Out)
            End If
            Invalidate()
        End Sub
        Private Sub InnerTextBoxMouseEnter(sender As Object, e As EventArgs) Handles InnerTextBox.MouseEnter
            MouseCurrentState = MouseState.Hovered
            If EnableAnimations AndAlso IsEnabled Then
                HoverAnimationManager.StartNewAnimation(AnimationDirection.In)
            End If
            Invalidate()
        End Sub
        Private Sub InnerTextBoxMouseLeave(sender As Object, e As EventArgs) Handles InnerTextBox.MouseLeave
            MouseCurrentState = MouseState.Normal
            If EnableAnimations AndAlso IsEnabled Then
                HoverAnimationManager.StartNewAnimation(AnimationDirection.Out)
            End If
            Invalidate()
        End Sub
        Private Sub InnerTextBoxTextChanged(sender As Object, e As EventArgs) Handles InnerTextBox.TextChanged
            MouseCurrentState = MouseState.Down
            RaiseEvent InputTextChanged(Me)
            Invalidate()
        End Sub
        Private Sub InnerTextBoxKeyDown(sender As Object, e As KeyEventArgs) Handles InnerTextBox.KeyDown
            MouseCurrentState = MouseState.Down
            Invalidate()
        End Sub
#End Region
#Region "Animation Handlers"
        Private Sub OnAnimateUpdateClick(Sender As Object)
            Invalidate()
        End Sub
        Private Sub OnAnimateUpdateHover(Sender As Object)
            Invalidate()
        End Sub
        Private Sub HandleFocusedRectangleAnimation(G As Graphics)
            Using FocusedBorderPen As New Pen(FocusedBorderColor, FocusedBorderWidth)
                Dim AnimationWidth As Integer = (Width - 1) * AnimationManager.GetProgress()
                Dim HalfAnimationWidth As Integer = AnimationWidth / 2
                Dim AnimationStart As Integer = (Width - 1) / 2
                If FocusedBorderPen.Width > 0 Then
                    If BorderRadius > 0 Then
                        G.DrawRoundedRectangle(FocusedBorderPen, New Rectangle(AnimationStart - HalfAnimationWidth, 0, AnimationWidth, Height - 1), BorderRadius)
                    Else
                        G.DrawRectangle(FocusedBorderPen, New Rectangle(AnimationStart - HalfAnimationWidth, 0, AnimationWidth, Height - 1))
                    End If
                End If
            End Using
        End Sub
        Private Sub HandleFocusedUnderlinedStyleAnimation(G As Graphics)
            Using FocusedBorderPen As New Pen(FocusedBorderColor, FocusedBorderWidth)
                Dim AnimationWidth As Single = InnerTextBox.Width * AnimationManager.GetProgress()
                Dim HalfAnimationWidth As Single = AnimationWidth / 2
                Dim AnimationStart As Single = InnerTextBox.Location.X + InnerTextBox.Width / 2
                If FocusedBorderPen.Width > 0 Then
                    G.DrawRectangle(FocusedBorderPen, AnimationStart - HalfAnimationWidth, Height - 1, AnimationWidth, FocusedBorderWidth)
                End If
            End Using
        End Sub
        Private Sub HandleHoveredRectangleAnimation(G As Graphics)
            Using HoveredBorderPen As New Pen(Color.FromArgb(HoverAnimationManager.GetProgress() * HoverBorderColor.A, HoverBorderColor.RemoveAlpha()), HoverBorderWidth)
                If HoveredBorderPen.Width > 0 Then
                    Dim Bounds As New Rectangle(0, 0, Width - 1, Height - 1)
                    If BorderRadius > 0 Then
                        G.DrawRoundedRectangle(HoveredBorderPen, Bounds, BorderRadius)
                    Else
                        G.DrawRectangle(HoveredBorderPen, Bounds)
                    End If
                End If
            End Using
        End Sub
        Private Sub HandleHoveredUnderlinedStyleAnimation(G As Graphics)
            Using HoveredBorderPen As New Pen(Color.FromArgb(HoverAnimationManager.GetProgress() * HoverBorderColor.A, HoverBorderColor.RemoveAlpha()), HoverBorderWidth)
                If HoveredBorderPen.Width > 0 Then
                    G.DrawLine(HoveredBorderPen, New Point(InnerTextBox.Location.X, Height - 1), New Point(Width - Padding.Right, Height - 1))
                End If
            End Using
        End Sub
#End Region
#Region "PlaceHolder Handlers"
#End Region
#End Region
#Region "Public Methods"
        Public Sub Undo()
            InnerTextBox.Undo()
        End Sub
        Public Sub Cut()
            InnerTextBox.Cut()
        End Sub
        Public Sub Copy()
            InnerTextBox.Copy()
        End Sub
        Public Sub Paste()
            InnerTextBox.Paste()
        End Sub
        Public Sub Delete()
            InnerTextBox.SelectedText = String.Empty
        End Sub
        Public Sub SelectAll()
            InnerTextBox.SelectAll()
        End Sub
        Public Function CanUndo() As Boolean
            Return InnerTextBox.CanUndo
        End Function
#End Region
#Region "Overrided Methods"
        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            If Not Controls.Contains(InnerTextBox) Then
                Controls.Add(InnerTextBox)
                OnResize(Nothing)
            End If
        End Sub
        Protected Overrides Sub OnResize(e As EventArgs)
            If Not MultiLine Then
                If InnerTextBox.Dock.Equals(DockStyle.Fill) Then
                    InnerTextBox.Dock = DockStyle.None
                End If
                Dim MiddlePointX As Integer = ClientRectangle().Left + Padding.Left
                Dim MiddlePointY As Integer = (Height / 2) - (InnerTextBox.Height / 2)
                InnerTextBox.Size = New Size(Width - Padding.Horizontal, Height - Padding.Vertical)
                InnerTextBox.Location = New Point(MiddlePointX, MiddlePointY)
            Else
                InnerTextBox.Dock = DockStyle.Fill
            End If
            MyBase.OnResize(e)
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim G As Graphics = e.Graphics.ToHighQuality()
            Dim Bounds As New Rectangle(0, 0, Width - 1, Height - 1)
            Dim InputBoxGraphicsPath As New GraphicsPath(FillMode.Winding)
            InputBoxGraphicsPath.StartFigure()
            If BorderRadius > 0 Then
                InputBoxGraphicsPath = GraphicsUtilities.RoundedRectangle(Bounds, BorderRadius)
            Else
                InputBoxGraphicsPath.AddRectangle(Bounds)
            End If
            InputBoxGraphicsPath.CloseFigure()
            If Not IsEnabled Then
                Using DisabledBackgroundBrush As New SolidBrush(DisabledBackgroundColor), DisabledBorderPen As New Pen(DisabledBorderColor, DisabledBorderWidth)
                    G.FillPath(DisabledBackgroundBrush, InputBoxGraphicsPath)
                    If DisabledBorderPen.Width > 0 Then
                        If UnderlinedStyle Then
                            G.DrawLine(DisabledBorderPen, New Point(InnerTextBox.Location.X, Height - 1), New Point(Width - Padding.Right, Height - 1))
                        Else
                            G.DrawPath(DisabledBorderPen, InputBoxGraphicsPath)
                        End If
                    End If
                End Using
            Else
                If Not EnableAnimations Then
                    If InnerTextBox.Focused Then
                        Using FocusedBackgroundBrush As New SolidBrush(FocusedBackgroundColor), FocusedBorderPen As New Pen(FocusedBorderColor, FocusedBorderWidth)
                            G.FillPath(FocusedBackgroundBrush, InputBoxGraphicsPath)
                            InnerTextBox.BackColor = FocusedBackgroundColor
                            InnerTextBox.ForeColor = FocusedTextColor
                            If FocusedBorderPen.Width > 0 Then
                                If UnderlinedStyle Then
                                    G.DrawLine(FocusedBorderPen, New Point(InnerTextBox.Location.X, Height - 1), New Point(Width - Padding.Right, Height - 1))
                                Else
                                    G.DrawPath(FocusedBorderPen, InputBoxGraphicsPath)
                                End If
                            End If
                        End Using
                    ElseIf MouseCurrentState.Equals(MouseState.Hovered) Then
                        Using HoverBackgroundBrush As New SolidBrush(HoverBackgroundColor), HoverBorderPen As New Pen(HoverBorderColor, HoverBorderWidth)
                            G.FillPath(HoverBackgroundBrush, InputBoxGraphicsPath)
                            InnerTextBox.BackColor = HoverBackgroundColor
                            InnerTextBox.ForeColor = HoverTextColor
                            If HoverBorderPen.Width > 0 Then
                                If UnderlinedStyle Then
                                    G.DrawLine(HoverBorderPen, New Point(InnerTextBox.Location.X, Height - 1), New Point(Width - Padding.Right, Height - 1))
                                Else
                                    G.DrawPath(HoverBorderPen, InputBoxGraphicsPath)
                                End If
                            End If
                        End Using
                    Else
                        Using DefaultBackgroundBrush As New SolidBrush(DefaultBackgroundColor), DefaultBorderPen As New Pen(DefaultBorderColor, DefaultBorderWidth)
                            G.FillPath(DefaultBackgroundBrush, InputBoxGraphicsPath)
                            InnerTextBox.BackColor = DefaultBackgroundColor
                            InnerTextBox.ForeColor = TextColor
                            If DefaultBorderPen.Width > 0 Then
                                If UnderlinedStyle Then
                                    G.DrawLine(DefaultBorderPen, New Point(InnerTextBox.Location.X, Height - 1), New Point(Width - Padding.Right, Height - 1))
                                Else
                                    G.DrawPath(DefaultBorderPen, InputBoxGraphicsPath)
                                End If
                            End If
                        End Using
                    End If
                Else
                    'Handle Animations for OnFocused, OnHovered, OnNormal.
                    If InnerTextBox.Focused Then
                        Using FocusedBackgroundBrush As New SolidBrush(FocusedBackgroundColor)
                            G.FillPath(FocusedBackgroundBrush, InputBoxGraphicsPath)
                            InnerTextBox.BackColor = FocusedBackgroundColor
                            InnerTextBox.ForeColor = FocusedTextColor
                            'Draws the animation -> OnFocused.
                            If UnderlinedStyle Then
                                HandleFocusedUnderlinedStyleAnimation(G)
                            Else
                                HandleFocusedRectangleAnimation(G)
                            End If
                        End Using
                    ElseIf MouseCurrentState.Equals(MouseState.Hovered) Then
                        Using HoverBackgroundBrush As New SolidBrush(HoverBackgroundColor), HoverBorderPen As New Pen(HoverBorderColor, HoverBorderWidth)
                            G.FillPath(HoverBackgroundBrush, InputBoxGraphicsPath)
                            InnerTextBox.BackColor = HoverBackgroundColor
                            InnerTextBox.ForeColor = HoverTextColor
                            If UnderlinedStyle Then
                                HandleHoveredUnderlinedStyleAnimation(G)
                            Else
                                HandleHoveredRectangleAnimation(G)
                            End If
                        End Using
                    Else
                        Using DefaultBackgroundBrush As New SolidBrush(DefaultBackgroundColor), DefaultBorderPen As New Pen(DefaultBorderColor, DefaultBorderWidth)
                            G.FillPath(DefaultBackgroundBrush, InputBoxGraphicsPath)
                            InnerTextBox.BackColor = DefaultBackgroundColor
                            InnerTextBox.ForeColor = TextColor
                            If DefaultBorderPen.Width > 0 Then
                                If UnderlinedStyle Then
                                    G.DrawLine(DefaultBorderPen, New Point(InnerTextBox.Location.X, Height - 1), New Point(Width - Padding.Right, Height - 1))
                                Else
                                    G.DrawPath(DefaultBorderPen, InputBoxGraphicsPath)
                                End If
                            End If
                        End Using
                    End If
                End If
            End If
            InputBoxGraphicsPath.Dispose()
        End Sub
#End Region
    End Class
End Namespace