<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionClientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.KelaniDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbGestionCl = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.TClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.rtbDireccion = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDCLIENTE = New System.Windows.Forms.TextBox()
        Me.ClienteTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.ClienteTableAdapter()
        Me.T_ClienteTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.T_ClienteTableAdapter()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoClDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwClientesTableAdapter1 = New Sistema_Kelani.KelaniDataSetTableAdapters.VwClientesTableAdapter()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGestionCl.SuspendLayout()
        CType(Me.TClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.KelaniDataSet
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KelaniDataSetBindingSource
        '
        Me.KelaniDataSetBindingSource.DataSource = Me.KelaniDataSet
        Me.KelaniDataSetBindingSource.Position = 0
        '
        'gbGestionCl
        '
        Me.gbGestionCl.Controls.Add(Me.btnNuevo)
        Me.gbGestionCl.Controls.Add(Me.btnEliminar)
        Me.gbGestionCl.Controls.Add(Me.btnEditar)
        Me.gbGestionCl.Controls.Add(Me.btnGuardar)
        Me.gbGestionCl.Controls.Add(Me.cbxTipo)
        Me.gbGestionCl.Controls.Add(Me.Label8)
        Me.gbGestionCl.Controls.Add(Me.Label7)
        Me.gbGestionCl.Controls.Add(Me.txtEmail)
        Me.gbGestionCl.Controls.Add(Me.rtbDireccion)
        Me.gbGestionCl.Controls.Add(Me.Label6)
        Me.gbGestionCl.Controls.Add(Me.Label5)
        Me.gbGestionCl.Controls.Add(Me.txttelefono)
        Me.gbGestionCl.Controls.Add(Me.Label4)
        Me.gbGestionCl.Controls.Add(Me.txtCedula)
        Me.gbGestionCl.Controls.Add(Me.Label3)
        Me.gbGestionCl.Controls.Add(Me.txtApellido)
        Me.gbGestionCl.Controls.Add(Me.Label2)
        Me.gbGestionCl.Controls.Add(Me.txtNombre)
        Me.gbGestionCl.Controls.Add(Me.Label1)
        Me.gbGestionCl.Controls.Add(Me.txtIDCLIENTE)
        Me.gbGestionCl.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGestionCl.Location = New System.Drawing.Point(9, 10)
        Me.gbGestionCl.Margin = New System.Windows.Forms.Padding(2)
        Me.gbGestionCl.Name = "gbGestionCl"
        Me.gbGestionCl.Padding = New System.Windows.Forms.Padding(2)
        Me.gbGestionCl.Size = New System.Drawing.Size(826, 310)
        Me.gbGestionCl.TabIndex = 1
        Me.gbGestionCl.TabStop = False
        Me.gbGestionCl.Text = "Clientes"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(680, 214)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(129, 41)
        Me.btnNuevo.TabIndex = 20
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(680, 168)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(129, 41)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(680, 122)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(129, 41)
        Me.btnEditar.TabIndex = 18
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(680, 76)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(129, 41)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cbxTipo
        '
        Me.cbxTipo.DataSource = Me.TClienteBindingSource
        Me.cbxTipo.DisplayMember = "tipo_Cl"
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Location = New System.Drawing.Point(163, 219)
        Me.cbxTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(179, 33)
        Me.cbxTipo.TabIndex = 16
        Me.cbxTipo.ValueMember = "idT_Cliente"
        '
        'TClienteBindingSource
        '
        Me.TClienteBindingSource.DataMember = "T_Cliente"
        Me.TClienteBindingSource.DataSource = Me.KelaniDataSetBindingSource1
        '
        'KelaniDataSetBindingSource1
        '
        Me.KelaniDataSetBindingSource1.DataSource = Me.KelaniDataSet
        Me.KelaniDataSetBindingSource1.Position = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 222)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tipo de cliente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 185)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "e-Mail:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(163, 183)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(179, 32)
        Me.txtEmail.TabIndex = 13
        '
        'rtbDireccion
        '
        Me.rtbDireccion.Location = New System.Drawing.Point(454, 76)
        Me.rtbDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.rtbDireccion.Name = "rtbDireccion"
        Me.rtbDireccion.Size = New System.Drawing.Size(210, 212)
        Me.rtbDireccion.TabIndex = 12
        Me.rtbDireccion.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(359, 76)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 258)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Teléfono:"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(163, 256)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(179, 32)
        Me.txttelefono.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cédula:"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(163, 147)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(179, 32)
        Me.txtCedula.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(163, 111)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(179, 32)
        Me.txtApellido.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(163, 76)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(179, 32)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "id:"
        '
        'txtIDCLIENTE
        '
        Me.txtIDCLIENTE.Enabled = False
        Me.txtIDCLIENTE.Location = New System.Drawing.Point(345, 30)
        Me.txtIDCLIENTE.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDCLIENTE.Name = "txtIDCLIENTE"
        Me.txtIDCLIENTE.Size = New System.Drawing.Size(110, 32)
        Me.txtIDCLIENTE.TabIndex = 0
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'T_ClienteTableAdapter
        '
        Me.T_ClienteTableAdapter.ClearBeforeFill = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.AutoGenerateColumns = False
        Me.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.TipoClDataGridViewTextBoxColumn})
        Me.dgvClientes.DataSource = Me.VwClientesBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClientes.Location = New System.Drawing.Point(9, 325)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.Size = New System.Drawing.Size(823, 269)
        Me.dgvClientes.TabIndex = 2
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoClDataGridViewTextBoxColumn
        '
        Me.TipoClDataGridViewTextBoxColumn.DataPropertyName = "tipo_Cl"
        Me.TipoClDataGridViewTextBoxColumn.HeaderText = "tipo_Cl"
        Me.TipoClDataGridViewTextBoxColumn.Name = "TipoClDataGridViewTextBoxColumn"
        Me.TipoClDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwClientesBindingSource1
        '
        Me.VwClientesBindingSource1.DataMember = "VwClientes"
        Me.VwClientesBindingSource1.DataSource = Me.KelaniDataSet
        '
        'VwClientesTableAdapter1
        '
        Me.VwClientesTableAdapter1.ClearBeforeFill = True
        '
        'frmGestionClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(844, 606)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.gbGestionCl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmGestionClientes"
        Me.Text = "Gestión de clientes - Kelani"
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGestionCl.ResumeLayout(False)
        Me.gbGestionCl.PerformLayout()
        CType(Me.TClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents ClienteTableAdapter As KelaniDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents gbGestionCl As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents rtbDireccion As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDCLIENTE As TextBox
    Friend WithEvents KelaniDataSetBindingSource As BindingSource
    Friend WithEvents KelaniDataSetBindingSource1 As BindingSource
    Friend WithEvents TClienteBindingSource As BindingSource
    Friend WithEvents T_ClienteTableAdapter As KelaniDataSetTableAdapters.T_ClienteTableAdapter
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoClDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VwClientesBindingSource1 As BindingSource
    Friend WithEvents VwClientesTableAdapter1 As KelaniDataSetTableAdapters.VwClientesTableAdapter
End Class
