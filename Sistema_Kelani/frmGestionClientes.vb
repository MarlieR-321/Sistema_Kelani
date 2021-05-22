Public Class frmGestionClientes
    Private Sub frmGestionClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.T_Cliente' Puede moverla o quitarla según sea necesario.
        Me.T_ClienteTableAdapter.Fill(Me.KelaniDataSet.T_Cliente)
        Me.VwClientesTableAdapter1.Fill(Me.KelaniDataSet.VwClientes)
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
        If (ComprobarCampos.Equals(1)) Then
            MessageBox.Show("Hay campos vacíos")
        Else

            Me.ClienteTableAdapter.agregar(
                                            txtNombre.Text,
                                            txtApellido.Text,
                                            txtCedula.Text,
                                            txttelefono.Text,
                                            rtbDireccion.Text,
                                            txtEmail.Text,
                                            Convert.ToInt32(cbxTipo.SelectedValue))
            Me.VwClientesTableAdapter1.Fill(Me.KelaniDataSet.VwClientes)

        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If ComprobarCampos.Equals(1) Then

            MessageBox.Show("Hay campos vacíos")

        Else

            Me.ClienteTableAdapter.editarCliente(txtNombre.Text,
                                            txtApellido.Text,
                                            txtCedula.Text,
                                            txttelefono.Text,
                                            rtbDireccion.Text,
                                            txtEmail.Text,
                                            Convert.ToInt32(cbxTipo.SelectedValue),
                                            Convert.ToInt32(txtIDCLIENTE.Text))

            Me.VwClientesTableAdapter1.Fill(Me.KelaniDataSet.VwClientes)

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim idEliminar = Convert.ToInt32(txtIDCLIENTE.Text)

        If idEliminar.Equals("") Then

            MessageBox.Show("No seleccionaste un cliente")

        Else

            Me.ClienteTableAdapter.eliminarCliente(idEliminar)
            Me.VwClientesTableAdapter1.Fill(Me.KelaniDataSet.VwClientes)

        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        txtIDCLIENTE.Text = dgvClientes.CurrentRow.Cells.Item(0).Value.ToString
        txtNombre.Text = dgvClientes.CurrentRow.Cells.Item(1).Value.ToString
        txtApellido.Text = dgvClientes.CurrentRow.Cells.Item(2).Value.ToString
        txttelefono.Text = dgvClientes.CurrentRow.Cells.Item(3).Value.ToString
        txtEmail.Text = dgvClientes.CurrentRow.Cells.Item(4).Value.ToString
        txtCedula.Text = dgvClientes.CurrentRow.Cells.Item(5).Value.ToString
        rtbDireccion.Text = dgvClientes.CurrentRow.Cells.Item(6).Value.ToString
        cbxTipo.SelectedItem = dgvClientes.CurrentRow.Cells.Item(7).Value.ToString
    End Sub
End Class