Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = Encode(TextBox1.Text)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = Decode(TextBox1.Text)
    End Sub
    Function Encode(ByVal dec As String) As String
        Dim bt() As Byte
        ReDim bt(dec.Length)
        bt = System.Text.Encoding.ASCII.GetBytes(dec)
        Dim enc As String
        enc = System.Convert.ToBase64String(bt)
        Return enc
    End Function
    Function Decode(ByVal enc As String) As String
        Dim bt() As Byte
        bt = System.Convert.FromBase64String(enc)
        Dim dec As String
        dec = System.Text.Encoding.ASCII.GetString(bt)
        Return dec
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.SelectAll()
        TextBox1.Copy()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox1.Paste()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox2.SelectAll()
        TextBox2.Copy()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox2.Clear()
        TextBox2.Paste()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        Form2.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Text = "Jordan Merli" & Space(73) & DateTime.Now
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form2.Show()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form3.Show()
    End Sub
End Class
