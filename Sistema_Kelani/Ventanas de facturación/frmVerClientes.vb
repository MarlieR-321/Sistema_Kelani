Public Class frmVerClientes
    Private Sub frmVerClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.VwClientes' Puede moverla o quitarla según sea necesario.
        Me.VwClientesTableAdapter.Fill(Me.KelaniDataSet.VwClientes)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        frmFactEncabezado.txtIDCliente.Text = dgvClientes.CurrentRow.Cells.Item(0).Value.ToString
        frmFactEncabezado.txtNombreCliente.Text = dgvClientes.CurrentRow.Cells.Item(1).Value.ToString
        frmFactEncabezado.txtIdentificacion.Text = dgvClientes.CurrentRow.Cells.Item(5).Value.ToString
        frmFactEncabezado.rtbDirCliente.Text = dgvClientes.CurrentRow.Cells.Item(6).Value.ToString

        frmVistaDeEncabezados.txtIDCliente.Text = dgvClientes.CurrentRow.Cells.Item(0).Value.ToString
        frmVistaDeEncabezados.txtNombreCliente.Text = dgvClientes.CurrentRow.Cells.Item(1).Value.ToString
        frmVistaDeEncabezados.txtIdentificacion.Text = dgvClientes.CurrentRow.Cells.Item(5).Value.ToString
        frmVistaDeEncabezados.rtbDirCliente.Text = dgvClientes.CurrentRow.Cells.Item(6).Value.ToString
        Me.Close()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        VwClientesTableAdapter.FillByText(KelaniDataSet.VwClientes, txtBusqueda.Text, txtBusqueda.Text)
    End Sub
End Class