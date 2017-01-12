Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each n As String In My.Computer.Ports.SerialPortNames
            PortsListBox.Items.Add(n)
        Next
    End Sub
End Class
