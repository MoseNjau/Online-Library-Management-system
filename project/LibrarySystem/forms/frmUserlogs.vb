Public Class frmUserlogs
    Private Sub frmUserlogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `Username`, `Email`, `UserRole`,`LogDate`, `LogMode` FROM `tbllogs` l, `tbluser` u WHERE l.`UserId`=u.`UserId`"
        reports(sql, "LogsReport", CrystalReportViewer1)
    End Sub
End Class