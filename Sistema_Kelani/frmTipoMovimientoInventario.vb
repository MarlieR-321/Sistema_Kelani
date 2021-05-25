Imports System.Data.SqlClient

Public Class frmTipoMovimientoInventario
    Private Sub TipoMovimientoInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.t_mov_inv' Puede moverla o quitarla según sea necesario.
        Me.T_mov_invTableAdapter.Fill(Me.KelaniDataSet.t_mov_inv)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.t_mov_inv' Puede moverla o quitarla según sea necesario.
        Me.T_mov_invTableAdapter.Fill(Me.KelaniDataSet.t_mov_inv)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.t_mov_inv' Puede moverla o quitarla según sea necesario.
        Me.T_mov_invTableAdapter.Fill(Me.KelaniDataSet.t_mov_inv)


    End Sub

    Private Sub limpiarCampos()
        Me.txtIdTipoMov.Text = ""
        Me.txtNombTM.Text = ""

    End Sub

    Private Sub btmIngresar_Click(sender As Object, e As EventArgs) Handles btmIngresar.Click
        If (Me.txtNombTM.Text.Equals("")) Then
            MessageBox.Show("El tipo de movimiento es necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Me.T_mov_invTableAdapter.InsertQuery(Me.txtNombTM.Text)
                Me.T_mov_invTableAdapter.Fill(Me.KelaniDataSet.t_mov_inv)
                Me.limpiarCampos()
                MessageBox.Show("El tipo de movimiento se ha guardado correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch sqlEx As SqlException
                MsgBox("Error al ingresar las categorias", sqlEx.Message())
            Catch Ex As Exception
                MsgBox("Error al ingresar el tipo de movimiento", Ex.Message())
                MsgBox("Error al ingresar el tipo de movimiento", Ex.StackTrace())
            End Try

        End If
    End Sub

    Private Sub btmEditar_Click(sender As Object, e As EventArgs) Handles btmEditar.Click
        If (Me.txtIdTipoMov.Text.Equals("") Or Me.txtNombTM.Text.Equals("")) Then
            MessageBox.Show("Debe seleccionar un tipo de movimiento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Me.T_mov_invTableAdapter.UpdateQuery(Me.txtNombTM.Text, Convert.ToInt32(Me.txtIdTipoMov.Text))
                Me.T_mov_invTableAdapter.Fill(Me.KelaniDataSet.t_mov_inv)
                Me.limpiarCampos()
                MessageBox.Show("El tipo de movimiento se ha actualizo correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch sqlEx As SqlException
                MsgBox("Error al editar el tipo de movimiento", sqlEx.Message())
            Catch Ex As Exception
                MsgBox("Error al editar el tipo de movimiento", Ex.Message())
                MsgBox("Error al editar el tipo de movimiento", Ex.StackTrace())

            End Try

        End If
    End Sub

    Private Sub btmEliminar_Click(sender As Object, e As EventArgs) Handles btmEliminar.Click
        If (Me.txtIdTipoMov.Text.Equals("")) Then
            MessageBox.Show("Necesita elegir el tipo de movimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim answer As Int32

            answer = MessageBox.Show("Esta seguro que quiere eliminar permanentemente el tipo de movimiento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (answer = vbYes) Then
                Try
                    Me.T_mov_invTableAdapter.DeleteQuery(Me.txtIdTipoMov.Text)
                    Me.T_mov_invTableAdapter.Fill(Me.KelaniDataSet.t_mov_inv)
                    Me.limpiarCampos()
                    MessageBox.Show("Se elimino el tipo de movimiento correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch sqlEx As SqlException
                    MsgBox("Error al buscar el tipo de movimiento", sqlEx.Message())
                Catch Ex As Exception
                    MsgBox("Error al eliminar el tipo de movimiento", Ex.Message())
                    MsgBox("Error al eliminar el tipo de movimiento", Ex.StackTrace())

                End Try

            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Me.dgvTipoMovInv.DataSource = Me.T_mov_invTableAdapter.GetDataBy3(txtBuscar.Text)
        Catch sqlEx As SqlException
            MsgBox("Error al editar el tipo de movimiento", sqlEx.Message())
        Catch Ex As Exception
            MsgBox("Error al editar el tipo de movimiento", Ex.Message())
            MsgBox("Error al editar el tipo de movimiento", Ex.StackTrace())

        End Try
    End Sub

    Private Sub dgvTipoMovInv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipoMovInv.CellClick
        Me.txtIdTipoMov.Text = dgvTipoMovInv.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txtNombTM.Text = dgvTipoMovInv.CurrentRow.Cells.Item(1).Value.ToString()
    End Sub

End Class