Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ReRepairController
    Inherits AbstractRepairController

    Public Sub InsertReRepair(Data As Dictionary(Of String, Object))
        Db.Execute($"INSERT INTO `{Tables.ReRepair}`(RetNo, RepNo, RNo, PNo, PSerialNo, Qty, Problem, Status) VALUES(@RETNO, @REPNO, @RNO, @PNO, @PSERIALNO, @QTY, @PROBLEM, @STATUS)", {
            New MySqlParameter("RETNO", Data(ReRepair.RetNo)),
            New MySqlParameter("REPNO", Data(ReRepair.RepNo)),
            New MySqlParameter("RNO", Data(ReRepair.RNo)),
            New MySqlParameter("PNO", Data(ReRepair.PNo)),
            New MySqlParameter("PSERIALNO", Data(ReRepair.PSerialNo)),
            New MySqlParameter("QTY", Data(ReRepair.Qty)),
            New MySqlParameter("PROBLEM", Data(ReRepair.Problem)),
            New MySqlParameter("STATUS", RepairStatus.Received)
        })
    End Sub
End Class
