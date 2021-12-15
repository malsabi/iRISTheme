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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.IrisButton1 = New iRISTheme.Src.Controls.IRISButton()
        Me.IrisThemeManager1 = New iRISTheme.Src.Components.IRISThemeManager()
        Me.IrisInputBox1 = New iRISTheme.Src.Controls.IRISInputBox()
        Me.IrisInputBox2 = New iRISTheme.Src.Controls.IRISInputBox()
        Me.SuspendLayout()
        '
        'IrisButton1
        '
        Me.IrisButton1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.IrisButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.IrisButton1.BorderRadius = 20
        Me.IrisButton1.BorderWidth = 2.0!
        Me.IrisButton1.ClickColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.IrisButton1.ClickTextColor = System.Drawing.Color.White
        Me.IrisButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.IrisButton1.DisabledBackgroundColor = System.Drawing.Color.Empty
        Me.IrisButton1.DisabledBorderColor = System.Drawing.Color.Empty
        Me.IrisButton1.DisabledBorderWidth = 0
        Me.IrisButton1.DisabledTextColor = System.Drawing.Color.Empty
        Me.IrisButton1.EnableAnimations = True
        Me.IrisButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IrisButton1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IrisButton1.HoverTextColor = System.Drawing.Color.White
        Me.IrisButton1.Image = CType(resources.GetObject("IrisButton1.Image"), System.Drawing.Image)
        Me.IrisButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IrisButton1.ImageOffset = New System.Drawing.Point(10, 0)
        Me.IrisButton1.IsEnabled = True
        Me.IrisButton1.Location = New System.Drawing.Point(311, 305)
        Me.IrisButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.IrisButton1.Name = "IrisButton1"
        Me.IrisButton1.Size = New System.Drawing.Size(160, 60)
        Me.IrisButton1.TabIndex = 2
        Me.IrisButton1.Text = "LOGIN"
        Me.IrisButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IrisButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(194, Byte), Integer))
        '
        'IrisThemeManager1
        '
        Me.IrisThemeManager1.CustomStyle = "N/A"
        Me.IrisThemeManager1.OwnerForm = Me
        Me.IrisThemeManager1.ThemeFont = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IrisThemeManager1.ThemeStyle = iRISTheme.Src.Enums.IRISThemeStyle.DarkStyle
        '
        'IrisInputBox1
        '
        Me.IrisInputBox1.BorderRadius = 30
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
        Me.IrisInputBox1.Location = New System.Drawing.Point(31, 69)
        Me.IrisInputBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.IrisInputBox1.MultiLine = False
        Me.IrisInputBox1.Name = "IrisInputBox1"
        Me.IrisInputBox1.Padding = New System.Windows.Forms.Padding(13, 6, 13, 6)
        Me.IrisInputBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IrisInputBox1.PlaceHolderText = "Enter your email"
        Me.IrisInputBox1.PlaceHolderTextColor = System.Drawing.Color.Gray
        Me.IrisInputBox1.Size = New System.Drawing.Size(725, 49)
        Me.IrisInputBox1.TabIndex = 7
        Me.IrisInputBox1.TabStop = False
        Me.IrisInputBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.IrisInputBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisInputBox1.UnderlinedStyle = False
        Me.IrisInputBox1.UseSystemPasswordChar = False
        '
        'IrisInputBox2
        '
        Me.IrisInputBox2.BorderRadius = 30
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
        Me.IrisInputBox2.Location = New System.Drawing.Point(31, 167)
        Me.IrisInputBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.IrisInputBox2.MultiLine = False
        Me.IrisInputBox2.Name = "IrisInputBox2"
        Me.IrisInputBox2.Padding = New System.Windows.Forms.Padding(13, 6, 13, 6)
        Me.IrisInputBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IrisInputBox2.PlaceHolderText = "Enter your password"
        Me.IrisInputBox2.PlaceHolderTextColor = System.Drawing.Color.Gray
        Me.IrisInputBox2.Size = New System.Drawing.Size(725, 49)
        Me.IrisInputBox2.TabIndex = 8
        Me.IrisInputBox2.TabStop = False
        Me.IrisInputBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.IrisInputBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IrisInputBox2.UnderlinedStyle = False
        Me.IrisInputBox2.UseSystemPasswordChar = True
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 441)
        Me.Controls.Add(Me.IrisInputBox2)
        Me.Controls.Add(Me.IrisInputBox1)
        Me.Controls.Add(Me.IrisButton1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "App"
        Me.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.Text = "App"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IrisThemeManager1 As Src.Components.IRISThemeManager
    Friend WithEvents IrisButton1 As Src.Controls.IRISButton
    Friend WithEvents IrisInputBox2 As Src.Controls.IRISInputBox
    Friend WithEvents IrisInputBox1 As Src.Controls.IRISInputBox
End Class
