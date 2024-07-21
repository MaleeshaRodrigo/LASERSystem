Namespace StructureDatabase
    Public Structure Tables
        Const AdminPermission = "AdminPermission"
        Const APCCommand = "APCCommand"
        Const Customer = "Customer"
        Const CustomerLoan = "CustomerLoan"
        Const Deliver = "Deliver"
        Const Mail = "Mail"
        Const Message = "Message"
        Const OnlineDB = "OnlineDB"
        Const Product = "Product"
        Const Receive = "Receive"
        Const Repair = "Repair"
        Const RepairActivity = "RepairActivity"
        Const RepairAdvanced = "RepairAdvanced"
        Const RepairRemarks1 = "RepairRemarks1"
        Const RepairRemarks2 = "RepairRemarks2"
        Const ReRepair = "Return"
        Const Sale = "Sale"
        Const SalesRepair = "SalesRepair"
        Const Settlement = "Settlement"
        Const Stock = "Stock"
        Const StockSale = "StockSale"
        Const StockSupply = "StockSupply"
        Const Supplier = "Supplier"
        Const Supply = "Supply"
        Const Technician = "Technician"
        Const TechnicianCost = "TechnicianCost"
        Const TechnicianLoan = "TechnicianLoan"
        Const TechnicianSalary = "TechnicianSalary"
        Const Transaction = "Transaction"
        Const User = "User"
    End Structure

    Public Structure AdminPermission
        Const APNo = "APNo"
        Const APDate = "APDate"
        Const Status = "Status"
        Const AppliedUNo = "AppliedUNo"
        Const ConfirmedUNo = "ConfirmedUNo"
        Const Keys = "Keys"
        Const Remarks = "Remarks"
        Const CreatedAt = "created_at"
        Const UpdatedAt = "updated_at"
    End Structure

    Public Structure Customer
        Const CuNo = "CuNo"
        Const CuName = "CuName"
        Const CuTelNo1 = "CuTelNo1"
        Const CuTelNo2 = "CuTelNo2"
        Const CuTelNo3 = "CuTelNo3"
        Const CuRemarks = "CuRemarks"
    End Structure

    Public Structure CustomerLoan
        Const CuLNo = "CuLNo"
        Const CuLDate = "CuLDate"
        Const CuNo = "CuNo"
        Const SaNo = "SaNo"
        Const DNo = "DNo"
        Const CuLAmount = "CuLAmount"
        Const Status = "Status"
        Const CuLRemarks = "CuLRemarks"
    End Structure

    Public Structure Deliver
        Const DNo = "DNo"
        Const DDate = "DDate"
        Const CuNo = "CuNo"
        Const DGrandTotal = "DGrandTotal"
        Const CReceived = "CReceived"
        Const CBalance = "CBalance"
        Const CAmount = "CAmount"
        Const CPInvoiceNo = "CPInvoiceNo"
        Const CPAmount = "CPAmount"
        Const CuLNo = "CuLNo"
        Const CuLAmount = "CuLAmount"
        Const DRemarks = "DRemarks"
        Const UNo = "UNo"
    End Structure

    Public Structure Mail
        Const MailNo = "MailNo"
        Const MailDate = "MailDate"
        Const EmailTo = "EmailTo"
        Const Subject = "Subject"
        Const Body = "Body"
        Const Attachment1 = "Attachment1"
        Const Attachment2 = "Attachment2"
        Const Attachment3 = "Attachment3"
        Const Status = "Status"
    End Structure

    Public Structure Message
        Const MsgNo = "MsgNo"
        Const MsgDate = "MsgDate"
        Const Action = "Action"
        Const RepNo = "RepNo"
        Const RetNo = "RetNo"
        Const TelNo = "TelNo"
        Const Message = "Message"
        Const Status = "Status"
    End Structure

    Public Structure MessageSuggestion
        Const Id = "id"
        Const Message = "message"
    End Structure

    Public Structure Product
        Const PNo = "PNo"
        Const PCategory = "PCategory"
        Const PName = "PName"
        Const PModelNo = "PModelNo"
        Const PDetails = "PDetails"
    End Structure

    Public Structure Receive
        Const RNo = "RNo"
        Const RDate = "RDate"
        Const CuNo = "CuNo"
        Const UNo = "UNo"
    End Structure

    Public Structure Repair
        Const RepNo = "RepNo"
        Const RNo = "RNo"
        Const PNo = "PNo"
        Const PSerialNo = "PSerialNo"
        Const Location = "Location"
        Const Problem = "Problem"
        Const Qty = "Qty"
        Const Charge = "Charge"
        Const PaidPrice = "PaidPrice"
        Const TNo = "TNo"
        Const Status = "Status"
        Const RepDate = "RepDate"
        Const DNo = "DNo"
        Const TSalNo = "TSalNo"
        Const CreatedAt = "created_at"
        Const UpdatedAt = "updated_at"
    End Structure

    Public Structure RepairActivity
        Const RepANo = "RepANo"
        Const RepNo = "RepNo"
        Const RetNo = "RetNo"
        Const RepADate = "RepADate"
        Const Activity = "Activity"
        Const UNo = "UNo"
    End Structure

    Public Structure RepairAdvanced
        Const ADNo = "ADNo"
        Const ADDate = "ADDate"
        Const RepNo = "RepNo"
        Const RetNo = "RetNo"
        Const Amount = "Amount"
        Const Remarks = "Remarks"
        Const UNo = "UNo"
    End Structure

    Public Structure RepairRemarks1
        Const Rem1No = "Rem1No"
        Const Rem1Date = "Rem1Date"
        Const RepNo = "RepNo"
        Const RetNo = "RetNo"
        Const Remarks = "Remarks"
        Const UNo = "UNo"
    End Structure

    Public Structure RepairRemarks2
        Const Rem2No = "Rem2No"
        Const Rem2Date = "Rem2Date"
        Const RepNo = "RepNo"
        Const RetNo = "RetNo"
        Const Remarks = "Remarks"
        Const UNo = "UNo"
    End Structure

    Public Structure ReRepair
        Const RetNo = "RetNo"
        Const RepNo = "RepNo"
        Const RNo = "RNo"
        Const PNo = "PNo"
        Const PSerialNo = "PSerialNo"
        Const Location = "Location"
        Const Problem = "Problem"
        Const Qty = "Qty"
        Const Charge = "Charge"
        Const PaidPrice = "PaidPrice"
        Const TNo = "TNo"
        Const Status = "Status"
        Const RepDate = "RepDate"
        Const DNo = "DNo"
        Const TSalNo = "TSalNo"
        Const CreatedAt = "created_at"
        Const UpdatedAt = "updated_at"
    End Structure

    Public Structure Sale
        Const SaNo = "SaNo"
        Const SaDate = "SaDate"
        Const CuNo = "CuNo"
        Const SaSubTotal = "SaSubTotal"
        Const SaLess = "SaLess"
        Const SaDue = "SaDue"
        Const CReceived = "CReceived"
        Const CBalance = "CBalance"
        Const CAmount = "CAmount"
        Const CPInvoiceNo = "CPInvoiceNo"
        Const CPAmount = "CPAmount"
        Const CuLNo = "CuLNo"
        Const CuLAmount = "CuLAmount"
        Const SaRemarks = "SaRemarks"
        Const UNo = "UNo"
    End Structure

    Public Structure Settlement
        Const SetNo = "SetNo"
        Const SetDate = "SetDate"
        Const SaTotal = "SaTotal"
        Const RepTotal = "RepTotal"
        Const TATotal = "TATotal"
        Const SetGrandTotal = "SetGrandTotal"
        Const CTotal = "CTotal"
        Const CPTotal = "CPTotal"
        Const CuLTotal = "CuLTotal"
        Const CPReceiptQty = "CPReceiptQty"
        Const CashinLocker = "CashinLocker"
        Const SetChange = "SetChange"
        Const LKR5000 = "LKR5000"
        Const LKR1000 = "LKR1000"
        Const LKR500 = "LKR500"
        Const LKR100 = "LKR100"
        Const LKR50 = "LKR50"
        Const LKR20 = "LKR20"
        Const LKR10 = "LKR10"
        Const LKR5 = "LKR5"
        Const LKR2 = "LKR2"
        Const LKR1 = "LKR1"
    End Structure

    Public Structure Stock
        Const Code = "SNo"
        Const Category = "SCategory"
        Const Name = "SName"
        Const ModelNo = "SModelNo"
        Const Location = "SLocation"
        Const Details = "SDetails"
        Const SalePrice = "SSalePrice"
        Const CostPrice = "SCostPrice"
        Const LowestPrice = "SLowestPrice"
        Const AvailableUnits = "SAvailableStocks"
        Const DamagedUnits = "SOutofStocks"
        Const ReorderPoint = "SMinStocks"
    End Structure

    Public Structure StockSale
        Const SSaNo = "SSaNo"
        Const SaNo = "SaNo"
        Const SNo = "SNo"
        Const SCategory = "SCategory"
        Const SName = "SName"
        Const SaType = "SaType"
        Const SaUnits = "SaUnits"
        Const SaRate = "SaRate"
        Const SaTotal = "SaTotal"
    End Structure

    Public Structure StockSupply
        Const SSupNo = "SSupNo"
        Const SupNo = "SupNo"
        Const SNo = "SNo"
        Const SCategory = "SCategory"
        Const SName = "SName"
        Const SupType = "SupType"
        Const SupUnits = "SupUnits"
        Const SupCostPrice = "SupCostPrice"
        Const SupTotal = "SupTotal"
    End Structure

    Public Structure Supplier
        Const SuNo = "SuNo"
        Const SuName = "SuName"
        Const SuAddress = "SuAddress"
        Const SuEmail = "SuEmail"
        Const SuTelNo1 = "SuTelNo1"
        Const SuTelNo2 = "SuTelNo2"
        Const SuTelNo3 = "SuTelNo3"
        Const SuRemarks = "SuRemarks"
    End Structure

    Public Structure Supply
        Const SupNo = "SupNo"
        Const SupDate = "SupDate"
        Const SuNo = "SuNo"
        Const SupGrandTotal = "SupGrandTotal"
        Const SupRemarks = "SupRemarks"
        Const UNo = "UNo"
    End Structure

    Public Structure User
        Const UNo = "UNo"
        Const Username = "Username"
        Const Password = "Password"
        Const UCategory = "UCategory"
        Const UName = "UName"
        Const Email = "Email"
        Const UAddress = "UAddress"
        Const UTelNo1 = "UTelNo1"
        Const UTelNo2 = "UTelNo2"
        Const UTelNo3 = "UTelNo3"
        Const IsLogin = "IsLogin"
        Const IsMail = "IsMail"
        Const URemarks = "URemarks"
    End Structure

End Namespace
