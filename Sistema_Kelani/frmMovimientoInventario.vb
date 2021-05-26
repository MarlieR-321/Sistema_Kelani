Imports System.Data.SqlClient

Public Class frmMovimientoInventario

    Private Sub MovimientoInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet1.t_mov_inv' Puede moverla o quitarla según sea necesario.
        Me.T_mov_invTableAdapter.Fill(Me.KelaniDataSet1.t_mov_inv)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet1.vwMov_Inv' Puede moverla o quitarla según sea necesario.
        Me.VwMov_InvTableAdapter.Fill(Me.KelaniDataSet1.vwMov_Inv)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet1.mov_inv' Puede moverla o quitarla según sea necesario.
        Me.Mov_invTableAdapter.Fill(Me.KelaniDataSet1.mov_inv)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet1.mov_inv' Puede moverla o quitarla según sea necesario.
        Me.Mov_invTableAdapter.Fill(Me.KelaniDataSet1.mov_inv)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet2.mov_inv' Puede moverla o quitarla según sea necesario.
        Me.Mov_invTableAdapter.Fill(Me.KelaniDataSet2.mov_inv)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet1.vwMov_Inv' Puede moverla o quitarla según sea necesario.
        Me.VwMov_InvTableAdapter.Fill(Me.KelaniDataSet1.vwMov_Inv)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet1.t_mov_inv' Puede moverla o quitarla según sea necesario.
        Me.T_mov_invTableAdapter.Fill(Me.KelaniDataSet1.t_mov_inv)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.mov_inv' Puede moverla o quitarla según sea necesario.
        Me.Mov_invTableAdapter.Fill(Me.KelaniDataSet.mov_inv)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.mov_inv' Puede moverla o quitarla según sea necesario.
        Me.Mov_invTableAdapter.Fill(Me.KelaniDataSet.mov_inv)




    End Sub

    Private Sub limpiarCampos()
        Me.txtIdMovInv.Text = ""
        Me.txtNombMov.Text = ""
        Me.cbxTipoMov.SelectedIndex = -1

    End Sub


    Private Sub btmIngresar_Click(sender As Object, e As EventArgs) Handles btmIngresar.Click
        If (Me.txtNombMov.Text.Equals("") Or Me.cbxTipoMov.SelectedValue = -1) Then
            MessageBox.Show("Todos los campos son necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Me.Mov_invTableAdapter.InsertQuery(Me.txtNombMov.Text, Convert.ToInt32(Me.cbxTipoMov.SelectedValue))
                Me.dgvMovInv.DataSource = Me.VwMov_InvTableAdapter.GetData()

                'Me.VwMov_InvTableAdapter.GetDataByText = Me.Vw_usuariosTableAdapter.GetDataByTexto(txtBuscar.Text)

                limpiarCampos()
                MessageBox.Show("El movimiento del inventario se ha guardado correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch sqlEx As SqlException
                MsgBox("Error al registrar el movimiento del inventario", sqlEx.Message())
            Catch Ex As Exception
                MsgBox("Error al registrar el movimiento del inventario", Ex.Message())
                MsgBox("Error al registrar el movimiento del inventario", Ex.StackTrace())
            End Try

        End If

    End Sub

    Private Sub dgvMovInv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovInv.CellContentClick
        Me.txtIdMovInv.Text = dgvMovInv.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txtNombMov.Text = dgvMovInv.CurrentRow.Cells.Item(1).Value.ToString()
        Me.cbxTipoMov.SelectedValue = dgvMovInv.CurrentRow.Cells.Item(2).Value.ToString()
        Me.txtTMI.Text = dgvMovInv.CurrentRow.Cells.Item(3).Value.ToString()

    End Sub

    Private Sub btmEditar_Click(sender As Object, e As EventArgs) Handles btmEditar.Click
        If (Me.txtIdMovInv.Text.Equals("")) Then
            MessageBox.Show("Debe seleccionar un movimiento del inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (Me.txtNombMov.Text.Equals("") Or Me.cbxTipoMov.SelectedValue = -1) Then

                MessageBox.Show("Todos los campos son necesarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Me.Mov_invTableAdapter.UpdateQuery(txtNombMov.Text, Me.cbxTipoMov.SelectedValue, Me.txtIdMovInv.Text)

                    Me.VwMov_InvTableAdapter.Fill(Me.KelaniDataSet.vwMov_Inv)
                    limpiarCampos()

                Catch sqlEx As SqlException
                    MsgBox("Error al actualizar el movimiento del inventario", sqlEx.Message())
                Catch Ex As Exception
                    MsgBox("Error al actualizar el movimiento del inventario", Ex.Message())
                    MsgBox("Error al actualizar el movimiento del inventario", Ex.StackTrace())
                End Try

            End If
        End If
    End Sub

    Private Sub btmEliminar_Click(sender As Object, e As EventArgs) Handles btmEliminar.Click
        If (Me.txtIdMovInv.Text.Equals("")) Then
            MessageBox.Show("Debe seleccionar un movimiento del inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim answer As Int32

            answer = MessageBox.Show("Esta seguro que quiere eliminar permanentemente el movimiento del inventario?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            Try
                If (answer = vbYes) Then

                    Me.Mov_invTableAdapter.DeleteQuery(Me.txtIdMovInv.Text)
                    Me.VwMov_InvTableAdapter.Fill(Me.KelaniDataSet.vwMov_Inv)
                    limpiarCampos()
                    MessageBox.Show("Ha eliminado el movimiento del inventario correctamente", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                End If
            Catch sqlEx As SqlException
                MsgBox("Error al eliminar el movimiento del inventario", sqlEx.Message())
            Catch Ex As Exception
                MsgBox("Error al eliminar el movimiento del inventario", Ex.Message())
                MsgBox("Error al eliminar el movimiento del inventario", Ex.StackTrace())
            End Try


        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Me.dgvMovInv.DataSource = Me.VwMov_InvTableAdapter.GetDataByText(txtBuscar.Text)
        Catch sqlEx As SqlException
            MsgBox("Error al buscar los movimientos del inventario", sqlEx.Message())
        Catch Ex As Exception
            MsgBox("Error al buscar los movimientos del inventario", Ex.Message())
            MsgBox("Error al buscar los movimientos del inventario", Ex.StackTrace())
        End Try
    End Sub
End Class