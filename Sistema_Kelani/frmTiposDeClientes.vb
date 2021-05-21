Public Class frmTiposDeClientes
    Private Sub frmTiposDeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.T_Cliente' Puede moverla o quitarla según sea necesario.
        Me.T_ClienteTableAdapter.Fill(Me.KelaniDataSet.T_Cliente)

    End Sub

    Private Sub limpiarCampos()
        txtID.Text = ""
        txtTIPO.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim tipoAgregar = txtTIPO.Text
        Me.T_ClienteTableAdapter.agregarTipo(tipoAgregar)
        Me.T_ClienteTableAdapter.Fill(Me.KelaniDataSet.T_Cliente)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim tipoActualizar = txtTIPO.Text
        Dim idActualizar = Convert.ToInt32(txtID.Text)

        Me.T_ClienteTableAdapter.actualizarTipo(tipoActualizar, idActualizar)
        Me.T_ClienteTableAdapter.Fill(Me.KelaniDataSet.T_Cliente)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim idEliminar = Convert.ToInt32(txtID.Text)

        Me.T_ClienteTableAdapter.eliminarTipo(idEliminar)
        Me.T_ClienteTableAdapter.Fill(Me.KelaniDataSet.T_Cliente)

    End Sub
End Class