Public Class frmVistaDeEncabezados
    Private Sub frmVistaDeEncabezados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.FacturaEnc' Puede moverla o quitarla según sea necesario.
        Me.FacturaEncTableAdapter.Fill(Me.KelaniDataSet.FacturaEnc)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnUsar.Click
        frmFactEncabezado.txtIDFactura.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString()
        frmFactEncabezado.txtNumeroFactura.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString()
        'frmFactEncabezado.txtIDFactura.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString()
        frmFactEncabezado.txtNombreCliente.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString()
        frmFactEncabezado.txtIdentificacion.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString()
        frmFactEncabezado.rtbDirCliente.Text = DataGridView1.CurrentRow.Cells.Item(5).Value.ToString()
        frmFactEncabezado.txtRUC.Text = DataGridView1.CurrentRow.Cells.Item(6).Value.ToString()
        frmFactEncabezado.txtIVA.Text = DataGridView1.CurrentRow.Cells.Item(7).Value.ToString()
        frmFactEncabezado.txtTotal.Text = DataGridView1.CurrentRow.Cells.Item(8).Value.ToString()
        frmFactEncabezado.txtIDCliente.Text = DataGridView1.CurrentRow.Cells.Item(9).Value.ToString()

        Close()

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmVerClientes.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        FacturaEncTableAdapter.agregarEncabezado(txtNumeroFactura.Text,
                                                 dtpFecha.Value,
                                                 txtNombreCliente.Text,
                                                 txtIdentificacion.Text,
                                                 rtbDirCliente.Text,
                                                 txtRUC.Text,
                                                 Convert.ToDouble(txtIVA.Text),
                                                 Convert.ToDouble(txtTotal.Text),
                                                 Convert.ToInt32(txtIDCliente.Text))
        Me.FacturaEncTableAdapter.Fill(Me.KelaniDataSet.FacturaEnc)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        FacturaEncTableAdapter.EditarEncabezado(txtNumeroFactura.Text,
                                                 dtpFecha.Value,
                                                 txtNombreCliente.Text,
                                                 txtIdentificacion.Text,
                                                 rtbDirCliente.Text,
                                                 txtRUC.Text,
                                                 Convert.ToDouble(txtIVA.Text),
                                                 Convert.ToDouble(txtTotal.Text),
                                                 Convert.ToInt32(txtIDCliente.Text),
                                                 Convert.ToInt32(txtIDFactura.Text))
        Me.FacturaEncTableAdapter.Fill(Me.KelaniDataSet.FacturaEnc)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        FacturaEncTableAdapter.EliminarEncabezado(Convert.ToInt32(txtIDFactura.Text))
        Me.FacturaEncTableAdapter.Fill(Me.KelaniDataSet.FacturaEnc)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNumeroFactura.Text = ""
        txtNombreCliente.Text = ""
        txtIdentificacion.Text = ""
        rtbDirCliente.Text = ""
        txtRUC.Text = ""
        txtIVA.Text = ""
        txtTotal.Text = ""
        txtIDCliente.Text = ""
        txtIDFactura.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtIDFactura.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString()
        txtNumeroFactura.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString()
        dtpFecha.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString()
        txtNombreCliente.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString()
        txtIdentificacion.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString()
        rtbDirCliente.Text = DataGridView1.CurrentRow.Cells.Item(5).Value.ToString()
        txtRUC.Text = DataGridView1.CurrentRow.Cells.Item(6).Value.ToString()
        txtIVA.Text = DataGridView1.CurrentRow.Cells.Item(7).Value.ToString()
        txtTotal.Text = DataGridView1.CurrentRow.Cells.Item(8).Value.ToString()
        txtIDCliente.Text = DataGridView1.CurrentRow.Cells.Item(9).Value.ToString()
    End Sub
End Class