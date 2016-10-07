Public Class Facebook_Form


    Private Sub Facebook_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Facebook_Browser.Navigate("wwww.facebook.com")

    End Sub

    Public Sub focusit()

        Dim allelements As HtmlElementCollection = Facebook_Browser.Document.All

        Try

            For Each webpageelement As HtmlElement In allelements

                If webpageelement.GetAttribute("classname").Contains("UFIAddCommentInput") Then

                    webpageelement.Focus()
                    Delay(1)

                    Dim randomNo As New Random
                    Dim randomIndex As Integer = randomNo.Next(0, lstspamtext.Items.Count - 1)

                    SendKeys.Send(lstspamtext.Items(randomIndex))
                    Delay(4)
                    SendKeys.Send("{ENTER}")

                    Dim RandNo As Integer = CInt(Math.Ceiling(Rnd() * 90)) + 1
                    Delay(RandNo)

                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFocus_Click(sender As Object, e As EventArgs) Handles btnFocus.Click
        focusit()
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        timermore.Enabled = True
        timermore.Interval = "500"
        timermore.Start()
    End Sub

    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        timermore.Enabled = False
        timermore.Stop()
    End Sub

    Private Sub timermore_Tick(sender As Object, e As EventArgs) Handles timermore.Tick
        'Scroll Down
        Facebook_Browser.Document.Body.ScrollIntoView(False)
    End Sub

    Private Sub btnAddTextToList_Click(sender As Object, e As EventArgs) Handles btnAddTextToList.Click
        lstspamtext.Items.Add(txtSpamText.Text)
    End Sub
End Class
