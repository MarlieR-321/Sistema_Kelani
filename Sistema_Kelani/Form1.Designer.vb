<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadDeMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarOpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioToolStripMenuItem, Me.CatalogosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.SeguridadToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(868, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionToolStripMenuItem, Me.IngresosToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.IngresosToolStripMenuItem.Text = "Ingresos"
        '
        'CatalogosToolStripMenuItem
        '
        Me.CatalogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.UnidadDeMedidaToolStripMenuItem})
        Me.CatalogosToolStripMenuItem.Name = "CatalogosToolStripMenuItem"
        Me.CatalogosToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.CatalogosToolStripMenuItem.Text = "Articulos"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'UnidadDeMedidaToolStripMenuItem
        '
        Me.UnidadDeMedidaToolStripMenuItem.Name = "UnidadDeMedidaToolStripMenuItem"
        Me.UnidadDeMedidaToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.UnidadDeMedidaToolStripMenuItem.Text = "Unidad de Medida"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionToolStripMenuItem, Me.TiposToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.InformacionToolStripMenuItem.Text = "Gestion de Clientes"
        '
        'TiposToolStripMenuItem
        '
        Me.TiposToolStripMenuItem.Name = "TiposToolStripMenuItem"
        Me.TiposToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TiposToolStripMenuItem.Text = "Tipos"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.RolesToolStripMenuItem, Me.OpcionesToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarUsuarioToolStripMenuItem, Me.AsignarRolesToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'IngresarUsuarioToolStripMenuItem
        '
        Me.IngresarUsuarioToolStripMenuItem.Name = "IngresarUsuarioToolStripMenuItem"
        Me.IngresarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.IngresarUsuarioToolStripMenuItem.Text = "Administrar usuario"
        '
        'AsignarRolesToolStripMenuItem
        '
        Me.AsignarRolesToolStripMenuItem.Name = "AsignarRolesToolStripMenuItem"
        Me.AsignarRolesToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.AsignarRolesToolStripMenuItem.Text = "Asignar roles"
        '
        'RolesToolStripMenuItem
        '
        Me.RolesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarRolesToolStripMenuItem, Me.AsignarOpcionesToolStripMenuItem})
        Me.RolesToolStripMenuItem.Name = "RolesToolStripMenuItem"
        Me.RolesToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.RolesToolStripMenuItem.Text = "Roles"
        '
        'AdministrarRolesToolStripMenuItem
        '
        Me.AdministrarRolesToolStripMenuItem.Name = "AdministrarRolesToolStripMenuItem"
        Me.AdministrarRolesToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.AdministrarRolesToolStripMenuItem.Text = "Administrar Roles"
        '
        'AsignarOpcionesToolStripMenuItem
        '
        Me.AsignarOpcionesToolStripMenuItem.Name = "AsignarOpcionesToolStripMenuItem"
        Me.AsignarOpcionesToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.AsignarOpcionesToolStripMenuItem.Text = "Asignar opciones"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 444)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema Kelani"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadDeMedidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarRolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarRolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarOpcionesToolStripMenuItem As ToolStripMenuItem
End Class
