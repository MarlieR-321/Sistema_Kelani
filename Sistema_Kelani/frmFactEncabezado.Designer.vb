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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bEditar = New System.Windows.Forms.Button()
        Me.bIngresar = New System.Windows.Forms.Button()
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.VwClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwClientesTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.VwClientesTableAdapter()
        Me.FacturaEncTableAdapter1 = New Sistema_Kelani.KelaniDataSetTableAdapters.FacturaEncTableAdapter()
        Me.KelaniDataSet1 = New Sistema_Kelani.KelaniDataSet()
        Me.VwFacturaDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_FacturaDetTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.vw_FacturaDetTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFacturaDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 43)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1183, 24)
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
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.bIngresar)
        Me.GroupBox4.Controls.Add(Me.bEditar)
        Me.GroupBox4.Controls.Add(Me.bEliminar)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 408)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1157, 355)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalles de la Factura"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(557, 299)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(277, 26)
        Me.TextBox1.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(470, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Cantidad: "
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "id_Producto"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 299)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(273, 28)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "id_Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Producto: "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1009, 244)
        Me.DataGridView1.TabIndex = 0
        '
        'bEliminar
        '
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.Location = New System.Drawing.Point(1042, 209)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(98, 30)
        Me.bEliminar.TabIndex = 4
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bEditar
        '
        Me.bEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEditar.Location = New System.Drawing.Point(1042, 131)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(98, 29)
        Me.bEditar.TabIndex = 5
        Me.bEditar.Text = "Editar"
        Me.bEditar.UseVisualStyleBackColor = True
        '
        'bIngresar
        '
        Me.bIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bIngresar.Location = New System.Drawing.Point(1042, 54)
        Me.bIngresar.Name = "bIngresar"
        Me.bIngresar.Size = New System.Drawing.Size(98, 28)
        Me.bIngresar.TabIndex = 6
        Me.bIngresar.Text = "Ingresar"
        Me.bIngresar.UseVisualStyleBackColor = True
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
        'KelaniDataSet1
        '
        Me.KelaniDataSet1.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwFacturaDetBindingSource
        '
        Me.VwFacturaDetBindingSource.DataMember = "vw_FacturaDet"
        Me.VwFacturaDetBindingSource.DataSource = Me.KelaniDataSet1
        '
        'Vw_FacturaDetTableAdapter
        '
        Me.Vw_FacturaDetTableAdapter.ClearBeforeFill = True
        '
        'frmFactEncabezado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1200, 637)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFactEncabezado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFacturaDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NombreCatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents KelaniDataSet1 As KelaniDataSet
    Friend WithEvents VwFacturaDetBindingSource As BindingSource
    Friend WithEvents Vw_FacturaDetTableAdapter As KelaniDataSetTableAdapters.vw_FacturaDetTableAdapter
    Friend WithEvents bIngresar As Button
    Friend WithEvents bEditar As Button
    Friend WithEvents bEliminar As Button
End Class
