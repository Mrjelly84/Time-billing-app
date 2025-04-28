Public Class Form1

    Dim clock As New TimeClock
    Dim billData As New Billing_data

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboClient.DataSource = billData.ClientColl

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        clock.ClientName = cboClient.Text
        Me.Text = cboClient.Text
        clock.StartClock()
        lblStart.Text = clock.StartTime.ToLongTimeString
        lblBilling.Visible = True
        btnStart.Enabled = False
        btnStop.Enabled = True
        btnExit.Enabled = False
        cboClient.Enabled = False

    End Sub
End Class
