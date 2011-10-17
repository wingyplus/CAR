<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageForm
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
        Me.IDTag = New System.Windows.Forms.Label()
        Me.IDTag_TextBox = New System.Windows.Forms.TextBox()
        Me.IDName = New System.Windows.Forms.Label()
        Me.IDName_TextBox = New System.Windows.Forms.TextBox()
        Me.FName = New System.Windows.Forms.Label()
        Me.FName_TextBox = New System.Windows.Forms.TextBox()
        Me.LName = New System.Windows.Forms.Label()
        Me.LName_TextBox = New System.Windows.Forms.TextBox()
        Me.Dormitory = New System.Windows.Forms.Label()
        Me.Dorm_TextBox = New System.Windows.Forms.TextBox()
        Me.Institute = New System.Windows.Forms.Label()
        Me.Ins_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Phone = New System.Windows.Forms.Label()
        Me.Phone_TextBox = New System.Windows.Forms.TextBox()
        Me.Brand = New System.Windows.Forms.Label()
        Me.Brand_TextBox = New System.Windows.Forms.TextBox()
        Me.Plate = New System.Windows.Forms.Label()
        Me.Plate_TextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Reset_Button = New System.Windows.Forms.Button()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Index_Button = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDTag
        '
        Me.IDTag.AutoSize = True
        Me.IDTag.Location = New System.Drawing.Point(54, 31)
        Me.IDTag.Name = "IDTag"
        Me.IDTag.Size = New System.Drawing.Size(48, 13)
        Me.IDTag.TabIndex = 0
        Me.IDTag.Text = "รหัสTAG"
        '
        'IDTag_TextBox
        '
        Me.IDTag_TextBox.Location = New System.Drawing.Point(142, 28)
        Me.IDTag_TextBox.Name = "IDTag_TextBox"
        Me.IDTag_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTag_TextBox.TabIndex = 1
        '
        'IDName
        '
        Me.IDName.AutoSize = True
        Me.IDName.Location = New System.Drawing.Point(54, 66)
        Me.IDName.Name = "IDName"
        Me.IDName.Size = New System.Drawing.Size(69, 13)
        Me.IDName.TabIndex = 2
        Me.IDName.Text = "รหัสนักศึกษา"
        '
        'IDName_TextBox
        '
        Me.IDName_TextBox.Location = New System.Drawing.Point(142, 63)
        Me.IDName_TextBox.Name = "IDName_TextBox"
        Me.IDName_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDName_TextBox.TabIndex = 3
        '
        'FName
        '
        Me.FName.AutoSize = True
        Me.FName.Location = New System.Drawing.Point(54, 101)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(20, 13)
        Me.FName.TabIndex = 4
        Me.FName.Text = "ชื่อ"
        '
        'FName_TextBox
        '
        Me.FName_TextBox.Location = New System.Drawing.Point(142, 98)
        Me.FName_TextBox.Name = "FName_TextBox"
        Me.FName_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.FName_TextBox.TabIndex = 5
        '
        'LName
        '
        Me.LName.AutoSize = True
        Me.LName.Location = New System.Drawing.Point(54, 136)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(46, 13)
        Me.LName.TabIndex = 6
        Me.LName.Text = "นามสกุล"
        '
        'LName_TextBox
        '
        Me.LName_TextBox.Location = New System.Drawing.Point(142, 133)
        Me.LName_TextBox.Name = "LName_TextBox"
        Me.LName_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.LName_TextBox.TabIndex = 7
        '
        'Dormitory
        '
        Me.Dormitory.AutoSize = True
        Me.Dormitory.Location = New System.Drawing.Point(54, 171)
        Me.Dormitory.Name = "Dormitory"
        Me.Dormitory.Size = New System.Drawing.Size(35, 13)
        Me.Dormitory.TabIndex = 8
        Me.Dormitory.Text = "หอพัก"
        '
        'Dorm_TextBox
        '
        Me.Dorm_TextBox.Location = New System.Drawing.Point(142, 168)
        Me.Dorm_TextBox.Name = "Dorm_TextBox"
        Me.Dorm_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dorm_TextBox.TabIndex = 9
        '
        'Institute
        '
        Me.Institute.AutoSize = True
        Me.Institute.Location = New System.Drawing.Point(54, 206)
        Me.Institute.Name = "Institute"
        Me.Institute.Size = New System.Drawing.Size(61, 13)
        Me.Institute.TabIndex = 11
        Me.Institute.Text = "คณะ/หอพัก"
        '
        'Ins_ComboBox
        '
        Me.Ins_ComboBox.FormattingEnabled = True
        Me.Ins_ComboBox.Items.AddRange(New Object() {"ยังไม่สังกัดสาขา", "วิศวกรรมการผลิต", "วิศวกรรมเกษตรและอาหาร", "วิศวกรรมขนส่ง", "วิศวกรรมคอมพิวเตอร์", "วิศวกรรมเคมี", "วิศวกรรมเครื่องกล", "วิศวกรรมเซรามิก", "วิศวกรรมโทรคมนาคม", "วิศวกรรมพอลิเมอร์", "วิศวกรรมไฟฟ้า", "วิศวกรรมโยธา", "วิศวกรรมโลหการ", "วิศวกรรมสิ่งแวดล้อม", "วิศวกรรมอุตสาหการ", "วิศวกรรมอิเล็กทรอนิกส์", "วิศวกรรมอากาศยาน", "วิศกรรมยานยนต์", "เทคโนโลยีธรณี"})
        Me.Ins_ComboBox.Location = New System.Drawing.Point(142, 203)
        Me.Ins_ComboBox.Name = "Ins_ComboBox"
        Me.Ins_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Ins_ComboBox.TabIndex = 12
        '
        'Phone
        '
        Me.Phone.AutoSize = True
        Me.Phone.Location = New System.Drawing.Point(54, 241)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(72, 13)
        Me.Phone.TabIndex = 13
        Me.Phone.Text = "เบอร์โทรศัพท์"
        '
        'Phone_TextBox
        '
        Me.Phone_TextBox.Location = New System.Drawing.Point(142, 238)
        Me.Phone_TextBox.Name = "Phone_TextBox"
        Me.Phone_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Phone_TextBox.TabIndex = 14
        '
        'Brand
        '
        Me.Brand.AutoSize = True
        Me.Brand.Location = New System.Drawing.Point(54, 276)
        Me.Brand.Name = "Brand"
        Me.Brand.Size = New System.Drawing.Size(27, 13)
        Me.Brand.TabIndex = 15
        Me.Brand.Text = "ยี่ห้อ"
        '
        'Brand_TextBox
        '
        Me.Brand_TextBox.Location = New System.Drawing.Point(142, 273)
        Me.Brand_TextBox.Name = "Brand_TextBox"
        Me.Brand_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Brand_TextBox.TabIndex = 16
        '
        'Plate
        '
        Me.Plate.AutoSize = True
        Me.Plate.Location = New System.Drawing.Point(54, 311)
        Me.Plate.Name = "Plate"
        Me.Plate.Size = New System.Drawing.Size(59, 13)
        Me.Plate.TabIndex = 17
        Me.Plate.Text = "ทะเบียนรถ"
        '
        'Plate_TextBox
        '
        Me.Plate_TextBox.Location = New System.Drawing.Point(142, 308)
        Me.Plate_TextBox.Name = "Plate_TextBox"
        Me.Plate_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Plate_TextBox.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Reset_Button)
        Me.GroupBox1.Controls.Add(Me.Submit_Button)
        Me.GroupBox1.Controls.Add(Me.IDTag)
        Me.GroupBox1.Controls.Add(Me.Plate_TextBox)
        Me.GroupBox1.Controls.Add(Me.IDTag_TextBox)
        Me.GroupBox1.Controls.Add(Me.Plate)
        Me.GroupBox1.Controls.Add(Me.IDName)
        Me.GroupBox1.Controls.Add(Me.Brand_TextBox)
        Me.GroupBox1.Controls.Add(Me.IDName_TextBox)
        Me.GroupBox1.Controls.Add(Me.Brand)
        Me.GroupBox1.Controls.Add(Me.FName)
        Me.GroupBox1.Controls.Add(Me.Phone_TextBox)
        Me.GroupBox1.Controls.Add(Me.FName_TextBox)
        Me.GroupBox1.Controls.Add(Me.Phone)
        Me.GroupBox1.Controls.Add(Me.LName)
        Me.GroupBox1.Controls.Add(Me.Ins_ComboBox)
        Me.GroupBox1.Controls.Add(Me.LName_TextBox)
        Me.GroupBox1.Controls.Add(Me.Institute)
        Me.GroupBox1.Controls.Add(Me.Dormitory)
        Me.GroupBox1.Controls.Add(Me.Dorm_TextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 383)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Reset_Button
        '
        Me.Reset_Button.Location = New System.Drawing.Point(167, 344)
        Me.Reset_Button.Name = "Reset_Button"
        Me.Reset_Button.Size = New System.Drawing.Size(75, 23)
        Me.Reset_Button.TabIndex = 20
        Me.Reset_Button.Text = "ล้างข้อมูล"
        Me.Reset_Button.UseVisualStyleBackColor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(57, 344)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_Button.TabIndex = 19
        Me.Submit_Button.Text = "บันทึกข้อมูล"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Index_Button
        '
        Me.Index_Button.Location = New System.Drawing.Point(659, 527)
        Me.Index_Button.Name = "Index_Button"
        Me.Index_Button.Size = New System.Drawing.Size(113, 23)
        Me.Index_Button.TabIndex = 20
        Me.Index_Button.Text = "กลับสู่หน้าหลัก"
        Me.Index_Button.UseVisualStyleBackColor = True
        '
        'ManageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Index_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageForm"
        Me.Text = "ManageForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IDTag As System.Windows.Forms.Label
    Friend WithEvents IDTag_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDName As System.Windows.Forms.Label
    Friend WithEvents IDName_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents FName As System.Windows.Forms.Label
    Friend WithEvents FName_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents LName As System.Windows.Forms.Label
    Friend WithEvents LName_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dormitory As System.Windows.Forms.Label
    Friend WithEvents Dorm_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Institute As System.Windows.Forms.Label
    Friend WithEvents Ins_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Phone As System.Windows.Forms.Label
    Friend WithEvents Phone_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Brand As System.Windows.Forms.Label
    Friend WithEvents Brand_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Plate As System.Windows.Forms.Label
    Friend WithEvents Plate_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Reset_Button As System.Windows.Forms.Button
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Index_Button As System.Windows.Forms.Button
End Class
