Imports CarClassLibrary
Imports System
'
' สร้าง Car Tab
'
Partial Public Class ManageForm

    Private Sub ClearCarForm()
        IDTag_TextBox.Text = ""
        Plate_TextBox.Text = ""
        Brand_TextBox.Text = ""
        Model_TextBox.Text = ""
        Path_TextBox.Text = ""
        StudentOwner_ComboBox.SelectedIndex = 0
        IDTag_TextBox.Focus()
    End Sub

    Private Function CopyAndRenameImage(ByVal PictureName As String) As String
        Dim path As New IO.FileInfo(PictureName)
        Dim destinationPath = IO.Path.GetFullPath(
               Environment.CurrentDirectory() & "..\..\..\Images\" & Plate_TextBox.Text & path.Extension())
        If destinationPath = path.FullName Then
            Return destinationPath
        Else
            If IO.File.Exists(destinationPath) Then
                My.Computer.FileSystem.DeleteFile(destinationPath)
            End If
            My.Computer.FileSystem.CopyFile(path.FullName, destinationPath, True)
        End If

        Return destinationPath
    End Function

    '
    ' Browse หารูป
    '
    Private Sub Browse_Button_Click(sender As System.Object, e As System.EventArgs) Handles Browse_Button.Click
        OpenFileDialog.Filter = "Images (*.jpeg, *.jpg, *.png)|*.jpeg;*.jpg;*.png"
        OpenFileDialog.Title = "Open Images"
        OpenFileDialog.InitialDirectory = Environment.SpecialFolder.MyPictures
        OpenFileDialog.ShowDialog()
        Path_TextBox.Text = OpenFileDialog.FileName
    End Sub

    '
    ' Save Data to Database
    '
    Private Sub CarSave_Button_Click(sender As System.Object, e As System.EventArgs) Handles CarSave_Button.Click
        Dim stOwner = StudentOwner_ComboBox.Text.Split(New Char() {"-"c})(0)
        If CarSave_Button.Text = "แก้ไขข้อมูล" Then
            Using entity As New DataCarEntities
                Dim car = entity.Cars.First(
                    Function(c) c.Id = Plate_TextBox.Text
                        )

                car.Brand = Brand_TextBox.Text
                car.TagId = IDTag_TextBox.Text
                car.Model = Model_TextBox.Text
                car.Student_Id = stOwner
                car.Picture = CopyAndRenameImage(Path_TextBox.Text)

                entity.SaveChanges()
                Plate_TextBox.Enabled = True
                StudentOwner_ComboBox.SelectedItem = 0
                MsgBox("แก้ไขข้อมูล เรียบร้อย")
                CarSave_Button.Text = "บันทึกข้อมูล"
            End Using
        Else
            Try
                Dim car As New CarClassLibrary.Car
                car.Id = Plate_TextBox.Text
                car.TagId = IDTag_TextBox.Text
                car.Brand = Brand_TextBox.Text
                car.Model = Model_TextBox.Text
                car.Student_Id = stOwner
                car.Picture = CopyAndRenameImage(Path_TextBox.Text)

                Using entity As New DataCarEntities
                    entity.Cars.AddObject(car)
                    entity.SaveChanges()
                End Using
                MsgBox("บันทึกข้อมูล เรียบร้อย")
            Catch ex As UpdateException
                MsgBox("ข้อมูลนี้มีอยู่แล้ว")
            End Try
        End If
        ClearCarForm()
        BindDataSource("Cars")
    End Sub

    Private Sub CarReset_Button_Click(sender As System.Object, e As System.EventArgs) Handles CarReset_Button.Click
        If CarReset_Button.Text = "ลบข้อมูล" Then
            Using entity As New DataCarEntities
                Dim car = entity.Cars.First(
                    Function(c) c.Id = Plate_TextBox.Text
                        )
                '
                ' Delete picture in Images folder.
                My.Computer.FileSystem.DeleteFile(car.Picture)
                entity.Cars.DeleteObject(car)
                entity.SaveChanges()
                Plate_TextBox.Enabled = True
                BindDataSource("Cars")
            End Using
            MsgBox("ลบข้อมูล เรียบร้อยแล้ว")
            CarReset_Button.Text = "ล้างข้อมูล"
        End If
        ClearCarForm()
    End Sub

    Private Sub CarCancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CarCancelButton.Click
        ClearCarForm()
        Plate_TextBox.Enabled = True
        CarSave_Button.Text = "บันทึกข้อมูล"
        CarReset_Button.Text = "ล้างข้อมูล"
        CarCancelButton.Hide()
    End Sub

    Private Sub CarsDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CarsDataGridView.CellContentClick
        Dim index = CarsDataGridView.CurrentRow.Index
        Dim id = CStr(CarsDataGridView.Item(0, index).Value)

        Using entity As New DataCarEntities
            Dim car = entity.Cars.First(
                Function(c) c.Id = id
                    )
            Dim student = entity.Students.First(
                Function(st) st.Id = car.Student_Id
                    )
            Plate_TextBox.Text = car.Id
            IDTag_TextBox.Text = car.TagId
            Brand_TextBox.Text = car.Brand
            Model_TextBox.Text = car.Model
            StudentOwner_ComboBox.SelectedItem = student.Id & "-" & student.FirstName & " " & student.LastName
            Path_TextBox.Text = car.Picture
        End Using

        CarSave_Button.Text = "แก้ไขข้อมูล"
        CarReset_Button.Text = "ลบข้อมูล"
        Plate_TextBox.Enabled = False
        CarCancelButton.Show()
    End Sub
End Class
