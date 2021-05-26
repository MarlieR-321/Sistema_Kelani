<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoInventario
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxTipoMov = New System.Windows.Forms.ComboBox()
        Me.TmovinvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNombMov = New System.Windows.Forms.TextBox()
        Me.btmEliminar = New System.Windows.Forms.Button()
        Me.btmEditar = New System.Windows.Forms.Button()
        Me.btmIngresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTMI = New System.Windows.Forms.TextBox()
        Me.txtIdMovInv = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvMovInv = New System.Windows.Forms.DataGridView()
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.T_mov_invTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.t_mov_invTableAdapter()
        Me.IdtmovinvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelaniDataSet1 = New Sistema_Kelani.KelaniDataSet()
        Me.KelaniDataSet2 = New Sistema_Kelani.KelaniDataSet()
        Me.MovinvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_invTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.mov_invTableAdapter()
        Me.VwMovInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwMov_InvTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.vwMov_InvTableAdapter()
        Me.id_tmov_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_mov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmovinvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtmovinvDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmovinvBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.TmovinvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMovInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovinvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwMovInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmovinvBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbxTipoMov)
        Me.GroupBox2.Controls.Add(Me.txtNombMov)
        Me.GroupBox2.Controls.Add(Me.btmEliminar)
        Me.GroupBox2.Controls.Add(Me.btmEditar)
        Me.GroupBox2.Controls.Add(Me.btmIngresar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 343)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(420, 154)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo de movimiento"
        '
        'cbxTipoMov
        '
        Me.cbxTipoMov.DataSource = Me.TmovinvBindingSource1
        Me.cbxTipoMov.DisplayMember = "t_mov"
        Me.cbxTipoMov.FormattingEnabled = True
        Me.cbxTipoMov.Location = New System.Drawing.Point(200, 51)
        Me.cbxTipoMov.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxTipoMov.Name = "cbxTipoMov"
        Me.cbxTipoMov.Size = New System.Drawing.Size(217, 28)
        Me.cbxTipoMov.TabIndex = 7
        Me.cbxTipoMov.ValueMember = "id_tmov_inv"
        '
        'TmovinvBindingSource
        '
        Me.TmovinvBindingSource.DataMember = "t_mov_inv"
        '
        'txtNombMov
        '
        Me.txtNombMov.Location = New System.Drawing.Point(199, 15)
        Me.txtNombMov.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombMov.Name = "txtNombMov"
        Me.txtNombMov.Size = New System.Drawing.Size(218, 26)
        Me.txtNombMov.TabIndex = 6
        '
        'btmEliminar
        '
        Me.btmEliminar.Location = New System.Drawing.Point(273, 98)
        Me.btmEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btmEliminar.Name = "btmEliminar"
        Me.btmEliminar.Size = New System.Drawing.Size(109, 40)
        Me.btmEliminar.TabIndex = 4
        Me.btmEliminar.Text = "Eliminar"
        Me.btmEliminar.UseVisualStyleBackColor = True
        '
        'btmEditar
        '
        Me.btmEditar.Location = New System.Drawing.Point(156, 98)
        Me.btmEditar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btmEditar.Name = "btmEditar"
        Me.btmEditar.Size = New System.Drawing.Size(80, 40)
        Me.btmEditar.TabIndex = 4
        Me.btmEditar.Text = "Editar"
        Me.btmEditar.UseVisualStyleBackColor = True
        '
        'btmIngresar
        '
        Me.btmIngresar.Location = New System.Drawing.Point(29, 98)
        Me.btmIngresar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btmIngresar.Name = "btmIngresar"
        Me.btmIngresar.Size = New System.Drawing.Size(87, 40)
        Me.btmIngresar.TabIndex = 4
        Me.btmIngresar.Text = "Ingresar"
        Me.btmIngresar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de movimiento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTMI)
        Me.GroupBox1.Controls.Add(Me.txtIdMovInv)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgvMovInv)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(413, 316)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda y Seleccion"
        '
        'txtTMI
        '
        Me.txtTMI.Location = New System.Drawing.Point(301, 50)
        Me.txtTMI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTMI.Name = "txtTMI"
        Me.txtTMI.Size = New System.Drawing.Size(109, 26)
        Me.txtTMI.TabIndex = 4
        Me.txtTMI.Visible = False
        '
        'txtIdMovInv
        '
        Me.txtIdMovInv.Location = New System.Drawing.Point(368, 20)
        Me.txtIdMovInv.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIdMovInv.Name = "txtIdMovInv"
        Me.txtIdMovInv.Size = New System.Drawing.Size(42, 26)
        Me.txtIdMovInv.TabIndex = 4
        Me.txtIdMovInv.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(64, 47)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(222, 26)
        Me.txtBuscar.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Buscar:"
        '
        'dgvMovInv
        '
        Me.dgvMovInv.AllowUserToAddRows = False
        Me.dgvMovInv.AllowUserToDeleteRows = False
        Me.dgvMovInv.AutoGenerateColumns = False
        Me.dgvMovInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tmov_inv, Me.t_mov, Me.IdmovinvDataGridViewTextBoxColumn, Me.MovDataGridViewTextBoxColumn, Me.IdtmovinvDataGridViewTextBoxColumn1})
        Me.dgvMovInv.DataSource = Me.VwMovInvBindingSource
        Me.dgvMovInv.Location = New System.Drawing.Point(0, 89)
        Me.dgvMovInv.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvMovInv.Name = "dgvMovInv"
        Me.dgvMovInv.ReadOnly = True
        Me.dgvMovInv.RowTemplate.Height = 24
        Me.dgvMovInv.Size = New System.Drawing.Size(413, 227)
        Me.dgvMovInv.TabIndex = 0
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_mov_invTableAdapter
        '
        Me.T_mov_invTableAdapter.ClearBeforeFill = True
        '
        'IdtmovinvDataGridViewTextBoxColumn
        '
        Me.IdtmovinvDataGridViewTextBoxColumn.DataPropertyName = "id_tmov_inv"
        Me.IdtmovinvDataGridViewTextBoxColumn.HeaderText = "id_tmov_inv"
        Me.IdtmovinvDataGridViewTextBoxColumn.Name = "IdtmovinvDataGridViewTextBoxColumn"
        Me.IdtmovinvDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KelaniDataSet1
        '
        Me.KelaniDataSet1.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KelaniDataSet2
        '
        Me.KelaniDataSet2.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MovinvBindingSource
        '
        Me.MovinvBindingSource.DataMember = "mov_inv"
        Me.MovinvBindingSource.DataSource = Me.KelaniDataSet1
        '
        'Mov_invTableAdapter
        '
        Me.Mov_invTableAdapter.ClearBeforeFill = True
        '
        'VwMovInvBindingSource
        '
        Me.VwMovInvBindingSource.DataMember = "vwMov_Inv"
        Me.VwMovInvBindingSource.DataSource = Me.KelaniDataSet1
        '
        'VwMov_InvTableAdapter
        '
        Me.VwMov_InvTableAdapter.ClearBeforeFill = True
        '
        'id_tmov_inv
        '
        Me.id_tmov_inv.DataPropertyName = "id_tmov_inv"
        Me.id_tmov_inv.HeaderText = "id_tmov_inv"
        Me.id_tmov_inv.Name = "id_tmov_inv"
        Me.id_tmov_inv.ReadOnly = True
        Me.id_tmov_inv.Visible = False
        '
        't_mov
        '
        Me.t_mov.DataPropertyName = "t_mov"
        Me.t_mov.HeaderText = "Tipo de Movimiento"
        Me.t_mov.Name = "t_mov"
        Me.t_mov.ReadOnly = True
        '
        'IdmovinvDataGridViewTextBoxColumn
        '
        Me.IdmovinvDataGridViewTextBoxColumn.DataPropertyName = "id_mov_inv"
        Me.IdmovinvDataGridViewTextBoxColumn.HeaderText = "id_mov_inv"
        Me.IdmovinvDataGridViewTextBoxColumn.Name = "IdmovinvDataGridViewTextBoxColumn"
        Me.IdmovinvDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdmovinvDataGridViewTextBoxColumn.Visible = False
        '
        'MovDataGridViewTextBoxColumn
        '
        Me.MovDataGridViewTextBoxColumn.DataPropertyName = "_mov"
        Me.MovDataGridViewTextBoxColumn.HeaderText = "Movimiento"
        Me.MovDataGridViewTextBoxColumn.Name = "MovDataGridViewTextBoxColumn"
        Me.MovDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdtmovinvDataGridViewTextBoxColumn1
        '
        Me.IdtmovinvDataGridViewTextBoxColumn1.DataPropertyName = "id_tmov_inv"
        Me.IdtmovinvDataGridViewTextBoxColumn1.HeaderText = "id_tmov_inv"
        Me.IdtmovinvDataGridViewTextBoxColumn1.Name = "IdtmovinvDataGridViewTextBoxColumn1"
        Me.IdtmovinvDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdtmovinvDataGridViewTextBoxColumn1.Visible = False
        '
        'TmovinvBindingSource1
        '
        Me.TmovinvBindingSource1.DataMember = "t_mov_inv"
        Me.TmovinvBindingSource1.DataSource = Me.KelaniDataSet1
        '
        'frmMovimientoInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 506)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMovimientoInventario"
        Me.Text = "MovimientoInventario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TmovinvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvMovInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovinvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwMovInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmovinvBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNombMov As TextBox
    Friend WithEvents btmEliminar As Button
    Friend WithEvents btmEditar As Button
    Friend WithEvents btmIngresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvMovInv As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxTipoMov As ComboBox
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents txtIdMovInv As TextBox
    Friend WithEvents TmovinvBindingSource As BindingSource
    Friend WithEvents T_mov_invTableAdapter As KelaniDataSetTableAdapters.t_mov_invTableAdapter
    Friend WithEvents txtTMI As TextBox
    Friend WithEvents IdtmovinvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KelaniDataSet1 As KelaniDataSet
    Friend WithEvents KelaniDataSet2 As KelaniDataSet
    Friend WithEvents MovinvBindingSource As BindingSource
    Friend WithEvents Mov_invTableAdapter As KelaniDataSetTableAdapters.mov_invTableAdapter
    Friend WithEvents VwMovInvBindingSource As BindingSource
    Friend WithEvents VwMov_InvTableAdapter As KelaniDataSetTableAdapters.vwMov_InvTableAdapter
    Friend WithEvents id_tmov_inv As DataGridViewTextBoxColumn
    Friend WithEvents t_mov As DataGridViewTextBoxColumn
    Friend WithEvents IdmovinvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtmovinvDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TmovinvBindingSource1 As BindingSource
End Class
