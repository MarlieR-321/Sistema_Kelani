Imports System.Data.SqlClient

Public Class frmMovimientoInventario
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub MovimientoInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.mov_inv' Puede moverla o quitarla según sea necesario.
        Me.Mov_invTableAdapter.Fill(Me.KelaniDataSet.mov_inv)

    End Sub

    Private Sub limpiarCampos()
        Me.txtIdMovInv.Text = ""
        Me.txtNombMov.Text = ""
        Me.cbxTipoMov.SelectedIndex = -1

    End Sub

    'Private Sub btmIngresar_Click(sender As Object, e As EventArgs) Handles btmIngresar.Click
    '    If (Me.txtNombTM.Text.Equals("")) Then
    '        MessageBox.Show("El tipo de movimiento es necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    'Else
    'Try
    'Me.T_mov_invTableAdapter.InsertQuery(Me.txtNombTM.Text)
    'Me.T_mov_invTableAdapter.Fill(Me.KelaniDataSet.t_mov_inv)
    'Me.limpiarCampos()
    'MessageBox.Show("El tipo de movimiento se ha guardado correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'Catch sqlEx As SqlException
    'MsgBox("Error al ingresar las categorias", sqlEx.Message())
    'Catch Ex As Exception
    'MsgBox("Error al ingresar el tipo de movimiento", Ex.Message())
    'MsgBox("Error al ingresar el tipo de movimiento", Ex.StackTrace())
    'End Try

    'End If
    'End Sub
End Class