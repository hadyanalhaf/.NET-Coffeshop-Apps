<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Promo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Promo))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim Animation3 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Me.transisi_detailorder = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.pnl_controlbox = New System.Windows.Forms.Panel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.btn_minimize = New Guna.UI.WinForms.GunaControlBox()
        Me.btn_maximaze = New Guna.UI.WinForms.GunaControlBox()
        Me.btn_close = New Guna.UI.WinForms.GunaControlBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_logout = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton7 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton3 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton5 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton4 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.transisi_bill = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.anim2 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.pnl_controlbox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'transisi_detailorder
        '
        Me.transisi_detailorder.AnimationType = Guna.UI.Animation.AnimationType.VertSlide
        Me.transisi_detailorder.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.transisi_detailorder.DefaultAnimation = Animation1
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox2.BackgroundImage = CType(resources.GetObject("GunaControlBox2.BackgroundImage"), System.Drawing.Image)
        Me.GunaControlBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GunaControlBox2.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.GunaControlBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transisi_detailorder.SetDecoration(Me.GunaControlBox2, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.GunaControlBox2, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.GunaControlBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaControlBox2.IconColor = System.Drawing.Color.Transparent
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(1860, 14)
        Me.GunaControlBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.Transparent
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaControlBox2.Size = New System.Drawing.Size(21, 20)
        Me.GunaControlBox2.TabIndex = 48
        '
        'GunaControlBox3
        '
        Me.GunaControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox3.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox3.AnimationSpeed = 0.03!
        Me.GunaControlBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox3.BackgroundImage = CType(resources.GetObject("GunaControlBox3.BackgroundImage"), System.Drawing.Image)
        Me.GunaControlBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GunaControlBox3.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transisi_detailorder.SetDecoration(Me.GunaControlBox3, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.GunaControlBox3, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.GunaControlBox3, Guna.UI.Animation.DecorationType.None)
        Me.GunaControlBox3.IconColor = System.Drawing.Color.Transparent
        Me.GunaControlBox3.IconSize = 15.0!
        Me.GunaControlBox3.Location = New System.Drawing.Point(1890, 14)
        Me.GunaControlBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaControlBox3.Name = "GunaControlBox3"
        Me.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.Transparent
        Me.GunaControlBox3.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaControlBox3.Size = New System.Drawing.Size(21, 20)
        Me.GunaControlBox3.TabIndex = 47
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transisi_detailorder.SetDecoration(Me.GunaPanel3, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.GunaPanel3, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.GunaPanel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 48)
        Me.GunaPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(2483, 59)
        Me.GunaPanel3.TabIndex = 54
        '
        'pnl_controlbox
        '
        Me.pnl_controlbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.pnl_controlbox.Controls.Add(Me.GunaControlBox1)
        Me.pnl_controlbox.Controls.Add(Me.btn_minimize)
        Me.pnl_controlbox.Controls.Add(Me.GunaControlBox2)
        Me.pnl_controlbox.Controls.Add(Me.GunaControlBox3)
        Me.pnl_controlbox.Controls.Add(Me.btn_maximaze)
        Me.pnl_controlbox.Controls.Add(Me.btn_close)
        Me.transisi_detailorder.SetDecoration(Me.pnl_controlbox, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.pnl_controlbox, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.pnl_controlbox, Guna.UI.Animation.DecorationType.None)
        Me.pnl_controlbox.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_controlbox.Location = New System.Drawing.Point(0, 0)
        Me.pnl_controlbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_controlbox.Name = "pnl_controlbox"
        Me.pnl_controlbox.Size = New System.Drawing.Size(1920, 48)
        Me.pnl_controlbox.TabIndex = 55
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.BackgroundImage = CType(resources.GetObject("GunaControlBox1.BackgroundImage"), System.Drawing.Image)
        Me.GunaControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transisi_detailorder.SetDecoration(Me.GunaControlBox1, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.GunaControlBox1, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.GunaControlBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1830, 14)
        Me.GunaControlBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.Size = New System.Drawing.Size(21, 20)
        Me.GunaControlBox1.TabIndex = 49
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.AnimationHoverSpeed = 0.07!
        Me.btn_minimize.AnimationSpeed = 0.03!
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.BackgroundImage = CType(resources.GetObject("btn_minimize.BackgroundImage"), System.Drawing.Image)
        Me.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_minimize.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.btn_minimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transisi_detailorder.SetDecoration(Me.btn_minimize, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.btn_minimize, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.btn_minimize, Guna.UI.Animation.DecorationType.None)
        Me.btn_minimize.IconColor = System.Drawing.Color.Transparent
        Me.btn_minimize.IconSize = 15.0!
        Me.btn_minimize.Location = New System.Drawing.Point(1830, 68)
        Me.btn_minimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.OnHoverIconColor = System.Drawing.Color.Transparent
        Me.btn_minimize.OnPressedColor = System.Drawing.Color.Transparent
        Me.btn_minimize.Size = New System.Drawing.Size(21, 20)
        Me.btn_minimize.TabIndex = 3
        '
        'btn_maximaze
        '
        Me.btn_maximaze.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maximaze.AnimationHoverSpeed = 0.07!
        Me.btn_maximaze.AnimationSpeed = 0.03!
        Me.btn_maximaze.BackColor = System.Drawing.Color.Transparent
        Me.btn_maximaze.BackgroundImage = CType(resources.GetObject("btn_maximaze.BackgroundImage"), System.Drawing.Image)
        Me.btn_maximaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_maximaze.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.btn_maximaze.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.btn_maximaze.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transisi_detailorder.SetDecoration(Me.btn_maximaze, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.btn_maximaze, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.btn_maximaze, Guna.UI.Animation.DecorationType.None)
        Me.btn_maximaze.IconColor = System.Drawing.Color.Transparent
        Me.btn_maximaze.IconSize = 15.0!
        Me.btn_maximaze.Location = New System.Drawing.Point(1860, 68)
        Me.btn_maximaze.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_maximaze.Name = "btn_maximaze"
        Me.btn_maximaze.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.btn_maximaze.OnHoverIconColor = System.Drawing.Color.Transparent
        Me.btn_maximaze.OnPressedColor = System.Drawing.Color.Transparent
        Me.btn_maximaze.Size = New System.Drawing.Size(21, 20)
        Me.btn_maximaze.TabIndex = 2
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.AnimationHoverSpeed = 0.07!
        Me.btn_close.AnimationSpeed = 0.03!
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_close.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transisi_detailorder.SetDecoration(Me.btn_close, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.btn_close, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.btn_close, Guna.UI.Animation.DecorationType.None)
        Me.btn_close.IconColor = System.Drawing.Color.Transparent
        Me.btn_close.IconSize = 15.0!
        Me.btn_close.Location = New System.Drawing.Point(1890, 68)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.btn_close.OnHoverIconColor = System.Drawing.Color.Transparent
        Me.btn_close.OnPressedColor = System.Drawing.Color.Transparent
        Me.btn_close.Size = New System.Drawing.Size(21, 20)
        Me.btn_close.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.anim2.SetDecoration(Me.ContextMenuStrip1, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me.ContextMenuStrip1, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.ContextMenuStrip1, Guna.UI.Animation.DecorationType.None)
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.anim2.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(222, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1835, 971)
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GunaPanel1.Controls.Add(Me.btn_logout)
        Me.GunaPanel1.Controls.Add(Me.BunifuButton7)
        Me.GunaPanel1.Controls.Add(Me.BunifuButton3)
        Me.GunaPanel1.Controls.Add(Me.BunifuButton1)
        Me.GunaPanel1.Controls.Add(Me.BunifuButton5)
        Me.GunaPanel1.Controls.Add(Me.BunifuButton4)
        Me.GunaPanel1.Controls.Add(Me.BunifuButton2)
        Me.transisi_detailorder.SetDecoration(Me.GunaPanel1, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.GunaPanel1, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.GunaPanel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPanel1.Location = New System.Drawing.Point(1, 108)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(84, 971)
        Me.GunaPanel1.TabIndex = 58
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.anim2.SetDecoration(Me.FlowLayoutPanel1, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me.FlowLayoutPanel1, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me.FlowLayoutPanel1, Guna.UI.Animation.DecorationType.None)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(85, 161)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 50)
        Me.FlowLayoutPanel1.TabIndex = 19
        '
        'btn_logout
        '
        Me.btn_logout.AllowAnimations = True
        Me.btn_logout.AllowMouseEffects = True
        Me.btn_logout.AllowToggling = False
        Me.btn_logout.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_logout.AnimationSpeed = 200
        Me.btn_logout.AutoGenerateColors = False
        Me.btn_logout.AutoRoundBorders = False
        Me.btn_logout.AutoSizeLeftIcon = True
        Me.btn_logout.AutoSizeRightIcon = True
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.BackColor1 = System.Drawing.Color.Transparent
        Me.btn_logout.BackgroundImage = CType(resources.GetObject("btn_logout.BackgroundImage"), System.Drawing.Image)
        Me.btn_logout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_logout.ButtonText = ""
        Me.btn_logout.ButtonTextMarginLeft = 0
        Me.btn_logout.ColorContrastOnClick = 45
        Me.btn_logout.ColorContrastOnHover = 45
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btn_logout.CustomizableEdges = BorderEdges1
        Me.transisi_bill.SetDecoration(Me.btn_logout, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me.btn_logout, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.btn_logout, Guna.UI.Animation.DecorationType.None)
        Me.btn_logout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_logout.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_logout.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_logout.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_logout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_logout.ForeColor = System.Drawing.Color.Transparent
        Me.btn_logout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_logout.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btn_logout.IconMarginLeft = 11
        Me.btn_logout.IconPadding = 10
        Me.btn_logout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_logout.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btn_logout.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btn_logout.IconSize = 25
        Me.btn_logout.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btn_logout.IdleBorderRadius = 10
        Me.btn_logout.IdleBorderThickness = 1
        Me.btn_logout.IdleFillColor = System.Drawing.Color.Transparent
        Me.btn_logout.IdleIconLeftImage = CType(resources.GetObject("btn_logout.IdleIconLeftImage"), System.Drawing.Image)
        Me.btn_logout.IdleIconRightImage = Nothing
        Me.btn_logout.IndicateFocus = False
        Me.btn_logout.Location = New System.Drawing.Point(3, 875)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_logout.OnDisabledState.BorderRadius = 10
        Me.btn_logout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_logout.OnDisabledState.BorderThickness = 1
        Me.btn_logout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_logout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_logout.OnDisabledState.IconLeftImage = Nothing
        Me.btn_logout.OnDisabledState.IconRightImage = Nothing
        Me.btn_logout.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_logout.onHoverState.BorderRadius = 10
        Me.btn_logout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_logout.onHoverState.BorderThickness = 1
        Me.btn_logout.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_logout.onHoverState.ForeColor = System.Drawing.Color.Transparent
        Me.btn_logout.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage"), System.Drawing.Image)
        Me.btn_logout.onHoverState.IconRightImage = Nothing
        Me.btn_logout.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_logout.OnIdleState.BorderRadius = 10
        Me.btn_logout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_logout.OnIdleState.BorderThickness = 1
        Me.btn_logout.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.btn_logout.OnIdleState.ForeColor = System.Drawing.Color.Transparent
        Me.btn_logout.OnIdleState.IconLeftImage = CType(resources.GetObject("btn_logout.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.btn_logout.OnIdleState.IconRightImage = Nothing
        Me.btn_logout.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_logout.OnPressedState.BorderRadius = 10
        Me.btn_logout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_logout.OnPressedState.BorderThickness = 1
        Me.btn_logout.OnPressedState.FillColor = System.Drawing.Color.Empty
        Me.btn_logout.OnPressedState.ForeColor = System.Drawing.Color.Transparent
        Me.btn_logout.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage1"), System.Drawing.Image)
        Me.btn_logout.OnPressedState.IconRightImage = Nothing
        Me.btn_logout.Size = New System.Drawing.Size(76, 69)
        Me.btn_logout.TabIndex = 29
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_logout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_logout.TextMarginLeft = 0
        Me.btn_logout.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_logout.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton7
        '
        Me.BunifuButton7.AllowAnimations = True
        Me.BunifuButton7.AllowMouseEffects = True
        Me.BunifuButton7.AllowToggling = False
        Me.BunifuButton7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuButton7.AnimationSpeed = 200
        Me.BunifuButton7.AutoGenerateColors = False
        Me.BunifuButton7.AutoRoundBorders = False
        Me.BunifuButton7.AutoSizeLeftIcon = True
        Me.BunifuButton7.AutoSizeRightIcon = True
        Me.BunifuButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.BackColor1 = System.Drawing.Color.Transparent
        Me.BunifuButton7.BackgroundImage = CType(resources.GetObject("BunifuButton7.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton7.ButtonText = ""
        Me.BunifuButton7.ButtonTextMarginLeft = 0
        Me.BunifuButton7.ColorContrastOnClick = 45
        Me.BunifuButton7.ColorContrastOnHover = 45
        Me.BunifuButton7.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BunifuButton7.CustomizableEdges = BorderEdges2
        Me.transisi_bill.SetDecoration(Me.BunifuButton7, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me.BunifuButton7, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.BunifuButton7, Guna.UI.Animation.DecorationType.None)
        Me.BunifuButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton7.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton7.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton7.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton7.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton7.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton7.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton7.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton7.IconMarginLeft = 11
        Me.BunifuButton7.IconPadding = 10
        Me.BunifuButton7.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton7.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton7.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton7.IconSize = 25
        Me.BunifuButton7.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.IdleBorderRadius = 10
        Me.BunifuButton7.IdleBorderThickness = 1
        Me.BunifuButton7.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.IdleIconLeftImage = CType(resources.GetObject("BunifuButton7.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton7.IdleIconRightImage = Nothing
        Me.BunifuButton7.IndicateFocus = False
        Me.BunifuButton7.Location = New System.Drawing.Point(3, 407)
        Me.BunifuButton7.Name = "BunifuButton7"
        Me.BunifuButton7.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton7.OnDisabledState.BorderRadius = 10
        Me.BunifuButton7.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton7.OnDisabledState.BorderThickness = 1
        Me.BunifuButton7.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton7.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton7.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton7.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton7.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.onHoverState.BorderRadius = 10
        Me.BunifuButton7.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton7.onHoverState.BorderThickness = 1
        Me.BunifuButton7.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton7.onHoverState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage2"), System.Drawing.Image)
        Me.BunifuButton7.onHoverState.IconRightImage = Nothing
        Me.BunifuButton7.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.OnIdleState.BorderRadius = 10
        Me.BunifuButton7.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton7.OnIdleState.BorderThickness = 1
        Me.BunifuButton7.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.OnIdleState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton7.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton7.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton7.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.OnPressedState.BorderRadius = 10
        Me.BunifuButton7.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton7.OnPressedState.BorderThickness = 1
        Me.BunifuButton7.OnPressedState.FillColor = System.Drawing.Color.Empty
        Me.BunifuButton7.OnPressedState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage3"), System.Drawing.Image)
        Me.BunifuButton7.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton7.Size = New System.Drawing.Size(76, 69)
        Me.BunifuButton7.TabIndex = 28
        Me.BunifuButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton7.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton7.TextMarginLeft = 0
        Me.BunifuButton7.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton7.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton3
        '
        Me.BunifuButton3.AllowAnimations = True
        Me.BunifuButton3.AllowMouseEffects = True
        Me.BunifuButton3.AllowToggling = False
        Me.BunifuButton3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuButton3.AnimationSpeed = 200
        Me.BunifuButton3.AutoGenerateColors = False
        Me.BunifuButton3.AutoRoundBorders = False
        Me.BunifuButton3.AutoSizeLeftIcon = True
        Me.BunifuButton3.AutoSizeRightIcon = True
        Me.BunifuButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.BackColor1 = System.Drawing.Color.Transparent
        Me.BunifuButton3.BackgroundImage = CType(resources.GetObject("BunifuButton3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.ButtonText = ""
        Me.BunifuButton3.ButtonTextMarginLeft = 0
        Me.BunifuButton3.ColorContrastOnClick = 45
        Me.BunifuButton3.ColorContrastOnHover = 45
        Me.BunifuButton3.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.BunifuButton3.CustomizableEdges = BorderEdges3
        Me.transisi_bill.SetDecoration(Me.BunifuButton3, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me.BunifuButton3, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.BunifuButton3, Guna.UI.Animation.DecorationType.None)
        Me.BunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton3.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton3.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton3.IconMarginLeft = 11
        Me.BunifuButton3.IconPadding = 10
        Me.BunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton3.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton3.IconSize = 25
        Me.BunifuButton3.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.IdleBorderRadius = 10
        Me.BunifuButton3.IdleBorderThickness = 1
        Me.BunifuButton3.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.IdleIconLeftImage = CType(resources.GetObject("BunifuButton3.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton3.IdleIconRightImage = Nothing
        Me.BunifuButton3.IndicateFocus = False
        Me.BunifuButton3.Location = New System.Drawing.Point(4, 331)
        Me.BunifuButton3.Name = "BunifuButton3"
        Me.BunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.BorderRadius = 10
        Me.BunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnDisabledState.BorderThickness = 1
        Me.BunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton3.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton3.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.onHoverState.BorderRadius = 10
        Me.BunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.onHoverState.BorderThickness = 1
        Me.BunifuButton3.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton3.onHoverState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage4"), System.Drawing.Image)
        Me.BunifuButton3.onHoverState.IconRightImage = Nothing
        Me.BunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.OnIdleState.BorderRadius = 10
        Me.BunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnIdleState.BorderThickness = 1
        Me.BunifuButton3.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton3.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton3.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.OnPressedState.BorderRadius = 10
        Me.BunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnPressedState.BorderThickness = 1
        Me.BunifuButton3.OnPressedState.FillColor = System.Drawing.Color.Empty
        Me.BunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage5"), System.Drawing.Image)
        Me.BunifuButton3.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton3.Size = New System.Drawing.Size(76, 69)
        Me.BunifuButton3.TabIndex = 27
        Me.BunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton3.TextMarginLeft = 0
        Me.BunifuButton3.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton3.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = ""
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges4
        Me.transisi_bill.SetDecoration(Me.BunifuButton1, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me.BunifuButton1, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.BunifuButton1, Guna.UI.Animation.DecorationType.None)
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton1.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.IdleBorderRadius = 10
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.IdleIconLeftImage = CType(resources.GetObject("BunifuButton1.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(3, 252)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 10
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 1
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.onHoverState.BorderRadius = 10
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 1
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage6"), System.Drawing.Image)
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.OnIdleState.BorderRadius = 10
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 1
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton1.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.OnPressedState.BorderRadius = 10
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 1
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.Empty
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage7"), System.Drawing.Image)
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(76, 69)
        Me.BunifuButton1.TabIndex = 26
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton5
        '
        Me.BunifuButton5.AllowAnimations = True
        Me.BunifuButton5.AllowMouseEffects = True
        Me.BunifuButton5.AllowToggling = False
        Me.BunifuButton5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuButton5.AnimationSpeed = 200
        Me.BunifuButton5.AutoGenerateColors = False
        Me.BunifuButton5.AutoRoundBorders = False
        Me.BunifuButton5.AutoSizeLeftIcon = True
        Me.BunifuButton5.AutoSizeRightIcon = True
        Me.BunifuButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.BackColor1 = System.Drawing.Color.Transparent
        Me.BunifuButton5.BackgroundImage = CType(resources.GetObject("BunifuButton5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.ButtonText = ""
        Me.BunifuButton5.ButtonTextMarginLeft = 0
        Me.BunifuButton5.ColorContrastOnClick = 45
        Me.BunifuButton5.ColorContrastOnHover = 45
        Me.BunifuButton5.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges5.BottomLeft = True
        BorderEdges5.BottomRight = True
        BorderEdges5.TopLeft = True
        BorderEdges5.TopRight = True
        Me.BunifuButton5.CustomizableEdges = BorderEdges5
        Me.transisi_bill.SetDecoration(Me.BunifuButton5, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me.BunifuButton5, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.BunifuButton5, Guna.UI.Animation.DecorationType.None)
        Me.BunifuButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton5.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton5.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton5.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton5.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton5.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton5.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton5.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton5.IconMarginLeft = 11
        Me.BunifuButton5.IconPadding = 10
        Me.BunifuButton5.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton5.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton5.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton5.IconSize = 25
        Me.BunifuButton5.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.IdleBorderRadius = 10
        Me.BunifuButton5.IdleBorderThickness = 1
        Me.BunifuButton5.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.IdleIconLeftImage = CType(resources.GetObject("BunifuButton5.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton5.IdleIconRightImage = Nothing
        Me.BunifuButton5.IndicateFocus = False
        Me.BunifuButton5.Location = New System.Drawing.Point(4, 177)
        Me.BunifuButton5.Name = "BunifuButton5"
        Me.BunifuButton5.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton5.OnDisabledState.BorderRadius = 10
        Me.BunifuButton5.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.OnDisabledState.BorderThickness = 1
        Me.BunifuButton5.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton5.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton5.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton5.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton5.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.onHoverState.BorderRadius = 10
        Me.BunifuButton5.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.onHoverState.BorderThickness = 1
        Me.BunifuButton5.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton5.onHoverState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage8"), System.Drawing.Image)
        Me.BunifuButton5.onHoverState.IconRightImage = Nothing
        Me.BunifuButton5.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.OnIdleState.BorderRadius = 10
        Me.BunifuButton5.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.OnIdleState.BorderThickness = 1
        Me.BunifuButton5.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.OnIdleState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton5.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton5.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton5.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.OnPressedState.BorderRadius = 10
        Me.BunifuButton5.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.OnPressedState.BorderThickness = 1
        Me.BunifuButton5.OnPressedState.FillColor = System.Drawing.Color.Empty
        Me.BunifuButton5.OnPressedState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage9"), System.Drawing.Image)
        Me.BunifuButton5.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton5.Size = New System.Drawing.Size(76, 69)
        Me.BunifuButton5.TabIndex = 25
        Me.BunifuButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton5.TextMarginLeft = 0
        Me.BunifuButton5.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton5.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton4
        '
        Me.BunifuButton4.AllowAnimations = True
        Me.BunifuButton4.AllowMouseEffects = True
        Me.BunifuButton4.AllowToggling = False
        Me.BunifuButton4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuButton4.AnimationSpeed = 200
        Me.BunifuButton4.AutoGenerateColors = False
        Me.BunifuButton4.AutoRoundBorders = False
        Me.BunifuButton4.AutoSizeLeftIcon = True
        Me.BunifuButton4.AutoSizeRightIcon = True
        Me.BunifuButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.BackColor1 = System.Drawing.Color.Transparent
        Me.BunifuButton4.BackgroundImage = CType(resources.GetObject("BunifuButton4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.ButtonText = ""
        Me.BunifuButton4.ButtonTextMarginLeft = 0
        Me.BunifuButton4.ColorContrastOnClick = 45
        Me.BunifuButton4.ColorContrastOnHover = 45
        Me.BunifuButton4.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges6.BottomLeft = True
        BorderEdges6.BottomRight = True
        BorderEdges6.TopLeft = True
        BorderEdges6.TopRight = True
        Me.BunifuButton4.CustomizableEdges = BorderEdges6
        Me.transisi_bill.SetDecoration(Me.BunifuButton4, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me.BunifuButton4, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.BunifuButton4, Guna.UI.Animation.DecorationType.None)
        Me.BunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton4.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton4.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton4.IconMarginLeft = 11
        Me.BunifuButton4.IconPadding = 10
        Me.BunifuButton4.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton4.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton4.IconSize = 25
        Me.BunifuButton4.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.IdleBorderRadius = 10
        Me.BunifuButton4.IdleBorderThickness = 1
        Me.BunifuButton4.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.IdleIconLeftImage = CType(resources.GetObject("BunifuButton4.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton4.IdleIconRightImage = Nothing
        Me.BunifuButton4.IndicateFocus = False
        Me.BunifuButton4.Location = New System.Drawing.Point(3, 102)
        Me.BunifuButton4.Name = "BunifuButton4"
        Me.BunifuButton4.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton4.OnDisabledState.BorderRadius = 10
        Me.BunifuButton4.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.OnDisabledState.BorderThickness = 1
        Me.BunifuButton4.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton4.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton4.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton4.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton4.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.onHoverState.BorderRadius = 10
        Me.BunifuButton4.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.onHoverState.BorderThickness = 1
        Me.BunifuButton4.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton4.onHoverState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage10"), System.Drawing.Image)
        Me.BunifuButton4.onHoverState.IconRightImage = Nothing
        Me.BunifuButton4.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.OnIdleState.BorderRadius = 10
        Me.BunifuButton4.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.OnIdleState.BorderThickness = 1
        Me.BunifuButton4.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.OnIdleState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton4.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton4.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton4.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.OnPressedState.BorderRadius = 10
        Me.BunifuButton4.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.OnPressedState.BorderThickness = 1
        Me.BunifuButton4.OnPressedState.FillColor = System.Drawing.Color.Empty
        Me.BunifuButton4.OnPressedState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage11"), System.Drawing.Image)
        Me.BunifuButton4.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton4.Size = New System.Drawing.Size(76, 69)
        Me.BunifuButton4.TabIndex = 24
        Me.BunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton4.TextMarginLeft = 0
        Me.BunifuButton4.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton4.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton2
        '
        Me.BunifuButton2.AllowAnimations = True
        Me.BunifuButton2.AllowMouseEffects = True
        Me.BunifuButton2.AllowToggling = False
        Me.BunifuButton2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuButton2.AnimationSpeed = 200
        Me.BunifuButton2.AutoGenerateColors = False
        Me.BunifuButton2.AutoRoundBorders = False
        Me.BunifuButton2.AutoSizeLeftIcon = True
        Me.BunifuButton2.AutoSizeRightIcon = True
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackColor1 = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.ButtonText = ""
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.ColorContrastOnClick = 45
        Me.BunifuButton2.ColorContrastOnHover = 45
        Me.BunifuButton2.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges7.BottomLeft = True
        BorderEdges7.BottomRight = True
        BorderEdges7.TopLeft = True
        BorderEdges7.TopRight = True
        Me.BunifuButton2.CustomizableEdges = BorderEdges7
        Me.transisi_bill.SetDecoration(Me.BunifuButton2, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me.BunifuButton2, Guna.UI.Animation.DecorationType.None)
        Me.anim2.SetDecoration(Me.BunifuButton2, Guna.UI.Animation.DecorationType.None)
        Me.BunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton2.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton2.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton2.IconMarginLeft = 11
        Me.BunifuButton2.IconPadding = 10
        Me.BunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton2.IconSize = 25
        Me.BunifuButton2.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.IdleBorderRadius = 10
        Me.BunifuButton2.IdleBorderThickness = 1
        Me.BunifuButton2.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.IdleIconLeftImage = CType(resources.GetObject("BunifuButton2.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton2.IdleIconRightImage = Nothing
        Me.BunifuButton2.IndicateFocus = False
        Me.BunifuButton2.Location = New System.Drawing.Point(4, 27)
        Me.BunifuButton2.Name = "BunifuButton2"
        Me.BunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.BorderRadius = 10
        Me.BunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnDisabledState.BorderThickness = 1
        Me.BunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton2.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.onHoverState.BorderRadius = 10
        Me.BunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.onHoverState.BorderThickness = 1
        Me.BunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton2.onHoverState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage12"), System.Drawing.Image)
        Me.BunifuButton2.onHoverState.IconRightImage = Nothing
        Me.BunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.OnIdleState.BorderRadius = 10
        Me.BunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnIdleState.BorderThickness = 1
        Me.BunifuButton2.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton2.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton2.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.OnPressedState.BorderRadius = 10
        Me.BunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnPressedState.BorderThickness = 1
        Me.BunifuButton2.OnPressedState.FillColor = System.Drawing.Color.Empty
        Me.BunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage13"), System.Drawing.Image)
        Me.BunifuButton2.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton2.Size = New System.Drawing.Size(76, 69)
        Me.BunifuButton2.TabIndex = 23
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton2.TextMarginLeft = 0
        Me.BunifuButton2.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton2.UseDefaultRadiusAndThickness = True
        '
        'transisi_bill
        '
        Me.transisi_bill.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        Me.transisi_bill.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.transisi_bill.DefaultAnimation = Animation2
        '
        'anim2
        '
        Me.anim2.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        Me.anim2.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.anim2.DefaultAnimation = Animation3
        '
        'Promo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.pnl_controlbox)
        Me.anim2.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.transisi_detailorder.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.transisi_bill.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Promo"
        Me.Text = "Promo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_controlbox.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents transisi_detailorder As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents transisi_bill As Guna.UI.WinForms.GunaTransition
    Friend WithEvents anim2 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnl_controlbox As Panel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btn_minimize As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btn_maximaze As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btn_close As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn_logout As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
