<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalorieCalculator
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
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblActivityLevel = New System.Windows.Forms.Label()
        Me.cboAct = New System.Windows.Forms.ComboBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblGeneralInfo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblBodyFat = New System.Windows.Forms.Label()
        Me.lblWaist = New System.Windows.Forms.Label()
        Me.lblWrist = New System.Windows.Forms.Label()
        Me.lblHip = New System.Windows.Forms.Label()
        Me.lblForearm = New System.Windows.Forms.Label()
        Me.txtWaist = New System.Windows.Forms.TextBox()
        Me.txtWrist = New System.Windows.Forms.TextBox()
        Me.txtHip = New System.Windows.Forms.TextBox()
        Me.txtForearm = New System.Windows.Forms.TextBox()
        Me.lbxUsers = New System.Windows.Forms.ListBox()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.cboMetricImperial = New System.Windows.Forms.ComboBox()
        Me.lblCurrentUserReport = New System.Windows.Forms.Label()
        Me.lblReportName = New System.Windows.Forms.Label()
        Me.lblReportHeight = New System.Windows.Forms.Label()
        Me.lblReportWeight = New System.Windows.Forms.Label()
        Me.lblReportAge = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBMR = New System.Windows.Forms.Label()
        Me.lblActivityMR = New System.Windows.Forms.Label()
        Me.lblActivity = New System.Windows.Forms.Label()
        Me.lblBodyFatPercent = New System.Windows.Forms.Label()
        Me.lblCURBodyFatPercent = New System.Windows.Forms.Label()
        Me.lblCURActivity = New System.Windows.Forms.Label()
        Me.lblCURActivityMR = New System.Windows.Forms.Label()
        Me.lblCURBMR = New System.Windows.Forms.Label()
        Me.lblCURGender = New System.Windows.Forms.Label()
        Me.lblCURName = New System.Windows.Forms.Label()
        Me.lblCURHeight = New System.Windows.Forms.Label()
        Me.lblCURWeight = New System.Windows.Forms.Label()
        Me.lblCURAge = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Silver
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(38, 172)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(67, 13)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Enter Age:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.BackColor = System.Drawing.Color.Silver
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(20, 130)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(85, 13)
        Me.lblWeight.TabIndex = 3
        Me.lblWeight.Text = "Enter Weight:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.BackColor = System.Drawing.Color.Silver
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(23, 85)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(82, 13)
        Me.lblHeight.TabIndex = 5
        Me.lblHeight.Text = "Enter Height:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(127, 165)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(212, 20)
        Me.txtAge.TabIndex = 4
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(127, 130)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(212, 20)
        Me.txtWeight.TabIndex = 3
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(127, 87)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(212, 20)
        Me.txtHeight.TabIndex = 2
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Location = New System.Drawing.Point(127, 212)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(212, 21)
        Me.cboSex.TabIndex = 5
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.BackColor = System.Drawing.Color.Silver
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(73, 212)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(32, 13)
        Me.lblSex.TabIndex = 7
        Me.lblSex.Text = "Sex:"
        '
        'lblActivityLevel
        '
        Me.lblActivityLevel.AutoSize = True
        Me.lblActivityLevel.BackColor = System.Drawing.Color.Silver
        Me.lblActivityLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityLevel.Location = New System.Drawing.Point(17, 254)
        Me.lblActivityLevel.Name = "lblActivityLevel"
        Me.lblActivityLevel.Size = New System.Drawing.Size(88, 13)
        Me.lblActivityLevel.TabIndex = 9
        Me.lblActivityLevel.Text = "Activity Level:"
        '
        'cboAct
        '
        Me.cboAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAct.FormattingEnabled = True
        Me.cboAct.Location = New System.Drawing.Point(127, 246)
        Me.cboAct.Name = "cboAct"
        Me.cboAct.Size = New System.Drawing.Size(212, 21)
        Me.cboAct.TabIndex = 6
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(262, 316)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(137, 28)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "Calculate Fitness"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(423, 316)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 28)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblGeneralInfo
        '
        Me.lblGeneralInfo.AutoSize = True
        Me.lblGeneralInfo.BackColor = System.Drawing.Color.Silver
        Me.lblGeneralInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralInfo.Location = New System.Drawing.Point(21, 21)
        Me.lblGeneralInfo.Name = "lblGeneralInfo"
        Me.lblGeneralInfo.Size = New System.Drawing.Size(118, 13)
        Me.lblGeneralInfo.TabIndex = 17
        Me.lblGeneralInfo.Text = "General Information"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Silver
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(58, 51)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 13)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "Name: "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(127, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(212, 20)
        Me.txtName.TabIndex = 1
        '
        'lblBodyFat
        '
        Me.lblBodyFat.AutoSize = True
        Me.lblBodyFat.BackColor = System.Drawing.Color.Silver
        Me.lblBodyFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodyFat.Location = New System.Drawing.Point(4, 331)
        Me.lblBodyFat.Name = "lblBodyFat"
        Me.lblBodyFat.Size = New System.Drawing.Size(135, 13)
        Me.lblBodyFat.TabIndex = 20
        Me.lblBodyFat.Text = "Body Fat Measurments"
        '
        'lblWaist
        '
        Me.lblWaist.AutoSize = True
        Me.lblWaist.BackColor = System.Drawing.Color.Silver
        Me.lblWaist.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaist.Location = New System.Drawing.Point(58, 376)
        Me.lblWaist.Name = "lblWaist"
        Me.lblWaist.Size = New System.Drawing.Size(43, 13)
        Me.lblWaist.TabIndex = 21
        Me.lblWaist.Text = "Waist:"
        '
        'lblWrist
        '
        Me.lblWrist.AutoSize = True
        Me.lblWrist.BackColor = System.Drawing.Color.Silver
        Me.lblWrist.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrist.Location = New System.Drawing.Point(58, 403)
        Me.lblWrist.Name = "lblWrist"
        Me.lblWrist.Size = New System.Drawing.Size(40, 13)
        Me.lblWrist.TabIndex = 22
        Me.lblWrist.Text = "Wrist:"
        '
        'lblHip
        '
        Me.lblHip.AutoSize = True
        Me.lblHip.BackColor = System.Drawing.Color.Silver
        Me.lblHip.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHip.Location = New System.Drawing.Point(58, 430)
        Me.lblHip.Name = "lblHip"
        Me.lblHip.Size = New System.Drawing.Size(30, 13)
        Me.lblHip.TabIndex = 23
        Me.lblHip.Text = "Hip:"
        '
        'lblForearm
        '
        Me.lblForearm.AutoSize = True
        Me.lblForearm.BackColor = System.Drawing.Color.Silver
        Me.lblForearm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForearm.Location = New System.Drawing.Point(58, 457)
        Me.lblForearm.Name = "lblForearm"
        Me.lblForearm.Size = New System.Drawing.Size(60, 13)
        Me.lblForearm.TabIndex = 24
        Me.lblForearm.Text = "Forearm: "
        '
        'txtWaist
        '
        Me.txtWaist.Location = New System.Drawing.Point(127, 369)
        Me.txtWaist.Name = "txtWaist"
        Me.txtWaist.Size = New System.Drawing.Size(128, 20)
        Me.txtWaist.TabIndex = 7
        '
        'txtWrist
        '
        Me.txtWrist.Location = New System.Drawing.Point(127, 396)
        Me.txtWrist.Name = "txtWrist"
        Me.txtWrist.Size = New System.Drawing.Size(128, 20)
        Me.txtWrist.TabIndex = 8
        '
        'txtHip
        '
        Me.txtHip.Location = New System.Drawing.Point(127, 426)
        Me.txtHip.Name = "txtHip"
        Me.txtHip.Size = New System.Drawing.Size(128, 20)
        Me.txtHip.TabIndex = 9
        '
        'txtForearm
        '
        Me.txtForearm.Location = New System.Drawing.Point(127, 453)
        Me.txtForearm.Name = "txtForearm"
        Me.txtForearm.Size = New System.Drawing.Size(128, 20)
        Me.txtForearm.TabIndex = 10
        '
        'lbxUsers
        '
        Me.lbxUsers.FormattingEnabled = True
        Me.lbxUsers.Location = New System.Drawing.Point(310, 369)
        Me.lbxUsers.Name = "lbxUsers"
        Me.lbxUsers.Size = New System.Drawing.Size(208, 160)
        Me.lbxUsers.TabIndex = 14
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.BackColor = System.Drawing.Color.Silver
        Me.lblUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsers.Location = New System.Drawing.Point(307, 353)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(43, 13)
        Me.lblUsers.TabIndex = 30
        Me.lblUsers.Text = "Users:"
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.BackColor = System.Drawing.Color.Silver
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(607, 21)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(53, 13)
        Me.lblSettings.TabIndex = 31
        Me.lblSettings.Text = "Settings"
        '
        'cboMetricImperial
        '
        Me.cboMetricImperial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMetricImperial.FormattingEnabled = True
        Me.cboMetricImperial.Location = New System.Drawing.Point(668, 43)
        Me.cboMetricImperial.Name = "cboMetricImperial"
        Me.cboMetricImperial.Size = New System.Drawing.Size(212, 21)
        Me.cboMetricImperial.TabIndex = 11
        '
        'lblCurrentUserReport
        '
        Me.lblCurrentUserReport.AutoSize = True
        Me.lblCurrentUserReport.BackColor = System.Drawing.Color.Silver
        Me.lblCurrentUserReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUserReport.Location = New System.Drawing.Point(607, 172)
        Me.lblCurrentUserReport.Name = "lblCurrentUserReport"
        Me.lblCurrentUserReport.Size = New System.Drawing.Size(120, 13)
        Me.lblCurrentUserReport.TabIndex = 33
        Me.lblCurrentUserReport.Text = "Current User Report"
        '
        'lblReportName
        '
        Me.lblReportName.AutoSize = True
        Me.lblReportName.BackColor = System.Drawing.Color.Silver
        Me.lblReportName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportName.Location = New System.Drawing.Point(649, 220)
        Me.lblReportName.Name = "lblReportName"
        Me.lblReportName.Size = New System.Drawing.Size(47, 13)
        Me.lblReportName.TabIndex = 37
        Me.lblReportName.Text = "Name: "
        '
        'lblReportHeight
        '
        Me.lblReportHeight.AutoSize = True
        Me.lblReportHeight.BackColor = System.Drawing.Color.Silver
        Me.lblReportHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportHeight.Location = New System.Drawing.Point(648, 249)
        Me.lblReportHeight.Name = "lblReportHeight"
        Me.lblReportHeight.Size = New System.Drawing.Size(48, 13)
        Me.lblReportHeight.TabIndex = 36
        Me.lblReportHeight.Text = "Height:"
        '
        'lblReportWeight
        '
        Me.lblReportWeight.AutoSize = True
        Me.lblReportWeight.BackColor = System.Drawing.Color.Silver
        Me.lblReportWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportWeight.Location = New System.Drawing.Point(645, 281)
        Me.lblReportWeight.Name = "lblReportWeight"
        Me.lblReportWeight.Size = New System.Drawing.Size(51, 13)
        Me.lblReportWeight.TabIndex = 35
        Me.lblReportWeight.Text = "Weight:"
        '
        'lblReportAge
        '
        Me.lblReportAge.AutoSize = True
        Me.lblReportAge.BackColor = System.Drawing.Color.Silver
        Me.lblReportAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportAge.Location = New System.Drawing.Point(663, 316)
        Me.lblReportAge.Name = "lblReportAge"
        Me.lblReportAge.Size = New System.Drawing.Size(33, 13)
        Me.lblReportAge.TabIndex = 34
        Me.lblReportAge.Text = "Age:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(644, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Gender:"
        '
        'lblBMR
        '
        Me.lblBMR.AutoSize = True
        Me.lblBMR.BackColor = System.Drawing.Color.Silver
        Me.lblBMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMR.Location = New System.Drawing.Point(658, 385)
        Me.lblBMR.Name = "lblBMR"
        Me.lblBMR.Size = New System.Drawing.Size(38, 13)
        Me.lblBMR.TabIndex = 39
        Me.lblBMR.Text = "BMR:"
        '
        'lblActivityMR
        '
        Me.lblActivityMR.AutoSize = True
        Me.lblActivityMR.BackColor = System.Drawing.Color.Silver
        Me.lblActivityMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityMR.Location = New System.Drawing.Point(620, 414)
        Me.lblActivityMR.Name = "lblActivityMR"
        Me.lblActivityMR.Size = New System.Drawing.Size(76, 13)
        Me.lblActivityMR.TabIndex = 40
        Me.lblActivityMR.Text = "Activity MR:"
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.BackColor = System.Drawing.Color.Silver
        Me.lblActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivity.Location = New System.Drawing.Point(643, 444)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(53, 13)
        Me.lblActivity.TabIndex = 41
        Me.lblActivity.Text = "Activity:"
        '
        'lblBodyFatPercent
        '
        Me.lblBodyFatPercent.AutoSize = True
        Me.lblBodyFatPercent.BackColor = System.Drawing.Color.Silver
        Me.lblBodyFatPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodyFatPercent.Location = New System.Drawing.Point(622, 477)
        Me.lblBodyFatPercent.Name = "lblBodyFatPercent"
        Me.lblBodyFatPercent.Size = New System.Drawing.Size(74, 13)
        Me.lblBodyFatPercent.TabIndex = 42
        Me.lblBodyFatPercent.Text = "Body Fat %:"
        '
        'lblCURBodyFatPercent
        '
        Me.lblCURBodyFatPercent.AutoSize = True
        Me.lblCURBodyFatPercent.BackColor = System.Drawing.Color.Silver
        Me.lblCURBodyFatPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCURBodyFatPercent.Location = New System.Drawing.Point(711, 477)
        Me.lblCURBodyFatPercent.Name = "lblCURBodyFatPercent"
        Me.lblCURBodyFatPercent.Size = New System.Drawing.Size(12, 13)
        Me.lblCURBodyFatPercent.TabIndex = 51
        Me.lblCURBodyFatPercent.Text = "*"
        '
        'lblCURActivity
        '
        Me.lblCURActivity.AutoSize = True
        Me.lblCURActivity.BackColor = System.Drawing.Color.Silver
        Me.lblCURActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCURActivity.Location = New System.Drawing.Point(711, 444)
        Me.lblCURActivity.Name = "lblCURActivity"
        Me.lblCURActivity.Size = New System.Drawing.Size(12, 13)
        Me.lblCURActivity.TabIndex = 50
        Me.lblCURActivity.Text = "*"
        '
        'lblCURActivityMR
        '
        Me.lblCURActivityMR.AutoSize = True
        Me.lblCURActivityMR.BackColor = System.Drawing.Color.Silver
        Me.lblCURActivityMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCURActivityMR.Location = New System.Drawing.Point(711, 414)
        Me.lblCURActivityMR.Name = "lblCURActivityMR"
        Me.lblCURActivityMR.Size = New System.Drawing.Size(12, 13)
        Me.lblCURActivityMR.TabIndex = 49
        Me.lblCURActivityMR.Text = "*"
        '
        'lblCURBMR
        '
        Me.lblCURBMR.AutoSize = True
        Me.lblCURBMR.BackColor = System.Drawing.Color.Silver
        Me.lblCURBMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCURBMR.Location = New System.Drawing.Point(711, 385)
        Me.lblCURBMR.Name = "lblCURBMR"
        Me.lblCURBMR.Size = New System.Drawing.Size(12, 13)
        Me.lblCURBMR.TabIndex = 48
        Me.lblCURBMR.Text = "*"
        '
        'lblCURGender
        '
        Me.lblCURGender.AutoSize = True
        Me.lblCURGender.BackColor = System.Drawing.Color.Silver
        Me.lblCURGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCURGender.Location = New System.Drawing.Point(711, 353)
        Me.lblCURGender.Name = "lblCURGender"
        Me.lblCURGender.Size = New System.Drawing.Size(12, 13)
        Me.lblCURGender.TabIndex = 47
        Me.lblCURGender.Text = "*"
        '
        'lblCURName
        '
        Me.lblCURName.AutoSize = True
        Me.lblCURName.BackColor = System.Drawing.Color.Silver
        Me.lblCURName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCURName.Location = New System.Drawing.Point(711, 220)
        Me.lblCURName.Name = "lblCURName"
        Me.lblCURName.Size = New System.Drawing.Size(12, 13)
        Me.lblCURName.TabIndex = 46
        Me.lblCURName.Text = "*"
        '
        'lblCURHeight
        '
        Me.lblCURHeight.AutoSize = True
        Me.lblCURHeight.BackColor = System.Drawing.Color.Silver
        Me.lblCURHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCURHeight.Location = New System.Drawing.Point(711, 249)
        Me.lblCURHeight.Name = "lblCURHeight"
        Me.lblCURHeight.Size = New System.Drawing.Size(12, 13)
        Me.lblCURHeight.TabIndex = 45
        Me.lblCURHeight.Text = "*"
        '
        'lblCURWeight
        '
        Me.lblCURWeight.AutoSize = True
        Me.lblCURWeight.BackColor = System.Drawing.Color.Silver
        Me.lblCURWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCURWeight.Location = New System.Drawing.Point(711, 281)
        Me.lblCURWeight.Name = "lblCURWeight"
        Me.lblCURWeight.Size = New System.Drawing.Size(12, 13)
        Me.lblCURWeight.TabIndex = 44
        Me.lblCURWeight.Text = "*"
        '
        'lblCURAge
        '
        Me.lblCURAge.AutoSize = True
        Me.lblCURAge.BackColor = System.Drawing.Color.Silver
        Me.lblCURAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCURAge.Location = New System.Drawing.Point(711, 316)
        Me.lblCURAge.Name = "lblCURAge"
        Me.lblCURAge.Size = New System.Drawing.Size(12, 13)
        Me.lblCURAge.TabIndex = 43
        Me.lblCURAge.Text = "*"
        '
        'frmCalorieCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(921, 616)
        Me.Controls.Add(Me.lblCURBodyFatPercent)
        Me.Controls.Add(Me.lblCURActivity)
        Me.Controls.Add(Me.lblCURActivityMR)
        Me.Controls.Add(Me.lblCURBMR)
        Me.Controls.Add(Me.lblCURGender)
        Me.Controls.Add(Me.lblCURName)
        Me.Controls.Add(Me.lblCURHeight)
        Me.Controls.Add(Me.lblCURWeight)
        Me.Controls.Add(Me.lblCURAge)
        Me.Controls.Add(Me.lblBodyFatPercent)
        Me.Controls.Add(Me.lblActivity)
        Me.Controls.Add(Me.lblActivityMR)
        Me.Controls.Add(Me.lblBMR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblReportName)
        Me.Controls.Add(Me.lblReportHeight)
        Me.Controls.Add(Me.lblReportWeight)
        Me.Controls.Add(Me.lblReportAge)
        Me.Controls.Add(Me.lblCurrentUserReport)
        Me.Controls.Add(Me.cboMetricImperial)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.lblUsers)
        Me.Controls.Add(Me.lbxUsers)
        Me.Controls.Add(Me.txtForearm)
        Me.Controls.Add(Me.txtHip)
        Me.Controls.Add(Me.txtWrist)
        Me.Controls.Add(Me.txtWaist)
        Me.Controls.Add(Me.lblForearm)
        Me.Controls.Add(Me.lblHip)
        Me.Controls.Add(Me.lblWrist)
        Me.Controls.Add(Me.lblWaist)
        Me.Controls.Add(Me.lblBodyFat)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblGeneralInfo)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.cboAct)
        Me.Controls.Add(Me.lblActivityLevel)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblAge)
        Me.Name = "frmCalorieCalculator"
        Me.Text = "Calorie Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAge As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents cboSex As ComboBox
    Friend WithEvents lblSex As Label
    Friend WithEvents lblActivityLevel As Label
    Friend WithEvents cboAct As ComboBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblGeneralInfo As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblBodyFat As Label
    Friend WithEvents lblWaist As Label
    Friend WithEvents lblWrist As Label
    Friend WithEvents lblHip As Label
    Friend WithEvents lblForearm As Label
    Friend WithEvents txtWaist As TextBox
    Friend WithEvents txtWrist As TextBox
    Friend WithEvents txtHip As TextBox
    Friend WithEvents txtForearm As TextBox
    Friend WithEvents lbxUsers As ListBox
    Friend WithEvents lblUsers As Label
    Friend WithEvents lblSettings As Label
    Friend WithEvents cboMetricImperial As ComboBox
    Friend WithEvents lblCurrentUserReport As Label
    Friend WithEvents lblReportName As Label
    Friend WithEvents lblReportHeight As Label
    Friend WithEvents lblReportWeight As Label
    Friend WithEvents lblReportAge As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBMR As Label
    Friend WithEvents lblActivityMR As Label
    Friend WithEvents lblActivity As Label
    Friend WithEvents lblBodyFatPercent As Label
    Friend WithEvents lblCURBodyFatPercent As Label
    Friend WithEvents lblCURActivity As Label
    Friend WithEvents lblCURActivityMR As Label
    Friend WithEvents lblCURBMR As Label
    Friend WithEvents lblCURGender As Label
    Friend WithEvents lblCURName As Label
    Friend WithEvents lblCURHeight As Label
    Friend WithEvents lblCURWeight As Label
    Friend WithEvents lblCURAge As Label
End Class
