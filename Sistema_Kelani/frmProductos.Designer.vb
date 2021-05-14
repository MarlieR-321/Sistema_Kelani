<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvProductos = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_CategoriaP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_U_Medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdProd = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.cbxUMedida = New System.Windows.Forms.ComboBox()
        Me.UnidadMedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtPresentacion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductoTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.ProductoTableAdapter()
        Me.CategoriaTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.CategoriaTableAdapter()
        Me.UnidadMedidaTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.unidadMedidaTableAdapter()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwProductosTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.vwProductosTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UnidadMedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DgvProductos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 334)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda y Seleccion"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(72, 31)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(697, 24)
        Me.txtBuscar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar:"
        '
        'DgvProductos
        '
        Me.DgvProductos.AllowUserToAddRows = False
        Me.DgvProductos.AllowUserToDeleteRows = False
        Me.DgvProductos.AutoGenerateColumns = False
        Me.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PresentacionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.id_CategoriaP, Me.NombreCatDataGridViewTextBoxColumn, Me.id_U_Medida, Me.NombreMedidaDataGridViewTextBoxColumn})
        Me.DgvProductos.DataSource = Me.VwProductosBindingSource
        Me.DgvProductos.Location = New System.Drawing.Point(6, 63)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.ReadOnly = True
        Me.DgvProductos.Size = New System.Drawing.Size(763, 257)
        Me.DgvProductos.TabIndex = 0
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "id_Producto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PresentacionDataGridViewTextBoxColumn
        '
        Me.PresentacionDataGridViewTextBoxColumn.DataPropertyName = "presentacion"
        Me.PresentacionDataGridViewTextBoxColumn.HeaderText = "Presentacion"
        Me.PresentacionDataGridViewTextBoxColumn.Name = "PresentacionDataGridViewTextBoxColumn"
        Me.PresentacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'id_CategoriaP
        '
        Me.id_CategoriaP.DataPropertyName = "id_CategoriaP"
        Me.id_CategoriaP.HeaderText = "id_CategoriaP"
        Me.id_CategoriaP.Name = "id_CategoriaP"
        Me.id_CategoriaP.ReadOnly = True
        Me.id_CategoriaP.Visible = False
        '
        'NombreCatDataGridViewTextBoxColumn
        '
        Me.NombreCatDataGridViewTextBoxColumn.DataPropertyName = "nombreCat"
        Me.NombreCatDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.NombreCatDataGridViewTextBoxColumn.Name = "NombreCatDataGridViewTextBoxColumn"
        Me.NombreCatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'id_U_Medida
        '
        Me.id_U_Medida.DataPropertyName = "id_U_Medida"
        Me.id_U_Medida.HeaderText = "id_U_Medida"
        Me.id_U_Medida.Name = "id_U_Medida"
        Me.id_U_Medida.ReadOnly = True
        Me.id_U_Medida.Visible = False
        '
        'NombreMedidaDataGridViewTextBoxColumn
        '
        Me.NombreMedidaDataGridViewTextBoxColumn.DataPropertyName = "nombreMedida"
        Me.NombreMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad de Medida"
        Me.NombreMedidaDataGridViewTextBoxColumn.Name = "NombreMedidaDataGridViewTextBoxColumn"
        Me.NombreMedidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwProductosBindingSource
        '
        Me.VwProductosBindingSource.DataMember = "vwProductos"
        Me.VwProductosBindingSource.DataSource = Me.KelaniDataSet
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.KelaniDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdProd)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnIngresar)
        Me.GroupBox2.Controls.Add(Me.cbxUMedida)
        Me.GroupBox2.Controls.Add(Me.cbxCategoria)
        Me.GroupBox2.Controls.Add(Me.txtCosto)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.txtPresentacion)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 353)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 245)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Producto"
        '
        'txtIdProd
        '
        Me.txtIdProd.Location = New System.Drawing.Point(712, 179)
        Me.txtIdProd.Name = "txtIdProd"
        Me.txtIdProd.Size = New System.Drawing.Size(42, 26)
        Me.txtIdProd.TabIndex = 15
        Me.txtIdProd.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(405, 205)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 29)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(204, 205)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(113, 29)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(12, 205)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(113, 29)
        Me.btnIngresar.TabIndex = 12
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'cbxUMedida
        '
        Me.cbxUMedida.DataSource = Me.UnidadMedidaBindingSource
        Me.cbxUMedida.DisplayMember = "nombreMedida"
        Me.cbxUMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUMedida.FormattingEnabled = True
        Me.cbxUMedida.Location = New System.Drawing.Point(156, 146)
        Me.cbxUMedida.Name = "cbxUMedida"
        Me.cbxUMedida.Size = New System.Drawing.Size(223, 26)
        Me.cbxUMedida.TabIndex = 11
        Me.cbxUMedida.ValueMember = "id_U_Medida"
        '
        'UnidadMedidaBindingSource
        '
        Me.UnidadMedidaBindingSource.DataMember = "unidadMedida"
        Me.UnidadMedidaBindingSource.DataSource = Me.KelaniDataSet
        '
        'cbxCategoria
        '
        Me.cbxCategoria.DataSource = Me.CategoriaBindingSource
        Me.cbxCategoria.DisplayMember = "nombreCat"
        Me.cbxCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(156, 93)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(223, 26)
        Me.cbxCategoria.TabIndex = 10
        Me.cbxCategoria.ValueMember = "id_CategoriaP"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.KelaniDataSet
        '
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Location = New System.Drawing.Point(523, 148)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(223, 24)
        Me.txtCosto.TabIndex = 9
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(523, 93)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(223, 24)
        Me.txtPrecio.TabIndex = 8
        '
        'txtPresentacion
        '
        Me.txtPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresentacion.Location = New System.Drawing.Point(523, 39)
        Me.txtPresentacion.Name = "txtPresentacion"
        Me.txtPresentacion.Size = New System.Drawing.Size(223, 24)
        Me.txtPresentacion.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(156, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(223, 24)
        Me.txtNombre.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(407, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Costo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(407, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Precio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(407, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Presentación:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Unidad de Medida:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'UnidadMedidaTableAdapter
        '
        Me.UnidadMedidaTableAdapter.ClearBeforeFill = True
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "Producto"
        Me.ProductoBindingSource1.DataSource = Me.KelaniDataSet
        '
        'VwProductosTableAdapter
        '
        Me.VwProductosTableAdapter.ClearBeforeFill = True
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 611)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmProductos"
        Me.Text = "Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.UnidadMedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents cbxUMedida As ComboBox
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtPresentacion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As KelaniDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As KelaniDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents UnidadMedidaBindingSource As BindingSource
    Friend WithEvents UnidadMedidaTableAdapter As KelaniDataSetTableAdapters.unidadMedidaTableAdapter
    Friend WithEvents ProductoBindingSource1 As BindingSource
    Friend WithEvents VwProductosBindingSource As BindingSource
    Friend WithEvents VwProductosTableAdapter As KelaniDataSetTableAdapters.vwProductosTableAdapter
    Friend WithEvents txtIdProd As TextBox
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PresentacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents id_CategoriaP As DataGridViewTextBoxColumn
    Friend WithEvents NombreCatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents id_U_Medida As DataGridViewTextBoxColumn
    Friend WithEvents NombreMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
