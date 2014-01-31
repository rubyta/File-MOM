
Partial Class Master_Template
    Inherits System.Web.UI.MasterPage

    Protected Sub LogoutButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogoutButton.Click
        Response.Redirect("~/Logout.aspx")
    End Sub
End Class

