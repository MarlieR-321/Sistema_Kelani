<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerProductos
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VwProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwProductosTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.vwProductosTableAdapter()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgvProductos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(937, 426)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ver productos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecciona el producto que quieras incorporar en la factura. Has click en Acpetar" &
    " para salir de la ventana"
        '
        'dgvProductos
        '
        Me.dgvProductos.AutoGenerateColumns = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PresentacionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.IdCategoriaPDataGridViewTextBoxColumn, Me.NombreCatDataGridViewTextBoxColumn, Me.IdUMedidaDataGridViewTextBoxColumn, Me.NombreMedidaDataGridViewTextBoxColumn})
        Me.dgvProductos.DataSource = Me.VwProductosBindingSource
        Me.dgvProductos.Location = New System.Drawing.Point(10, 102)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(920, 281)
        Me.dgvProductos.TabIndex = 1
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buscar por nombre:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(160, 68)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(770, 26)
        Me.txtBusqueda.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(819, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VwProductosBindingSource
        '
        Me.VwProductosBindingSource.DataMember = "vwProductos"
        Me.VwProductosBindingSource.DataSource = Me.KelaniDataSet
        '
        'VwProductosTableAdapter
        '
        Me.VwProductosTableAdapter.ClearBeforeFill = True
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "id_Producto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "id_Producto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'PresentacionDataGridViewTextBoxColumn
        '
        Me.PresentacionDataGridViewTextBoxColumn.DataPropertyName = "presentacion"
        Me.PresentacionDataGridViewTextBoxColumn.HeaderText = "presentacion"
        Me.PresentacionDataGridViewTextBoxColumn.Name = "PresentacionDataGridViewTextBoxColumn"
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        '
        'IdCategoriaPDataGridViewTextBoxColumn
        '
        Me.IdCategoriaPDataGridViewTextBoxColumn.DataPropertyName = "id_CategoriaP"
        Me.IdCategoriaPDataGridViewTextBoxColumn.HeaderText = "id_CategoriaP"
        Me.IdCategoriaPDataGridViewTextBoxColumn.Name = "IdCategoriaPDataGridViewTextBoxColumn"
        '
        'NombreCatDataGridViewTextBoxColumn
        '
        Me.NombreCatDataGridViewTextBoxColumn.DataPropertyName = "nombreCat"
        Me.NombreCatDataGridViewTextBoxColumn.HeaderText = "nombreCat"
        Me.NombreCatDataGridViewTextBoxColumn.Name = "NombreCatDataGridViewTextBoxColumn"
        '
        'IdUMedidaDataGridViewTextBoxColumn
        '
        Me.IdUMedidaDataGridViewTextBoxColumn.DataPropertyName = "id_U_Medida"
        Me.IdUMedidaDataGridViewTextBoxColumn.HeaderText = "id_U_Medida"
        Me.IdUMedidaDataGridViewTextBoxColumn.Name = "IdUMedidaDataGridViewTextBoxColumn"
        '
        'NombreMedidaDataGridViewTextBoxColumn
        '
        Me.NombreMedidaDataGridViewTextBoxColumn.DataPropertyName = "nombreMedida"
        Me.NombreMedidaDataGridViewTextBoxColumn.HeaderText = "nombreMedida"
        Me.NombreMedidaDataGridViewTextBoxColumn.Name = "NombreMedidaDataGridViewTextBoxColumn"
        '
        'frmVerProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVerProductos"
        Me.Text = "Búsqueda de productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents VwProductosBindingSource As BindingSource
    Friend WithEvents VwProductosTableAdapter As KelaniDataSetTableAdapters.vwProductosTableAdapter
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PresentacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdUMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
