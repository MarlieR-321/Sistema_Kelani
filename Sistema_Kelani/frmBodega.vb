Public Class frmBodega
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.bodega' Puede moverla o quitarla según sea necesario.
        Me.BodegaTableAdapter.Fill(Me.KelaniDataSet.bodega)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BodegaTableAdapter.InsertQuery(txtBodega.Text)
    End Sub
End Class