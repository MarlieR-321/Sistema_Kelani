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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.ClienteBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.ClienteBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.ClienteTableAdapter()
        Me.gbGestionCl = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
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
        Me.ClienteBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_ClienteTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.T_ClienteTableAdapter()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGestionCl.SuspendLayout()
        CType(Me.ClienteBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AutoGenerateColumns = False
        Me.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.IdTClienteDataGridViewTextBoxColumn})
        Me.dgvClientes.DataSource = Me.ClienteBindingSource6
        Me.dgvClientes.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvClientes.Location = New System.Drawing.Point(12, 400)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersWidth = 51
        Me.dgvClientes.RowTemplate.Height = 24
        Me.dgvClientes.Size = New System.Drawing.Size(1102, 334)
        Me.dgvClientes.TabIndex = 0
        '
        'ClienteBindingSource5
        '
        Me.ClienteBindingSource5.DataMember = "Cliente"
        Me.ClienteBindingSource5.DataSource = Me.KelaniDataSet
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource4
        '
        Me.ClienteBindingSource4.DataMember = "Cliente"
        Me.ClienteBindingSource4.DataSource = Me.KelaniDataSetBindingSource
        '
        'KelaniDataSetBindingSource
        '
        Me.KelaniDataSetBindingSource.DataSource = Me.KelaniDataSet
        Me.KelaniDataSetBindingSource.Position = 0
        '
        'ClienteBindingSource1
        '
        Me.ClienteBindingSource1.DataMember = "Cliente"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.KelaniDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
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
        Me.gbGestionCl.Location = New System.Drawing.Point(12, 12)
        Me.gbGestionCl.Name = "gbGestionCl"
        Me.gbGestionCl.Size = New System.Drawing.Size(1102, 382)
        Me.gbGestionCl.TabIndex = 1
        Me.gbGestionCl.TabStop = False
        Me.gbGestionCl.Text = "Clientes"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(907, 264)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(172, 51)
        Me.btnNuevo.TabIndex = 20
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(907, 207)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(172, 51)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(907, 150)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(172, 51)
        Me.btnEditar.TabIndex = 18
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(907, 93)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(172, 51)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cbxTipo
        '
        Me.cbxTipo.DataSource = Me.TClienteBindingSource
        Me.cbxTipo.DisplayMember = "tipo_Cl"
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Location = New System.Drawing.Point(217, 270)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(237, 39)
        Me.cbxTipo.TabIndex = 16
        Me.cbxTipo.ValueMember = "idT_Cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 32)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tipo de cliente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(122, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 32)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "e-Mail:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(217, 225)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(237, 38)
        Me.txtEmail.TabIndex = 13
        '
        'rtbDireccion
        '
        Me.rtbDireccion.Location = New System.Drawing.Point(605, 93)
        Me.rtbDireccion.Name = "rtbDireccion"
        Me.rtbDireccion.Size = New System.Drawing.Size(279, 260)
        Me.rtbDireccion.TabIndex = 12
        Me.rtbDireccion.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(479, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Teléfono:"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(217, 315)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(237, 38)
        Me.txttelefono.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cédula:"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(217, 181)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(237, 38)
        Me.txtCedula.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(217, 137)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(237, 38)
        Me.txtApellido.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(217, 93)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(237, 38)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(414, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "id:"
        '
        'txtIDCLIENTE
        '
        Me.txtIDCLIENTE.Enabled = False
        Me.txtIDCLIENTE.Location = New System.Drawing.Point(460, 37)
        Me.txtIDCLIENTE.Name = "txtIDCLIENTE"
        Me.txtIDCLIENTE.Size = New System.Drawing.Size(146, 38)
        Me.txtIDCLIENTE.TabIndex = 0
        '
        'ClienteBindingSource2
        '
        Me.ClienteBindingSource2.DataMember = "Cliente"
        '
        'ClienteBindingSource3
        '
        Me.ClienteBindingSource3.DataMember = "Cliente"
        Me.ClienteBindingSource3.DataSource = Me.KelaniDataSet
        '
        'KelaniDataSetBindingSource1
        '
        Me.KelaniDataSetBindingSource1.DataSource = Me.KelaniDataSet
        Me.KelaniDataSetBindingSource1.Position = 0
        '
        'ClienteBindingSource6
        '
        Me.ClienteBindingSource6.DataMember = "Cliente"
        Me.ClienteBindingSource6.DataSource = Me.KelaniDataSet
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdClienteDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.Width = 125
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.Width = 125
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.Width = 125
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'IdTClienteDataGridViewTextBoxColumn
        '
        Me.IdTClienteDataGridViewTextBoxColumn.DataPropertyName = "idT_Cliente"
        Me.IdTClienteDataGridViewTextBoxColumn.HeaderText = "idT_Cliente"
        Me.IdTClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdTClienteDataGridViewTextBoxColumn.Name = "IdTClienteDataGridViewTextBoxColumn"
        Me.IdTClienteDataGridViewTextBoxColumn.Width = 125
        '
        'TClienteBindingSource
        '
        Me.TClienteBindingSource.DataMember = "T_Cliente"
        Me.TClienteBindingSource.DataSource = Me.KelaniDataSetBindingSource1
        '
        'T_ClienteTableAdapter
        '
        Me.T_ClienteTableAdapter.ClearBeforeFill = True
        '
        'frmGestionClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1126, 746)
        Me.Controls.Add(Me.gbGestionCl)
        Me.Controls.Add(Me.dgvClientes)
        Me.MaximizeBox = False
        Me.Name = "frmGestionClientes"
        Me.Text = "Gestión de clientes - Kelani"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGestionCl.ResumeLayout(False)
        Me.gbGestionCl.PerformLayout()
        CType(Me.ClienteBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As KelaniDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingSource1 As BindingSource
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
    Friend WithEvents ClienteBindingSource2 As BindingSource
    Friend WithEvents ClienteBindingSource3 As BindingSource
    Friend WithEvents ClienteBindingSource4 As BindingSource
    Friend WithEvents KelaniDataSetBindingSource As BindingSource
    Friend WithEvents ClienteBindingSource5 As BindingSource
    Friend WithEvents KelaniDataSetBindingSource1 As BindingSource
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdTClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource6 As BindingSource
    Friend WithEvents TClienteBindingSource As BindingSource
    Friend WithEvents T_ClienteTableAdapter As KelaniDataSetTableAdapters.T_ClienteTableAdapter
End Class
