Imports CarClassLibrary

Public Class ManageForm

    Private Sub ClearStudentForm()
        IDName_TextBox.Text = ""
        FName_TextBox.Text = ""
        LName_TextBox.Text = ""
        Dorm_TextBox.Text = ""
        Field_ComboBox.Text = ""
        Phone_TextBox.Text = ""
    End Sub

    Private Sub BindDataSource()
        Using dataCar As New DataCarEntities
            Dim students = From a In dataCar.Students
                           Select a.Id, a.FirstName, a.LastName
                           Order By Id Ascending
            StudentBindingSource.DataSource = students
        End Using
    End Sub

    '
    ' เรียกข้อมูลมาใส่ Owner_ComboBox
    '
    Private Sub ManageForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Using dataCar As New DataCarEntities
            Dim students = From a In dataCar.Students
                           Select a.Id, a.FirstName, a.LastName
                           Order By Id Ascending
            StudentBindingSource.DataSource = students
            For Each student In students
                StudentOwner_ComboBox.Items.Add(student.Id & "-" & student.FirstName & " " & student.LastName)
            Next
        End Using
    End Sub

    Private Sub Index_Button_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        IndexForm.Show()
    End Sub

    Private Sub StudentReset_Button_Click(sender As System.Object, e As System.EventArgs) Handles StudentReset_Button.Click
        ClearStudentForm()
    End Sub

    '
    ' นำข้อมูลจาก Field ต่างๆ ลงฐานข้อมูล
    '
    Private Sub StudentSave_Button_Click(sender As System.Object, e As System.EventArgs) Handles StudentSave_Button.Click
        Try
            Dim student As New Student
            student.Id = IDName_TextBox.Text.Trim
            student.FirstName = FName_TextBox.Text
            student.LastName = LName_TextBox.Text
            student.Dome = Dorm_TextBox.Text
            student.StudyField = Field_ComboBox.Text
            student.Phone = Phone_TextBox.Text
            Using entity As New DataCarEntities
                entity.Students.AddObject(student)
                entity.SaveChanges()
            End Using
        Catch ex As UpdateException
            MsgBox("ข้อมูลนี้มีอยู่แล้ว")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("บันทึกข้อมูลเรียบร้อย")
        StudentOwner_ComboBox.Items.Add(IDName_TextBox.Text & "-" & FName_TextBox.Text & " " & LName_TextBox.Text)
        ClearStudentForm()
        BindDataSource()
    End Sub

    Private Sub Browse_Button_Click(sender As System.Object, e As System.EventArgs) Handles Browse_Button.Click
        OpenFileDialog.ShowDialog()
        Path_TextBox.Text = OpenFileDialog.FileName
    End Sub

    Private Sub StudentDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        Dim index = StudentDataGridView.CurrentRow.Index
        Dim id = CStr(StudentDataGridView.Item(0, index).Value)
        Using entity As New DataCarEntities
            Dim student = entity.Students.First(
                Function(st) st.Id = id
                    )

            IDName_TextBox.Text = student.Id
            FName_TextBox.Text = student.FirstName
            LName_TextBox.Text = student.LastName
            Dorm_TextBox.Text = student.Dome
            Field_ComboBox.SelectedText = student.StudyField
            Phone_TextBox.Text = student.Phone
        End Using
    End Sub
End Class