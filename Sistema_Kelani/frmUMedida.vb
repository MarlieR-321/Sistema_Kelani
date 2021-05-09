Public Class frmUMedida
    Private Sub frmUMedida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.unidadMedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadMedidaTableAdapter.Fill(Me.KelaniDataSet.unidadMedida)

    End Sub
End Class