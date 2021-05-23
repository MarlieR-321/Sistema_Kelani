Public Class frmVistaDeEncabezados
    Private Sub frmVistaDeEncabezados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.FacturaEnc' Puede moverla o quitarla según sea necesario.
        Me.FacturaEncTableAdapter.Fill(Me.KelaniDataSet.FacturaEnc)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
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

    End Sub
End Class