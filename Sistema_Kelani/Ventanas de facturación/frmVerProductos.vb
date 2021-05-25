Public Class frmVerProductos
    Private Sub frmVerProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.vwProductos' Puede moverla o quitarla según sea necesario.
        Me.VwProductosTableAdapter.Fill(Me.KelaniDataSet.vwProductos)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Dim buscar = txtBusqueda.Text
        VwProductosTableAdapter.FillByText(KelaniDataSet.vwProductos, buscar)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmFactEncabezado.txtIDProducto.Text = dgvProductos.CurrentRow.Cells.Item(0).Value.ToString()
        frmFactEncabezado.txtNombreProducto.Text = dgvProductos.CurrentRow.Cells.Item(1).Value.ToString()
        frmFactEncabezado.txtPresentacionProducto.Text = dgvProductos.CurrentRow.Cells.Item(2).Value.ToString()
        frmFactEncabezado.txtPrecioProducto.Text = dgvProductos.CurrentRow.Cells.Item(3).Value.ToString()

        Close()
    End Sub
End Class