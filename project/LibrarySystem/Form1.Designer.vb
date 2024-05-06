<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserIdToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tsLogin = New System.Windows.Forms.ToolStripButton()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.btnUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCategories = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogs = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnBorrower = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBooks = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBorrow = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReturn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnOverdue = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.SignUpButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Utilities = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Utilities.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.UserIdToolStripStatus, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.UserToolStripStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 725)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.StatusStrip1.UseWaitCursor = True
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(29, 19)
        Me.ToolStripStatusLabel1.Text = "Id#"
        '
        'UserIdToolStripStatus
        '
        Me.UserIdToolStripStatus.Name = "UserIdToolStripStatus"
        Me.UserIdToolStripStatus.Size = New System.Drawing.Size(140, 19)
        Me.UserIdToolStripStatus.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(33, 19)
        Me.ToolStripStatusLabel2.Text = "###"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(37, 19)
        Me.ToolStripStatusLabel3.Text = "User"
        '
        'UserToolStripStatus
        '
        Me.UserToolStripStatus.Name = "UserToolStripStatus"
        Me.UserToolStripStatus.Size = New System.Drawing.Size(140, 19)
        Me.UserToolStripStatus.Text = "ToolStripStatusLabel4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(997, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 42)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date and Time"
        Me.GroupBox1.UseWaitCursor = True
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(7, 18)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(152, 21)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Label1"
        Me.lblDate.UseWaitCursor = True
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(190, 16)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(170, 23)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "Label1"
        Me.lblTime.UseWaitCursor = True
        '
        'Timer1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.tsLogin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1370, 54)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(69, 51)
        Me.ToolStripButton2.Text = "Find Books"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsLogin
        '
        Me.tsLogin.Image = CType(resources.GetObject("tsLogin.Image"), System.Drawing.Image)
        Me.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLogin.Name = "tsLogin"
        Me.tsLogin.Size = New System.Drawing.Size(41, 51)
        Me.tsLogin.Text = "Login"
        Me.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnUser
        '
        Me.btnUser.BorderRadius = 20
        Me.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUser.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.Black
        Me.btnUser.Location = New System.Drawing.Point(20, 148)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(157, 42)
        Me.btnUser.TabIndex = 8
        Me.btnUser.Text = "Manage User"
        Me.btnUser.UseWaitCursor = True
        '
        'btnCategories
        '
        Me.btnCategories.BorderRadius = 20
        Me.btnCategories.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCategories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCategories.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCategories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCategories.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategories.ForeColor = System.Drawing.Color.Black
        Me.btnCategories.Location = New System.Drawing.Point(240, 148)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(149, 45)
        Me.btnCategories.TabIndex = 7
        Me.btnCategories.Text = "Categories"
        Me.btnCategories.UseWaitCursor = True
        '
        'btnLogs
        '
        Me.btnLogs.BorderRadius = 20
        Me.btnLogs.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogs.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogs.ForeColor = System.Drawing.Color.Black
        Me.btnLogs.Location = New System.Drawing.Point(291, 145)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(166, 45)
        Me.btnLogs.TabIndex = 5
        Me.btnLogs.Text = "User Logs"
        Me.btnLogs.UseWaitCursor = True
        '
        'btnReports
        '
        Me.btnReports.BorderRadius = 20
        Me.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReports.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.Black
        Me.btnReports.Location = New System.Drawing.Point(24, 145)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(160, 45)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Books Inventory"
        Me.btnReports.UseWaitCursor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.BorderColor = System.Drawing.Color.Gray
        Me.GroupBox2.BorderRadius = 20
        Me.GroupBox2.Controls.Add(Me.Guna2PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Guna2PictureBox1)
        Me.GroupBox2.Controls.Add(Me.btnBorrower)
        Me.GroupBox2.Controls.Add(Me.btnBooks)
        Me.GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(11, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 221)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.Text = "Data Management"
        Me.GroupBox2.UseWaitCursor = True
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BorderRadius = 10
        Me.Guna2PictureBox2.Image = Global.LibrarySystem.My.Resources.Resources.pexels_rahul_pandit_1083633
        Me.Guna2PictureBox2.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(303, 43)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(223, 135)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 14
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseWaitCursor = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderRadius = 10
        Me.Guna2PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.pexels_pixabay_301920
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(29, 43)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(191, 135)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 13
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseWaitCursor = True
        '
        'btnBorrower
        '
        Me.btnBorrower.BorderRadius = 10
        Me.btnBorrower.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrower.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrower.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrower.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBorrower.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBorrower.ForeColor = System.Drawing.Color.Black
        Me.btnBorrower.Location = New System.Drawing.Point(303, 184)
        Me.btnBorrower.Name = "btnBorrower"
        Me.btnBorrower.Size = New System.Drawing.Size(166, 34)
        Me.btnBorrower.TabIndex = 12
        Me.btnBorrower.Text = "Borrower"
        Me.btnBorrower.UseWaitCursor = True
        '
        'btnBooks
        '
        Me.btnBooks.BorderRadius = 10
        Me.btnBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBooks.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBooks.ForeColor = System.Drawing.Color.Black
        Me.btnBooks.Location = New System.Drawing.Point(29, 184)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(124, 31)
        Me.btnBooks.TabIndex = 4
        Me.btnBooks.Text = "Books"
        Me.btnBooks.UseWaitCursor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.BorderRadius = 10
        Me.btnBorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBorrow.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBorrow.ForeColor = System.Drawing.Color.Black
        Me.btnBorrow.Location = New System.Drawing.Point(26, 125)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(117, 28)
        Me.btnBorrow.TabIndex = 11
        Me.btnBorrow.Text = "Borrow"
        Me.btnBorrow.UseWaitCursor = True
        '
        'btnReturn
        '
        Me.btnReturn.BorderRadius = 10
        Me.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReturn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnReturn.ForeColor = System.Drawing.Color.Black
        Me.btnReturn.Location = New System.Drawing.Point(165, 125)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(108, 28)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseWaitCursor = True
        '
        'btnOverdue
        '
        Me.btnOverdue.Animated = True
        Me.btnOverdue.BackColor = System.Drawing.Color.Transparent
        Me.btnOverdue.BorderRadius = 10
        Me.btnOverdue.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOverdue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOverdue.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOverdue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOverdue.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOverdue.ForeColor = System.Drawing.Color.Black
        Me.btnOverdue.Location = New System.Drawing.Point(359, 125)
        Me.btnOverdue.Name = "btnOverdue"
        Me.btnOverdue.Size = New System.Drawing.Size(124, 28)
        Me.btnOverdue.TabIndex = 9
        Me.btnOverdue.Text = "Overdue"
        Me.btnOverdue.UseTransparentBackground = True
        Me.btnOverdue.UseWaitCursor = True
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.btnOverdue)
        Me.Guna2GroupBox1.Controls.Add(Me.PictureBox6)
        Me.Guna2GroupBox1.Controls.Add(Me.PictureBox4)
        Me.Guna2GroupBox1.Controls.Add(Me.btnReturn)
        Me.Guna2GroupBox1.Controls.Add(Me.btnBorrow)
        Me.Guna2GroupBox1.Controls.Add(Me.PictureBox5)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(652, 118)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(544, 170)
        Me.Guna2GroupBox1.TabIndex = 15
        Me.Guna2GroupBox1.Text = "Transaction"
        Me.Guna2GroupBox1.UseWaitCursor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(360, 59)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(123, 60)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.UseWaitCursor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.LibrarySystem.My.Resources.Resources.return_box
        Me.PictureBox4.Location = New System.Drawing.Point(26, 59)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(123, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.UseWaitCursor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = Global.LibrarySystem.My.Resources.Resources.test
        Me.PictureBox5.Location = New System.Drawing.Point(165, 59)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(123, 60)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.UseWaitCursor = True
        '
        'SignUpButton
        '
        Me.SignUpButton.Animated = True
        Me.SignUpButton.BackColor = System.Drawing.Color.Transparent
        Me.SignUpButton.BorderRadius = 10
        Me.SignUpButton.BorderThickness = 1
        Me.SignUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SignUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SignUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SignUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SignUpButton.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SignUpButton.ForeColor = System.Drawing.Color.Black
        Me.SignUpButton.IndicateFocus = True
        Me.SignUpButton.Location = New System.Drawing.Point(474, 15)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(116, 33)
        Me.SignUpButton.TabIndex = 16
        Me.SignUpButton.Text = "Sign Up"
        Me.SignUpButton.UseTransparentBackground = True
        Me.SignUpButton.UseWaitCursor = True
        '
        'Utilities
        '
        Me.Utilities.BorderColor = System.Drawing.Color.Gray
        Me.Utilities.BorderRadius = 20
        Me.Utilities.Controls.Add(Me.PictureBox8)
        Me.Utilities.Controls.Add(Me.btnUser)
        Me.Utilities.Controls.Add(Me.btnCategories)
        Me.Utilities.Controls.Add(Me.PictureBox7)
        Me.Utilities.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Utilities.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Utilities.ForeColor = System.Drawing.Color.Black
        Me.Utilities.Location = New System.Drawing.Point(98, 387)
        Me.Utilities.Name = "Utilities"
        Me.Utilities.Size = New System.Drawing.Size(458, 200)
        Me.Utilities.TabIndex = 18
        Me.Utilities.Text = "User Management"
        Me.Utilities.UseWaitCursor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(20, 43)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(166, 99)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.UseWaitCursor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(240, 43)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(166, 99)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.UseWaitCursor = True
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Image = Global.LibrarySystem.My.Resources.Resources.education
        Me.PictureBox9.Location = New System.Drawing.Point(291, 43)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(166, 99)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 3
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.UseWaitCursor = True
        '
        'PictureBox10
        '
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox10.Image = Global.LibrarySystem.My.Resources.Resources.test
        Me.PictureBox10.Location = New System.Drawing.Point(24, 40)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(166, 99)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 2
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.UseWaitCursor = True
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox2.BorderRadius = 20
        Me.Guna2GroupBox2.Controls.Add(Me.btnReports)
        Me.Guna2GroupBox2.Controls.Add(Me.PictureBox9)
        Me.Guna2GroupBox2.Controls.Add(Me.btnLogs)
        Me.Guna2GroupBox2.Controls.Add(Me.PictureBox10)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(705, 387)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(491, 200)
        Me.Guna2GroupBox2.TabIndex = 19
        Me.Guna2GroupBox2.Text = "Reports"
        Me.Guna2GroupBox2.UseWaitCursor = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Location = New System.Drawing.Point(705, 15)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(120, 33)
        Me.Guna2Button1.TabIndex = 21
        Me.Guna2Button1.Text = "Login"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Utilities)
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Utilities.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserIdToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCategories As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBorrower As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBooks As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnReturn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnOverdue As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBorrow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents SignUpButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Utilities As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents tsLogin As ToolStripButton
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
