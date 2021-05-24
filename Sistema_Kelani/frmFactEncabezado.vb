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

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    'Guardar un ecabezado para un uso posterior
    '    FacturaEncTableAdapter1.agregarEncabezado(txtNumeroFactura.Text,
    '                                             dtpFecha.Value,
    '                                             txtNombreCliente.Text,
    '                                             txtIdentificacion.Text,
    '                                             rtbDirCliente.Text,
    '                                             txtRUC.Text,
    '                                             Convert.ToDouble(txtIVA.Text),
    '                                             Convert.ToDouble(txtTotal.Text),
    '                                             Convert.ToInt32(txtIDCliente.Text))
    'End Sub

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
End Class