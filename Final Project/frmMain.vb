

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim lines() As String = IO.File.ReadAllLines("Previous.txt")
        lblPrevious.Text = lines(lines.Length - 1)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' declare variables and assign inputs
        Dim intOdometer As Integer
        Dim intPrevious As Integer
        Dim intTotal As Integer
        Dim intTrip As Integer
        Dim lines() As String = IO.File.ReadAllLines("Previous.txt")
        Dim outPrevious As IO.StreamWriter
        Integer.TryParse(txtOdometer.Text, intOdometer)

        ' get previous odometer reading
        intPrevious = lines(lines.Length - 1)
        lblPrevious.Text = intPrevious
        ' get current Odometer Reading and calculate and display trip miles. Also updates Previous.txt files
        ' to the new value
        If intOdometer >= lines(lines.Length - 1) Then
            lblTotal.Text = intOdometer
            intTrip = intOdometer - intPrevious
            lblTrip.Text = intTrip
        Else
            MessageBox.Show("Please enter number greater than previous odometer reading", "Current Odometer = " & lines.Length - 1)
            intTotal = intOdometer
        End If

        If intOdometer >= lines(lines.Length - 1) AndAlso IO.File.Exists("Previous.txt") = True Then
            outPrevious = IO.File.AppendText("Previous.txt")
            outPrevious.WriteLine(ControlChars.NewLine & lblTotal.Text.Trim)
            outPrevious.Close()
            txtOdometer.Text = String.Empty
            txtOdometer.Focus()
        End If
    End Sub

End Class
