Imports System.Data.SqlClient

Public Class frmUMedida
    Private Sub frmUMedida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.unidadMedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadMedidaTableAdapter.Fill(Me.KelaniDataSet.unidadMedida)

    End Sub

    Private Sub limpiar()
        Me.txtIdMedida.Text = ""
        Me.txtMedida.Text = ""
        Me.txtAbreviatura.Text = ""
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If (Me.txtMedida.Text.Equals("") Or Me.txtAbreviatura.Text.Equals("")) Then
            MessageBox.Show("Todos los datos son necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Me.UnidadMedidaTableAdapter.InsertQuery(Me.txtMedida.Text, Me.txtAbreviatura.Text)
                Me.UnidadMedidaTableAdapter.Fill(Me.KelaniDataSet.unidadMedida)
                Me.limpiar()
                MessageBox.Show("La unidad de medida se ha guardado correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch sqlEx As SqlException
                MsgBox("Error al ingresar la unidad de medida", sqlEx.Message())
            Catch Ex As Exception
                MsgBox("Error al ingresar la unidad de medida", Ex.Message())
                MsgBox("Error al ingresar la unidad de medida", Ex.StackTrace())
            End Try

        End If
    End Sub

    Private Sub DgvUMedidas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUMedidas.CellClick
        Me.txtIdMedida.Text = DgvUMedidas.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txtMedida.Text = DgvUMedidas.CurrentRow.Cells.Item(1).Value.ToString()
        Me.txtIdMedida.Text = DgvUMedidas.CurrentRow.Cells.Item(0).Value.ToString()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (Me.txtMedida.Text.Equals("") Or Me.txtAbreviatura.Text.Equals("")) Then
            MessageBox.Show("Todos los datos son necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Me.UnidadMedidaTableAdapter.UpdateQuery(Me.txtIdMedida.Text, Me.txtAbreviatura.Text, Me.txtIdMedida.Text)
                Me.UnidadMedidaTableAdapter.Fill(Me.KelaniDataSet.unidadMedida)
                Me.limpiar()
                MessageBox.Show("La medida se ha actualizado correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch sqlEx As SqlException
                MsgBox("Error al actualizar la unidad de medida", sqlEx.Message())
            Catch Ex As Exception
                MsgBox("Error al actualizar la unidad de medida", Ex.Message())
                MsgBox("Error al actualizar la unidad de medida", Ex.StackTrace())
            End Try

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Me.txtIdMedida.Text.Equals("")) Then
            MessageBox.Show("Tiene que seleccionar una medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim answer As Int32

            answer = MessageBox.Show("Esta seguro que quiere eliminar permanentemente la unidad de medida?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (answer = vbYes) Then
                Try
                    Me.UnidadMedidaTableAdapter.DeleteQuery(Me.txtIdMedida.Text)
                    Me.UnidadMedidaTableAdapter.Fill(Me.KelaniDataSet.unidadMedida)
                    Me.limpiar()
                    MessageBox.Show("La Unidad de Medida se ha eliminado correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch sqlEx As SqlException
                    MsgBox("Error al eliminar la unidad de medida", sqlEx.Message())
                Catch Ex As Exception
                    MsgBox("Error al eliminar la unidad de medida", Ex.Message())
                    MsgBox("Error al eliminar la unidad de medida", Ex.StackTrace())
                End Try

            End If

        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Me.DgvUMedidas.DataSource = Me.UnidadMedidaTableAdapter.GetDataByText(txtBuscar.Text)
        Catch sqlEx As SqlException
            MsgBox("Error al buscar la unidad de medida", sqlEx.Message())
        Catch Ex As Exception
            MsgBox("Error al buscar la unidad de medida", Ex.Message())
            MsgBox("Error al buscar la unidad de medida", Ex.StackTrace())
        End Try
    End Sub
End Class