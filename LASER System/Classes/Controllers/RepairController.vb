
Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class RepairController : Inherits AbstractRepairController

    Public Sub InsertRepair(Data As Dictionary(Of String, Object))
        Db.Execute("INSERT INTO Repair(RepNo,RNo,PNo,PSerialNo,Qty,Problem,Status,TNo) VALUES(@REPNO, @RNO, @PNO, @PSERIALNO, @QTY, @PROBLEM, @STATUS, @TNO);", {
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
