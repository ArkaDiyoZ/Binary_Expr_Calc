Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Multiline = True ' процедура вывода файла "обучения" проверяющая на целостность переноса данных 

        Try
            FileOpen(1, "xor.txt", OpenMode.Input)
            Do While Not EOF(1)
                TextBox1.Text &= (LineInput(1)) & vbCrLf
            Loop
            FileClose(1)
        Catch ex As Exception
            MsgBox("Ошибка чтения файла")
        End Try
    End Sub


End Class