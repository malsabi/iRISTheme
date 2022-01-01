<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.TabControlImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.IrisVerticalTabControl1 = New iRISTheme.Src.Controls.IRISVerticalTabControl()
        Me.UIHeaderabPage = New System.Windows.Forms.TabPage()
        Me.ButtonsTabPage = New System.Windows.Forms.TabPage()
        Me.IrisButton25 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton24 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton23 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton22 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton21 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton11 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton12 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton13 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton14 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton15 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton16 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton17 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton18 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton19 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton20 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton6 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton7 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton8 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton9 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton10 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton5 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton4 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton3 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton2 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisButton1 = New iRISTheme.Src.Controls.IRISButton()
        Me.InputTabPage = New System.Windows.Forms.TabPage()
        Me.IrisInputBox2 = New iRISTheme.Src.Controls.IRISInputBox()
        Me.InputBoxContextMenu = New iRISTheme.Src.Controls.IRISInputBoxContextMenuStrip()
        Me.IrisInputBox1 = New iRISTheme.Src.Controls.IRISInputBox()
        Me.CheckBaseTabPage = New System.Windows.Forms.TabPage()
        Me.IrisCheckBox2 = New iRISTheme.Src.Controls.IRISCheckBox()
        Me.IrisCheckBox1 = New iRISTheme.Src.Controls.IRISCheckBox()
        Me.SplitterTabPage = New System.Windows.Forms.TabPage()
        Me.ComHeaderTabPage = New System.Windows.Forms.TabPage()
        Me.ThemeManagerTabPage = New System.Windows.Forms.TabPage()
        Me.IrisVerticalTabControl1.SuspendLayout()
        Me.ButtonsTabPage.SuspendLayout()
        Me.InputTabPage.SuspendLayout()
        Me.CheckBaseTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlImageList
        '
        Me.TabControlImageList.ImageStream = CType(resources.GetObject("TabControlImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TabControlImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TabControlImageList.Images.SetKeyName(0, "ThemeManagerBitmap.bmp")
        '
        'IrisVerticalTabControl1
        '
        Me.IrisVerticalTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.IrisVerticalTabControl1.BorderStyle = iRISTheme.Src.Enums.BorderStyle.Left
        Me.IrisVerticalTabControl1.Controls.Add(Me.UIHeaderabPage)
        Me.IrisVerticalTabControl1.Controls.Add(Me.ButtonsTabPage)
        Me.IrisVerticalTabControl1.Controls.Add(Me.InputTabPage)
        Me.IrisVerticalTabControl1.Controls.Add(Me.CheckBaseTabPage)
        Me.IrisVerticalTabControl1.Controls.Add(Me.SplitterTabPage)
        Me.IrisVerticalTabControl1.Controls.Add(Me.ComHeaderTabPage)
        Me.IrisVerticalTabControl1.Controls.Add(Me.ThemeManagerTabPage)
        Me.IrisVerticalTabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisVerticalTabControl1.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisVerticalTabControl1.DisabledTabBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisVerticalTabControl1.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisVerticalTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IrisVerticalTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.IrisVerticalTabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IrisVerticalTabControl1.HeaderBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisVerticalTabControl1.HeaderFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IrisVerticalTabControl1.HeaderImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisVerticalTabControl1.HeaderTextAlign = System.Drawing.StringAlignment.Near
        Me.IrisVerticalTabControl1.HeaderTextColor = System.Drawing.Color.Gray
        Me.IrisVerticalTabControl1.HeaderTextOffset = New System.Drawing.Point(40, 0)
        Me.IrisVerticalTabControl1.HoveredBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.IrisVerticalTabControl1.HoveredTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisVerticalTabControl1.ImageAlign = System.Drawing.StringAlignment.Near
        Me.IrisVerticalTabControl1.ImageList = Me.TabControlImageList
        Me.IrisVerticalTabControl1.ImageOffset = New System.Drawing.Point(40, 0)
        Me.IrisVerticalTabControl1.ImageSize = New System.Drawing.Size(16, 16)
        Me.IrisVerticalTabControl1.IsEnabled = True
        Me.IrisVerticalTabControl1.ItemSize = New System.Drawing.Size(40, 220)
        Me.IrisVerticalTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.IrisVerticalTabControl1.Multiline = True
        Me.IrisVerticalTabControl1.Name = "IrisVerticalTabControl1"
        Me.IrisVerticalTabControl1.SelectedBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IrisVerticalTabControl1.SelectedBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisVerticalTabControl1.SelectedBorderWidth = 3
        Me.IrisVerticalTabControl1.SelectedIndex = 0
        Me.IrisVerticalTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisVerticalTabControl1.Size = New System.Drawing.Size(1027, 527)
        Me.IrisVerticalTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.IrisVerticalTabControl1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisVerticalTabControl1.SplitterWidth = 1
        Me.IrisVerticalTabControl1.SurfaceColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisVerticalTabControl1.TabIndex = 10
        Me.IrisVerticalTabControl1.TextAlign = System.Drawing.StringAlignment.Near
        Me.IrisVerticalTabControl1.TextOffset = New System.Drawing.Point(60, 0)
        Me.IrisVerticalTabControl1.UnSelectedBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisVerticalTabControl1.UnSelectedTextColor = System.Drawing.Color.Gray
        '
        'UIHeaderabPage
        '
        Me.UIHeaderabPage.Location = New System.Drawing.Point(224, 4)
        Me.UIHeaderabPage.Name = "UIHeaderabPage"
        Me.UIHeaderabPage.Size = New System.Drawing.Size(799, 519)
        Me.UIHeaderabPage.TabIndex = 1
        Me.UIHeaderabPage.Tag = "Header"
        Me.UIHeaderabPage.Text = "UI CONTROLS"
        Me.UIHeaderabPage.UseVisualStyleBackColor = True
        '
        'ButtonsTabPage
        '
        Me.ButtonsTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton25)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton24)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton23)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton22)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton21)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton11)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton12)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton13)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton14)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton15)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton16)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton17)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton18)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton19)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton20)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton6)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton7)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton8)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton9)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton10)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton5)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton4)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton3)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton2)
        Me.ButtonsTabPage.Controls.Add(Me.IrisButton1)
        Me.ButtonsTabPage.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonsTabPage.ImageIndex = 0
        Me.ButtonsTabPage.Location = New System.Drawing.Point(224, 4)
        Me.ButtonsTabPage.Name = "ButtonsTabPage"
        Me.ButtonsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ButtonsTabPage.Size = New System.Drawing.Size(799, 519)
        Me.ButtonsTabPage.TabIndex = 0
        Me.ButtonsTabPage.Text = "BUTTONS"
        '
        'IrisButton25
        '
        Me.IrisButton25.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.IrisButton25.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton25.BorderRadius = 30
        Me.IrisButton25.BorderWidth = 0!
        Me.IrisButton25.ClickColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.IrisButton25.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton25.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton25.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton25.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton25.DisabledBorderWidth = 1
        Me.IrisButton25.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton25.EnableAnimations = True
        Me.IrisButton25.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton25.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton25.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton25.Image = CType(resources.GetObject("IrisButton25.Image"), System.Drawing.Image)
        Me.IrisButton25.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton25.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton25.IsEnabled = True
        Me.IrisButton25.Location = New System.Drawing.Point(644, 359)
        Me.IrisButton25.Name = "IrisButton25"
        Me.IrisButton25.Size = New System.Drawing.Size(140, 125)
        Me.IrisButton25.StretchImage = False
        Me.IrisButton25.TabIndex = 32
        Me.IrisButton25.Text = "Home"
        Me.IrisButton25.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IrisButton25.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton25.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton24
        '
        Me.IrisButton24.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.IrisButton24.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton24.BorderRadius = 30
        Me.IrisButton24.BorderWidth = 0!
        Me.IrisButton24.ClickColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IrisButton24.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton24.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton24.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton24.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton24.DisabledBorderWidth = 1
        Me.IrisButton24.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton24.EnableAnimations = True
        Me.IrisButton24.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton24.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton24.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton24.Image = CType(resources.GetObject("IrisButton24.Image"), System.Drawing.Image)
        Me.IrisButton24.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton24.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton24.IsEnabled = True
        Me.IrisButton24.Location = New System.Drawing.Point(484, 359)
        Me.IrisButton24.Name = "IrisButton24"
        Me.IrisButton24.Size = New System.Drawing.Size(140, 125)
        Me.IrisButton24.StretchImage = False
        Me.IrisButton24.TabIndex = 31
        Me.IrisButton24.Text = "Alarm"
        Me.IrisButton24.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IrisButton24.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton24.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton23
        '
        Me.IrisButton23.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.IrisButton23.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton23.BorderRadius = 30
        Me.IrisButton23.BorderWidth = 0!
        Me.IrisButton23.ClickColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.IrisButton23.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton23.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton23.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton23.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton23.DisabledBorderWidth = 1
        Me.IrisButton23.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton23.EnableAnimations = True
        Me.IrisButton23.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton23.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton23.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton23.Image = CType(resources.GetObject("IrisButton23.Image"), System.Drawing.Image)
        Me.IrisButton23.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton23.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton23.IsEnabled = True
        Me.IrisButton23.Location = New System.Drawing.Point(327, 359)
        Me.IrisButton23.Name = "IrisButton23"
        Me.IrisButton23.Size = New System.Drawing.Size(140, 125)
        Me.IrisButton23.StretchImage = False
        Me.IrisButton23.TabIndex = 30
        Me.IrisButton23.Text = "Warning"
        Me.IrisButton23.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IrisButton23.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton23.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton22
        '
        Me.IrisButton22.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IrisButton22.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton22.BorderRadius = 30
        Me.IrisButton22.BorderWidth = 0!
        Me.IrisButton22.ClickColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.IrisButton22.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton22.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton22.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton22.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton22.DisabledBorderWidth = 1
        Me.IrisButton22.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton22.EnableAnimations = True
        Me.IrisButton22.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton22.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton22.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton22.Image = CType(resources.GetObject("IrisButton22.Image"), System.Drawing.Image)
        Me.IrisButton22.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton22.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton22.IsEnabled = True
        Me.IrisButton22.Location = New System.Drawing.Point(171, 359)
        Me.IrisButton22.Name = "IrisButton22"
        Me.IrisButton22.Size = New System.Drawing.Size(140, 125)
        Me.IrisButton22.StretchImage = False
        Me.IrisButton22.TabIndex = 29
        Me.IrisButton22.Text = "Security"
        Me.IrisButton22.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IrisButton22.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton22.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton21
        '
        Me.IrisButton21.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton21.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton21.BorderRadius = 30
        Me.IrisButton21.BorderWidth = 0!
        Me.IrisButton21.ClickColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.IrisButton21.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton21.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton21.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton21.DisabledBorderWidth = 1
        Me.IrisButton21.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton21.EnableAnimations = True
        Me.IrisButton21.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton21.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton21.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton21.Image = CType(resources.GetObject("IrisButton21.Image"), System.Drawing.Image)
        Me.IrisButton21.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton21.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton21.IsEnabled = True
        Me.IrisButton21.Location = New System.Drawing.Point(16, 359)
        Me.IrisButton21.Name = "IrisButton21"
        Me.IrisButton21.Size = New System.Drawing.Size(140, 125)
        Me.IrisButton21.StretchImage = True
        Me.IrisButton21.TabIndex = 28
        Me.IrisButton21.Text = "Play"
        Me.IrisButton21.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IrisButton21.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton21.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton11
        '
        Me.IrisButton11.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IrisButton11.BorderRadius = 30
        Me.IrisButton11.BorderWidth = 1.0!
        Me.IrisButton11.ClickColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IrisButton11.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton11.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton11.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton11.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton11.DisabledBorderWidth = 1
        Me.IrisButton11.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton11.EnableAnimations = True
        Me.IrisButton11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton11.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton11.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton11.Image = CType(resources.GetObject("IrisButton11.Image"), System.Drawing.Image)
        Me.IrisButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton11.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton11.IsEnabled = True
        Me.IrisButton11.Location = New System.Drawing.Point(644, 264)
        Me.IrisButton11.Name = "IrisButton11"
        Me.IrisButton11.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton11.StretchImage = False
        Me.IrisButton11.TabIndex = 27
        Me.IrisButton11.Text = "Error"
        Me.IrisButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton11.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton11.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton12
        '
        Me.IrisButton12.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.IrisButton12.BorderRadius = 30
        Me.IrisButton12.BorderWidth = 1.0!
        Me.IrisButton12.ClickColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.IrisButton12.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton12.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton12.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton12.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton12.DisabledBorderWidth = 1
        Me.IrisButton12.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton12.EnableAnimations = True
        Me.IrisButton12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton12.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton12.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton12.Image = CType(resources.GetObject("IrisButton12.Image"), System.Drawing.Image)
        Me.IrisButton12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton12.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton12.IsEnabled = True
        Me.IrisButton12.Location = New System.Drawing.Point(484, 264)
        Me.IrisButton12.Name = "IrisButton12"
        Me.IrisButton12.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton12.StretchImage = False
        Me.IrisButton12.TabIndex = 26
        Me.IrisButton12.Text = "Warning"
        Me.IrisButton12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton12.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton12.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton13
        '
        Me.IrisButton13.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton13.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.IrisButton13.BorderRadius = 30
        Me.IrisButton13.BorderWidth = 1.0!
        Me.IrisButton13.ClickColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IrisButton13.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton13.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton13.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton13.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton13.DisabledBorderWidth = 1
        Me.IrisButton13.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton13.EnableAnimations = True
        Me.IrisButton13.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton13.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton13.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton13.Image = CType(resources.GetObject("IrisButton13.Image"), System.Drawing.Image)
        Me.IrisButton13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton13.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton13.IsEnabled = True
        Me.IrisButton13.Location = New System.Drawing.Point(327, 264)
        Me.IrisButton13.Name = "IrisButton13"
        Me.IrisButton13.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton13.StretchImage = False
        Me.IrisButton13.TabIndex = 25
        Me.IrisButton13.Text = "Success"
        Me.IrisButton13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton13.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton13.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton14
        '
        Me.IrisButton14.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton14.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.IrisButton14.BorderRadius = 30
        Me.IrisButton14.BorderWidth = 1.0!
        Me.IrisButton14.ClickColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.IrisButton14.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton14.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton14.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton14.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton14.DisabledBorderWidth = 1
        Me.IrisButton14.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton14.EnableAnimations = True
        Me.IrisButton14.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton14.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton14.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton14.Image = CType(resources.GetObject("IrisButton14.Image"), System.Drawing.Image)
        Me.IrisButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton14.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton14.IsEnabled = True
        Me.IrisButton14.Location = New System.Drawing.Point(171, 264)
        Me.IrisButton14.Name = "IrisButton14"
        Me.IrisButton14.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton14.StretchImage = False
        Me.IrisButton14.TabIndex = 24
        Me.IrisButton14.Text = "Secondary"
        Me.IrisButton14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton14.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton14.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton15
        '
        Me.IrisButton15.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton15.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton15.BorderRadius = 30
        Me.IrisButton15.BorderWidth = 1.0!
        Me.IrisButton15.ClickColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.IrisButton15.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton15.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton15.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton15.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton15.DisabledBorderWidth = 1
        Me.IrisButton15.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton15.EnableAnimations = True
        Me.IrisButton15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton15.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton15.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton15.Image = CType(resources.GetObject("IrisButton15.Image"), System.Drawing.Image)
        Me.IrisButton15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton15.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton15.IsEnabled = True
        Me.IrisButton15.Location = New System.Drawing.Point(16, 264)
        Me.IrisButton15.Name = "IrisButton15"
        Me.IrisButton15.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton15.StretchImage = False
        Me.IrisButton15.TabIndex = 23
        Me.IrisButton15.Text = "Primary"
        Me.IrisButton15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton15.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton15.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton16
        '
        Me.IrisButton16.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IrisButton16.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton16.BorderRadius = 30
        Me.IrisButton16.BorderWidth = 0!
        Me.IrisButton16.ClickColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.IrisButton16.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton16.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton16.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton16.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton16.DisabledBorderWidth = 1
        Me.IrisButton16.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton16.EnableAnimations = True
        Me.IrisButton16.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton16.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton16.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton16.Image = CType(resources.GetObject("IrisButton16.Image"), System.Drawing.Image)
        Me.IrisButton16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton16.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton16.IsEnabled = True
        Me.IrisButton16.Location = New System.Drawing.Point(644, 195)
        Me.IrisButton16.Name = "IrisButton16"
        Me.IrisButton16.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton16.StretchImage = False
        Me.IrisButton16.TabIndex = 22
        Me.IrisButton16.Text = "Error"
        Me.IrisButton16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton16.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton16.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton17
        '
        Me.IrisButton17.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.IrisButton17.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton17.BorderRadius = 30
        Me.IrisButton17.BorderWidth = 0!
        Me.IrisButton17.ClickColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.IrisButton17.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton17.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton17.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton17.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton17.DisabledBorderWidth = 1
        Me.IrisButton17.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton17.EnableAnimations = True
        Me.IrisButton17.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton17.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton17.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton17.Image = CType(resources.GetObject("IrisButton17.Image"), System.Drawing.Image)
        Me.IrisButton17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton17.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton17.IsEnabled = True
        Me.IrisButton17.Location = New System.Drawing.Point(484, 195)
        Me.IrisButton17.Name = "IrisButton17"
        Me.IrisButton17.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton17.StretchImage = False
        Me.IrisButton17.TabIndex = 21
        Me.IrisButton17.Text = "Warning"
        Me.IrisButton17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton17.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton17.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton18
        '
        Me.IrisButton18.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.IrisButton18.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton18.BorderRadius = 30
        Me.IrisButton18.BorderWidth = 0!
        Me.IrisButton18.ClickColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IrisButton18.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton18.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton18.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton18.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton18.DisabledBorderWidth = 1
        Me.IrisButton18.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton18.EnableAnimations = True
        Me.IrisButton18.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton18.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton18.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton18.Image = CType(resources.GetObject("IrisButton18.Image"), System.Drawing.Image)
        Me.IrisButton18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton18.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton18.IsEnabled = True
        Me.IrisButton18.Location = New System.Drawing.Point(327, 195)
        Me.IrisButton18.Name = "IrisButton18"
        Me.IrisButton18.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton18.StretchImage = False
        Me.IrisButton18.TabIndex = 20
        Me.IrisButton18.Text = "Success"
        Me.IrisButton18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton18.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton18.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton19
        '
        Me.IrisButton19.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.IrisButton19.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton19.BorderRadius = 30
        Me.IrisButton19.BorderWidth = 0!
        Me.IrisButton19.ClickColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.IrisButton19.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton19.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton19.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton19.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton19.DisabledBorderWidth = 1
        Me.IrisButton19.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton19.EnableAnimations = True
        Me.IrisButton19.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton19.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton19.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton19.Image = CType(resources.GetObject("IrisButton19.Image"), System.Drawing.Image)
        Me.IrisButton19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton19.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton19.IsEnabled = True
        Me.IrisButton19.Location = New System.Drawing.Point(171, 195)
        Me.IrisButton19.Name = "IrisButton19"
        Me.IrisButton19.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton19.StretchImage = False
        Me.IrisButton19.TabIndex = 19
        Me.IrisButton19.Text = "Secondary"
        Me.IrisButton19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton19.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton19.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton20
        '
        Me.IrisButton20.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton20.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton20.BorderRadius = 30
        Me.IrisButton20.BorderWidth = 0!
        Me.IrisButton20.ClickColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.IrisButton20.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton20.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton20.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton20.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton20.DisabledBorderWidth = 1
        Me.IrisButton20.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton20.EnableAnimations = True
        Me.IrisButton20.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton20.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton20.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton20.Image = CType(resources.GetObject("IrisButton20.Image"), System.Drawing.Image)
        Me.IrisButton20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton20.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton20.IsEnabled = True
        Me.IrisButton20.Location = New System.Drawing.Point(16, 195)
        Me.IrisButton20.Name = "IrisButton20"
        Me.IrisButton20.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton20.StretchImage = False
        Me.IrisButton20.TabIndex = 18
        Me.IrisButton20.Text = "Primary"
        Me.IrisButton20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton20.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton20.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton6
        '
        Me.IrisButton6.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.IrisButton6.BorderRadius = 30
        Me.IrisButton6.BorderWidth = 1.0!
        Me.IrisButton6.ClickColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.IrisButton6.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton6.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton6.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton6.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton6.DisabledBorderWidth = 1
        Me.IrisButton6.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton6.EnableAnimations = True
        Me.IrisButton6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton6.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton6.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton6.Image = Nothing
        Me.IrisButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton6.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton6.IsEnabled = True
        Me.IrisButton6.Location = New System.Drawing.Point(644, 100)
        Me.IrisButton6.Name = "IrisButton6"
        Me.IrisButton6.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton6.StretchImage = False
        Me.IrisButton6.TabIndex = 17
        Me.IrisButton6.Text = "Error"
        Me.IrisButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton6.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton7
        '
        Me.IrisButton7.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.IrisButton7.BorderRadius = 30
        Me.IrisButton7.BorderWidth = 1.0!
        Me.IrisButton7.ClickColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.IrisButton7.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton7.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton7.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton7.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton7.DisabledBorderWidth = 1
        Me.IrisButton7.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton7.EnableAnimations = True
        Me.IrisButton7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton7.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton7.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton7.Image = Nothing
        Me.IrisButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton7.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton7.IsEnabled = True
        Me.IrisButton7.Location = New System.Drawing.Point(484, 100)
        Me.IrisButton7.Name = "IrisButton7"
        Me.IrisButton7.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton7.StretchImage = False
        Me.IrisButton7.TabIndex = 16
        Me.IrisButton7.Text = "Warning"
        Me.IrisButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton7.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton7.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton8
        '
        Me.IrisButton8.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.IrisButton8.BorderRadius = 30
        Me.IrisButton8.BorderWidth = 1.0!
        Me.IrisButton8.ClickColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IrisButton8.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton8.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton8.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton8.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton8.DisabledBorderWidth = 1
        Me.IrisButton8.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton8.EnableAnimations = True
        Me.IrisButton8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton8.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton8.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton8.Image = Nothing
        Me.IrisButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton8.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton8.IsEnabled = True
        Me.IrisButton8.Location = New System.Drawing.Point(327, 100)
        Me.IrisButton8.Name = "IrisButton8"
        Me.IrisButton8.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton8.StretchImage = False
        Me.IrisButton8.TabIndex = 15
        Me.IrisButton8.Text = "Success"
        Me.IrisButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton8.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton8.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton9
        '
        Me.IrisButton9.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.IrisButton9.BorderRadius = 30
        Me.IrisButton9.BorderWidth = 1.0!
        Me.IrisButton9.ClickColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.IrisButton9.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton9.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton9.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton9.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton9.DisabledBorderWidth = 1
        Me.IrisButton9.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton9.EnableAnimations = True
        Me.IrisButton9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton9.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton9.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton9.Image = Nothing
        Me.IrisButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton9.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton9.IsEnabled = True
        Me.IrisButton9.Location = New System.Drawing.Point(171, 100)
        Me.IrisButton9.Name = "IrisButton9"
        Me.IrisButton9.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton9.StretchImage = False
        Me.IrisButton9.TabIndex = 14
        Me.IrisButton9.Text = "Secondary"
        Me.IrisButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton9.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton9.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton10
        '
        Me.IrisButton10.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton10.BorderRadius = 30
        Me.IrisButton10.BorderWidth = 1.0!
        Me.IrisButton10.ClickColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.IrisButton10.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton10.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton10.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton10.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton10.DisabledBorderWidth = 1
        Me.IrisButton10.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton10.EnableAnimations = True
        Me.IrisButton10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton10.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton10.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton10.Image = Nothing
        Me.IrisButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton10.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton10.IsEnabled = True
        Me.IrisButton10.Location = New System.Drawing.Point(16, 100)
        Me.IrisButton10.Name = "IrisButton10"
        Me.IrisButton10.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton10.StretchImage = False
        Me.IrisButton10.TabIndex = 13
        Me.IrisButton10.Text = "Primary"
        Me.IrisButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton10.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton10.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton5
        '
        Me.IrisButton5.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IrisButton5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton5.BorderRadius = 30
        Me.IrisButton5.BorderWidth = 0!
        Me.IrisButton5.ClickColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.IrisButton5.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton5.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton5.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton5.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton5.DisabledBorderWidth = 1
        Me.IrisButton5.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton5.EnableAnimations = True
        Me.IrisButton5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton5.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton5.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton5.Image = Nothing
        Me.IrisButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton5.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton5.IsEnabled = True
        Me.IrisButton5.Location = New System.Drawing.Point(644, 31)
        Me.IrisButton5.Name = "IrisButton5"
        Me.IrisButton5.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton5.StretchImage = False
        Me.IrisButton5.TabIndex = 12
        Me.IrisButton5.Text = "Error"
        Me.IrisButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton5.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton4
        '
        Me.IrisButton4.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.IrisButton4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton4.BorderRadius = 30
        Me.IrisButton4.BorderWidth = 0!
        Me.IrisButton4.ClickColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.IrisButton4.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton4.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton4.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton4.DisabledBorderWidth = 1
        Me.IrisButton4.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton4.EnableAnimations = True
        Me.IrisButton4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton4.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton4.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton4.Image = Nothing
        Me.IrisButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton4.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton4.IsEnabled = True
        Me.IrisButton4.Location = New System.Drawing.Point(484, 31)
        Me.IrisButton4.Name = "IrisButton4"
        Me.IrisButton4.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton4.StretchImage = False
        Me.IrisButton4.TabIndex = 11
        Me.IrisButton4.Text = "Warning"
        Me.IrisButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton4.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton3
        '
        Me.IrisButton3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.IrisButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton3.BorderRadius = 30
        Me.IrisButton3.BorderWidth = 0!
        Me.IrisButton3.ClickColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IrisButton3.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton3.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton3.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton3.DisabledBorderWidth = 1
        Me.IrisButton3.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton3.EnableAnimations = True
        Me.IrisButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton3.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton3.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton3.Image = Nothing
        Me.IrisButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton3.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton3.IsEnabled = True
        Me.IrisButton3.Location = New System.Drawing.Point(327, 31)
        Me.IrisButton3.Name = "IrisButton3"
        Me.IrisButton3.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton3.StretchImage = False
        Me.IrisButton3.TabIndex = 10
        Me.IrisButton3.Text = "Success"
        Me.IrisButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton3.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton2
        '
        Me.IrisButton2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.IrisButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton2.BorderRadius = 30
        Me.IrisButton2.BorderWidth = 0!
        Me.IrisButton2.ClickColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.IrisButton2.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton2.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton2.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton2.DisabledBorderWidth = 1
        Me.IrisButton2.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton2.EnableAnimations = True
        Me.IrisButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton2.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton2.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton2.Image = Nothing
        Me.IrisButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton2.IsEnabled = True
        Me.IrisButton2.Location = New System.Drawing.Point(171, 31)
        Me.IrisButton2.Name = "IrisButton2"
        Me.IrisButton2.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton2.StretchImage = False
        Me.IrisButton2.TabIndex = 9
        Me.IrisButton2.Text = "Secondary"
        Me.IrisButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton2.TextOffset = New System.Drawing.Point(0, 0)
        '
        'IrisButton1
        '
        Me.IrisButton1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton1.BorderRadius = 30
        Me.IrisButton1.BorderWidth = 0!
        Me.IrisButton1.ClickColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.IrisButton1.ClickTextColor = System.Drawing.Color.Empty
        Me.IrisButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton1.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisButton1.DisabledBorderWidth = 1
        Me.IrisButton1.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisButton1.EnableAnimations = True
        Me.IrisButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.IrisButton1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisButton1.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton1.Image = Nothing
        Me.IrisButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.IrisButton1.IsEnabled = True
        Me.IrisButton1.Location = New System.Drawing.Point(16, 31)
        Me.IrisButton1.Name = "IrisButton1"
        Me.IrisButton1.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton1.StretchImage = False
        Me.IrisButton1.TabIndex = 8
        Me.IrisButton1.Text = "Primary"
        Me.IrisButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisButton1.TextOffset = New System.Drawing.Point(0, 0)
        '
        'InputTabPage
        '
        Me.InputTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.InputTabPage.Controls.Add(Me.IrisInputBox2)
        Me.InputTabPage.Controls.Add(Me.IrisInputBox1)
        Me.InputTabPage.Cursor = System.Windows.Forms.Cursors.Default
        Me.InputTabPage.ImageIndex = 0
        Me.InputTabPage.Location = New System.Drawing.Point(224, 4)
        Me.InputTabPage.Name = "InputTabPage"
        Me.InputTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.InputTabPage.Size = New System.Drawing.Size(799, 519)
        Me.InputTabPage.TabIndex = 2
        Me.InputTabPage.Text = "INPUTS"
        '
        'IrisInputBox2
        '
        Me.IrisInputBox2.BorderRadius = 0
        Me.IrisInputBox2.ContextMenuStrip = Me.InputBoxContextMenu
        Me.IrisInputBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IrisInputBox2.DefaultBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisInputBox2.DefaultBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisInputBox2.DefaultBorderWidth = 1.0!
        Me.IrisInputBox2.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisInputBox2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisInputBox2.DisabledBorderWidth = 1
        Me.IrisInputBox2.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisInputBox2.EnableAnimations = True
        Me.IrisInputBox2.FocusedBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisInputBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisInputBox2.FocusedBorderWidth = 1
        Me.IrisInputBox2.FocusedTextColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.IrisInputBox2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.IrisInputBox2.HoverBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisInputBox2.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisInputBox2.HoverBorderWidth = 1
        Me.IrisInputBox2.HoverTextColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.IrisInputBox2.IsEnabled = True
        Me.IrisInputBox2.Location = New System.Drawing.Point(25, 88)
        Me.IrisInputBox2.MultiLine = False
        Me.IrisInputBox2.Name = "IrisInputBox2"
        Me.IrisInputBox2.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.IrisInputBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IrisInputBox2.PlaceHolderText = "Enter your password"
        Me.IrisInputBox2.PlaceHolderTextColor = System.Drawing.Color.Gray
        Me.IrisInputBox2.SelectedText = ""
        Me.IrisInputBox2.Size = New System.Drawing.Size(504, 40)
        Me.IrisInputBox2.TabIndex = 9
        Me.IrisInputBox2.TabStop = False
        Me.IrisInputBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.IrisInputBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisInputBox2.UnderlinedStyle = True
        Me.IrisInputBox2.UseSystemPasswordChar = False
        '
        'InputBoxContextMenu
        '
        Me.InputBoxContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.InputBoxContextMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InputBoxContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.InputBoxContextMenu.Name = "TextBoxContextMenuStrip"
        Me.InputBoxContextMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.InputBoxContextMenu.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.InputBoxContextMenu.RenderStyle.DisabledArrowColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.InputBoxContextMenu.RenderStyle.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.InputBoxContextMenu.RenderStyle.ExtendItemWidth = 15
        Me.InputBoxContextMenu.RenderStyle.ImageOffset = New System.Drawing.Point(0, 0)
        Me.InputBoxContextMenu.RenderStyle.RoundedEdges = True
        Me.InputBoxContextMenu.RenderStyle.SelectedArrowColor = System.Drawing.Color.White
        Me.InputBoxContextMenu.RenderStyle.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InputBoxContextMenu.RenderStyle.SelectedTextColor = System.Drawing.Color.White
        Me.InputBoxContextMenu.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.InputBoxContextMenu.RenderStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InputBoxContextMenu.RenderStyle.TextOffset = New System.Drawing.Point(0, 0)
        Me.InputBoxContextMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.InputBoxContextMenu.ShowImageMargin = False
        Me.InputBoxContextMenu.Size = New System.Drawing.Size(191, 172)
        '
        'IrisInputBox1
        '
        Me.IrisInputBox1.BorderRadius = 0
        Me.IrisInputBox1.ContextMenuStrip = Me.InputBoxContextMenu
        Me.IrisInputBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IrisInputBox1.DefaultBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisInputBox1.DefaultBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisInputBox1.DefaultBorderWidth = 1.0!
        Me.IrisInputBox1.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisInputBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisInputBox1.DisabledBorderWidth = 1
        Me.IrisInputBox1.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisInputBox1.EnableAnimations = True
        Me.IrisInputBox1.FocusedBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisInputBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisInputBox1.FocusedBorderWidth = 1
        Me.IrisInputBox1.FocusedTextColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.IrisInputBox1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.IrisInputBox1.HoverBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisInputBox1.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisInputBox1.HoverBorderWidth = 1
        Me.IrisInputBox1.HoverTextColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.IrisInputBox1.IsEnabled = True
        Me.IrisInputBox1.Location = New System.Drawing.Point(25, 20)
        Me.IrisInputBox1.MultiLine = False
        Me.IrisInputBox1.Name = "IrisInputBox1"
        Me.IrisInputBox1.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.IrisInputBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IrisInputBox1.PlaceHolderText = "Enter your email or username"
        Me.IrisInputBox1.PlaceHolderTextColor = System.Drawing.Color.Gray
        Me.IrisInputBox1.SelectedText = ""
        Me.IrisInputBox1.Size = New System.Drawing.Size(504, 40)
        Me.IrisInputBox1.TabIndex = 8
        Me.IrisInputBox1.TabStop = False
        Me.IrisInputBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.IrisInputBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisInputBox1.UnderlinedStyle = True
        Me.IrisInputBox1.UseSystemPasswordChar = False
        '
        'CheckBaseTabPage
        '
        Me.CheckBaseTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.CheckBaseTabPage.Controls.Add(Me.IrisCheckBox2)
        Me.CheckBaseTabPage.Controls.Add(Me.IrisCheckBox1)
        Me.CheckBaseTabPage.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBaseTabPage.ImageIndex = 0
        Me.CheckBaseTabPage.Location = New System.Drawing.Point(224, 4)
        Me.CheckBaseTabPage.Name = "CheckBaseTabPage"
        Me.CheckBaseTabPage.Size = New System.Drawing.Size(799, 519)
        Me.CheckBaseTabPage.TabIndex = 3
        Me.CheckBaseTabPage.Text = "CHECKBASES"
        '
        'IrisCheckBox2
        '
        Me.IrisCheckBox2.AutoSize = True
        Me.IrisCheckBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IrisCheckBox2.BorderRadius = 8
        Me.IrisCheckBox2.CheckedBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisCheckBox2.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisCheckBox2.CheckedBorderWidth = 1
        Me.IrisCheckBox2.CheckedTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisCheckBox2.CheckedTickColor = System.Drawing.Color.White
        Me.IrisCheckBox2.DefaultBorderColor = System.Drawing.Color.Gray
        Me.IrisCheckBox2.DefaultBorderWidth = 1
        Me.IrisCheckBox2.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisCheckBox2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisCheckBox2.DisabledBorderWidth = 1
        Me.IrisCheckBox2.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisCheckBox2.EnableAnimations = True
        Me.IrisCheckBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.IrisCheckBox2.ForeColor = System.Drawing.Color.Gray
        Me.IrisCheckBox2.HoveredBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisCheckBox2.HoveredBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisCheckBox2.HoveredBorderWidth = 1
        Me.IrisCheckBox2.HoveredTextColor = System.Drawing.Color.White
        Me.IrisCheckBox2.HoveredTickColor = System.Drawing.Color.White
        Me.IrisCheckBox2.IsEnabled = True
        Me.IrisCheckBox2.Location = New System.Drawing.Point(173, 37)
        Me.IrisCheckBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IrisCheckBox2.Name = "IrisCheckBox2"
        Me.IrisCheckBox2.Size = New System.Drawing.Size(120, 30)
        Me.IrisCheckBox2.Text = "Remember Me"
        '
        'IrisCheckBox1
        '
        Me.IrisCheckBox1.AutoSize = True
        Me.IrisCheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IrisCheckBox1.BorderRadius = 8
        Me.IrisCheckBox1.CheckedBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisCheckBox1.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisCheckBox1.CheckedBorderWidth = 1
        Me.IrisCheckBox1.CheckedTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisCheckBox1.CheckedTickColor = System.Drawing.Color.White
        Me.IrisCheckBox1.DefaultBorderColor = System.Drawing.Color.Gray
        Me.IrisCheckBox1.DefaultBorderWidth = 1
        Me.IrisCheckBox1.DisabledBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IrisCheckBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisCheckBox1.DisabledBorderWidth = 1
        Me.IrisCheckBox1.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.IrisCheckBox1.EnableAnimations = True
        Me.IrisCheckBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.IrisCheckBox1.ForeColor = System.Drawing.Color.Gray
        Me.IrisCheckBox1.HoveredBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IrisCheckBox1.HoveredBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisCheckBox1.HoveredBorderWidth = 1
        Me.IrisCheckBox1.HoveredTextColor = System.Drawing.Color.White
        Me.IrisCheckBox1.HoveredTickColor = System.Drawing.Color.White
        Me.IrisCheckBox1.IsEnabled = True
        Me.IrisCheckBox1.Location = New System.Drawing.Point(41, 37)
        Me.IrisCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IrisCheckBox1.Name = "IrisCheckBox1"
        Me.IrisCheckBox1.Size = New System.Drawing.Size(117, 30)
        Me.IrisCheckBox1.Text = "Stay Signed In"
        '
        'SplitterTabPage
        '
        Me.SplitterTabPage.Location = New System.Drawing.Point(224, 4)
        Me.SplitterTabPage.Name = "SplitterTabPage"
        Me.SplitterTabPage.Size = New System.Drawing.Size(799, 519)
        Me.SplitterTabPage.TabIndex = 4
        Me.SplitterTabPage.Tag = "Splitter"
        Me.SplitterTabPage.UseVisualStyleBackColor = True
        '
        'ComHeaderTabPage
        '
        Me.ComHeaderTabPage.Location = New System.Drawing.Point(224, 4)
        Me.ComHeaderTabPage.Name = "ComHeaderTabPage"
        Me.ComHeaderTabPage.Size = New System.Drawing.Size(799, 519)
        Me.ComHeaderTabPage.TabIndex = 5
        Me.ComHeaderTabPage.Tag = "Header"
        Me.ComHeaderTabPage.Text = "UI COMPONENTS"
        Me.ComHeaderTabPage.UseVisualStyleBackColor = True
        '
        'ThemeManagerTabPage
        '
        Me.ThemeManagerTabPage.Location = New System.Drawing.Point(224, 4)
        Me.ThemeManagerTabPage.Name = "ThemeManagerTabPage"
        Me.ThemeManagerTabPage.Size = New System.Drawing.Size(799, 519)
        Me.ThemeManagerTabPage.TabIndex = 6
        Me.ThemeManagerTabPage.Text = "Theme Manager"
        Me.ThemeManagerTabPage.UseVisualStyleBackColor = True
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1027, 527)
        Me.Controls.Add(Me.IrisVerticalTabControl1)
        Me.Name = "App"
        Me.Text = "IRIS Theme Test Application"
        Me.IrisVerticalTabControl1.ResumeLayout(False)
        Me.ButtonsTabPage.ResumeLayout(False)
        Me.InputTabPage.ResumeLayout(False)
        Me.CheckBaseTabPage.ResumeLayout(False)
        Me.CheckBaseTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputBoxContextMenu As Src.Controls.IRISInputBoxContextMenuStrip
    Friend WithEvents IrisVerticalTabControl1 As Src.Controls.IRISVerticalTabControl
    Friend WithEvents ButtonsTabPage As TabPage
    Friend WithEvents IrisButton1 As Src.Controls.IRISButton
    Friend WithEvents UIHeaderabPage As TabPage
    Friend WithEvents InputTabPage As TabPage
    Friend WithEvents TabControlImageList As ImageList
    Friend WithEvents IrisInputBox2 As Src.Controls.IRISInputBox
    Friend WithEvents IrisInputBox1 As Src.Controls.IRISInputBox
    Friend WithEvents CheckBaseTabPage As TabPage
    Friend WithEvents IrisCheckBox2 As Src.Controls.IRISCheckBox
    Friend WithEvents IrisCheckBox1 As Src.Controls.IRISCheckBox
    Friend WithEvents IrisButton3 As Src.Controls.IRISButton
    Friend WithEvents IrisButton2 As Src.Controls.IRISButton
    Friend WithEvents IrisButton5 As Src.Controls.IRISButton
    Friend WithEvents IrisButton4 As Src.Controls.IRISButton
    Friend WithEvents IrisButton6 As Src.Controls.IRISButton
    Friend WithEvents IrisButton7 As Src.Controls.IRISButton
    Friend WithEvents IrisButton8 As Src.Controls.IRISButton
    Friend WithEvents IrisButton9 As Src.Controls.IRISButton
    Friend WithEvents IrisButton10 As Src.Controls.IRISButton
    Friend WithEvents IrisButton11 As Src.Controls.IRISButton
    Friend WithEvents IrisButton12 As Src.Controls.IRISButton
    Friend WithEvents IrisButton13 As Src.Controls.IRISButton
    Friend WithEvents IrisButton14 As Src.Controls.IRISButton
    Friend WithEvents IrisButton15 As Src.Controls.IRISButton
    Friend WithEvents IrisButton16 As Src.Controls.IRISButton
    Friend WithEvents IrisButton17 As Src.Controls.IRISButton
    Friend WithEvents IrisButton18 As Src.Controls.IRISButton
    Friend WithEvents IrisButton19 As Src.Controls.IRISButton
    Friend WithEvents IrisButton20 As Src.Controls.IRISButton
    Friend WithEvents IrisButton21 As Src.Controls.IRISButton
    Friend WithEvents IrisButton25 As Src.Controls.IRISButton
    Friend WithEvents IrisButton24 As Src.Controls.IRISButton
    Friend WithEvents IrisButton23 As Src.Controls.IRISButton
    Friend WithEvents IrisButton22 As Src.Controls.IRISButton
    Friend WithEvents SplitterTabPage As TabPage
    Friend WithEvents ComHeaderTabPage As TabPage
    Friend WithEvents ThemeManagerTabPage As TabPage
End Class