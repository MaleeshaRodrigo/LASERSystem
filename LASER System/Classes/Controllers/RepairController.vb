
Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class RepairController : Inherits AbstractRepairController

    ''' <summary>
    ''' Retrieves repair information for a given repair number.
    ''' </summary>
    ''' <param name="RepNo">The repair number to retrieve information for.</param>
    ''' <param name="Fields">An array of column names to be selected in the query</param>
    ''' <param name="JoinQueries">An array of join queries to include in the main query.</param>
    ''' <returns>A dictionary containing the repair information, with column names as keys and corresponding values.</returns>
    ''' <remarks>
    ''' This function dynamically constructs an SQL query based on the provided fields and join queries.
    ''' It then executes the query and returns the result as a dictionary. 
    ''' <code>Format: SELECT {Fields} FROM Repair REP {JoinQueries} WHERE REP.RepNo = {RepNo};</code>
    ''' </remarks>
    Public Function GetRepair(RepNo As Integer, Fields As String(), JoinQueries As String()) As Dictionary(Of String, Object)
        Dim Query As String = $"SELECT {Join(Fields, ", ")} FROM Repair REP"
        For Each JoinQuery In JoinQueries
            Query &= $" {JoinQuery}"
        Next

        Query &= "WHERE REP.RepNo = @REPNO;"
        Return Db.GetDataDictionary(Query, {
            New MySqlParameter("REPNO", RepNo)
        })
    End Function

    Public Sub InsertRepair(Data As Dictionary(Of String, Object))
        Db.Execute($"INSERT INTO {Tables.Repair}(RepNo,RNo,PNo,PSerialNo,Qty,Problem,Status,TNo) VALUES(@REPNO, @RNO, @PNO, @PSERIALNO, @QTY, @PROBLEM, @STATUS, @TNO);", {
            New MySqlParameter("REPNO", Data(Repair.RepNo)),
            New MySqlParameter("RNO", Data(Repair.RNo)),
            New MySqlParameter("PNO", Data(Repair.PNo)),
            New MySqlParameter("PSERIALNO", Data(Repair.PSerialNo)),
            New MySqlParameter("QTY", Data(Repair.Qty)),
            New MySqlParameter("PROBLEM", Data(Repair.Problem)),
            New MySqlParameter("STATUS", Data(Repair.Status)),
            New MySqlParameter("TNO", Data(Repair.HandedOverToTNo))
        })
    End Sub
End Class
