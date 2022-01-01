Imports System.ComponentModel
Imports iRISTheme.Src.Enums
Imports iRISTheme.Src.Extensions
Imports iRISTheme.Src.Helpers
Imports iRISTheme.Src.Interfaces
Imports iRISTheme.Src.Styles.Dark
Imports iRISTheme.Src.Utilities

Namespace Src.Controls
    Public Class IRISVerticalTabControl : Inherits TabControl : Implements IRISControl
#Region "Fields"
        Private _IsEnabled As Boolean
        Private _HeaderTextAlign As StringAlignment
        Private _TextAlign As StringAlignment
        Private _ItemSize As Size
        Private _SurfaceColor As Color
        Private _HeaderFont As Font
        Private _HeaderTextColor As Color
        Private _HeaderBackgroundColor As Color
        Private _HoveredTextColor As Color
        Private _HoveredBackgroundColor As Color
        Private _SelectedTextColor As Color
        Private _SelectedBackgroundColor As Color
        Private _SelectedBorderColor As Color
        Private _SelectedBorderWidth As Integer
        Private _UnSelectedTextColor As Color
        Private _UnSelectedBackgroundColor As Color
        Private _DisabledTextColor
        Private _DisabledBackgroundColor As Color
        Private _DisabledTabBackroundColor As Color
        Private _ImageSize As Size
        Private _ImageAlign As StringAlignment
        Private _ImageOffset As Point
        Private _HeaderTextOffset As Point
        Private _TextOffset As Point
        Private _HeaderImageOffset As Point
        Private _BorderStyle As BorderStyle
        Private _SplitterColor As Color
        Private _SplitterWidth As Integer
        Private MouseLocation As Point
#End Region
#Region "Properties"
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the Enabled property is invalid on IRISVerticalTabControl", True)>
        Public Overloads Property Enabled As Boolean
            Get
                Return MyBase.Enabled
            End Get
            Set(value As Boolean)
                Throw New AccessViolationException("Accessing the Enabled property is invalid on IRISButton")
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets if the button is enabled or disabled.")>
        Public Property IsEnabled As Boolean
            Get
                Return _IsEnabled
            End Get
            Set(value As Boolean)
                _IsEnabled = value
                MyBase.Enabled = value
                Cursor = Cursors.Default
                Invalidate()
            End Set
        End Property
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the Text property is invalid on IRISVerticalTabControl", True)>
        Public Overrides Property Text As String
            Get
                Return MyBase.Text
            End Get
            Set(value As String)
                Throw New AccessViolationException("Accessing the Text property is invalid on IRISVerticalTabControl")
            End Set
        End Property
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the BackColor property is invalid on IRISVerticalTabControl", True)>
        Public Overrides Property BackColor As Color
            Get
                Return MyBase.BackColor
            End Get
            Set(value As Color)
                Throw New AccessViolationException("Accessing the BackColor property is invalid on IRISVerticalTabControl")
            End Set
        End Property
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <Obsolete("Accessing the ForeColor property is invalid on IRISVerticalTabControl", True)>
        Public Overrides Property ForeColor As Color
            Get
                Return MyBase.ForeColor
            End Get
            Set(value As Color)
                Throw New AccessViolationException("Accessing the ForeColor property is invalid on IRISVerticalTabControl")
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the header text alignment of the IRISVerticalTabControl.")>
        Public Property HeaderTextAlign As StringAlignment
            Get
                Return _HeaderTextAlign
            End Get
            Set(value As StringAlignment)
                _HeaderTextAlign = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the text alignment of the IRISVerticalTabControl.")>
        Public Property TextAlign As StringAlignment
            Get
                Return _TextAlign
            End Get
            Set(value As StringAlignment)
                _TextAlign = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the item size of the IRISVerticalTabControl.")>
        Public Overloads Property ItemSize As Size
            Get
                Return _ItemSize
            End Get
            Set(value As Size)
                _ItemSize = value
                MyBase.ItemSize = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the surface color of the IRISVerticalTabControl.")>
        Public Property SurfaceColor As Color
            Get
                Return _SurfaceColor
            End Get
            Set(value As Color)
                _SurfaceColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the header font of the IRISVerticalTabControl.")>
        Public Property HeaderFont As Font
            Get
                Return _HeaderFont
            End Get
            Set(value As Font)
                _HeaderFont = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the header text color of the IRISVerticalTabControl.")>
        Public Property HeaderTextColor As Color
            Get
                Return _HeaderTextColor
            End Get
            Set(value As Color)
                _HeaderTextColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the header background color of the IRISVerticalTabControl.")>
        Public Property HeaderBackgroundColor As Color
            Get
                Return _HeaderBackgroundColor
            End Get
            Set(value As Color)
                _HeaderBackgroundColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the hovered text color of the IRISVerticalTabControl.")>
        Public Property HoveredTextColor As Color
            Get
                Return _HoveredTextColor
            End Get
            Set(value As Color)
                _HoveredTextColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the hovered background color of the IRISVerticalTabControl.")>
        Public Property HoveredBackgroundColor As Color
            Get
                Return _HoveredBackgroundColor
            End Get
            Set(value As Color)
                _HoveredBackgroundColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the selected text color of the IRISVerticalTabControl.")>
        Public Property SelectedTextColor As Color
            Get
                Return _SelectedTextColor
            End Get
            Set(value As Color)
                _SelectedTextColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the header background color of the IRISVerticalTabControl.")>
        Public Property SelectedBackgroundColor As Color
            Get
                Return _SelectedBackgroundColor
            End Get
            Set(value As Color)
                _SelectedBackgroundColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the selected border color of the IRISVerticalTabControl.")>
        Public Property SelectedBorderColor As Color
            Get
                Return _SelectedBorderColor
            End Get
            Set(value As Color)
                _SelectedBorderColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the selected border width of the IRISVerticalTabControl.")>
        Public Property SelectedBorderWidth As Integer
            Get
                Return _SelectedBorderWidth
            End Get
            Set(value As Integer)
                _SelectedBorderWidth = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the unselected text color of the IRISVerticalTabControl.")>
        Public Property UnSelectedTextColor As Color
            Get
                Return _UnSelectedTextColor
            End Get
            Set(value As Color)
                _UnSelectedTextColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the unselected background color of the IRISVerticalTabControl.")>
        Public Property UnSelectedBackgroundColor As Color
            Get
                Return _UnSelectedBackgroundColor
            End Get
            Set(value As Color)
                _UnSelectedBackgroundColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled text color of the IRISVerticalTabControl.")>
        Public Property DisabledTextColor As Color
            Get
                Return _DisabledTextColor
            End Get
            Set(value As Color)
                _DisabledTextColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled background color of the IRISVerticalTabControl.")>
        Public Property DisabledBackgroundColor As Color
            Get
                Return _DisabledBackgroundColor
            End Get
            Set(value As Color)
                _DisabledBackgroundColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the disabled tab background color of the IRISVerticalTabControl.")>
        Public Property DisabledTabBackgroundColor As Color
            Get
                Return _DisabledTabBackroundColor
            End Get
            Set(value As Color)
                _DisabledTabBackroundColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the image size of the IRISVerticalTabControl.")>
        Public Property ImageSize As Size
            Get
                Return _ImageSize
            End Get
            Set(value As Size)
                _ImageSize = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the image alignment of the IRISVerticalTabControl.")>
        Public Property ImageAlign As StringAlignment
            Get
                Return _ImageAlign
            End Get
            Set(value As StringAlignment)
                _ImageAlign = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the image offset of the IRISVerticalTabControl.")>
        Public Property ImageOffset As Point
            Get
                Return _ImageOffset
            End Get
            Set(value As Point)
                _ImageOffset = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the header text offset of the IRISVerticalTabControl.")>
        Public Property HeaderTextOffset As Point
            Get
                Return _HeaderTextOffset
            End Get
            Set(value As Point)
                _HeaderTextOffset = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the text offset of the IRISVerticalTabControl.")>
        Public Property TextOffset As Point
            Get
                Return _TextOffset
            End Get
            Set(value As Point)
                _TextOffset = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the Header image offset of the IRISVerticalTabControl.")>
        Public Property HeaderImageOffset As Point
            Get
                Return _HeaderImageOffset
            End Get
            Set(value As Point)
                _HeaderImageOffset = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the border style of the IRISVerticalTabControl.")>
        Public Property BorderStyle As BorderStyle
            Get
                Return _BorderStyle
            End Get
            Set(value As BorderStyle)
                _BorderStyle = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the splitter color of the IRISVerticalTabControl.")>
        Public Property SplitterColor As Color
            Get
                Return _SplitterColor
            End Get
            Set(value As Color)
                _SplitterColor = value
                Refresh()
            End Set
        End Property
        <Category("IRIS Theme"), Description("Gets or sets the splitter width of the IRISVerticalTabControl.")>
        Public Property SplitterWidth As Integer
            Get
                Return _SplitterWidth
            End Get
            Set(value As Integer)
                _SplitterWidth = value
                Refresh()
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
            SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
            UpdateStyles()
            SizeMode = TabSizeMode.Fixed
            Alignment = TabAlignment.Left
            DrawMode = TabDrawMode.OwnerDrawFixed
            IsEnabled = True
            HeaderTextAlign = StringAlignment.Near
            TextAlign = StringAlignment.Center
            ItemSize = New Size(40, 180)
            HeaderFont = FontUtilities.Bold(11)
            Font = FontUtilities.Regular(9.5)
            SurfaceColor = New DarkStyle().BackgroundColor
            HeaderBackgroundColor = New DarkStyle().BackgroundColor
            HeaderTextColor = New DarkStyle().OnBackgroundColor
            HoveredBackgroundColor = New DarkStyle().PrimaryColor
            HoveredTextColor = New DarkStyle().OnPrimaryColor
            SelectedBackgroundColor = Color.FromArgb(34, 34, 34)
            SelectedTextColor = New DarkStyle().OnPrimaryColor
            SelectedBorderColor = New DarkStyle().PrimaryColor
            SelectedBorderWidth = 1
            UnSelectedBackgroundColor = New DarkStyle().BackgroundColor
            UnSelectedTextColor = New DarkStyle().OnBackgroundColor
            DisabledBackgroundColor = New DarkStyle().DisabledColor
            DisabledTabBackgroundColor = New DarkStyle().DisabledColor
            DisabledTextColor = New DarkStyle().OnDisabledColor
            ImageSize = New Size(16, 16)
            ImageAlign = StringAlignment.Near
            ImageOffset = New Point(0, 0)
            HeaderTextOffset = New Point(0, 0)
            TextOffset = New Point(0, 0)
            HeaderImageOffset = New Point(0, 0)
            BorderStyle = BorderStyle.Left
            SplitterColor = New DarkStyle().PrimaryColor
            SplitterWidth = 1
            MouseLocation = New Point(-1, -1)
        End Sub
#End Region
#Region "TabControl Methods"
        Private Function IsMouseOverTab(CursorLocation As Point) As Boolean
            For i As Integer = 0 To TabCount - 1
                Dim TabPage As TabPage = TabPages.Item(i)
                If TabPage.Tag Is Nothing AndAlso String.IsNullOrEmpty(CStr(TabPage.Tag)) Then
                    If GetTabRect(i).Contains(CursorLocation) Then
                        Return True
                    End If
                End If
            Next
            Return False
        End Function
        Private Function GetBorderLocation(TabBounds As Rectangle) As Point()
            Select Case BorderStyle
                Case BorderStyle.Left
                    Return New Point() {New Point(TabBounds.Left, TabBounds.Top), New Point(TabBounds.Left, TabBounds.Bottom)}
                Case BorderStyle.Top
                    Return New Point() {New Point(TabBounds.Left, TabBounds.Top), New Point(TabBounds.Right, TabBounds.Top)}
                Case BorderStyle.Right
                    Return New Point() {New Point(TabBounds.Right, TabBounds.Top), New Point(TabBounds.Right, TabBounds.Bottom)}
                Case BorderStyle.Bottom
                    Return New Point() {New Point(TabBounds.Left, TabBounds.Bottom), New Point(TabBounds.Right, TabBounds.Bottom)}
                Case BorderStyle.Fill
                    Return New Point() {New Point(TabBounds.Left, TabBounds.Top), New Point(TabBounds.Right, TabBounds.Top), New Point(TabBounds.Right, TabBounds.Bottom), New Point(TabBounds.Left, TabBounds.Bottom), New Point(TabBounds.Left, TabBounds.Top)}
                Case Else
                    Return New Point() {New Point(-1, -1), New Point(-1, -1)}
            End Select
        End Function
#End Region
#End Region
#Region "Overrided Methods"
        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim G As Graphics = e.Graphics.ToHighQuality()

            If IsEnabled Then
                'Clear the background of the control.
                G.Clear(SurfaceColor)
                For i As Integer = 0 To TabCount - 1
                    Dim TabBounds As Rectangle = New Rectangle(GetTabRect(i).X - 2, GetTabRect(i).Y + 1, GetTabRect(i).Width + 4, GetTabRect(i).Height)
                    Dim TabPage As TabPage = TabPages.Item(i)
                    'If the tag is not null or empty and contains a string then
                    'it is considered as a header tab and we will extract the header
                    'value from the tag, otherwise it is considered as a normal tab
                    'either selected or hovered or default.
                    If TabPage.Tag IsNot Nothing AndAlso CStr(TabPage.Tag).Equals("Header") Then
                        Using HeaderBackgroundBrush As New SolidBrush(HeaderBackgroundColor)
                            Using HeaderTextBrush As New SolidBrush(HeaderTextColor)
                                G.FillRectangle(HeaderBackgroundBrush, TabBounds)
                                G.DrawText(HeaderFont, TabPage.Text, HeaderTextBrush, HeaderTextAlign, HeaderTextOffset, TabBounds, GraphicsHelper.SetVerticalPosition(StringAlignment.Center))
                            End Using
                        End Using
                        'Check if the imagelist is not empty and contains some images.
                        'Check if the tab item image index is in the range of the image list.
                        If ImageList IsNot Nothing AndAlso ImageList.Images.Count > 0 Then
                            If TabPage.ImageIndex >= 0 AndAlso TabPage.ImageIndex <= ImageList.Images.Count - 1 Then
                                G.DrawImage(ImageList.Images(TabPage.ImageIndex), ImageSize, ImageAlign, HeaderImageOffset, TabBounds)
                            End If
                        End If
                    ElseIf TabPage.Tag IsNot Nothing AndAlso CStr(TabPage.Tag).Equals("Splitter") Then
                        Using SplitterPen As New Pen(SplitterColor, SplitterWidth)
                            TabBounds.Height /= 2
                            G.DrawLine(SplitterPen, New Point(TabBounds.Left + 10, TabBounds.Bottom), New Point(TabBounds.Right - 10, TabBounds.Bottom))
                        End Using
                    Else
                        If SelectedIndex = i Then
                            Using SelectedBackgroundBrush As New SolidBrush(SelectedBackgroundColor)
                                Using SelectedTextBrush As New SolidBrush(SelectedTextColor)
                                    G.FillRectangle(SelectedBackgroundBrush, TabBounds)
                                    G.DrawText(Font, TabPage.Text, SelectedTextBrush, TextAlign, TextOffset, TabBounds, GraphicsHelper.SetVerticalPosition(StringAlignment.Center))
                                End Using
                            End Using
                            Using SelectedBorderPen As New Pen(SelectedBorderColor, SelectedBorderWidth)
                                Dim Points As Point() = GetBorderLocation(GetTabRect(i))
                                G.DrawLines(SelectedBorderPen, Points)
                            End Using
                        ElseIf TabBounds.Contains(MouseLocation) Then
                            Using HoveredBackgroundBrush As New SolidBrush(HoveredBackgroundColor)
                                Using HoveredTextBrush As New SolidBrush(HoveredTextColor)
                                    G.FillRectangle(HoveredBackgroundBrush, TabBounds)
                                    G.DrawText(Font, TabPage.Text, HoveredTextBrush, TextAlign, TextOffset, TabBounds, GraphicsHelper.SetVerticalPosition(StringAlignment.Center))
                                End Using
                            End Using
                        Else
                            Using DefaultBackgroundBrush As New SolidBrush(UnSelectedBackgroundColor)
                                Using DefaultTextBrush As New SolidBrush(UnSelectedTextColor)
                                    G.FillRectangle(DefaultBackgroundBrush, TabBounds)
                                    G.DrawText(Font, TabPage.Text, DefaultTextBrush, TextAlign, TextOffset, TabBounds, GraphicsHelper.SetVerticalPosition(StringAlignment.Center))
                                End Using
                            End Using
                        End If
                        'Check if the imagelist is not empty and contains some images.
                        'Check if the tab item image index is in the range of the image list.
                        If ImageList IsNot Nothing AndAlso ImageList.Images.Count > 0 Then
                            If TabPage.ImageIndex >= 0 AndAlso TabPage.ImageIndex <= ImageList.Images.Count - 1 Then
                                G.DrawImage(ImageList.Images(TabPage.ImageIndex), ImageSize, ImageAlign, ImageOffset, TabBounds)
                            End If
                        End If
                    End If
                Next
            Else
                G.Clear(DisabledBackgroundColor)
                For i As Integer = 0 To TabCount - 1
                    Dim TabBounds As Rectangle = New Rectangle(GetTabRect(i).X - 2, GetTabRect(i).Y + 1, GetTabRect(i).Width + 4, GetTabRect(i).Height)
                    Dim TabPage As TabPage = TabPages.Item(i)
                    'If the tag is not null or empty and contains a string then
                    'it is considered as a header tab and we will extract the header
                    'value from the tag, otherwise it is considered as a normal tab
                    'either selected or hovered or default.
                    If TabPage.Tag IsNot Nothing AndAlso CStr(TabPage.Tag).Equals("Header") Then
                        Using DisabledHeaderBackgroundBrush As New SolidBrush(DisabledBackgroundColor)
                            Using DisabledHeaderTextBrush As New SolidBrush(DisabledTextColor)
                                G.FillRectangle(DisabledHeaderBackgroundBrush, TabBounds)
                                G.DrawText(HeaderFont, TabPage.Text, DisabledHeaderTextBrush, HeaderTextAlign, HeaderTextOffset, TabBounds, GraphicsHelper.SetVerticalPosition(StringAlignment.Center))
                            End Using
                        End Using
                    ElseIf TabPage.Tag IsNot Nothing AndAlso CStr(TabPage.Tag).Equals("Splitter") Then
                        Using SplitterPen As New Pen(SplitterColor, SplitterWidth)
                            TabBounds.Height /= 2
                            G.DrawLine(SplitterPen, New Point(TabBounds.Left + 10, TabBounds.Bottom), New Point(TabBounds.Right - 10, TabBounds.Bottom))
                        End Using
                    Else
                        Using DisabledBackgroundBrush As New SolidBrush(DisabledTabBackgroundColor)
                            Using DisabledTextBrush As New SolidBrush(DisabledTextColor)
                                G.FillRectangle(DisabledBackgroundBrush, TabBounds)
                                G.DrawText(Font, TabPage.Text, DisabledTextBrush, TextAlign, TextOffset, TabBounds, GraphicsHelper.SetVerticalPosition(StringAlignment.Center))
                            End Using
                        End Using
                    End If
                    'Check if the imagelist is not empty and contains some images.
                    'Check if the tab item image index is in the range of the image list.
                    If ImageList IsNot Nothing AndAlso ImageList.Images.Count > 0 Then
                        If TabPage.ImageIndex >= 0 AndAlso TabPage.ImageIndex <= ImageList.Images.Count - 1 Then
                            G.DrawImageWithColor(DisabledBackgroundColor, ImageList.Images(TabPage.ImageIndex), ImageSize, ImageAlign, ImageOffset, TabBounds)
                        End If
                    End If
                Next
            End If
        End Sub
        Protected Overrides Sub WndProc(ByRef m As Message)
            User32Utilities.SmoothCursor(m)
            MyBase.WndProc(m)
        End Sub
        Protected Overrides Sub OnSelecting(e As TabControlCancelEventArgs)
            MyBase.OnSelecting(e)
            If IsEnabled Then
                Dim CurrentIndex As Integer = e.TabPageIndex
                If e.TabPage.Tag IsNot Nothing Then
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        End Sub
        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            If IsEnabled Then
                MouseLocation = New Point(-1, -1)
                Cursor = Cursors.Default
                Invalidate()
            End If
        End Sub
        Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
            MyBase.OnMouseMove(e)
            If IsEnabled Then
                MouseLocation = e.Location
                If IsMouseOverTab(e.Location) Then
                    Cursor = Cursors.Hand
                Else
                    Cursor = Cursors.Default
                End If
                Invalidate()
            End If
        End Sub
#End Region
    End Class
End Namespace