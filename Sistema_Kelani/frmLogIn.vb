Public Class LogIn
	Private Sub btnSalir_Click(sender As Object, e As EventArgs)
		LogIn.ActiveForm.Close()
	End Sub

	Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
		frmPrincipal.Show()
		Me.Hide()
	End Sub

	Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
		Close()
	End Sub
End Class
