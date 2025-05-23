﻿Public Class Form1

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
        lblDurration.Visible = True
        btnStart.Enabled = False
        btnStop.Enabled = True
        btnExit.Enabled = False
        cboClient.Enabled = False

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        btnStart.Enabled = True
        btnStop.Enabled = False
        btnExit.Enabled = True
        lblBilling.Visible = False
        cboClient.Enabled = True
        clock.StopClock()
        lblStop.Text = clock.StopTime.ToShortTimeString
        lblDurration.Text = clock.Elapsed.Hours & ":" & clock.Elapsed.Minutes & ":" & clock.Elapsed.Seconds

        With clock
            billData.writeBilling(
            Now.ToShortDateString & ", " &
            .ClientName & ", " &
            .StartTime.ToShortTimeString & ", " &
            .StopTime.ToShortTimeString & ", " &
            .TotalElapsed.Hours & ":" &
            .TotalElapsed.Minutes & ":" &
            .TotalElapsed.Seconds
            )
        End With
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        billData.CloseBilling()
        Close()

    End Sub
End Class
