<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfo))
        Me.picInfoPic = New System.Windows.Forms.PictureBox()
        Me.chkShowPic = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.radBlack = New System.Windows.Forms.RadioButton()
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblCityInfo = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picInfoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picInfoPic
        '
        Me.picInfoPic.Image = CType(resources.GetObject("picInfoPic.Image"), System.Drawing.Image)
        Me.picInfoPic.Location = New System.Drawing.Point(29, 29)
        Me.picInfoPic.Name = "picInfoPic"
        Me.picInfoPic.Size = New System.Drawing.Size(118, 118)
        Me.picInfoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInfoPic.TabIndex = 0
        Me.picInfoPic.TabStop = False
        '
        'chkShowPic
        '
        Me.chkShowPic.AutoSize = True
        Me.chkShowPic.Checked = True
        Me.chkShowPic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowPic.Location = New System.Drawing.Point(29, 170)
        Me.chkShowPic.Name = "chkShowPic"
        Me.chkShowPic.Size = New System.Drawing.Size(89, 17)
        Me.chkShowPic.TabIndex = 1
        Me.chkShowPic.Text = "Show &Picture"
        Me.chkShowPic.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radGreen)
        Me.GroupBox1.Controls.Add(Me.radBlue)
        Me.GroupBox1.Controls.Add(Me.radRed)
        Me.GroupBox1.Controls.Add(Me.radBlack)
        Me.GroupBox1.Location = New System.Drawing.Point(200, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 132)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color"
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Location = New System.Drawing.Point(19, 102)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(54, 17)
        Me.radGreen.TabIndex = 3
        Me.radGreen.Text = "&Green"
        Me.ToolTip1.SetToolTip(Me.radGreen, "Display address in green")
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Location = New System.Drawing.Point(19, 79)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(46, 17)
        Me.radBlue.TabIndex = 2
        Me.radBlue.Text = "&Blue"
        Me.ToolTip1.SetToolTip(Me.radBlue, "Display address in blue")
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(19, 56)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(45, 17)
        Me.radRed.TabIndex = 1
        Me.radRed.Text = "&Red"
        Me.ToolTip1.SetToolTip(Me.radRed, "Display address in red")
        Me.radRed.UseVisualStyleBackColor = True
        '
        'radBlack
        '
        Me.radBlack.AutoSize = True
        Me.radBlack.Checked = True
        Me.radBlack.Location = New System.Drawing.Point(19, 31)
        Me.radBlack.Name = "radBlack"
        Me.radBlack.Size = New System.Drawing.Size(52, 17)
        Me.radBlack.TabIndex = 0
        Me.radBlack.TabStop = True
        Me.radBlack.Text = "&Black"
        Me.ToolTip1.SetToolTip(Me.radBlack, "Display address in black")
        Me.radBlack.UseVisualStyleBackColor = True
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Location = New System.Drawing.Point(71, 289)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnShowInfo.TabIndex = 3
        Me.btnShowInfo.Text = "&Show Info"
        Me.ToolTip1.SetToolTip(Me.btnShowInfo, "Display address")
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(200, 289)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Terminate project execution")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblName.Location = New System.Drawing.Point(200, 29)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(106, 16)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Jerrodo Butler"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblName.Visible = False
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet.Location = New System.Drawing.Point(200, 66)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(123, 16)
        Me.lblStreet.TabIndex = 6
        Me.lblStreet.Text = "13000 Marine Ln."
        Me.lblStreet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblStreet.Visible = False
        '
        'lblCityInfo
        '
        Me.lblCityInfo.AutoSize = True
        Me.lblCityInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityInfo.Location = New System.Drawing.Point(200, 106)
        Me.lblCityInfo.Name = "lblCityInfo"
        Me.lblCityInfo.Size = New System.Drawing.Size(153, 16)
        Me.lblCityInfo.TabIndex = 7
        Me.lblCityInfo.Text = "San Diego, CA 92100"
        Me.lblCityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCityInfo.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Form1
        '
        Me.AcceptButton = Me.btnShowInfo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(412, 350)
        Me.Controls.Add(Me.lblCityInfo)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkShowPic)
        Me.Controls.Add(Me.picInfoPic)
        Me.Name = "Form1"
        Me.Text = "My Information"
        CType(Me.picInfoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picInfoPic As PictureBox
    Friend WithEvents chkShowPic As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnShowInfo As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radRed As RadioButton
    Friend WithEvents radBlack As RadioButton
    Friend WithEvents radGreen As RadioButton
    Friend WithEvents lblName As Label
    Friend WithEvents lblStreet As Label
    Friend WithEvents lblCityInfo As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
