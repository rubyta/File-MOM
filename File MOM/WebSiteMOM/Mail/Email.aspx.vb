Imports System
Imports System.Data
Imports System.Net.Mail

Partial Class Mail_Email
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Try
            Dim mail As MailMessage = New MailMessage()
            mail.To.Add(txtTo.Text)
            mail.From = New MailAddress("rubyta.herwinda@gmail.com")
            mail.Subject = txtSubject.Text
            mail.Body = txtBody.Text
            mail.BodyEncoding = System.Text.Encoding.UTF8
            mail.IsBodyHtml = True
            mail.Priority = MailPriority.High

            If fileUpload1.HasFile Then
                mail.Attachments.Add(New Attachment(fileUpload1.PostedFile.InputStream, fileUpload1.FileName))
            End If

            Dim smtp As SmtpClient = New SmtpClient()
            smtp.Host = "smtp.gmail.com"
            smtp.Credentials = New System.Net.NetworkCredential("rubyta.herwinda@gmail.com", "rubygila20")
            smtp.Port = 587
            smtp.EnableSsl = False
            smtp.Send(mail)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Response.Write("Your email has been sent successfully")
        End Try
    End Sub
End Class

