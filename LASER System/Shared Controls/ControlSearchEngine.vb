Imports System.Windows.Markup
Imports MySqlConnector
Imports Newtonsoft.Json.Linq

Public Class ControlSearchEngine
    Public Event SearchSubmissionEvent(Query As String, Values As MySqlParameter())

    Private Filters As Dictionary(Of String, String)
    Private PoistionList As New List(Of Object)
    Private Operators As New List(Of String) From {"AND", "OR", ")", "("}

    Public Sub Init(Filters As Dictionary(Of String, String))
        Me.Filters = Filters

        ComboFilter.Items.Clear()
        ComboFilter.Items.AddRange(Filters.Values.ToArray)
        ComboFilter.SelectedIndex = 0
    End Sub

    Public Sub QueryValidator(Valid As Boolean)
        LabelInvalidator.Visible = Not Valid
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click, TextSearch.Enter
        If TextSearch.Text.Trim() = "" Then
            Return
        End If

        ApplyPrefixOperator()
        AddPoistion(TextSearch.Text, GetKeyFromValue(Filters, ComboFilter.Text))
        Dim QueryResult = BuildQuery()
        TextSearch.Text = ""

        RaiseEvent SearchSubmissionEvent(QueryResult.Query, QueryResult.Values.ToArray)
    End Sub

    Private Function BuildQuery() As (Query As String, Values As List(Of MySqlParameter))
        Dim Query As String = ""
        Dim Values As New List(Of MySqlParameter)()
        Dim Random As New Random
        For Each Poistion As Object In PoistionList
            If Poistion.GetType.Name = "String" AndAlso Operators.Contains(Poistion) Then
                Query += $" {Poistion} "
                Continue For
            End If
            If Poistion(0) = "All" Then
                Dim Result = PerformFilterAll(Random, Poistion(1))
                Query += Result.Query
                Values.Add(Result.Value)
                Continue For
            End If
            Dim RandomNumber As Integer = Random.Next()
            Query += $" {Poistion(0)} LIKE @VALUE{RandomNumber} "
            Values.Add(New MySqlParameter($"VALUE{RandomNumber}", $"%{Poistion(1)}%"))
        Next

        Return (Query, Values)
    End Function

    Private Function PerformFilterAll(Random As Random, SearchText As String) As (Query As String, Value As MySqlParameter)
        Dim QueryArray As New List(Of String)
        Dim RandomNumber As Integer = Random.Next()
        Dim ParameterValue As New MySqlParameter($"VALUE{RandomNumber}", $"%{SearchText}%")
        For Each Key In Filters.Keys
            If Key = "All" Then
                Continue For
            End If
            QueryArray.Add($"{Key} LIKE @VALUE{RandomNumber}")
        Next

        Return ($" ({String.Join(" OR ", QueryArray)}) ", ParameterValue)
    End Function

    Private Sub AddPoistion(Text As String, Optional Field As String = Nothing)
        If Field Is Nothing Then
            PoistionList.Add(Text)
            CreatePanelPoistion(Text)
        Else
            PoistionList.Add({Field, Text})
            CreatePanelPoistion($"{Filters(Field)}: {Text}")
        End If
    End Sub

    Private Sub CreatePanelPoistion(Text As String)
        Dim Color As Color = If(Operators.Contains(Text), Color.LightGray, Nothing)
        Dim ControlSearchEnginePoistion As New ControlSearchEnginePoistion()
        ControlSearchEnginePoistion.Init(Text, PoistionList.Count - 1, Color)
        AddHandler ControlSearchEnginePoistion.CloseEvent, AddressOf ControlSearchEnginePoistion_Close
        FlowPanel.Controls.Add(ControlSearchEnginePoistion)
    End Sub

    Private Sub ControlSearchEnginePoistion_Close(Index As Integer)
        If Index >= PoistionList.Count Then
            Return
        End If

        Dim RemovedItemsCount As Integer = 1
        PoistionList.RemoveAt(Index)
        If Index > 1 AndAlso PoistionList.Item(Index - 1).GetType.Name = "String" AndAlso Operators.Contains(PoistionList.Item(Index - 1)) Then
            Dim Poistion As ControlSearchEnginePoistion = FlowPanel.Controls.Item(Index - 1)
            Poistion.Dispose()
            PoistionList.RemoveAt(Index - 1)
            RemovedItemsCount = 2
        End If

        For i = Index - RemovedItemsCount + 2 To PoistionList.Count
            Dim Poistion As ControlSearchEnginePoistion = FlowPanel.Controls.Item(i)
            Poistion.Index = Poistion.Index - RemovedItemsCount
        Next
        Dim QueryResult = BuildQuery()
        RaiseEvent SearchSubmissionEvent(QueryResult.Query, QueryResult.Values.ToArray)
    End Sub

    Private Sub ButtonOpenBracket_Click(sender As Object, e As EventArgs) Handles ButtonOpenBracket.Click
        ApplyPrefixOperator()
        AddPoistion("(")
        Dim QueryResult = BuildQuery()
        RaiseEvent SearchSubmissionEvent(QueryResult.Query, QueryResult.Values.ToArray)
    End Sub

    Private Sub ButtonCloseBracket_Click(sender As Object, e As EventArgs) Handles ButtonCloseBracket.Click
        AddPoistion(")")
        Dim QueryResult = BuildQuery()
        RaiseEvent SearchSubmissionEvent(QueryResult.Query, QueryResult.Values.ToArray)
    End Sub

    Private Sub ApplyPrefixOperator()
        Dim CommonCondition As Boolean = PoistionList.Count > 0 AndAlso
            (PoistionList.Item(PoistionList.Count - 1).GetType.Name <> "String" OrElse
            PoistionList.Item(PoistionList.Count - 1) = ")")
        If CommonCondition AndAlso RadioAnd.Checked Then
            AddPoistion("AND")
        ElseIf CommonCondition AndAlso RadioOr.Checked Then
            AddPoistion("OR")
        End If
    End Sub

    Private Function GetKeyFromValue(Dictionary As Dictionary(Of String, String), Value As String) As String
        For Each KeyValuePair In Dictionary
            If KeyValuePair.Value = Value Then
                Return KeyValuePair.Key
            End If
        Next

        Return Nothing
    End Function
End Class
