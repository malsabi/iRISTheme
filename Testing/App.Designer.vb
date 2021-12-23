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
        Me.IrisInputBox2 = New iRISTheme.Src.Controls.IRISInputBox()
        Me.InputBoxContextMenu = New iRISTheme.Src.Controls.IRISInputBoxContextMenuStrip()
        Me.IrisInputBox1 = New iRISTheme.Src.Controls.IRISInputBox()
        Me.IrisButton1 = New iRISTheme.Src.Controls.IRISButton()
        Me.SuspendLayout()
        '
        'IrisInputBox2
        '
        Me.IrisInputBox2.BorderRadius = 30
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
        Me.IrisInputBox2.Location = New System.Drawing.Point(136, 142)
        Me.IrisInputBox2.MultiLine = False
        Me.IrisInputBox2.Name = "IrisInputBox2"
        Me.IrisInputBox2.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.IrisInputBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IrisInputBox2.PlaceHolderText = "Enter your password"
        Me.IrisInputBox2.PlaceHolderTextColor = System.Drawing.Color.Gray
        Me.IrisInputBox2.SelectedText = ""
        Me.IrisInputBox2.Size = New System.Drawing.Size(320, 40)
        Me.IrisInputBox2.TabIndex = 2
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
        Me.IrisInputBox1.BorderRadius = 30
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
        Me.IrisInputBox1.Location = New System.Drawing.Point(136, 74)
        Me.IrisInputBox1.MultiLine = False
        Me.IrisInputBox1.Name = "IrisInputBox1"
        Me.IrisInputBox1.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.IrisInputBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IrisInputBox1.PlaceHolderText = "Enter your email or username"
        Me.IrisInputBox1.PlaceHolderTextColor = System.Drawing.Color.Gray
        Me.IrisInputBox1.SelectedText = ""
        Me.IrisInputBox1.Size = New System.Drawing.Size(320, 40)
        Me.IrisInputBox1.TabIndex = 1
        Me.IrisInputBox1.TabStop = False
        Me.IrisInputBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.IrisInputBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisInputBox1.UnderlinedStyle = True
        Me.IrisInputBox1.UseSystemPasswordChar = False
        '
        'IrisButton1
        '
        Me.IrisButton1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton1.BorderRadius = 30
        Me.IrisButton1.BorderWidth = 1.0!
        Me.IrisButton1.ClickColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.IrisButton1.Location = New System.Drawing.Point(211, 250)
        Me.IrisButton1.Name = "IrisButton1"
        Me.IrisButton1.Size = New System.Drawing.Size(140, 43)
        Me.IrisButton1.TabIndex = 3
        Me.IrisButton1.Text = "LOGIN"
        Me.IrisButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(594, 358)
        Me.Controls.Add(Me.IrisButton1)
        Me.Controls.Add(Me.IrisInputBox2)
        Me.Controls.Add(Me.IrisInputBox1)
        Me.Name = "App"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IrisInputBox1 As Src.Controls.IRISInputBox
    Friend WithEvents InputBoxContextMenu As Src.Controls.IRISInputBoxContextMenuStrip
    Friend WithEvents IrisInputBox2 As Src.Controls.IRISInputBox
    Friend WithEvents IrisButton1 As Src.Controls.IRISButton
End Class