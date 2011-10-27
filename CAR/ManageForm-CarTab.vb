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
        My.Computer.FileSystem.CopyFile(path.FullName, destinationPath, True)

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
        Try
            Dim stOwner = StudentOwner_ComboBox.Text.Split(New Char() {"-"c})(0)

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
        ClearCarForm()
        BindDataSource("Cars")
    End Sub
End Class
