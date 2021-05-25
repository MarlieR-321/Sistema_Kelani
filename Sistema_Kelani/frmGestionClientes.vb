Imports System.Data.SqlClient

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

        If String.IsNullOrEmpty(txtApellido.Text) Or
            String.IsNullOrEmpty(txtCedula.Text) Or
            String.IsNullOrEmpty(txtEmail.Text) Or
            String.IsNullOrEmpty(txtNombre.Text) Or
            String.IsNullOrEmpty(txttelefono.Text) Or
            String.IsNullOrEmpty(txtIDCLIENTE.Text) Or
            String.IsNullOrEmpty(rtbDireccion.Text) Then

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

            Try

                Me.ClienteTableAdapter.agregar(
                                txtNombre.Text,
                                txtApellido.Text,
                                txtCedula.Text,
                                txttelefono.Text,
                                rtbDireccion.Text,
                                txtEmail.Text,
                                Convert.ToInt32(cbxTipo.SelectedValue))

                Me.VwClientesTableAdapter1.Fill(Me.KelaniDataSet.VwClientes)

            Catch SQLex As SqlException

                MsgBox("Hubo un error al registrar el cliente\n" + SQLex.ToString(), MsgBoxStyle.Critical, "Error SQL")

            Catch ex As Exception

                MsgBox("Hubo un error al registrar el cliente\n" + ex.ToString(), MsgBoxStyle.Critical, "Error")
                MsgBox("Hubo un error al registrar el cliente\n" + ex.StackTrace(), MsgBoxStyle.Critical, "Error")

            End Try

        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If ComprobarCampos.Equals(1) Then

            MessageBox.Show("Hay campos vacíos")

        Else

            Try

                Me.ClienteTableAdapter.editarCliente(txtNombre.Text,
                                txtApellido.Text,
                                txtCedula.Text,
                                txttelefono.Text,
                                rtbDireccion.Text,
                                txtEmail.Text,
                                Convert.ToInt32(cbxTipo.SelectedValue),
                                Convert.ToInt32(txtIDCLIENTE.Text))

                Me.VwClientesTableAdapter1.Fill(Me.KelaniDataSet.VwClientes)
            Catch SQLex As SqlException

                MsgBox("Hubo un error al editar el cliente" + vbCr + SQLex.ToString(), MsgBoxStyle.Critical, "Error SQL")


            Catch ex As Exception

                MsgBox("Hubo un error al editar el cliente" + vbCr + ex.ToString(), MsgBoxStyle.Critical, "Error")
                MsgBox("Hubo un error al editar el cliente" + vbCr + ex.StackTrace(), MsgBoxStyle.Critical, "Error")

            End Try

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            Dim idEliminar = txtIDCLIENTE.Text

            If idEliminar.Equals("") Then

                MessageBox.Show("No seleccionaste un cliente")

            Else

                Convert.ToInt32(idEliminar)

                Me.ClienteTableAdapter.eliminarCliente(idEliminar)
                Me.VwClientesTableAdapter1.Fill(Me.KelaniDataSet.VwClientes)

            End If

        Catch ex As Exception

            MsgBox("Hubo un error al borrar el cliente\n" + ex.ToString(), MsgBoxStyle.Critical, "Error")
            MsgBox("Hubo un error al borrar el cliente\n" + ex.StackTrace(), MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        txtIDCLIENTE.Text = dgvClientes.CurrentRow.Cells.Item(0).Value.ToString
        txtNombre.Text = dgvClientes.CurrentRow.Cells.Item(1).Value.ToString
        txtApellido.Text = dgvClientes.CurrentRow.Cells.Item(2).Value.ToString
        txttelefono.Text = dgvClientes.CurrentRow.Cells.Item(3).Value.ToString
        txtEmail.Text = dgvClientes.CurrentRow.Cells.Item(4).Value.ToString
        txtCedula.Text = dgvClientes.CurrentRow.Cells.Item(5).Value.ToString
        rtbDireccion.Text = dgvClientes.CurrentRow.Cells.Item(6).Value.ToString
        'cbxTipo.SelectedValue = dgvClientes.CurrentRow.Cells.Item(7).Value.ToString()
    End Sub
End Class