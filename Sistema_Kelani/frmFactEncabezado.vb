Public Class frmFactEncabezado
    Private Sub bIngresar_Click(sender As Object, e As EventArgs)
        frmFactDetalles.Show()
    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs)
        frmFactDetalles.Show()
    End Sub

    Private Sub frmFactEncabezado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.VwClientes' Puede moverla o quitarla según sea necesario.
        Me.VwClientesTableAdapter.Fill(Me.KelaniDataSet.VwClientes)

    End Sub

    Private Sub dgv_Clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Clientes.CellClick
        txtIDCliente.Text = dgv_Clientes.CurrentRow.Cells.Item(0).Value.ToString()
        txtNombreCliente.Text = dgv_Clientes.CurrentRow.Cells.Item(1).Value.ToString()
        txtIdentificacion.Text = dgv_Clientes.CurrentRow.Cells.Item(5).Value.ToString()
        rtbDirCliente.Text = dgv_Clientes.CurrentRow.Cells.Item(6).Value.ToString()
    End Sub

    Private Sub txtCajaDeBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtCajaDeBusqueda.TextChanged

        Dim filtro = txtCajaDeBusqueda.Text

        Me.VwClientesTableAdapter.FillByText(Me.KelaniDataSet.VwClientes, filtro, filtro)
    End Sub
End Class