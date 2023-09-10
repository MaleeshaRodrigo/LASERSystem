﻿Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Web.Security
Imports Newtonsoft.Json

Module Utils
    Public Sub ComboBoxDropDown(Db As Database, cmb As ComboBox, SQL As String)
        cmb.Items.Clear()
        Dim DT0 As New DataTable
        Dim DA0 As OleDbDataAdapter = Db.GetDataAdapter(SQL)
        DA0.Fill(DT0)
        Dim items = DT0.AsEnumerable().Select(Function(d) DirectCast(d(0).ToString(), Object)).ToArray()
        cmb.Items.AddRange(items)
        DT0.Dispose()
        DA0.Dispose()
    End Sub

    Public Sub SetNextKey(Db As Database, txt As TextBox, SQL As String, ColumnName As String)
        Dim DR0 As OleDbDataReader = Db.GetDataReader(SQL)
        If DR0.HasRows = True Then
            DR0.Read()
            txt.Text = Int(DR0.Item(ColumnName)) + 1
        Else
            txt.Text = "1"
        End If
        DR0.Close()
    End Sub

    Public Function GetRowsCount(Cmd As OleDbCommand) As Integer
        Dim DR0 As OleDbDataReader = Cmd.ExecuteReader
        Dim DT0 As New DataTable
        DT0.Load(DR0)
        Return (DT0.Rows.Count)
        DR0.Close()
        DT0.Clear()
    End Function

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

    Public Function GetArrayfromSQL(SQL As String, ColumnName As String) As List(Of String)
        Dim CMD0 = New OleDbCommand(SQL)
        Dim DR0 As OleDbDataReader = CMD0.ExecuteReader()
        Dim arr As New List(Of String)
        While DR0.Read
            arr.Add(DR0(ColumnName).ToString)
        End While
        Return (arr)
        CMD0.Cancel()
        DR0.Close()
    End Function

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
        Dim CMD0 = New OleDbCommand(SQL)
        Dim DR0 As OleDbDataReader = CMD0.ExecuteReader()
        If DR0.HasRows = True Then
            Return True
        Else
            Return False
        End If
        CMD0.Cancel()
        DR0.Close()
    End Function

    Public Function CheckExistData(cmb As Control, SQL As String, msg As String, IsDataExist As Boolean) As Boolean
        Dim CMD0 = New OleDbCommand(SQL)
        Dim DR0 As OleDbDataReader = CMD0.ExecuteReader()
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
        Dim Rjson As String = File.ReadAllText(Application.StartupPath & "\System Files\Activity\Activity.json")
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
        File.WriteAllText(Application.StartupPath & "\System Files\Activity\Activity.json", Wjson)
    End Sub

    Public Function CheckExistRelationsforDelete(SQl As String, FieldName As String, msg As String) As Boolean
        CheckExistRelationsforDelete = True
        CMD = New OleDb.OleDbCommand(SQl)
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

#Region "OpenCashDrawer"
    Public Sub OpenCashdrawer()
        If My.Settings.CashDrawer = False Then Exit Sub
        'Modify DrawerCode to your receipt printer open drawer code
        Dim DrawerCode As String = Chr(27) & Chr(112) & Chr(48) & Chr(64) & Chr(64)
        'Modify PrinterName to your receipt printer name
        Dim PrinterName As String = My.Settings.BillPrinterName

        RawPrinter.PrintRaw(PrinterName, DrawerCode)
    End Sub

    Public Class RawPrinter
        ' ----- Define the data type that supplies basic print job information to the spooler.
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
        Public Structure DOCINFO
            <MarshalAs(UnmanagedType.LPWStr)>
            Public pDocName As String
            <MarshalAs(UnmanagedType.LPWStr)>
            Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)>
            Public pDataType As String
        End Structure

        ' ----- Define interfaces to the functions supplied in the DLL.
        <DllImport("winspool.drv", EntryPoint:="OpenPrinterW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function OpenPrinter(ByVal printerName As String, ByRef hPrinter As IntPtr, ByVal printerDefaults As Integer) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="ClosePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="StartDocPrinterW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Integer, ByRef documentInfo As DOCINFO) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="EndDocPrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="StartPagePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="EndPagePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="WritePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal buffer As IntPtr, ByVal bufferLength As Integer, ByRef bytesWritten As Integer) As Boolean
        End Function

        Public Shared Function PrintRaw(ByVal printerName As String, ByVal origString As String) As Boolean
            ' ----- Send a string of  raw data to  the printer.
            Dim hPrinter As IntPtr
            Dim spoolData As New DOCINFO
            Dim dataToSend As IntPtr
            Dim dataSize As Integer
            Dim bytesWritten As Integer

            ' ----- The internal format of a .NET String is just
            '       different enough from what the printer expects
            '       that there will be a problem if we send it
            '       directly. Convert it to ANSI format before
            '       sending.
            dataSize = origString.Length()
            dataToSend = Marshal.StringToCoTaskMemAnsi(origString)

            ' ----- Prepare information for the spooler.
            spoolData.pDocName = "OpenDrawer" ' class='highlight'
            spoolData.pDataType = "RAW"

            Try
                ' ----- Open a channel to  the printer or spooler.
                Call OpenPrinter(printerName, hPrinter, 0)

                ' ----- Start a new document and Section 1.1.
                Call StartDocPrinter(hPrinter, 1, spoolData)
                Call StartPagePrinter(hPrinter)

                ' ----- Send the data to the printer.
                Call WritePrinter(hPrinter, dataToSend,
                   dataSize, bytesWritten)

                ' ----- Close everything that we opened.
                EndPagePrinter(hPrinter)
                EndDocPrinter(hPrinter)
                ClosePrinter(hPrinter)
                PrintRaw = True
            Catch ex As Exception
                MsgBox("Error occurred: " & ex.ToString)
                PrintRaw = False
            Finally
                ' ----- Get rid of the special ANSI version.
                Marshal.FreeCoTaskMem(dataToSend)
            End Try
        End Function
    End Class
#End Region

#Region "MessagePanel"
    'Indicates current Message panel to add controls to 
    Private _CurrentMessagePanelName As String = Nothing

    'Used to give unique control names such as label1, label2 etc
    Private _MessagePanelsAddedCount As Integer = 0

    'Add Message panel to flow layout panel
    Public Sub CreateMessagePanel(Title As String, Message As String, Optional ByVal Tag As String = "")
        Dim MessagePanel As New ControlMessageBox
        'Add panel to flow layout panel
        MdifrmMain.flpMessage.Controls.Add(MessagePanel)

        'Update panel variables
        _CurrentMessagePanelName = MessagePanel.Name
        _MessagePanelsAddedCount += 1

        MessagePanel.btnMessageDelete.Name = "btnMessageDelete" + (_MessagePanelsAddedCount).ToString

        MessagePanel.lblTitle.Name = "lblTitle" + (_MessagePanelsAddedCount).ToString
        MessagePanel.lblTitle.Text = Title

        MessagePanel.lblMessage.Name = "lblMessage" + (_MessagePanelsAddedCount).ToString
        MessagePanel.lblMessage.Text = Message

        'Set panel properties
        With MessagePanel
            .Name = "pnlMessage" + (_MessagePanelsAddedCount).ToString
            .Tag = Tag
        End With
    End Sub
    'Remove handlers and Message panel 
    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentPanelName As String

        parentPanelName = Nothing

        'Remove handler from sender
        For Each controlObj As Control In MdifrmMain.flpMessage.Controls
            For Each childControlObj As Control In controlObj.Controls
                If childControlObj.Name = sender.name Then
                    RemoveHandler childControlObj.Click, AddressOf DynamicButton_Click
                    parentPanelName = childControlObj.Parent.Name
                End If
            Next
            If controlObj.Name = parentPanelName Then
                MdifrmMain.flpMessage.Controls.Remove(controlObj)
                controlObj.Dispose()
            End If
        Next

    End Sub
#End Region

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
        AddHandler cmdOpenCashDrawer.Click, AddressOf OpenCashdrawer

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

