Imports CarClassLibrary

Public Class ManageForm

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
        Cancel_Button.Hide()
    End Sub

    Private Sub Browse_Button_Click(sender As System.Object, e As System.EventArgs) Handles Browse_Button.Click
        OpenFileDialog.ShowDialog()
        Path_TextBox.Text = OpenFileDialog.FileName
    End Sub

    
End Class