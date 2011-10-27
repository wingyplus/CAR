Imports CarClassLibrary

Public Class ManageForm

    Private Sub BindDataSource(ByVal Bind As String)
        Select Case Bind
            Case "Students"
                Using dataCar As New DataCarEntities
                    Dim students = From a In dataCar.Students
                                   Select a.Id, a.FirstName, a.LastName
                                   Order By Id Ascending
                    StudentBindingSource.DataSource = students
                End Using
            Case "Cars"
                'MsgBox("Cars")
                Using dataCar As New DataCarEntities
                    Dim cars = (From b In dataCar.Cars
                               Select b
                               Order By b.Id Ascending).ToList()

                    'MsgBox(cars)
                    'CarBindingSource.DataSource = cars
                    CarBindingSource.DataSource = cars
                End Using
        End Select
        
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
        BindDataSource("Cars")
        Cancel_Button.Hide()
    End Sub
End Class