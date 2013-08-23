Module modCommon
    'Public CL As New DBFunction
    Public mConnectionString As String
    Public scrMode_frmdbo_dolia_alpha As String
    Public scrMode_frmdbo_dolia_fyear As String
    Public searchSQL As String
    Public cmbSelectValue As String
    Public searchSQLFilter As String
    Public searchSQLFilter1 As String
    Public mySelectQuery As String
    Public keyascii As Integer
    Public searchKeyID As String
    Public searchKeydolia_fyear0 As String

    Public searchOwner As String
    Public searchTable As String
    Public fldString As String
    Public fldHeading As String
    Public fldCount As Integer
    Public fldBoolean As String
    Public fldNum As String
    Public fldNumDot As String
    Public fldDate As String
    Public fldForeignHeading As String
    Public fldForeignString As String
    Public fldCondition As String = "[ALL], =, >, <, >=, <=, <>, like, not like,"
    Public mCriteria As String
    Public xxxGet As String
    Public x00 As Integer = 0
    Public xxStart As Integer = 1
    Public xxLength As Integer = 0
    Public arrAdvSearch(500) As Object
    Public IsValid As Boolean

    Public msgCaptionDBError As String = "Failed"
    Public msgNotAdded As String = "Record not added!"
    Public msgAdded As String = "Record successfully added!"
    Public msgUpdated As String = "Record successfully updated!"
    Public msgDelete As String = "Do you really want to delete this record?"
    Public msgDeleted As String = "Record successfully deleted!"
    Public msgCaptionEntry As String = "Success!"
    Public msgCaptionInfo As String = "Invalid!"
    Public msgCaptionDelete As String = "Delete record?"
    Public msgConcurrencyError As String = "Another user has updated or deleted that record."
    Public msgNoRecord As String = "No records to display!"
    Public msgRecordExists As String = "Record already exists!"
    Public msgCmbHelp As String = "Press Ctrl + z for combo-box lookup help."
    Public msgNotNull As String = "Value should NOT be Null."
    Public PasswordMismatch As String = "The passwords do not match."
    Public msgUserNotFound As String = "The user does not exist."

    '//public modules
    Public edit As Boolean = False
    Public collegeid As Integer = 0
    Public facultyid As Integer = 0
    Public teacherid As Integer = 0
    Public staffid As Integer = 0
    Public userid As Integer = 0
    '//retire list
    Public retirelist As Integer = 0
    Public year As String = 0
    Public year1 As String = 0
    Public year2 As String = 0
    Public singleYear As Integer = 0
    Public multiYear As Integer = 0

    '//end retirelist



End Module
