Public Class frmFactEncabezado
    Private Sub bEditar_Click(sender As Object, e As EventArgs)
        frmFactDetalles.Show()
    End Sub

    Private Sub frmFactEncabezado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.vw_Detalles' Puede moverla o quitarla según sea necesario.
        Me.Vw_DetallesTableAdapter.Fill(Me.KelaniDataSet.vw_Detalles)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet1.vw_FacturaDet' Puede moverla o quitarla según sea necesario.
        Me.Vw_FacturaDetTableAdapter.Fill(Me.KelaniDataSet1.vw_FacturaDet)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.vw_FacturaDet' Puede moverla o quitarla según sea necesario.
        Me.Vw_FacturaDetTableAdapter.Fill(Me.KelaniDataSet.vw_FacturaDet)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.VwClientes' Puede moverla o quitarla según sea necesario.
        Me.VwClientesTableAdapter.Fill(Me.KelaniDataSet.VwClientes)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmVerClientes.Show()
    End Sub

    Private Sub VerEncabezadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerEncabezadosToolStripMenuItem.Click
        frmVistaDeEncabezados.Show()
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        frmVerProductos.Show()
    End Sub

    Private Sub btnGuardarEncabezado_Click(sender As Object, e As EventArgs) Handles btnGuardarEncabezado.Click
        FacturaEncTableAdapter1.agregarEncabezado(txtNumeroFactura.Text,
                                         dtpFecha.Value,
                                         txtNombreCliente.Text,
                                         txtIdentificacion.Text,
                                         rtbDirCliente.Text,
                                         txtRUC.Text,
                                         Convert.ToDouble(txtIVA.Text),
                                         Convert.ToDouble(txtTotal.Text),
                                         Convert.ToInt32(txtIDCliente.Text))
        MessageBox.Show("Se agregó el encabezado con este RUC: " + txtRUC.Text + " a nombre de: " + txtNombreCliente.Text)
    End Sub

    Private Sub btnAgregarALaFactura_Click(sender As Object, e As EventArgs) Handles btnAgregarALaFactura.Click

        Dim subTotalProducto = Convert.ToDouble(txtPrecioProducto.Text) * Convert.ToInt32(txtCantidadProducto.Text)

        FacturaDetTableAdapter1.InsertQuery(
            Convert.ToDouble(txtPrecioProducto.Text),
            subTotalProducto,
            Convert.ToInt32(txtCantidadProducto.Text),
            Convert.ToInt32(txtIDFactura.Text),
            Convert.ToInt32(txtIDProducto.Text))

        Me.Vw_FacturaDetTableAdapter.Fill(Me.KelaniDataSet.vw_FacturaDet)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellClick
        txtIDDetalle.Text = dgvDetalles.CurrentRow.Cells.Item(0).Value.ToString()
        txtNombreProducto.Text = dgvDetalles.CurrentRow.Cells.Item(1).Value.ToString()
        txtPresentacionProducto.Text = dgvDetalles.CurrentRow.Cells.Item(2).Value.ToString()
        txtCantidadProducto.Text = dgvDetalles.CurrentRow.Cells.Item(3).Value.ToString()
        txtPrecioProducto.Text = dgvDetalles.CurrentRow.Cells.Item(4).Value.ToString()
    End Sub
End Class