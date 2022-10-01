Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        OpenFileDialog1.Filter = "CSV files (*.csv)|*.CSV"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReadCSV(TextBox1.Text)
    End Sub

    Private Sub ReadCSV(fname As String)
        Dim TextLine As String = ""
        Dim SplitLine() As String

        Using objReader As New System.IO.StreamReader(fname, Encoding.ASCII)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                SplitLine = Split(TextLine, ",")
                Me.DataGridView1.Rows.Add(SplitLine)
            Loop
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Text = "Lowest grade in the class" & vbCrLf & "Grade: " + (From row As DataGridViewRow In DataGridView1.Rows
                                                                                Where row.Cells(1).FormattedValue.ToString() <> String.Empty
                                                                                Select Convert.ToInt32(row.Cells(1).FormattedValue)
                             ).Min().ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.Text = "Highest grade in the class" & vbCrLf & "Grade: " + (From row As DataGridViewRow In DataGridView1.Rows
                                                                                 Where row.Cells(1).FormattedValue.ToString() <> String.Empty
                                                                                 Select Convert.ToInt32(row.Cells(1).FormattedValue)
                             ).Max().ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RichTextBox1.Text = "Arithmetic mean of the class" & vbCrLf & "Average: " + (From row As DataGridViewRow In DataGridView1.Rows
                                                                                     Where row.Cells(1).FormattedValue.ToString() <> String.Empty
                                                                                     Select Convert.ToInt32(row.Cells(1).FormattedValue)
                             ).Average().ToString("00.00")
    End Sub
End Class
