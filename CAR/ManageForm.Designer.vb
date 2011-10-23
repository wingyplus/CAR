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
        Me.Field_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Phone = New System.Windows.Forms.Label()
        Me.Phone_TextBox = New System.Windows.Forms.TextBox()
        Me.Brand = New System.Windows.Forms.Label()
        Me.Brand_TextBox = New System.Windows.Forms.TextBox()
        Me.Plate = New System.Windows.Forms.Label()
        Me.Plate_TextBox = New System.Windows.Forms.TextBox()
        Me.StudentGroup = New System.Windows.Forms.GroupBox()
        Me.StudentReset_Button = New System.Windows.Forms.Button()
        Me.StudentSave_Button = New System.Windows.Forms.Button()
        Me.Index_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureCar = New System.Windows.Forms.Label()
        Me.Model_TextBox = New System.Windows.Forms.TextBox()
        Me.CarReset_Button = New System.Windows.Forms.Button()
        Me.CarSave_Button = New System.Windows.Forms.Button()
        Me.Model = New System.Windows.Forms.Label()
        Me.StudentOwner = New System.Windows.Forms.Label()
        Me.StudentOwner_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Browse_Button = New System.Windows.Forms.Button()
        Me.Path_TextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.StudentGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDTag
        '
        Me.IDTag.AutoSize = True
        Me.IDTag.Location = New System.Drawing.Point(23, 41)
        Me.IDTag.Name = "IDTag"
        Me.IDTag.Size = New System.Drawing.Size(48, 13)
        Me.IDTag.TabIndex = 0
        Me.IDTag.Text = "รหัสTAG"
        '
        'IDTag_TextBox
        '
        Me.IDTag_TextBox.Location = New System.Drawing.Point(111, 38)
        Me.IDTag_TextBox.Name = "IDTag_TextBox"
        Me.IDTag_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTag_TextBox.TabIndex = 1
        '
        'IDName
        '
        Me.IDName.AutoSize = True
        Me.IDName.Location = New System.Drawing.Point(54, 41)
        Me.IDName.Name = "IDName"
        Me.IDName.Size = New System.Drawing.Size(69, 13)
        Me.IDName.TabIndex = 2
        Me.IDName.Text = "รหัสนักศึกษา"
        '
        'IDName_TextBox
        '
        Me.IDName_TextBox.Location = New System.Drawing.Point(142, 38)
        Me.IDName_TextBox.Name = "IDName_TextBox"
        Me.IDName_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDName_TextBox.TabIndex = 3
        '
        'FName
        '
        Me.FName.AutoSize = True
        Me.FName.Location = New System.Drawing.Point(54, 76)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(20, 13)
        Me.FName.TabIndex = 4
        Me.FName.Text = "ชื่อ"
        '
        'FName_TextBox
        '
        Me.FName_TextBox.Location = New System.Drawing.Point(142, 73)
        Me.FName_TextBox.Name = "FName_TextBox"
        Me.FName_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.FName_TextBox.TabIndex = 5
        '
        'LName
        '
        Me.LName.AutoSize = True
        Me.LName.Location = New System.Drawing.Point(54, 111)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(46, 13)
        Me.LName.TabIndex = 6
        Me.LName.Text = "นามสกุล"
        '
        'LName_TextBox
        '
        Me.LName_TextBox.Location = New System.Drawing.Point(142, 108)
        Me.LName_TextBox.Name = "LName_TextBox"
        Me.LName_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.LName_TextBox.TabIndex = 7
        '
        'Dormitory
        '
        Me.Dormitory.AutoSize = True
        Me.Dormitory.Location = New System.Drawing.Point(54, 146)
        Me.Dormitory.Name = "Dormitory"
        Me.Dormitory.Size = New System.Drawing.Size(35, 13)
        Me.Dormitory.TabIndex = 8
        Me.Dormitory.Text = "หอพัก"
        '
        'Dorm_TextBox
        '
        Me.Dorm_TextBox.Location = New System.Drawing.Point(142, 143)
        Me.Dorm_TextBox.Name = "Dorm_TextBox"
        Me.Dorm_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dorm_TextBox.TabIndex = 9
        '
        'Institute
        '
        Me.Institute.AutoSize = True
        Me.Institute.Location = New System.Drawing.Point(54, 181)
        Me.Institute.Name = "Institute"
        Me.Institute.Size = New System.Drawing.Size(73, 13)
        Me.Institute.TabIndex = 11
        Me.Institute.Text = "คณะ/สาขาวิชา"
        '
        'Field_ComboBox
        '
        Me.Field_ComboBox.FormattingEnabled = True
        Me.Field_ComboBox.Items.AddRange(New Object() {"ยังไม่สังกัดสาขา", "วิศวกรรมการผลิต", "วิศวกรรมเกษตรและอาหาร", "วิศวกรรมขนส่ง", "วิศวกรรมคอมพิวเตอร์", "วิศวกรรมเคมี", "วิศวกรรมเครื่องกล", "วิศวกรรมเซรามิก", "วิศวกรรมโทรคมนาคม", "วิศวกรรมพอลิเมอร์", "วิศวกรรมไฟฟ้า", "วิศวกรรมโยธา", "วิศวกรรมโลหการ", "วิศวกรรมสิ่งแวดล้อม", "วิศวกรรมอุตสาหการ", "วิศวกรรมอิเล็กทรอนิกส์", "วิศวกรรมอากาศยาน", "วิศกรรมยานยนต์", "เทคโนโลยีธรณี"})
        Me.Field_ComboBox.Location = New System.Drawing.Point(142, 178)
        Me.Field_ComboBox.Name = "Field_ComboBox"
        Me.Field_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Field_ComboBox.TabIndex = 12
        '
        'Phone
        '
        Me.Phone.AutoSize = True
        Me.Phone.Location = New System.Drawing.Point(54, 216)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(72, 13)
        Me.Phone.TabIndex = 13
        Me.Phone.Text = "เบอร์โทรศัพท์"
        '
        'Phone_TextBox
        '
        Me.Phone_TextBox.Location = New System.Drawing.Point(142, 213)
        Me.Phone_TextBox.Name = "Phone_TextBox"
        Me.Phone_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Phone_TextBox.TabIndex = 14
        '
        'Brand
        '
        Me.Brand.AutoSize = True
        Me.Brand.Location = New System.Drawing.Point(23, 111)
        Me.Brand.Name = "Brand"
        Me.Brand.Size = New System.Drawing.Size(27, 13)
        Me.Brand.TabIndex = 15
        Me.Brand.Text = "ยี่ห้อ"
        '
        'Brand_TextBox
        '
        Me.Brand_TextBox.Location = New System.Drawing.Point(111, 108)
        Me.Brand_TextBox.Name = "Brand_TextBox"
        Me.Brand_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Brand_TextBox.TabIndex = 16
        '
        'Plate
        '
        Me.Plate.AutoSize = True
        Me.Plate.Location = New System.Drawing.Point(23, 76)
        Me.Plate.Name = "Plate"
        Me.Plate.Size = New System.Drawing.Size(59, 13)
        Me.Plate.TabIndex = 17
        Me.Plate.Text = "ทะเบียนรถ"
        '
        'Plate_TextBox
        '
        Me.Plate_TextBox.Location = New System.Drawing.Point(111, 73)
        Me.Plate_TextBox.Name = "Plate_TextBox"
        Me.Plate_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Plate_TextBox.TabIndex = 18
        '
        'StudentGroup
        '
        Me.StudentGroup.Controls.Add(Me.StudentReset_Button)
        Me.StudentGroup.Controls.Add(Me.StudentSave_Button)
        Me.StudentGroup.Controls.Add(Me.IDName)
        Me.StudentGroup.Controls.Add(Me.IDName_TextBox)
        Me.StudentGroup.Controls.Add(Me.FName)
        Me.StudentGroup.Controls.Add(Me.Phone_TextBox)
        Me.StudentGroup.Controls.Add(Me.FName_TextBox)
        Me.StudentGroup.Controls.Add(Me.Phone)
        Me.StudentGroup.Controls.Add(Me.LName)
        Me.StudentGroup.Controls.Add(Me.Field_ComboBox)
        Me.StudentGroup.Controls.Add(Me.LName_TextBox)
        Me.StudentGroup.Controls.Add(Me.Institute)
        Me.StudentGroup.Controls.Add(Me.Dormitory)
        Me.StudentGroup.Controls.Add(Me.Dorm_TextBox)
        Me.StudentGroup.Location = New System.Drawing.Point(24, 21)
        Me.StudentGroup.Name = "StudentGroup"
        Me.StudentGroup.Size = New System.Drawing.Size(304, 301)
        Me.StudentGroup.TabIndex = 19
        Me.StudentGroup.TabStop = False
        Me.StudentGroup.Text = "ข้อมูลนักศึกษา"
        '
        'StudentReset_Button
        '
        Me.StudentReset_Button.Location = New System.Drawing.Point(167, 253)
        Me.StudentReset_Button.Name = "StudentReset_Button"
        Me.StudentReset_Button.Size = New System.Drawing.Size(75, 23)
        Me.StudentReset_Button.TabIndex = 20
        Me.StudentReset_Button.Text = "ล้างข้อมูล"
        Me.StudentReset_Button.UseVisualStyleBackColor = True
        '
        'StudentSave_Button
        '
        Me.StudentSave_Button.Location = New System.Drawing.Point(57, 253)
        Me.StudentSave_Button.Name = "StudentSave_Button"
        Me.StudentSave_Button.Size = New System.Drawing.Size(75, 23)
        Me.StudentSave_Button.TabIndex = 19
        Me.StudentSave_Button.Text = "บันทึกข้อมูล"
        Me.StudentSave_Button.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Path_TextBox)
        Me.GroupBox1.Controls.Add(Me.Browse_Button)
        Me.GroupBox1.Controls.Add(Me.PictureCar)
        Me.GroupBox1.Controls.Add(Me.Model_TextBox)
        Me.GroupBox1.Controls.Add(Me.CarReset_Button)
        Me.GroupBox1.Controls.Add(Me.CarSave_Button)
        Me.GroupBox1.Controls.Add(Me.Model)
        Me.GroupBox1.Controls.Add(Me.StudentOwner)
        Me.GroupBox1.Controls.Add(Me.StudentOwner_ComboBox)
        Me.GroupBox1.Controls.Add(Me.IDTag)
        Me.GroupBox1.Controls.Add(Me.Brand_TextBox)
        Me.GroupBox1.Controls.Add(Me.Brand)
        Me.GroupBox1.Controls.Add(Me.Plate_TextBox)
        Me.GroupBox1.Controls.Add(Me.IDTag_TextBox)
        Me.GroupBox1.Controls.Add(Me.Plate)
        Me.GroupBox1.Location = New System.Drawing.Point(421, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 301)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลรถ"
        '
        'PictureCar
        '
        Me.PictureCar.AutoSize = True
        Me.PictureCar.Location = New System.Drawing.Point(23, 216)
        Me.PictureCar.Name = "PictureCar"
        Me.PictureCar.Size = New System.Drawing.Size(40, 13)
        Me.PictureCar.TabIndex = 25
        Me.PictureCar.Text = "รูปภาพ"
        '
        'Model_TextBox
        '
        Me.Model_TextBox.Location = New System.Drawing.Point(111, 143)
        Me.Model_TextBox.Name = "Model_TextBox"
        Me.Model_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Model_TextBox.TabIndex = 24
        '
        'CarReset_Button
        '
        Me.CarReset_Button.Location = New System.Drawing.Point(147, 252)
        Me.CarReset_Button.Name = "CarReset_Button"
        Me.CarReset_Button.Size = New System.Drawing.Size(75, 23)
        Me.CarReset_Button.TabIndex = 22
        Me.CarReset_Button.Text = "ล้างข้อมูล"
        Me.CarReset_Button.UseVisualStyleBackColor = True
        '
        'CarSave_Button
        '
        Me.CarSave_Button.Location = New System.Drawing.Point(26, 253)
        Me.CarSave_Button.Name = "CarSave_Button"
        Me.CarSave_Button.Size = New System.Drawing.Size(75, 23)
        Me.CarSave_Button.TabIndex = 21
        Me.CarSave_Button.Text = "บันทึกข้อมูล"
        Me.CarSave_Button.UseVisualStyleBackColor = True
        '
        'Model
        '
        Me.Model.AutoSize = True
        Me.Model.Location = New System.Drawing.Point(23, 146)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(21, 13)
        Me.Model.TabIndex = 23
        Me.Model.Text = "รุ่น"
        '
        'StudentOwner
        '
        Me.StudentOwner.AutoSize = True
        Me.StudentOwner.Location = New System.Drawing.Point(23, 181)
        Me.StudentOwner.Name = "StudentOwner"
        Me.StudentOwner.Size = New System.Drawing.Size(40, 13)
        Me.StudentOwner.TabIndex = 20
        Me.StudentOwner.Text = "เจ้าของ"
        '
        'StudentOwner_ComboBox
        '
        Me.StudentOwner_ComboBox.FormattingEnabled = True
        Me.StudentOwner_ComboBox.Location = New System.Drawing.Point(111, 178)
        Me.StudentOwner_ComboBox.Name = "StudentOwner_ComboBox"
        Me.StudentOwner_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StudentOwner_ComboBox.TabIndex = 19
        '
        'Browse_Button
        '
        Me.Browse_Button.Location = New System.Drawing.Point(238, 216)
        Me.Browse_Button.Name = "Browse_Button"
        Me.Browse_Button.Size = New System.Drawing.Size(75, 23)
        Me.Browse_Button.TabIndex = 26
        Me.Browse_Button.Text = "Browse"
        Me.Browse_Button.UseVisualStyleBackColor = True
        '
        'Path_TextBox
        '
        Me.Path_TextBox.Location = New System.Drawing.Point(111, 218)
        Me.Path_TextBox.Name = "Path_TextBox"
        Me.Path_TextBox.Size = New System.Drawing.Size(121, 20)
        Me.Path_TextBox.TabIndex = 27
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.InitialDirectory = "C:\"
        '
        'ManageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Index_Button)
        Me.Controls.Add(Me.StudentGroup)
        Me.Name = "ManageForm"
        Me.Text = "ManageForm"
        Me.StudentGroup.ResumeLayout(False)
        Me.StudentGroup.PerformLayout()
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
    Friend WithEvents Field_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Phone As System.Windows.Forms.Label
    Friend WithEvents Phone_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Brand As System.Windows.Forms.Label
    Friend WithEvents Brand_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Plate As System.Windows.Forms.Label
    Friend WithEvents Plate_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentGroup As System.Windows.Forms.GroupBox
    Friend WithEvents StudentReset_Button As System.Windows.Forms.Button
    Friend WithEvents StudentSave_Button As System.Windows.Forms.Button
    Friend WithEvents Index_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CarSave_Button As System.Windows.Forms.Button
    Friend WithEvents StudentOwner As System.Windows.Forms.Label
    Friend WithEvents StudentOwner_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CarReset_Button As System.Windows.Forms.Button
    Friend WithEvents PictureCar As System.Windows.Forms.Label
    Friend WithEvents Model_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Model As System.Windows.Forms.Label
    Friend WithEvents Path_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Browse_Button As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
