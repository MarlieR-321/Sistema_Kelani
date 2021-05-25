<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactEncabezado
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIDFactura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarEncabezado = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtIDCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rtbDirCliente = New System.Windows.Forms.RichTextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VerEncabezadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtIDDetalle = New System.Windows.Forms.TextBox()
        Me.txtIDProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecioProducto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregarALaFactura = New System.Windows.Forms.Button()
        Me.txtCantidadProducto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.IdFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFacturaDetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwFacturaDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet1 = New Sistema_Kelani.KelaniDataSet()
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.VwClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwClientesTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.VwClientesTableAdapter()
        Me.FacturaEncTableAdapter1 = New Sistema_Kelani.KelaniDataSetTableAdapters.FacturaEncTableAdapter()
        Me.Vw_FacturaDetTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.vw_FacturaDetTableAdapter()
        Me.FacturaDetTableAdapter1 = New Sistema_Kelani.KelaniDataSetTableAdapters.FacturaDetTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFacturaDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1158, 359)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factura Encabezado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtRUC)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.dtpFecha)
        Me.GroupBox3.Controls.Add(Me.txtIVA)
        Me.GroupBox3.Controls.Add(Me.txtNumeroFactura)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.txtIDFactura)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1124, 96)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información general"
        '
        'txtRUC
        '
        Me.txtRUC.Location = New System.Drawing.Point(68, 57)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(516, 26)
        Me.txtRUC.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(594, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "IVA:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(748, 25)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(361, 26)
        Me.dtpFecha.TabIndex = 5
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(637, 57)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(57, 26)
        Me.txtIVA.TabIndex = 8
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(378, 25)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(207, 26)
        Me.txtNumeroFactura.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(700, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "RUC:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(748, 57)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(96, 26)
        Me.txtTotal.TabIndex = 10
        '
        'txtIDFactura
        '
        Me.txtIDFactura.Location = New System.Drawing.Point(121, 25)
        Me.txtIDFactura.Name = "txtIDFactura"
        Me.txtIDFactura.ReadOnly = True
        Me.txtIDFactura.Size = New System.Drawing.Size(100, 26)
        Me.txtIDFactura.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "iD de factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número de factura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(595, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Selecciona la fecha"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGuardarEncabezado)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtIDCliente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.rtbDirCliente)
        Me.GroupBox2.Controls.Add(Me.txtIdentificacion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1124, 211)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del cliente"
        '
        'btnGuardarEncabezado
        '
        Me.btnGuardarEncabezado.Location = New System.Drawing.Point(783, 161)
        Me.btnGuardarEncabezado.Name = "btnGuardarEncabezado"
        Me.btnGuardarEncabezado.Size = New System.Drawing.Size(183, 33)
        Me.btnGuardarEncabezado.TabIndex = 12
        Me.btnGuardarEncabezado.Text = "Guardar Encabezado"
        Me.btnGuardarEncabezado.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(972, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Buscar cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Location = New System.Drawing.Point(278, 25)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.ReadOnly = True
        Me.txtIDCliente.Size = New System.Drawing.Size(60, 26)
        Me.txtIDCliente.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(244, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "iD:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Dirección:"
        '
        'rtbDirCliente
        '
        Me.rtbDirCliente.Location = New System.Drawing.Point(100, 68)
        Me.rtbDirCliente.Name = "rtbDirCliente"
        Me.rtbDirCliente.Size = New System.Drawing.Size(1018, 76)
        Me.rtbDirCliente.TabIndex = 7
        Me.rtbDirCliente.Text = ""
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(458, 25)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.ReadOnly = True
        Me.txtIdentificacion.Size = New System.Drawing.Size(284, 26)
        Me.txtIdentificacion.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Identificación:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(99, 25)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(139, 26)
        Me.txtNombreCliente.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nombre:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerEncabezadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1241, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VerEncabezadosToolStripMenuItem
        '
        Me.VerEncabezadosToolStripMenuItem.Name = "VerEncabezadosToolStripMenuItem"
        Me.VerEncabezadosToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.VerEncabezadosToolStripMenuItem.Text = "Ver encabezados"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtIDDetalle)
        Me.GroupBox4.Controls.Add(Me.txtIDProducto)
        Me.GroupBox4.Controls.Add(Me.txtPrecioProducto)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.btnEliminar)
        Me.GroupBox4.Controls.Add(Me.btnEditar)
        Me.GroupBox4.Controls.Add(Me.btnAgregarALaFactura)
        Me.GroupBox4.Controls.Add(Me.txtCantidadProducto)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtNombreProducto)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.btnBuscarProducto)
        Me.GroupBox4.Controls.Add(Me.dgvDetalles)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 405)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1158, 497)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalles de la Factura"
        '
        'txtIDDetalle
        '
        Me.txtIDDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDDetalle.Location = New System.Drawing.Point(32, 128)
        Me.txtIDDetalle.Name = "txtIDDetalle"
        Me.txtIDDetalle.Size = New System.Drawing.Size(108, 26)
        Me.txtIDDetalle.TabIndex = 16
        Me.txtIDDetalle.Visible = False
        '
        'txtIDProducto
        '
        Me.txtIDProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDProducto.Location = New System.Drawing.Point(163, 128)
        Me.txtIDProducto.Name = "txtIDProducto"
        Me.txtIDProducto.Size = New System.Drawing.Size(108, 26)
        Me.txtIDProducto.TabIndex = 14
        Me.txtIDProducto.Visible = False
        '
        'txtPrecioProducto
        '
        Me.txtPrecioProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioProducto.Location = New System.Drawing.Point(941, 44)
        Me.txtPrecioProducto.Name = "txtPrecioProducto"
        Me.txtPrecioProducto.ReadOnly = True
        Me.txtPrecioProducto.Size = New System.Drawing.Size(185, 26)
        Me.txtPrecioProducto.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(835, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 20)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Precio:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(737, 91)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 32)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(839, 91)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(96, 32)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregarALaFactura
        '
        Me.btnAgregarALaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarALaFactura.Location = New System.Drawing.Point(941, 91)
        Me.btnAgregarALaFactura.Name = "btnAgregarALaFactura"
        Me.btnAgregarALaFactura.Size = New System.Drawing.Size(189, 32)
        Me.btnAgregarALaFactura.TabIndex = 8
        Me.btnAgregarALaFactura.Text = "Agregar a la factura"
        Me.btnAgregarALaFactura.UseVisualStyleBackColor = True
        '
        'txtCantidadProducto
        '
        Me.txtCantidadProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadProducto.Location = New System.Drawing.Point(597, 47)
        Me.txtCantidadProducto.Name = "txtCantidadProducto"
        Me.txtCantidadProducto.Size = New System.Drawing.Size(162, 26)
        Me.txtCantidadProducto.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(490, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Cantidad:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Location = New System.Drawing.Point(273, 47)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.ReadOnly = True
        Me.txtNombreProducto.Size = New System.Drawing.Size(134, 26)
        Me.txtNombreProducto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre:"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProducto.Location = New System.Drawing.Point(17, 41)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(163, 32)
        Me.btnBuscarProducto.TabIndex = 1
        Me.btnBuscarProducto.Text = "Buscar producto"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.AutoGenerateColumns = False
        Me.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFacturaDataGridViewTextBoxColumn, Me.IdFacturaDetDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.PresentacionDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dgvDetalles.DataSource = Me.VwFacturaDetBindingSource
        Me.dgvDetalles.Location = New System.Drawing.Point(17, 160)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvDetalles.Size = New System.Drawing.Size(1124, 319)
        Me.dgvDetalles.TabIndex = 0
        '
        'IdFacturaDataGridViewTextBoxColumn
        '
        Me.IdFacturaDataGridViewTextBoxColumn.DataPropertyName = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.HeaderText = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.Name = "IdFacturaDataGridViewTextBoxColumn"
        Me.IdFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdFacturaDataGridViewTextBoxColumn.Visible = False
        '
        'IdFacturaDetDataGridViewTextBoxColumn
        '
        Me.IdFacturaDetDataGridViewTextBoxColumn.DataPropertyName = "idFacturaDet"
        Me.IdFacturaDetDataGridViewTextBoxColumn.HeaderText = "idFacturaDet"
        Me.IdFacturaDetDataGridViewTextBoxColumn.Name = "IdFacturaDetDataGridViewTextBoxColumn"
        Me.IdFacturaDetDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdFacturaDetDataGridViewTextBoxColumn.Visible = False
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "id_Producto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "id_Producto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Visible = False
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PresentacionDataGridViewTextBoxColumn
        '
        Me.PresentacionDataGridViewTextBoxColumn.DataPropertyName = "presentacion"
        Me.PresentacionDataGridViewTextBoxColumn.HeaderText = "Presentacion"
        Me.PresentacionDataGridViewTextBoxColumn.Name = "PresentacionDataGridViewTextBoxColumn"
        Me.PresentacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio Unitario"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "precioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Visible = False
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Visible = False
        '
        'VwFacturaDetBindingSource
        '
        Me.VwFacturaDetBindingSource.DataMember = "vw_FacturaDet"
        Me.VwFacturaDetBindingSource.DataSource = Me.KelaniDataSet1
        '
        'KelaniDataSet1
        '
        Me.KelaniDataSet1.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwClientesBindingSource
        '
        Me.VwClientesBindingSource.DataMember = "VwClientes"
        Me.VwClientesBindingSource.DataSource = Me.KelaniDataSet
        '
        'VwClientesTableAdapter
        '
        Me.VwClientesTableAdapter.ClearBeforeFill = True
        '
        'FacturaEncTableAdapter1
        '
        Me.FacturaEncTableAdapter1.ClearBeforeFill = True
        '
        'Vw_FacturaDetTableAdapter
        '
        Me.Vw_FacturaDetTableAdapter.ClearBeforeFill = True
        '
        'FacturaDetTableAdapter1
        '
        Me.FacturaDetTableAdapter1.ClearBeforeFill = True
        '
        'frmFactEncabezado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1258, 553)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFactEncabezado"
        Me.Text = "Facturación - Kelani"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFacturaDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIDFactura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumeroFactura As TextBox
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIDCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rtbDirCliente As RichTextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents VwClientesBindingSource As BindingSource
    Friend WithEvents VwClientesTableAdapter As KelaniDataSetTableAdapters.VwClientesTableAdapter
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRUC As TextBox
    Friend WithEvents FacturaEncTableAdapter1 As KelaniDataSetTableAdapters.FacturaEncTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VerEncabezadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvDetalles As DataGridView
    Friend WithEvents NombreCatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KelaniDataSet1 As KelaniDataSet
    Friend WithEvents VwFacturaDetBindingSource As BindingSource
    Friend WithEvents Vw_FacturaDetTableAdapter As KelaniDataSetTableAdapters.vw_FacturaDetTableAdapter
    Friend WithEvents btnGuardarEncabezado As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregarALaFactura As Button
    Friend WithEvents txtCantidadProducto As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents FacturaDetTableAdapter1 As KelaniDataSetTableAdapters.FacturaDetTableAdapter
    Friend WithEvents txtIDProducto As TextBox
    Friend WithEvents txtIDDetalle As TextBox
    Friend WithEvents IdFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdFacturaDetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PresentacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
