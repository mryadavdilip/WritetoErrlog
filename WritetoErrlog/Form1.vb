Public Class WritetoErrlog
    Dim dir As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim dateTime As DateTime = New DateTime()
    Dim message
    Dim status As Boolean
    Sub Input(ByRef msg As String, ByRef status As Boolean)
        Dim file As System.IO.StreamWriter
        Try
            file = My.Computer.FileSystem.OpenTextFileWriter(dir + "/WritetoErrlogMessages.txt", True)
            file.WriteLine("(" + DateTime.Now.ToString + "): " + msg)
            file.Close()
            status = True
        Catch ex As Exception
            status = False
        Finally
            StatusLable.Text = status.ToString
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub createFile_btn_Click(sender As Object, e As EventArgs) Handles createFile_btn.Click
        message = MessageBox.Text
        Input(message, status)
    End Sub
End Class
