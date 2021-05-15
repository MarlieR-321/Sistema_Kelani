Public Class frmTiposClientes
    Private Sub frmTiposClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.T_Cliente' Puede moverla o quitarla según sea necesario.
        Me.T_ClienteTableAdapter1.Fill(Me.KelaniDataSet.T_Cliente)
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet1.T_Cliente' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub limpiarCampos()
        txtiD.Text = ""
        txtNombreTipo.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Me.T_ClienteTableAdapter1.agregarTipoCliente(txtNombreTipo.Text)
        Me.T_ClienteTableAdapter1.Fill(Me.KelaniDataSet.T_Cliente)
    End Sub
End Class