<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(search))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_search = New Bunifu.UI.WinForms.BunifuPanel()
        Me.btn_back = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.dgv_search = New Guna.UI.WinForms.GunaDataGridView()
        Me.pnl_search.SuspendLayout()
        CType(Me.dgv_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_search
        '
        Me.pnl_search.BackgroundColor = System.Drawing.Color.IndianRed
        Me.pnl_search.BackgroundImage = CType(resources.GetObject("pnl_search.BackgroundImage"), System.Drawing.Image)
        Me.pnl_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_search.BorderColor = System.Drawing.Color.Transparent
        Me.pnl_search.BorderRadius = 3
        Me.pnl_search.BorderThickness = 1
        Me.pnl_search.Controls.Add(Me.btn_back)
        Me.pnl_search.Controls.Add(Me.dgv_search)
        Me.pnl_search.Location = New System.Drawing.Point(-133, -2)
        Me.pnl_search.Name = "pnl_search"
        Me.pnl_search.ShowBorders = True
        Me.pnl_search.Size = New System.Drawing.Size(1674, 655)
        Me.pnl_search.TabIndex = 57
        '
        'btn_back
        '
        Me.btn_back.AllowAnimations = True
        Me.btn_back.AllowMouseEffects = True
        Me.btn_back.AllowToggling = False
        Me.btn_back.AnimationSpeed = 200
        Me.btn_back.AutoGenerateColors = False
        Me.btn_back.AutoRoundBorders = False
        Me.btn_back.AutoSizeLeftIcon = True
        Me.btn_back.AutoSizeRightIcon = True
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_back.ButtonText = "Back"
        Me.btn_back.ButtonTextMarginLeft = 0
        Me.btn_back.ColorContrastOnClick = 45
        Me.btn_back.ColorContrastOnHover = 45
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btn_back.CustomizableEdges = BorderEdges1
        Me.btn_back.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_back.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_back.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_back.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_back.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_back.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_back.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btn_back.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btn_back.IconMarginLeft = 11
        Me.btn_back.IconPadding = 10
        Me.btn_back.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_back.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btn_back.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btn_back.IconSize = 25
        Me.btn_back.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btn_back.IdleBorderRadius = 20
        Me.btn_back.IdleBorderThickness = 1
        Me.btn_back.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_back.IdleIconLeftImage = Nothing
        Me.btn_back.IdleIconRightImage = Nothing
        Me.btn_back.IndicateFocus = False
        Me.btn_back.Location = New System.Drawing.Point(1213, 534)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_back.OnDisabledState.BorderRadius = 20
        Me.btn_back.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_back.OnDisabledState.BorderThickness = 1
        Me.btn_back.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_back.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_back.OnDisabledState.IconLeftImage = Nothing
        Me.btn_back.OnDisabledState.IconRightImage = Nothing
        Me.btn_back.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_back.onHoverState.BorderRadius = 20
        Me.btn_back.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_back.onHoverState.BorderThickness = 1
        Me.btn_back.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_back.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btn_back.onHoverState.IconLeftImage = Nothing
        Me.btn_back.onHoverState.IconRightImage = Nothing
        Me.btn_back.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_back.OnIdleState.BorderRadius = 20
        Me.btn_back.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_back.OnIdleState.BorderThickness = 1
        Me.btn_back.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_back.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btn_back.OnIdleState.IconLeftImage = Nothing
        Me.btn_back.OnIdleState.IconRightImage = Nothing
        Me.btn_back.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_back.OnPressedState.BorderRadius = 20
        Me.btn_back.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_back.OnPressedState.BorderThickness = 1
        Me.btn_back.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_back.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btn_back.OnPressedState.IconLeftImage = Nothing
        Me.btn_back.OnPressedState.IconRightImage = Nothing
        Me.btn_back.Size = New System.Drawing.Size(349, 41)
        Me.btn_back.TabIndex = 57
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_back.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_back.TextMarginLeft = 0
        Me.btn_back.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_back.UseDefaultRadiusAndThickness = True
        '
        'dgv_search
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgv_search.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_search.BackgroundColor = System.Drawing.Color.White
        Me.dgv_search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_search.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_search.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_search.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_search.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_search.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_search.EnableHeadersVisualStyles = False
        Me.dgv_search.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_search.Location = New System.Drawing.Point(169, 25)
        Me.dgv_search.Name = "dgv_search"
        Me.dgv_search.RowHeadersVisible = False
        Me.dgv_search.RowHeadersWidth = 51
        Me.dgv_search.RowTemplate.Height = 24
        Me.dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_search.Size = New System.Drawing.Size(1343, 452)
        Me.dgv_search.TabIndex = 0
        Me.dgv_search.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgv_search.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_search.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_search.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_search.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_search.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_search.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_search.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_search.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_search.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_search.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_search.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_search.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_search.ThemeStyle.HeaderStyle.Height = 4
        Me.dgv_search.ThemeStyle.ReadOnly = False
        Me.dgv_search.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_search.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_search.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_search.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_search.ThemeStyle.RowsStyle.Height = 24
        Me.dgv_search.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_search.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1674, 645)
        Me.Controls.Add(Me.pnl_search)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "search"
        Me.Text = "search"
        Me.pnl_search.ResumeLayout(False)
        CType(Me.dgv_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_search As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents btn_back As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Public WithEvents dgv_search As Guna.UI.WinForms.GunaDataGridView
End Class
