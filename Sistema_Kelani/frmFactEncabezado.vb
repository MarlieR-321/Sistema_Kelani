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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Guardar un ecabezado para un uso posterior
        FacturaEncTableAdapter1.agregarEncabezado(txtNumeroFactura.Text,
                                                 dtpFecha.Value,
                                                 txtNombreCliente.Text,
                                                 txtIdentificacion.Text,
                                                 rtbDirCliente.Text,
                                                 txtRUC.Text,
                                                 Convert.ToDouble(txtIVA.Text),
                                                 Convert.ToDouble(txtTotal.Text),
                                                 Convert.ToInt32(txtIDCliente.Text))
    End Sub

    Private Sub VerEncabezadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerEncabezadosToolStripMenuItem.Click
        frmVistaDeEncabezados.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Guarda el encabezado y muestra la ventana del detalle

        FacturaEncTableAdapter1.agregarEncabezado(txtNumeroFactura.Text,
                                         dtpFecha.Value,
                                         txtNombreCliente.Text,
                                         txtIdentificacion.Text,
                                         rtbDirCliente.Text,
                                         txtRUC.Text,
                                         Convert.ToDouble(txtIVA.Text),
                                         Convert.ToDouble(txtTotal.Text),
                                         Convert.ToInt32(txtIDCliente.Text))

        'Aquí se ejecuta la ventana del detalle (Marlie esto te corresponde)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Editar encabezado

    End Sub
End Class