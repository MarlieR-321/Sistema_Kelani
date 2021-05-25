<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaDeEncabezados
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnUsar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtIDCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rtbDirCliente = New System.Windows.Forms.RichTextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FacturaEncBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FacturaEncTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.FacturaEncTableAdapter()
        Me.VwFacturaDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_FacturaDetTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.vw_FacturaDetTableAdapter()
        Me.IdFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreClDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionClDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumRUCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaEncBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFacturaDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnUsar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1147, 664)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezados"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(675, 628)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 29)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnUsar
        '
        Me.btnUsar.Location = New System.Drawing.Point(517, 628)
        Me.btnUsar.Name = "btnUsar"
        Me.btnUsar.Size = New System.Drawing.Size(152, 29)
        Me.btnUsar.TabIndex = 17
        Me.btnUsar.Text = "Usar encabezado"
        Me.btnUsar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(1029, 628)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 29)
        Me.btnNuevo.TabIndex = 16
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(911, 628)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 29)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(793, 628)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(112, 29)
        Me.btnEditar.TabIndex = 14
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 309)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1135, 96)
        Me.GroupBox3.TabIndex = 13
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
        Me.dtpFecha.Size = New System.Drawing.Size(381, 26)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "iD de factura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Número de factura:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(595, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Selecciona la fecha"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox2.Controls.Add(Me.txtIDCliente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.rtbDirCliente)
        Me.GroupBox2.Controls.Add(Me.txtIdentificacion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 411)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1135, 211)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del cliente"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(986, 159)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(137, 33)
        Me.btnBuscarCliente.TabIndex = 11
        Me.btnBuscarCliente.Text = "Buscar cliente"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
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
        Me.rtbDirCliente.Size = New System.Drawing.Size(1023, 76)
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFacturaDataGridViewTextBoxColumn, Me.NumFacturaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.NombreClDataGridViewTextBoxColumn, Me.IdentificacionDataGridViewTextBoxColumn, Me.DireccionClDataGridViewTextBoxColumn, Me.NumRUCDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.IdClienteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FacturaEncBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1135, 223)
        Me.DataGridView1.TabIndex = 2
        '
        'FacturaEncBindingSource
        '
        Me.FacturaEncBindingSource.DataMember = "FacturaEnc"
        Me.FacturaEncBindingSource.DataSource = Me.KelaniDataSet
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(159, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(317, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar por RUC:"
        '
        'FacturaEncTableAdapter
        '
        Me.FacturaEncTableAdapter.ClearBeforeFill = True
        '
        'VwFacturaDetBindingSource
        '
        Me.VwFacturaDetBindingSource.DataMember = "vw_FacturaDet"
        Me.VwFacturaDetBindingSource.DataSource = Me.KelaniDataSet
        '
        'Vw_FacturaDetTableAdapter
        '
        Me.Vw_FacturaDetTableAdapter.ClearBeforeFill = True
        '
        'IdFacturaDataGridViewTextBoxColumn
        '
        Me.IdFacturaDataGridViewTextBoxColumn.DataPropertyName = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.HeaderText = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.Name = "IdFacturaDataGridViewTextBoxColumn"
        Me.IdFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumFacturaDataGridViewTextBoxColumn
        '
        Me.NumFacturaDataGridViewTextBoxColumn.DataPropertyName = "numFactura"
        Me.NumFacturaDataGridViewTextBoxColumn.HeaderText = "numFactura"
        Me.NumFacturaDataGridViewTextBoxColumn.Name = "NumFacturaDataGridViewTextBoxColumn"
        Me.NumFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreClDataGridViewTextBoxColumn
        '
        Me.NombreClDataGridViewTextBoxColumn.DataPropertyName = "nombreCl"
        Me.NombreClDataGridViewTextBoxColumn.HeaderText = "nombreCl"
        Me.NombreClDataGridViewTextBoxColumn.Name = "NombreClDataGridViewTextBoxColumn"
        Me.NombreClDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdentificacionDataGridViewTextBoxColumn
        '
        Me.IdentificacionDataGridViewTextBoxColumn.DataPropertyName = "identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn.HeaderText = "identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn.Name = "IdentificacionDataGridViewTextBoxColumn"
        Me.IdentificacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionClDataGridViewTextBoxColumn
        '
        Me.DireccionClDataGridViewTextBoxColumn.DataPropertyName = "direccionCl"
        Me.DireccionClDataGridViewTextBoxColumn.HeaderText = "direccionCl"
        Me.DireccionClDataGridViewTextBoxColumn.Name = "DireccionClDataGridViewTextBoxColumn"
        Me.DireccionClDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumRUCDataGridViewTextBoxColumn
        '
        Me.NumRUCDataGridViewTextBoxColumn.DataPropertyName = "numRUC"
        Me.NumRUCDataGridViewTextBoxColumn.HeaderText = "numRUC"
        Me.NumRUCDataGridViewTextBoxColumn.Name = "NumRUCDataGridViewTextBoxColumn"
        Me.NumRUCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IVADataGridViewTextBoxColumn
        '
        Me.IVADataGridViewTextBoxColumn.DataPropertyName = "IVA"
        Me.IVADataGridViewTextBoxColumn.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn.Name = "IVADataGridViewTextBoxColumn"
        Me.IVADataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmVistaDeEncabezados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1166, 682)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVistaDeEncabezados"
        Me.Text = "Encabezados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaEncBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFacturaDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents FacturaEncBindingSource As BindingSource
    Friend WithEvents FacturaEncTableAdapter As KelaniDataSetTableAdapters.FacturaEncTableAdapter
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnUsar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtRUC As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents txtNumeroFactura As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIDFactura As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtIDCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rtbDirCliente As RichTextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents VwFacturaDetBindingSource As BindingSource
    Friend WithEvents Vw_FacturaDetTableAdapter As KelaniDataSetTableAdapters.vw_FacturaDetTableAdapter
    Friend WithEvents IdFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreClDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionClDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumRUCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
