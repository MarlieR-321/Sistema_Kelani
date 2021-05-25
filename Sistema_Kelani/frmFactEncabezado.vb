Public Class frmFactEncabezado
    Private Sub bEditar_Click(sender As Object, e As EventArgs)
        frmFactDetalles.Show()
    End Sub

    Private Sub frmFactEncabezado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet1.vw_FacturaDet' Puede moverla o quitarla según sea necesario.
        ' Me.Vw_FacturaDetTableAdapter.Fill(Me.KelaniDataSet1.vw_FacturaDet, 0)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.vw_FacturaDet' Puede moverla o quitarla según sea necesario.
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
                                         0, 0, Convert.ToInt32(txtIDCliente.Text))
        MessageBox.Show("Se agregó el encabezado con este RUC: " + txtRUC.Text + " a nombre de: " + txtNombreCliente.Text)

    End Sub

    Private Sub btnAgregarALaFactura_Click(sender As Object, e As EventArgs) Handles btnAgregarALaFactura.Click

        Dim subTotalProducto = Convert.ToDouble(txtPrecioProducto.Text) * Convert.ToInt32(txtCantidadProducto.Text)
        Dim idFactura
        Dim total

        If (Me.txtIDFactura.Text.Equals("")) Then

            idFactura = FacturaEncTableAdapter1.GetIdFactura()
            FacturaDetTableAdapter1.InsertQuery(
           Convert.ToDouble(txtPrecioProducto.Text),
           subTotalProducto,
           Convert.ToInt32(txtCantidadProducto.Text),
           idFactura,
           Convert.ToInt32(txtIDProducto.Text))
            total = FacturaDetTableAdapter1.SumaSubtotal(idFactura)
            FacturaEncTableAdapter1.ActualizarTotal(total, idFactura)
            Me.dgvDetalles.DataSource = Me.Vw_FacturaDetTableAdapter.GetData(idFactura)
            limpiarDet()
        Else

            idFactura = txtIDFactura.Text
            FacturaDetTableAdapter1.InsertQuery(
           Convert.ToDouble(txtPrecioProducto.Text),
           subTotalProducto,
           Convert.ToInt32(txtCantidadProducto.Text),
           idFactura,
           Convert.ToInt32(txtIDProducto.Text))
            total = FacturaDetTableAdapter1.SumaSubtotal(idFactura)
            FacturaEncTableAdapter1.ActualizarTotal(total, idFactura)
            Me.dgvDetalles.DataSource = Me.Vw_FacturaDetTableAdapter.GetData(idFactura)
            limpiarDet()
        End If



    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellClick
        'Aviso mi view usa varios datos pero deja visibles solo algunos so  estan buenos los numero
        txtIDDetalle.Text = dgvDetalles.CurrentRow.Cells.Item(1).Value.ToString()
        txtIDProducto.Text = dgvDetalles.CurrentRow.Cells.Item(2).Value.ToString()
        txtNombreProducto.Text = dgvDetalles.CurrentRow.Cells.Item(3).Value.ToString()
        'txtPresentacionProducto.Text = dgvDetalles.CurrentRow.Cells.Item(5).Value.ToString()
        txtCantidadProducto.Text = dgvDetalles.CurrentRow.Cells.Item(7).Value.ToString()
        txtPrecioProducto.Text = dgvDetalles.CurrentRow.Cells.Item(6).Value.ToString()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim subTotalProducto = Convert.ToDouble(txtPrecioProducto.Text) * Convert.ToInt32(txtCantidadProducto.Text)
        Dim idFactura
        Dim total

        If (Me.txtIDFactura.Text.Equals("")) Then

            idFactura = FacturaEncTableAdapter1.GetIdFactura()
            FacturaDetTableAdapter1.UpdateQuery(
           Convert.ToDouble(txtPrecioProducto.Text),
           subTotalProducto,
           Convert.ToInt32(txtCantidadProducto.Text),
           idFactura,
           Convert.ToInt32(txtIDProducto.Text), Convert.ToInt32(txtIDDetalle.Text))
            total = FacturaDetTableAdapter1.SumaSubtotal(idFactura)
            FacturaEncTableAdapter1.ActualizarTotal(total, idFactura)
            Me.dgvDetalles.DataSource = Me.Vw_FacturaDetTableAdapter.GetData(idFactura)
            limpiarDet()
        Else

            idFactura = txtIDFactura.Text
            FacturaDetTableAdapter1.UpdateQuery(
           Convert.ToDouble(txtPrecioProducto.Text),
           subTotalProducto,
           Convert.ToInt32(txtCantidadProducto.Text),
           idFactura,
           Convert.ToInt32(txtIDProducto.Text), Convert.ToInt32(txtIDDetalle.Text))


            total = FacturaDetTableAdapter1.SumaSubtotal(idFactura)
            FacturaEncTableAdapter1.ActualizarTotal(total, idFactura)
            Me.dgvDetalles.DataSource = Me.Vw_FacturaDetTableAdapter.GetData(idFactura)
            limpiarDet()
        End If
    End Sub

    Private Sub limpiarDet()
        txtIDDetalle.Text = ""
        txtIDProducto.Text = ""
        txtPrecioProducto.Text = ""
        txtCantidadProducto.Text = ""

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

End Class