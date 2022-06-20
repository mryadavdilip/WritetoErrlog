Public Class WritetoErrlog
    Dim filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/WritetoErrlogMessages.txt"
    Dim dateTime As DateTime = New DateTime()
    Dim message
    Dim status As Boolean
    Sub Input(ByRef msg As String, ByRef status As Boolean)
        Dim file As System.IO.StreamWriter
        Try
            If System.IO.File.Exists(filePath) Then
                FileExistence.Text = "Message appended"
            ElseIf Not System.IO.File.Exists(filePath) Then
                System.IO.File.Create(filePath).Dispose()
                FileExistence.Text = "File created"
            End If
            file = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)
            file.WriteLine("(" + DateTime.Now.ToString + "): " + msg)
            file.Close()
            status = True
            MessageBox.Clear()
        Catch ex As Exception
            status = False
        Finally
            StatusLable.Text = "Status: " + status.ToString
        End Try
    End Sub

    Private Sub createFile_btn_Click(sender As Object, e As EventArgs) Handles createFile_btn.Click
        message = MessageBox.Text
        Input(message, status)
    End Sub
End Class
