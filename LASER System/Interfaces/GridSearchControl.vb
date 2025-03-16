Imports MySqlConnector

Public Interface GridSearchControl
    ReadOnly Property Control As UserControl
    Function Init(Db As Database, ParentForm As FormSearch) As GridSearchControl
    Sub SearchSubmission(WhereQuery As String, Values As MySqlParameter())
    Function GetFilterDictionary() As Dictionary(Of String, String)
End Interface
