Public Class frmGestionClientes
    Private Sub frmGestionClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.T_Cliente' Puede moverla o quitarla según sea necesario.
        Me.T_ClienteTableAdapter.Fill(Me.KelaniDataSet.T_Cliente)

    End Sub
    Private Sub limpiarCampos()
        txtApellido.Text = ""
        txtCedula.Text = ""
        txtEmail.Text = ""
        txtIDCLIENTE.Text = ""
        txtNombre.Text = ""
        txttelefono.Text = ""
        rtbDireccion.Text = ""
    End Sub

    Function ComprobarCampos() As Integer
        'Verifica que ninguno de los campos del formulario estén vacíos.
        'Retorna 1 si están vacíos

        If (String.IsNullOrEmpty(txtApellido.Text) Or
            String.IsNullOrEmpty(txtCedula.Text) Or
            String.IsNullOrEmpty(txtEmail.Text) Or
            String.IsNullOrEmpty(txtNombre.Text) Or
            String.IsNullOrEmpty(txttelefono.Text)) Then

            Return 1

        Else

            Return 0

        End If


    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (ComprobarCampos().Equals(1)) Then
            MessageBox.Show("Hay campos vacíos")

        Else



        End If
    End Sub
End Class