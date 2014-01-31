
Partial Class Master_Template4
    Inherits System.Web.UI.MasterPage

    Protected Sub LogoutButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogoutButton.Click
        Response.Redirect("~/Default.aspx")
    End Sub
End Class

