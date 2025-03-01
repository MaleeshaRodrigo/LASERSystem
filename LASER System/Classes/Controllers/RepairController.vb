
Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class RepairController : Inherits AbstractRepairController

    Public Sub GetHandedOverTechnician(RepairNo As Integer)
        Db.GetData($"SELECT {Technician.TName} FROM {Tables.Repair} REP LEFT JOIN {Tables.Technician} T ON T.TNo = REP.HandedOverToTNo WHERE RepNo = @REPNO", {
            New MySqlParameter("REPNO", RepairNo)
        })
    End Sub

    Public Sub GetSpecificRepairFieldFromRepairNo(RepairNo As Integer, Fields As String())
        Db.GetDataTable($"SELECT {String.Join(",", Fields)} FROM {Tables.Repair} WHERE RepNo = @REPNO;", {
            New MySqlParameter("REPNO", RepairNo)
        })
    End Sub

    Public Sub GetRepairFromRepairNo(RepairNo As Integer)
        Db.GetDataTable($"SELECT * FROM {Tables.Repair} WHERE RepNo = @REPNO;", {
            New MySqlParameter("REPNO", RepairNo)
        })
    End Sub

    Public Sub InsertRepair(Data As Dictionary(Of String, Object))
        Db.Execute($"INSERT INTO {Tables.Repair}(RepNo,RNo,PNo,PSerialNo,Qty,Problem,Status,TNo) VALUES(@REPNO, @RNO, @PNO, @PSERIALNO, @QTY, @PROBLEM, @STATUS, @TNO);", {
            New MySqlParameter("REPNO", Data(Repair.RepNo)),
            New MySqlParameter("RNO", Data(Repair.RNo)),
            New MySqlParameter("PNO", Data(Repair.PNo)),
            New MySqlParameter("PSERIALNO", Data(Repair.PSerialNo)),
            New MySqlParameter("QTY", Data(Repair.Qty)),
            New MySqlParameter("PROBLEM", Data(Repair.Problem)),
            New MySqlParameter("STATUS", Data(Repair.Status)),
            New MySqlParameter("TNO", Data(Repair.TNo))
        })
    End Sub
End Class
