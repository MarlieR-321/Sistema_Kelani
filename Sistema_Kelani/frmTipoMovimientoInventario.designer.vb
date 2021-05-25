<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoMovimientoInventario
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
        Me.txtIdTipoMov = New System.Windows.Forms.TextBox()
        Me.txtNombTM = New System.Windows.Forms.TextBox()
        Me.btmEliminar = New System.Windows.Forms.Button()
        Me.btmEditar = New System.Windows.Forms.Button()
        Me.btmIngresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvTipoMovInv = New System.Windows.Forms.DataGridView()
        Me.IdtmovinvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmovDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmovinvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_mov_invTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.t_mov_invTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTipoMovInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmovinvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdTipoMov)
        Me.GroupBox2.Controls.Add(Me.txtNombTM)
        Me.GroupBox2.Controls.Add(Me.btmEliminar)
        Me.GroupBox2.Controls.Add(Me.btmEditar)
        Me.GroupBox2.Controls.Add(Me.btmIngresar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 386)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(501, 181)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'txtIdTipoMov
        '
        Me.txtIdTipoMov.Location = New System.Drawing.Point(413, 65)
        Me.txtIdTipoMov.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdTipoMov.Name = "txtIdTipoMov"
        Me.txtIdTipoMov.Size = New System.Drawing.Size(81, 30)
        Me.txtIdTipoMov.TabIndex = 5
        Me.txtIdTipoMov.Visible = False
        '
        'txtNombTM
        '
        Me.txtNombTM.Location = New System.Drawing.Point(56, 65)
        Me.txtNombTM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombTM.Name = "txtNombTM"
        Me.txtNombTM.Size = New System.Drawing.Size(279, 30)
        Me.txtNombTM.TabIndex = 5
        '
        'btmEliminar
        '
        Me.btmEliminar.Location = New System.Drawing.Point(339, 133)
        Me.btmEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btmEliminar.Name = "btmEliminar"
        Me.btmEliminar.Size = New System.Drawing.Size(108, 42)
        Me.btmEliminar.TabIndex = 4
        Me.btmEliminar.Text = "Eliminar"
        Me.btmEliminar.UseVisualStyleBackColor = True
        '
        'btmEditar
        '
        Me.btmEditar.Location = New System.Drawing.Point(182, 133)
        Me.btmEditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btmEditar.Name = "btmEditar"
        Me.btmEditar.Size = New System.Drawing.Size(102, 42)
        Me.btmEditar.TabIndex = 4
        Me.btmEditar.Text = "Editar"
        Me.btmEditar.UseVisualStyleBackColor = True
        '
        'btmIngresar
        '
        Me.btmIngresar.Location = New System.Drawing.Point(35, 133)
        Me.btmIngresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btmIngresar.Name = "btmIngresar"
        Me.btmIngresar.Size = New System.Drawing.Size(109, 42)
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
        Me.Label1.Location = New System.Drawing.Point(5, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del tipo de movimiento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvTipoMovInv)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(501, 368)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda y Seleccion"
        '
        'dgvTipoMovInv
        '
        Me.dgvTipoMovInv.AllowUserToAddRows = False
        Me.dgvTipoMovInv.AllowUserToDeleteRows = False
        Me.dgvTipoMovInv.AutoGenerateColumns = False
        Me.dgvTipoMovInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoMovInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtmovinvDataGridViewTextBoxColumn, Me.TmovDataGridViewTextBoxColumn})
        Me.dgvTipoMovInv.DataSource = Me.TmovinvBindingSource
        Me.dgvTipoMovInv.Location = New System.Drawing.Point(11, 96)
        Me.dgvTipoMovInv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTipoMovInv.Name = "dgvTipoMovInv"
        Me.dgvTipoMovInv.ReadOnly = True
        Me.dgvTipoMovInv.RowTemplate.Height = 24
        Me.dgvTipoMovInv.Size = New System.Drawing.Size(485, 272)
        Me.dgvTipoMovInv.TabIndex = 5
        '
        'IdtmovinvDataGridViewTextBoxColumn
        '
        Me.IdtmovinvDataGridViewTextBoxColumn.DataPropertyName = "id_tmov_inv"
        Me.IdtmovinvDataGridViewTextBoxColumn.HeaderText = "id_tmov_inv"
        Me.IdtmovinvDataGridViewTextBoxColumn.Name = "IdtmovinvDataGridViewTextBoxColumn"
        Me.IdtmovinvDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TmovDataGridViewTextBoxColumn
        '
        Me.TmovDataGridViewTextBoxColumn.DataPropertyName = "t_mov"
        Me.TmovDataGridViewTextBoxColumn.HeaderText = "t_mov"
        Me.TmovDataGridViewTextBoxColumn.Name = "TmovDataGridViewTextBoxColumn"
        Me.TmovDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TmovinvBindingSource
        '
        Me.TmovinvBindingSource.DataMember = "t_mov_inv"
        Me.TmovinvBindingSource.DataSource = Me.KelaniDataSet
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(87, 39)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(343, 30)
        Me.txtBuscar.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Buscar:"
        '
        'T_mov_invTableAdapter
        '
        Me.T_mov_invTableAdapter.ClearBeforeFill = True
        '
        'frmTipoMovimientoInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 578)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmTipoMovimientoInventario"
        Me.Text = "TipoMovimientoInventario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTipoMovInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmovinvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btmEliminar As Button
    Friend WithEvents btmEditar As Button
    Friend WithEvents btmIngresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombTM As TextBox
    Friend WithEvents txtIdTipoMov As TextBox
    Friend WithEvents dgvTipoMovInv As DataGridView
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents TmovinvBindingSource As BindingSource
    Friend WithEvents T_mov_invTableAdapter As KelaniDataSetTableAdapters.t_mov_invTableAdapter
    Friend WithEvents IdtmovinvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TmovDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
