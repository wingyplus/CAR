Public Class ManageForm

    Private Sub ClearStudentForm()
        IDName_TextBox.Text = ""
        FName_TextBox.Text = ""
        LName_TextBox.Text = ""
        Dorm_TextBox.Text = ""
        Field_ComboBox.Text = ""
        Phone_TextBox.Text = ""
    End Sub

    '
    ' เรียกข้อมูลมาใส่ Owner_ComboBox
    '
    Private Sub ManageForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Using dataCar As New DataCarEntities
            Dim students = From a In dataCar.Students
                           Select a.Id, a.FirstName, a.LastName
                           Order By Id Ascending
            For Each student In students
                StudentOwner_ComboBox.Items.Add(student.Id & "-" & student.FirstName & " " & student.LastName)
            Next
        End Using
    End Sub

    Private Sub Index_Button_Click(sender As System.Object, e As System.EventArgs) Handles Index_Button.Click
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
    End Sub
End Class