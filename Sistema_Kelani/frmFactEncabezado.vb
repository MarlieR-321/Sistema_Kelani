Public Class frmFactEncabezado
    Private Sub bEditar_Click(sender As Object, e As EventArgs)
        frmFactDetalles.Show()
    End Sub

    Private Sub frmFactEncabezado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet1.vw_FacturaDet' Puede moverla o quitarla según sea necesario.
        Me.Vw_FacturaDetTableAdapter.Fill(Me.KelaniDataSet1.vw_FacturaDet)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.vw_FacturaDet' Puede moverla o quitarla según sea necesario.
        Me.Vw_FacturaDetTableAdapter.Fill(Me.KelaniDataSet.vw_FacturaDet)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.VwClientes' Puede moverla o quitarla según sea necesario.
        Me.VwClientesTableAdapter.Fill(Me.KelaniDataSet.VwClientes)

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    'Guarda el encabezado y muestra la ventana del detalle

    '    FacturaEncTableAdapter1.agregarEncabezado(txtNumeroFactura.Text,
    '                                     dtpFecha.Value,
    '                                     txtNombreCliente.Text,
    '                                     txtIdentificacion.Text,
    '                                     rtbDirCliente.Text,
    '                                     txtRUC.Text,
    '                                     Convert.ToDouble(txtIVA.Text),
    '                                     Convert.ToDouble(txtTotal.Text),
    '                                     Convert.ToInt32(txtIDCliente.Text))

    '    'Aquí se ejecuta la ventana del detalle (Marlie esto te corresponde)

    'End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmVerClientes.Show()
    End Sub

    Private Sub VerEncabezadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerEncabezadosToolStripMenuItem.Click
        frmVistaDeEncabezados.Show()
    End Sub


End Class