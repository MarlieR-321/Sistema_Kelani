Public Class frmProductos
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.vwProductos' Puede moverla o quitarla según sea necesario.
        Me.VwProductosTableAdapter.Fill(Me.KelaniDataSet.vwProductos)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.unidadMedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadMedidaTableAdapter.Fill(Me.KelaniDataSet.unidadMedida)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.KelaniDataSet.Categoria)


    End Sub

    Private Sub limpiar()
        Me.txtIdProd.Text = ""
        Me.txtNombre.Text = ""
        Me.txtPresentacion.Text = ""
        Me.txtPrecio.Text = ""
        Me.txtCosto.Text = ""
        Me.cbxCategoria.SelectedIndex = -1
        Me.cbxUMedida.SelectedIndex = -1
    End Sub

    Private Sub DgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProductos.CellClick
        Me.txtIdProd.Text = DgvProductos.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txtNombre.Text = DgvProductos.CurrentRow.Cells.Item(1).Value.ToString()
        Me.txtPresentacion.Text = DgvProductos.CurrentRow.Cells.Item(2).Value.ToString()
        Me.txtPrecio.Text = DgvProductos.CurrentRow.Cells.Item(3).Value.ToString()
        Me.txtCosto.Text = DgvProductos.CurrentRow.Cells.Item(4).Value.ToString()
        Me.cbxCategoria.SelectedValue = DgvProductos.CurrentRow.Cells.Item(5).Value.ToString()
        Me.cbxUMedida.SelectedValue = DgvProductos.CurrentRow.Cells.Item(7).Value.ToString()

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If (Me.txtNombre.Text.Equals("") Or Me.txtPresentacion.Text.Equals("") Or Me.txtPrecio.Text.Equals("") Or Me.txtCosto.Text.Equals("") Or Me.cbxCategoria.SelectedValue = -1 Or Me.cbxUMedida.SelectedValue = -1) Then
            MessageBox.Show("Todos los campos son necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.ProductoTableAdapter.InsertQuery(Me.txtNombre.Text, Me.txtPresentacion.Text, Me.txtPrecio.Text, Me.txtCosto.Text, Convert.ToInt32(Me.cbxCategoria.SelectedValue), Convert.ToInt32(Me.cbxUMedida.SelectedValue))
            Me.VwProductosTableAdapter.Fill(Me.KelaniDataSet.vwProductos)
            limpiar()
            MessageBox.Show("El producto se ha guardado correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (Me.txtIdProd.Text.Equals("")) Then
            MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (Me.txtNombre.Text.Equals("") Or Me.txtPresentacion.Text.Equals("") Or Me.txtPrecio.Text.Equals("") Or Me.txtCosto.Text.Equals("") Or Me.cbxCategoria.SelectedValue = -1 Or Me.cbxUMedida.SelectedValue = -1) Then

                MessageBox.Show("Todos los campos son necesarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.ProductoTableAdapter.UpdateQuery(txtNombre.Text, Me.txtPresentacion.Text, Me.txtPrecio.Text, Me.txtCosto.Text, Me.cbxCategoria.SelectedValue,
                                                    Me.cbxUMedida.SelectedValue, Me.txtIdProd.Text)

                Me.VwProductosTableAdapter.Fill(Me.KelaniDataSet.vwProductos)
                limpiar()
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Me.txtIdProd.Text.Equals("")) Then
            MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim answer As Int32

            answer = MessageBox.Show("Esta seguro que quiere eliminar permanentemente el producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If (answer = vbYes) Then

                Me.ProductoTableAdapter.DeleteQuery(Me.txtIdProd.Text)
                Me.VwProductosTableAdapter.Fill(Me.KelaniDataSet.vwProductos)
                limpiar()
                MessageBox.Show("Ha eliminado el usuario correctamente", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            End If
        End If
    End Sub
End Class