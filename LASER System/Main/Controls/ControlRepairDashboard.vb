Public Class ControlRepairDashboard
    Private ReadOnly Db As New Database
    Private TaskRefreshData As Task

    Public Sub Init()
        TimerRefresh.Start()
        TaskRefreshData = Task.Run(AddressOf LoadData)
    End Sub

    Private Sub LoadData()
        Try
            Dim DataTable As DataTable = Db.GetDataTable("SELECT TName AS 'Technician', 
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Assigned To' AND rep.AssignedToTNo = t.TNo) AS 'AssignedTo',
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Handed Over To' AND rep.HandedOverToTNo = t.TNo) AS 'HandedOverTo',
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Pending' AND rep.HandedOverToTNo = t.TNo) AS 'Pending',
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Repaired' AND rep.HandedOverToTNo = t.TNo) AS 'Repaired',
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Returned' AND rep.HandedOverToTNo = t.TNo) AS 'Returned'
                        FROM technician t WHERE t.TActive = 1 ORDER BY TName;")
            Invoke(Sub() GridTechnicianOverall.DataSource = DataTable)
            Dim DataReader = Db.GetDataDictionary("SELECT  
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Received') AS 'Received',
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Assigned To') AS 'AssignedTo',
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Handed Over To') AS 'HandedOverTo',
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Pending') AS 'Pending',
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Repaired') AS 'Repaired',
                        (SELECT COUNT(RepNo) FROM repair rep WHERE status='Returned') AS 'Returned'")
            Invoke(Sub()
                       LabelReceived.Text = DataReader("Received")
                       LabelAssignedTo.Text = DataReader("AssignedTo")
                       LabelHandedOverTo.Text = DataReader("HandedOverTo")
                       LabelPending.Text = DataReader("Pending")
                       LabelRepaired.Text = DataReader("Repaired")
                       LabelReturned.Text = DataReader("Returned")
                   End Sub)
        Catch Ex As Exception
            TimerRefresh.Stop()
            Invoke(Sub()
                       LabelReceived.Text = "Error"
                       LabelAssignedTo.Text = "Error"
                       LabelHandedOverTo.Text = "Error"
                       LabelPending.Text = "Error"
                       LabelRepaired.Text = "Error"
                       LabelReturned.Text = "Error"
                   End Sub)
        End Try
    End Sub

    Private Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick
        If TaskRefreshData IsNot Nothing AndAlso Not TaskRefreshData.IsCompleted Then
            Return
        End If

        TaskRefreshData = Task.Run(AddressOf LoadData)
    End Sub
End Class
