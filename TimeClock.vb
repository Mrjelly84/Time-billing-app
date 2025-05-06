Public Class TimeClock
    Private startApp As DateTime
    Private stopApp As DateTime
    Public Property ClientName As String

    Public Sub StartClock()
        startApp = Now

    End Sub

    Public Sub StopClock()
        stopApp = Now
    End Sub

    Public ReadOnly Property StartTime As DateTime
        Get
            Return startApp

        End Get
    End Property

    Public ReadOnly Property StopTime As DateTime
        Get
            Return stopApp

        End Get
    End Property

    Public ReadOnly Property Elapsed As TimeSpan
        Get
            Return Now.Subtract(startApp)

        End Get
    End Property

    Public ReadOnly Property TotalElapsed As TimeSpan
        Get
            Return stopApp.Subtract(startApp)

        End Get
    End Property

End Class
