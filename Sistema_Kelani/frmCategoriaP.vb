Imports System.Data.SqlClient

Public Class frmCategoriaP
    Private Sub frmCategoriaP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KelaniDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.KelaniDataSet.Categoria)

    End Sub

    Private Sub limpiarCampos()
        Me.txtIdCat.Text = ""
        Me.txtCategoria.Text = ""
        Me.txtDescripcion.Text = ""

    End Sub

    Private Sub DgvCategoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategoria.CellClick

        Me.txtIdCat.Text = DgvCategoria.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txtCategoria.Text = DgvCategoria.CurrentRow.Cells.Item(1).Value.ToString()
        Me.txtDescripcion.Text = DgvCategoria.CurrentRow.Cells.Item(2).Value.ToString()

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If (Me.txtCategoria.Text.Equals("")) Then
            MessageBox.Show("El nombre de la categoria es necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Me.CategoriaTableAdapter.InsertQuery(Me.txtCategoria.Text, Me.txtDescripcion.Text)
                Me.CategoriaTableAdapter.Fill(Me.KelaniDataSet.Categoria)
                Me.limpiarCampos()
                MessageBox.Show("La Categoria se ha guardado correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch sqlEx As SqlException
                MsgBox("Error al ingresar las categorias", sqlEx.Message())
            Catch Ex As Exception
                MsgBox("Error al ingresar las categorias", Ex.Message())
                MsgBox("Error al ingresar las categorias", Ex.StackTrace())
            End Try

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Me.txtIdCat.Text.Equals("")) Then
            MessageBox.Show("Necesita elegir una categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim answer As Int32

            answer = MessageBox.Show("Esta seguro que quiere eliminar permanentemente el producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (answer = vbYes) Then
                Try
                    Me.CategoriaTableAdapter.DeleteQuery(Me.txtIdCat.Text)
                    Me.CategoriaTableAdapter.Fill(Me.KelaniDataSet.Categoria)
                    Me.limpiarCampos()
                    MessageBox.Show("Se elimino la categoria correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch sqlEx As SqlException
                    MsgBox("Error al buscar las categorias", sqlEx.Message())
                Catch Ex As Exception
                    MsgBox("Error al eliminar las categorias", Ex.Message())
                    MsgBox("Error al eliminar las categorias", Ex.StackTrace())

                End Try

            End If
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (Me.txtIdCat.Text.Equals("") Or Me.txtCategoria.Text.Equals("")) Then
            MessageBox.Show("Debe seleccionar una Categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Me.CategoriaTableAdapter.UpdateQuery(Me.txtCategoria.Text, Me.txtDescripcion.Text, Me.txtIdCat.Text)
                Me.CategoriaTableAdapter.Fill(Me.KelaniDataSet.Categoria)
                Me.limpiarCampos()
                MessageBox.Show("La Categoria se ha actualizo correctamente", "Gestion Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch sqlEx As SqlException
                MsgBox("Error al editar las categorias", sqlEx.Message())
            Catch Ex As Exception
                MsgBox("Error al editar las categorias", Ex.Message())
                MsgBox("Error al editar las categorias", Ex.StackTrace())

            End Try

        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Me.DgvCategoria.DataSource = Me.CategoriaTableAdapter.GetDataByText(txtBuscar.Text)
        Catch sqlEx As SqlException
            MsgBox("Error al editar las categorias", sqlEx.Message())
        Catch Ex As Exception
            MsgBox("Error al editar las categorias", Ex.Message())
            MsgBox("Error al editar las categorias", Ex.StackTrace())

        End Try
    End Sub

    Private Sub DgvCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategoria.CellContentClick

    End Sub
End Class