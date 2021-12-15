Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports iRISTheme.Src.Animations
Imports iRISTheme.Src.Components.Designers
Imports iRISTheme.Src.Enums
Imports iRISTheme.Src.Extensions
Imports iRISTheme.Src.Helpers
Imports iRISTheme.Src.Interfaces
Imports iRISTheme.Src.Styles.Dark
Imports iRISTheme.Src.Utilities

Namespace Src.Controls
    <ToolboxItem(True)>
    <ToolboxBitmap(GetType(ComponentBitmap), "ButtonBitmap.bmp")>
    <Designer(GetType(IRISButtonDesigner))>
    <DefaultEvent("Click")>
    <DefaultProperty("Text")>
    Public Class IRISButton : Inherits Control : Implements IRISControl
#Region "Fields"
        Private _Text As String
        Private _TextAlign As ContentAlignment
        Private _TextColor As Color
        Private _BorderColor As Color
        Private _BorderRadius As Integer
        Private _BorderWidth As Single
        Private _IsEnabled As Boolean
        Private _Image As Image
        Private _ImageAlign As ContentAlignment
        Private _ImageOffset As Point
        Private _BackgroundColor As Color
        Private _HoverColor As Color
        Private _HoverTextColor As Color
        Private _ClickColor As Color
        Private _ClickTextColor As Color
        Private _DisabledBackgroundColor As Color
        Private _DisabledTextColor As Color
        Private _DisabledBorderColor As Color
        Private _DisabledBorderWidth As Integer
        Private _EnableAnimations As Boolean
        Private MouseCurrentState As MouseState
        Private AnimationManager As AnimationManager
        Private HoverAnimationManager As AnimationManager
#End Region

#Region "Interface"
        '<Category("IRIS Theme"), Description("Gets or sets the theme manager that is associated with the button.")>
        '<RefreshProperties(RefreshProperties.All)>
        '<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        'Public Property IRISThemeManager As IRISThemeManager Implements IRISControl.IRISThemeManager
        '    Get
        '        Return _ThemeManager
        '    End Get
        '    Set(value As IRISThemeManager)
        '        FireChanging()
        '        _ThemeManager = value
        '        Invalidate()
        '        FireChanged()
        '    End Set
        'End Property
#End Region

#Region "Properties"
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the BackColor property is invalid on IRISButton", True)>
        Public Overrides Property BackColor As Color
            Get
                Return MyBase.BackColor
            End Get
            Set(value As Color)
                Throw New AccessViolationException("Accessing the BackColor property is invalid on IRISButton")
            End Set
        End Property
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the Enabled property is invalid on IRISButton", True)>
        Public Overloads Property Enabled As Boolean
            Get
                Return MyBase.Enabled
            End Get
            Set(value As Boolean)
                Throw New AccessViolationException("Accessing the Enabled property is invalid on IRISButton")
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
        <Category("IRIS Theme"), Description("Gets or sets the text of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Overrides Property Text As String
            Get
                Return _Text
            End Get
            Set(value As String)
                _Text = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the text-alignment of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property TextAlign As ContentAlignment
            Get
                Return _TextAlign
            End Get
            Set(value As ContentAlignment)
                _TextAlign = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the text color of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property TextColor As Color
            Get
                Return _TextColor
            End Get
            Set(value As Color)
                _TextColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the border color of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property BorderColor As Color
            Get
                Return _BorderColor
            End Get
            Set(value As Color)
                _BorderColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the border radius of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property BorderRadius As Integer
            Get
                Return _BorderRadius
            End Get
            Set(value As Integer)
                _BorderRadius = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the border size of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property BorderWidth As Single
            Get
                Return _BorderWidth
            End Get
            Set(value As Single)
                _BorderWidth = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the border size of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property Image As Image
            Get
                Return _Image
            End Get
            Set(value As Image)
                If ValidateImage(value) Then
                    _Image = value
                    Invalidate()
                Else
                    _Image = Nothing
                End If
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the Image Alignment of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property ImageAlign As ContentAlignment
            Get
                Return _ImageAlign
            End Get
            Set(value As ContentAlignment)
                _ImageAlign = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the Image Offset of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property ImageOffset As Point
            Get
                Return _ImageOffset
            End Get
            Set(value As Point)
                _ImageOffset = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the background color of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property BackgroundColor As Color
            Get
                Return _BackgroundColor
            End Get
            Set(value As Color)
                _BackgroundColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the hover color of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property HoverColor As Color
            Get
                Return _HoverColor
            End Get
            Set(value As Color)
                _HoverColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the hover text color of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property HoverTextColor As Color
            Get
                Return _HoverTextColor
            End Get
            Set(value As Color)
                _HoverTextColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the click color of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property ClickColor As Color
            Get
                Return _ClickColor
            End Get
            Set(value As Color)
                _ClickColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the click text color of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property ClickTextColor As Color
            Get
                Return _ClickTextColor
            End Get
            Set(value As Color)
                _ClickTextColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled background color of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property DisabledBackgroundColor As Color
            Get
                Return _DisabledBackgroundColor
            End Get
            Set(value As Color)
                _DisabledBackgroundColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled text color of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property DisabledTextColor As Color
            Get
                Return _DisabledTextColor
            End Get
            Set(value As Color)
                _DisabledTextColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled border color of the InputBox.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property DisabledBorderColor As Color
            Get
                Return _DisabledBorderColor
            End Get
            Set(value As Color)
                _DisabledBorderColor = value
                Invalidate()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled border width of the button.")>
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
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
        <RefreshProperties(RefreshProperties.All)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property EnableAnimations As Boolean
            Get
                Return _EnableAnimations
            End Get
            Set(value As Boolean)
                _EnableAnimations = value
                Invalidate()
            End Set
        End Property
#End Region

#Region "Constructors"
        Public Sub New()
            Initialize()
        End Sub
#End Region

#Region "Private Methods"
#Region "Initialization"
        Private Sub Initialize()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
            UpdateStyles()
            IsEnabled = True
            Text = "IRIS Button"
            TextAlign = ContentAlignment.MiddleCenter
            ImageAlign = ContentAlignment.MiddleLeft
            TextColor = New DarkButtonStyle().OnNormalColor
            BorderColor = New DarkButtonStyle().NormalBorderColor
            BorderRadius = 30
            BorderWidth = 1
            BackgroundColor = New DarkButtonStyle().NormalColor
            HoverColor = New DarkButtonStyle().HoveredColor
            ClickColor = New DarkButtonStyle().PressedColor
            DisabledBackgroundColor = New DarkButtonStyle().DisabledColor
            DisabledTextColor = New DarkButtonStyle().OnDisabledColor
            DisabledBorderColor = New DarkButtonStyle().DisabledBorderColor
            DisabledBorderWidth = 1
            EnableAnimations = True
            MouseCurrentState = MouseState.Normal
            AnimationManager = New AnimationManager(False) With
            {
                .AnimationType = AnimationType.EaseOut,
                .Increment = 0.03
            }
            HoverAnimationManager = New AnimationManager(True) With
            {
                .AnimationType = AnimationType.Linear,
                .Increment = 0.07
            }
            AddHandler AnimationManager.OnAnimationProgress, AddressOf OnAnimateUpdateClick
            AddHandler HoverAnimationManager.OnAnimationProgress, AddressOf OnAnimateUpdateHover
        End Sub
#End Region
#Region "Animation Handlers"
        Private Sub OnAnimateUpdateClick(Sender As Object)
            Invalidate()
        End Sub
        Private Sub OnAnimateUpdateHover(Sender As Object)
            Invalidate()
        End Sub
        Private Function HandleClickAnimation(G As Graphics) As Bitmap
            Dim Bitmap As Bitmap = If(G Is Nothing, New Bitmap(Width, Height), Nothing)
            Dim Graphics As Graphics = If(G, Graphics.FromImage(Bitmap)).ToHighQuality()
            For i As Integer = 0 To AnimationManager.GetAnimationCount() - 1
                Dim AnimationValue = AnimationManager.GetProgress(i)
                Dim AnimationSource = AnimationManager.GetSource(i)
                Using ClickedBackgroundBrush As Brush = New SolidBrush(Color.FromArgb(101 - (AnimationValue * 100), ClickColor))
                    Dim RippleSize = CInt(AnimationValue * Width * 2)
                    Graphics.FillEllipse(ClickedBackgroundBrush, New Rectangle(AnimationSource.X - RippleSize / 2, AnimationSource.Y - RippleSize / 2, RippleSize, RippleSize))
                End Using
            Next
            Return Bitmap
        End Function
#End Region
#Region "Validations"
        Private Function ValidateImage(Img As Image) As Boolean
            Dim SmallSize As New Size(16, 16)
            Dim LargeSize As New Size(32, 32)
            If Img IsNot Nothing Then
                If Img.Size.Width < SmallSize.Width AndAlso Img.Size.Height < SmallSize.Height Then
                    Throw New Exception("Image should be greater or equal than 16x16 pixel.")
                ElseIf Img.Size.Width > LargeSize.Width AndAlso Img.Size.Height > LargeSize.Height Then
                    Throw New Exception("Image should be below or equal than 32x32 pixel.")
                Else
                    Return True
                End If
            End If
            Return False
        End Function
#End Region
#End Region

#Region "Overrided Methods"
        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim G As Graphics = e.Graphics.ToHighQuality()
            Dim TextAlignment As StringFormat = GraphicsHelper.GetTextPosition(TextAlign)
            Dim ButtonBounds As Rectangle = New Rectangle(0, 0, Width - 1, Height - 1)
            Dim ButtonGraphicsPath As New GraphicsPath(FillMode.Winding)
            ButtonGraphicsPath.StartFigure()
            If BorderRadius > 0 Then
                ButtonGraphicsPath = GraphicsUtilities.RoundedRectangle(ButtonBounds, BorderRadius)
            Else
                ButtonGraphicsPath.AddRectangle(ButtonBounds)
            End If
            ButtonGraphicsPath.CloseFigure()
            If IsEnabled Then
                Using BackgroundBrush As Brush = New SolidBrush(BackgroundColor), BorderPen As New Pen(BorderColor, BorderWidth)
                    'Draws the backgroumd
                    G.FillPath(BackgroundBrush, ButtonGraphicsPath)
                    'Draws the border if the border width greater than zero.
                    If BorderPen.Width > 0 Then
                        G.DrawPath(BorderPen, ButtonGraphicsPath)
                    End If
                    'Applies Ripple Effect on Clicking and Linear Effects on hovering
                    If EnableAnimations Then
                        'Linear Animation on hovering.
                        Using HoveredBackgroundBrush As Brush = New SolidBrush(Color.FromArgb(HoverAnimationManager.GetProgress() * HoverColor.A, HoverColor.RemoveAlpha()))
                            'Draws the hovered backgroumd
                            G.FillPath(HoveredBackgroundBrush, ButtonGraphicsPath)
                            'Draws the border if the border width greater than zero.
                            If BorderPen.Width > 0 Then
                                G.DrawPath(BorderPen, ButtonGraphicsPath)
                            End If
                        End Using
                        'Draws the text with a given text color
                        Using FontBrush As Brush = New SolidBrush(HoverTextColor)
                            G.DrawString(Text, Font, FontBrush, ButtonBounds, TextAlignment)
                        End Using
                        'Ripple Animation on clicking.
                        If AnimationManager.IsAnimating() Then
                            'Draws the ripple animation.
                            If BorderRadius > 0 Then
                                G.FillPath(New TextureBrush(HandleClickAnimation(Nothing)), ButtonGraphicsPath)
                            Else
                                HandleClickAnimation(G)
                            End If
                            'Draws the text with a given text color
                            Using FontBrush As Brush = New SolidBrush(ClickTextColor)
                                G.DrawString(Text, Font, FontBrush, ButtonBounds, TextAlignment)
                            End Using
                        End If
                    Else
                        If MouseCurrentState.Equals(MouseState.Hovered) OrElse MouseCurrentState.Equals(MouseState.Up) Then
                            Using HoveredBackgroundBrush As Brush = New SolidBrush(HoverColor)
                                'Draws the hovered backgroumd
                                G.FillPath(HoveredBackgroundBrush, ButtonGraphicsPath)
                                'Draws the border if the border width greater than zero.
                                If BorderPen.Width > 0 Then
                                    G.DrawPath(BorderPen, ButtonGraphicsPath)
                                End If
                            End Using
                            'Draws the text with a given text color
                            Using FontBrush As Brush = New SolidBrush(HoverTextColor)
                                G.DrawString(Text, Font, FontBrush, ButtonBounds, TextAlignment)
                            End Using
                        ElseIf MouseCurrentState.Equals(MouseState.Down) Then
                            Using ClickedBackgroundBrush As Brush = New SolidBrush(ClickColor)
                                'Draws the hovered backgroumd
                                G.FillPath(ClickedBackgroundBrush, ButtonGraphicsPath)
                                'Draws the border if the border width greater than zero.
                                If BorderPen.Width > 0 Then
                                    G.DrawPath(BorderPen, ButtonGraphicsPath)
                                End If
                            End Using
                            'Draws the text with a given text color
                            Using FontBrush As Brush = New SolidBrush(ClickTextColor)
                                G.DrawString(Text, Font, FontBrush, ButtonBounds, TextAlignment)
                            End Using
                        End If
                    End If
                    If MouseCurrentState.Equals(MouseState.Normal) Then
                        'Draws the text with a given text color
                        Using FontBrush As Brush = New SolidBrush(TextColor)
                            G.DrawString(Text, Font, FontBrush, ButtonBounds, TextAlignment)
                        End Using
                    End If
                    'Draws the image.
                    If Image IsNot Nothing Then
                        G.DrawImage(Image, ImageAlign, ImageOffset, Size)
                    End If
                End Using
            Else
                Using DisabledBackgroundBrush As New SolidBrush(DisabledBackgroundColor), DisabledBorderPen As New Pen(DisabledBorderColor, DisabledBorderWidth)
                    G.FillPath(DisabledBackgroundBrush, ButtonGraphicsPath)
                    If DisabledBorderPen.Width > 0 Then
                        G.DrawPath(DisabledBorderPen, ButtonGraphicsPath)
                    End If
                End Using
                'Draws the text with a given text color
                Using FontBrush As Brush = New SolidBrush(DisabledTextColor)
                    G.DrawString(Text, Font, FontBrush, ButtonBounds, TextAlignment)
                End Using
            End If
            ButtonGraphicsPath.Dispose()
        End Sub
        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            If IsEnabled Then
                Cursor = Cursors.Hand
                If EnableAnimations Then
                    HoverAnimationManager.StartNewAnimation(AnimationDirection.In)
                End If
            Else
                Cursor = Cursors.Default
            End If
            MouseCurrentState = MouseState.Hovered
            Invalidate()
        End Sub
        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            Cursor = Cursors.Default
            If IsEnabled Then
                If EnableAnimations Then
                    HoverAnimationManager.StartNewAnimation(AnimationDirection.Out)
                End If
            End If
            MouseCurrentState = MouseState.Normal
            Invalidate()
        End Sub
        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            If IsEnabled Then
                Cursor = Cursors.Hand
                If EnableAnimations Then
                    AnimationManager.StartNewAnimation(AnimationDirection.In, e.Location)
                End If
            Else
                Cursor = Cursors.Default
            End If
            MouseCurrentState = MouseState.Down
            Invalidate()
        End Sub
        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            If IsEnabled Then
                Cursor = Cursors.Hand
            Else
                Cursor = Cursors.Default
            End If
            Invalidate()
            MouseCurrentState = MouseState.Up
        End Sub
#End Region
    End Class
End Namespace