Public Class MovimientoInventario
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub MovimientoInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.mov_inv' Puede moverla o quitarla según sea necesario.
        Me.Mov_invTableAdapter.Fill(Me.KelaniDataSet.mov_inv)

    End Sub
End Class