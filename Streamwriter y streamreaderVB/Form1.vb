Imports System
Imports System.IO
Public Class Form1
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Using re As StreamReader = New StreamReader("C:\Users\pc\OneDrive\Documentos\2do semestre\Streamwriter y streamreaderVB\Streamwriter y streamreaderVB\TextoWR.txt")

            While Not re.EndOfStream
                rtbCampo.AppendText(re.ReadLine())
            End While
        End Using
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Using wr As StreamWriter = New StreamWriter("C:\Users\pc\OneDrive\Documentos\2do semestre\Streamwriter y streamreaderVB\Streamwriter y streamreaderVB\TextoWR.txt")
            wr.WriteLine((rtbCampo.Text))
        End Using
    End Sub

End Class
