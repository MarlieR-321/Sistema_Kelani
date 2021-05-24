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
        'Me.txtDescripcion.Text = DgvCategoria.CurrentRow.Cells.Item(2).Value.ToString()
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
                'Try

                Me.BodegaTableAdapter.UpdateQuery(Me.txtBodega.Text, estado)
                MessageBox.Show("La Bodega se ha actualizo correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Catch sqlEx As SqlException
                Me.Vw_BodegaTableAdapter.Fill(Me.KelaniDataSet.vw_Bodega)
                limpiarCampos()
            End If

            'MsgBox("Error al editar las categorias", sqlEx.Message())
            'Catch Ex As Exception
            'MsgBox("Error al editar las categorias", Ex.Message())
            'MsgBox("Error al editar las categorias", Ex.StackTrace())

            'End Try

        End If
    End Sub
End Class