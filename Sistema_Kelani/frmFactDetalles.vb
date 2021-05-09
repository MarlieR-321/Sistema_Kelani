Public Class frmFactDetalles
    Private Sub frmFactDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.KelaniDataSet.Producto)

    End Sub
End Class