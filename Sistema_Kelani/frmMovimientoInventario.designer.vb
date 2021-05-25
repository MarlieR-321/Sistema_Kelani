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
        Me.txtNombMov = New System.Windows.Forms.TextBox()
        Me.btmEliminar = New System.Windows.Forms.Button()
        Me.btmEditar = New System.Windows.Forms.Button()
        Me.btmIngresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdMovInv = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvMovInv = New System.Windows.Forms.DataGridView()
        Me.IdmovinvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtmovinvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovinvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.Mov_invTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.mov_invTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMovInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovinvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox2.Location = New System.Drawing.Point(3, 422)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 189)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo de movimiento"
        '
        'cbxTipoMov
        '
        Me.cbxTipoMov.FormattingEnabled = True
        Me.cbxTipoMov.Location = New System.Drawing.Point(226, 66)
        Me.cbxTipoMov.Name = "cbxTipoMov"
        Me.cbxTipoMov.Size = New System.Drawing.Size(288, 33)
        Me.cbxTipoMov.TabIndex = 7
        '
        'txtNombMov
        '
        Me.txtNombMov.Location = New System.Drawing.Point(225, 22)
        Me.txtNombMov.Name = "txtNombMov"
        Me.txtNombMov.Size = New System.Drawing.Size(289, 30)
        Me.txtNombMov.TabIndex = 6
        '
        'btmEliminar
        '
        Me.btmEliminar.Location = New System.Drawing.Point(364, 120)
        Me.btmEliminar.Name = "btmEliminar"
        Me.btmEliminar.Size = New System.Drawing.Size(115, 49)
        Me.btmEliminar.TabIndex = 4
        Me.btmEliminar.Text = "Eliminar"
        Me.btmEliminar.UseVisualStyleBackColor = True
        '
        'btmEditar
        '
        Me.btmEditar.Location = New System.Drawing.Point(208, 120)
        Me.btmEditar.Name = "btmEditar"
        Me.btmEditar.Size = New System.Drawing.Size(106, 49)
        Me.btmEditar.TabIndex = 4
        Me.btmEditar.Text = "Editar"
        Me.btmEditar.UseVisualStyleBackColor = True
        '
        'btmIngresar
        '
        Me.btmIngresar.Location = New System.Drawing.Point(60, 120)
        Me.btmIngresar.Name = "btmIngresar"
        Me.btmIngresar.Size = New System.Drawing.Size(95, 49)
        Me.btmIngresar.TabIndex = 4
        Me.btmIngresar.Text = "Ingresar"
        Me.btmIngresar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de movimiento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIdMovInv)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgvMovInv)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 389)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda y Seleccion"
        '
        'txtIdMovInv
        '
        Me.txtIdMovInv.Location = New System.Drawing.Point(490, 25)
        Me.txtIdMovInv.Name = "txtIdMovInv"
        Me.txtIdMovInv.Size = New System.Drawing.Size(55, 30)
        Me.txtIdMovInv.TabIndex = 4
        Me.txtIdMovInv.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(85, 58)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(295, 30)
        Me.txtBuscar.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Buscar:"
        '
        'dgvMovInv
        '
        Me.dgvMovInv.AutoGenerateColumns = False
        Me.dgvMovInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmovinvDataGridViewTextBoxColumn, Me.MovDataGridViewTextBoxColumn, Me.IdtmovinvDataGridViewTextBoxColumn})
        Me.dgvMovInv.DataSource = Me.MovinvBindingSource
        Me.dgvMovInv.Location = New System.Drawing.Point(0, 110)
        Me.dgvMovInv.Name = "dgvMovInv"
        Me.dgvMovInv.RowTemplate.Height = 24
        Me.dgvMovInv.Size = New System.Drawing.Size(551, 279)
        Me.dgvMovInv.TabIndex = 0
        '
        'IdmovinvDataGridViewTextBoxColumn
        '
        Me.IdmovinvDataGridViewTextBoxColumn.DataPropertyName = "id_mov_inv"
        Me.IdmovinvDataGridViewTextBoxColumn.HeaderText = "id_mov_inv"
        Me.IdmovinvDataGridViewTextBoxColumn.Name = "IdmovinvDataGridViewTextBoxColumn"
        Me.IdmovinvDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovDataGridViewTextBoxColumn
        '
        Me.MovDataGridViewTextBoxColumn.DataPropertyName = "_mov"
        Me.MovDataGridViewTextBoxColumn.HeaderText = "_mov"
        Me.MovDataGridViewTextBoxColumn.Name = "MovDataGridViewTextBoxColumn"
        '
        'IdtmovinvDataGridViewTextBoxColumn
        '
        Me.IdtmovinvDataGridViewTextBoxColumn.DataPropertyName = "id_tmov_inv"
        Me.IdtmovinvDataGridViewTextBoxColumn.HeaderText = "id_tmov_inv"
        Me.IdtmovinvDataGridViewTextBoxColumn.Name = "IdtmovinvDataGridViewTextBoxColumn"
        '
        'MovinvBindingSource
        '
        Me.MovinvBindingSource.DataMember = "mov_inv"
        Me.MovinvBindingSource.DataSource = Me.KelaniDataSet
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mov_invTableAdapter
        '
        Me.Mov_invTableAdapter.ClearBeforeFill = True
        '
        'frmMovimientoInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 623)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMovimientoInventario"
        Me.Text = "MovimientoInventario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvMovInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovinvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MovinvBindingSource As BindingSource
    Friend WithEvents Mov_invTableAdapter As KelaniDataSetTableAdapters.mov_invTableAdapter
    Friend WithEvents IdmovinvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtmovinvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtIdMovInv As TextBox
End Class
