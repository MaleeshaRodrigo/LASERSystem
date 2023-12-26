Imports System.Data.MySql
Imports System.IO
Imports System.Net
Imports Microsoft.VisualBasic.FileIO
Imports Newtonsoft.Json

Module Utils
    Public SystemFolderPath As String = Path.Combine(SpecialDirectories.MyDocuments, "LASER System Data")
    Public Sub ComboBoxDropDown(Db As Database, cmb As ComboBox, SQL As String)
        cmb.Items.Clear()
        Dim DT0 As DataTable = Db.GetDataTable(SQL)
        Dim items = DT0.AsEnumerable().Select(Function(d) DirectCast(d(0).ToString(), Object)).ToArray()
        cmb.Items.AddRange(items)
        DT0.Dispose()
    End Sub

    Public Sub SetNextKey(Db As Database, txt As TextBox, SQL As String, ColumnName As String)
        Dim DR0 As MySqlDataReader = Db.GetDataReader(SQL)
        If DR0.HasRows = True Then
            DR0.Read()
            txt.Text = Int(DR0.Item(ColumnName)) + 1
        Else
            txt.Text = "1"
        End If
        DR0.Close()
    End Sub

    Public Sub OnlynumberQty(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub OnlynumberPrice(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 45 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub TextBoxPrice_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberPrice(e)
    End Sub

    Public Sub TextBoxQty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

    Public Function CheckEmptyStr(str As String, msg As String) As Boolean
        CheckEmptyStr = True
        If str = "" Then
            MsgBox(msg, vbCritical + vbOKOnly)
            Return False
        End If
    End Function

    Public Function CheckEmptyfield(txt As Control, msg As String) As Boolean
        CheckEmptyfield = True
        If String.IsNullOrEmpty(txt.Text.Trim) Then
            MsgBox(msg, vbCritical + vbOKOnly)
            txt.Focus()
            Return False
        End If
    End Function

    ''' <summary>
    ''' Checking whether the given SQL query has rows or not
    ''' </summary>
    ''' <param name="SQL">The SQL Query</param>
    ''' <returns>True, if there are rows in the SQL query, or false</returns>
    Public Function CheckExistData(SQL As String) As Boolean
        Dim CMD0 = New MySqlCommand(SQL)
        Dim DR0 As MySqlDataReader = CMD0.ExecuteReader()
        If DR0.HasRows = True Then
            Return True
        Else
            Return False
        End If
        CMD0.Cancel()
        DR0.Close()
    End Function

    Public Function CheckExistData(cmb As Control, SQL As String, msg As String, IsDataExist As Boolean) As Boolean
        Dim CMD0 = New MySqlCommand(SQL)
        Dim DR0 As MySqlDataReader = CMD0.ExecuteReader()
        If DR0.HasRows = True Then
            If IsDataExist = True Then
                MsgBox(msg, vbCritical + vbOKOnly)
                cmb.Focus()
            End If
            Return True
        Else
            If IsDataExist = False Then
                MsgBox(msg, vbCritical + vbOKOnly)
                cmb.Focus()
            End If
            Return False
        End If
        CMD0.Cancel()
        DR0.Close()
    End Function

    Public Sub WriteActivity(txt As String)
        Dim DSActivity As DataSet
        Dim DTActivity As DataTable
        Dim LastIndex As Integer = 0
        If Not File.Exists(Path.Combine(SystemFolderPath, "System Files\Activity\Activity.json")) Then
            Exit Sub
        End If
        Dim Rjson As String = File.ReadAllText(Path.Combine(SystemFolderPath, "System Files\Activity\Activity.json"))
        If String.IsNullOrEmpty(Rjson) Then
            DSActivity = New DataSet
            DTActivity = New DataTable

            DTActivity.Columns.Add("ID")
            DTActivity.Columns.Add("Date")
            DTActivity.Columns.Add("Command")

            DSActivity.Tables.Add(DTActivity)
        Else
            DSActivity = JsonConvert.DeserializeObject(Of DataSet)(Rjson)
            DTActivity = DSActivity.Tables.Item("Table1")
            LastIndex = DTActivity.Rows(DTActivity.Rows.Count - 1)(0)
        End If
        DTActivity.Rows.Add(LastIndex + 1, Now, txt)

        MdifrmMain.GrdActivity.DataSource = DTActivity

        Dim Wjson As String = JsonConvert.SerializeObject(DSActivity, Formatting.Indented)
        File.WriteAllText(Path.Combine(SystemFolderPath, "System Files\Activity\Activity.json"), Wjson)
    End Sub

    Public Function CheckExistRelationsforDelete(SQl As String, FieldName As String, msg As String) As Boolean
        CheckExistRelationsforDelete = True
        CMD = New MySql.MySqlCommand(SQl)
        DR = CMD.ExecuteReader
        Dim tmp As String = ""
        If DR.HasRows = True Then
            While DR.Read
                tmp = tmp + DR(FieldName).ToString + " "
            End While
            MsgBox(msg + vbCrLf + "The field/s called '" + FieldName + "' are/is " + tmp, vbCritical + vbOKOnly)
            Return False
        End If
    End Function

    Public Function NextfrmNo(frmNew As Form) As Integer
        Dim i As Integer = 0
        For Each oForm As Form In Application.OpenForms().OfType(Of Form)()
            If oForm.Name.ToString.StartsWith(frmNew.Name) = True Then
                If IsNumeric(oForm.Name.ToString.Replace(frmNew.Name, "")) = True Then
                    If i <= oForm.Name.ToString.Replace(frmNew.Name, "") Then
                        i = oForm.Name.ToString.Replace(frmNew.Name, "")
                    End If
                End If
            End If
        Next
        Return (i + 1)
    End Function

    Public Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("https://www.lasertec.lk")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Function mnustrpMENU() As ToolStripMenuItem
        Dim cmdStock As ToolStripMenuItem = New ToolStripMenuItem("Stock")
        Dim cmdCustomer As ToolStripMenuItem = New ToolStripMenuItem("Customer")
        Dim cmdSupplier As ToolStripMenuItem = New ToolStripMenuItem("Supplier")
        Dim cmdTechnician As ToolStripMenuItem = New ToolStripMenuItem("Technician")
        Dim cmdProduct As ToolStripMenuItem = New ToolStripMenuItem("Product")
        Dim cmdSale As ToolStripMenuItem = New ToolStripMenuItem("Sale")
        Dim cmdOpenSale As ToolStripMenuItem = New ToolStripMenuItem("Open Sale")
        Dim cmdNewSale As ToolStripMenuItem = New ToolStripMenuItem("New Sale")
        Dim cmdSupply As ToolStripMenuItem = New ToolStripMenuItem("Supply")
        Dim cmdReceive As ToolStripMenuItem = New ToolStripMenuItem("Receive")
        Dim cmdRepair As ToolStripMenuItem = New ToolStripMenuItem("Repair")
        Dim cmdDeliver As ToolStripMenuItem = New ToolStripMenuItem("Deliver")
        Dim cmdSalesRepair As ToolStripMenuItem = New ToolStripMenuItem("Sales Repair")
        Dim cmdTechnicianCost As ToolStripMenuItem = New ToolStripMenuItem("Technician Cost")
        Dim cmdTechnicianLoan As ToolStripMenuItem = New ToolStripMenuItem("Technician Loan")
        Dim cmdTechnicianSalary As ToolStripMenuItem = New ToolStripMenuItem("Technician Salary")
        Dim cmdCustomerLoan As ToolStripMenuItem = New ToolStripMenuItem("Customer Loan")
        Dim cmdSettlement As ToolStripMenuItem = New ToolStripMenuItem("Settlement")
        Dim cmdBarCodeGenerator As ToolStripMenuItem = New ToolStripMenuItem("Barcode Generator")
        Dim cmdTool As ToolStripMenuItem = New ToolStripMenuItem("Tools")
        Dim cmdOpenCashDrawer As ToolStripMenuItem = New ToolStripMenuItem("Open Cash Drawer")
        Dim sep1, sep2, sep3, sep4 As New ToolStripSeparator
        cmdStock.ShortcutKeys = Keys.F1
        AddHandler cmdStock.Click, AddressOf MdifrmMain.CmdStock_Click
        AddHandler cmdCustomer.Click, AddressOf MdifrmMain.CmdCustomer_Click
        AddHandler cmdSupplier.Click, AddressOf MdifrmMain.CmdSupplier_Click
        AddHandler cmdTechnician.Click, AddressOf MdifrmMain.cmdTechnician_Click
        AddHandler cmdProduct.Click, AddressOf MdifrmMain.CmdProduct_Click
        AddHandler cmdOpenSale.Click, AddressOf MdifrmMain.OpenSaleToolStripMenuItem_Click
        cmdOpenSale.ShortcutKeys = Keys.F2 + Keys.Control
        AddHandler cmdNewSale.Click, AddressOf MdifrmMain.NewSaleToolStripMenuItem_Click
        cmdNewSale.ShortcutKeys = Keys.F2
        AddHandler cmdSupply.Click, AddressOf MdifrmMain.CmdSupply_Click
        cmdReceive.ShortcutKeys = Keys.F3
        AddHandler cmdReceive.Click, AddressOf MdifrmMain.CmdReceive_Click
        cmdRepair.ShortcutKeys = Keys.F4
        AddHandler cmdRepair.Click, AddressOf MdifrmMain.cmdRepair_Click
        cmdDeliver.ShortcutKeys = Keys.F5
        AddHandler cmdDeliver.Click, AddressOf MdifrmMain.cmdDeliver_Click
        AddHandler cmdSalesRepair.Click, AddressOf MdifrmMain.cmdSalesRepair_Click
        cmdTechnicianCost.ShortcutKeys = Keys.F6
        AddHandler cmdTechnicianCost.Click, AddressOf MdifrmMain.cmdTechnicianCost_Click
        cmdTechnicianLoan.ShortcutKeys = Keys.F7
        AddHandler cmdTechnicianLoan.Click, AddressOf MdifrmMain.cmdTechnicianLoan_Click
        AddHandler cmdTechnicianSalary.Click, AddressOf MdifrmMain.cmdTechnicianSalary_Click
        AddHandler cmdCustomerLoan.Click, AddressOf MdifrmMain.cmdCustomerLoan_Click
        AddHandler cmdSettlement.Click, AddressOf MdifrmMain.CmdSettlement_Click
        AddHandler cmdBarCodeGenerator.Click, AddressOf MdifrmMain.BarCodeGeneratorToolStripMenuItem_Click
        cmdOpenCashDrawer.ShortcutKeys = Keys.F8
        AddHandler cmdOpenCashDrawer.Click, AddressOf CashDrawer.Open

        mnustrpMENU = New ToolStripMenuItem("MENU")
        mnustrpMENU.DropDownItems.Add(cmdStock)
        mnustrpMENU.DropDownItems.Add(cmdCustomer)
        mnustrpMENU.DropDownItems.Add(cmdSupplier)
        mnustrpMENU.DropDownItems.Add(cmdTechnician)
        mnustrpMENU.DropDownItems.Add(cmdProduct)
        mnustrpMENU.DropDownItems.Add(sep1)

        mnustrpMENU.DropDownItems.Add(cmdSale)
        cmdSale.DropDownItems.Add(cmdNewSale)
        cmdSale.DropDownItems.Add(cmdOpenSale)
        mnustrpMENU.DropDownItems.Add(cmdSupply)
        mnustrpMENU.DropDownItems.Add(sep2)

        mnustrpMENU.DropDownItems.Add(cmdReceive)
        mnustrpMENU.DropDownItems.Add(cmdRepair)
        mnustrpMENU.DropDownItems.Add(cmdDeliver)
        mnustrpMENU.DropDownItems.Add(cmdSalesRepair)
        mnustrpMENU.DropDownItems.Add(sep3)

        mnustrpMENU.DropDownItems.Add(cmdTechnicianCost)
        mnustrpMENU.DropDownItems.Add(cmdTechnicianLoan)
        mnustrpMENU.DropDownItems.Add(cmdTechnicianSalary)
        mnustrpMENU.DropDownItems.Add(cmdCustomerLoan)
        mnustrpMENU.DropDownItems.Add(cmdSettlement)
        mnustrpMENU.DropDownItems.Add(cmdBarCodeGenerator)
        mnustrpMENU.DropDownItems.Add(sep4)

        mnustrpMENU.DropDownItems.Add(cmdTool)
        cmdTool.DropDownItems.Add(cmdOpenCashDrawer)

        Return mnustrpMENU
    End Function

End Module

