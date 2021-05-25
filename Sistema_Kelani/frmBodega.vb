Imports System.Data.SqlClient
Public Class frmBodega

    Private Sub frmBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.vw_Bodega' Puede moverla o quitarla según sea necesario.
        Me.Vw_BodegaTableAdapter.Fill(Me.KelaniDataSet.vw_Bodega)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.bodega' Puede moverla o quitarla según sea necesario.
        Me.BodegaTableAdapter.Fill(Me.KelaniDataSet.bodega)

    End Sub

    Private Sub limpiarCampos()
        Me.txtIdBodega.Text = ""
        Me.txtBodega.Text = ""
        Me.cbxEstado.SelectedIndex = -1

    End Sub

    Private Sub dgvBodega_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBodega.CellContentClick

        Me.txtIdBodega.Text = dgvBodega.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txtBodega.Text = dgvBodega.CurrentRow.Cells.Item(1).Value.ToString()

    End Sub

    Private Sub btmIngresar_Click(sender As Object, e As EventArgs) Handles btmIngresar.Click
        Dim estado As Int32
        If (Me.cbxEstado.SelectedIndex = -1) Then
            MessageBox.Show("Seleccione el estado del bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (Me.cbxEstado.SelectedItem.Equals("INACTIVO")) Then
                estado = 3
            Else
                estado = 1
            End If
            If (Me.txtBodega.Text.Equals("")) Then
                MessageBox.Show("Seleccione el usuario que desee dar de baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.BodegaTableAdapter.InsertQuery1(Me.txtBodega.Text, estado)
                MessageBox.Show("La bodega se ha guardado correctamente", "Gestion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Vw_BodegaTableAdapter.Fill(Me.KelaniDataSet.vw_Bodega)
                limpiarCampos()
            End If
        End If


    End Sub

    Private Sub btmEditar_Click(sender As Object, e As EventArgs) Handles btmEditar.Click
        Try
            Dim estado As Int32
            If (Me.cbxEstado.SelectedIndex = -1) Then
                MessageBox.Show("Seleccione el estado del bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If (Me.cbxEstado.SelectedItem.Equals("INACTIVO")) Then
                    estado = 3
                Else
                    estado = 1
                End If
                If (Me.txtIdBodega.Text.Equals("")) Then
                    MessageBox.Show("Debe seleccionar una Bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else


                    Me.BodegaTableAdapter.UpdateQuery(Me.txtBodega.Text, estado, Convert.ToInt32(Me.txtIdBodega.Text))
                    MessageBox.Show("La Bodega se ha actualizo correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Vw_BodegaTableAdapter.Fill(Me.KelaniDataSet.vw_Bodega)
                    limpiarCampos()
                End If
            End If
        Catch sqlEx As SqlException
            MsgBox("Error al editar los estados", sqlEx.Message())
            MsgBox("Error al editar los estados", sqlEx.StackTrace())

        Catch Ex As Exception
            MsgBox("Error al editar los estados", Ex.Message())
            MsgBox("Error al editar los estados", Ex.StackTrace())

        End Try



    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Me.dgvBodega.DataSource = Me.Vw_BodegaTableAdapter.GetDataByText(txtBuscar.Text)
        Catch sqlEx As SqlException
            MsgBox("Error al editar el tipo de movimiento", sqlEx.Message())
        Catch Ex As Exception
            MsgBox("Error al editar el tipo de movimiento", Ex.Message())
            MsgBox("Error al editar el tipo de movimiento", Ex.StackTrace())

        End Try
    End Sub
End Class