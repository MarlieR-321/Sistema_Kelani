Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProductos.Show()

    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        frmCategoriaP.Show()

    End Sub

    Private Sub UnidadDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadDeMedidaToolStripMenuItem.Click
        frmUMedida.Show()
    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem.Click
        frmFactEncabezado.Show()
    End Sub

    Private Sub TiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposToolStripMenuItem.Click
        frmTiposClientes.Show()
    End Sub

    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        frmGestionClientes.Show()
    End Sub
End Class
