<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBodega
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
        Me.VwBodegaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.txtBodega = New System.Windows.Forms.TextBox()
        Me.btmEditar = New System.Windows.Forms.Button()
        Me.btmIngresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BodegaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdBodega = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvBodega = New System.Windows.Forms.DataGridView()
        Me.IdBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.bodegaTableAdapter()
        Me.Vw_BodegaTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.vw_BodegaTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VwBodegaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxEstado)
        Me.GroupBox2.Controls.Add(Me.txtBodega)
        Me.GroupBox2.Controls.Add(Me.btmEditar)
        Me.GroupBox2.Controls.Add(Me.btmIngresar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 327)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(398, 231)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'cbxEstado
        '
        Me.cbxEstado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.VwBodegaBindingSource, "estado", True))
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.cbxEstado.Location = New System.Drawing.Point(102, 106)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(250, 33)
        Me.cbxEstado.TabIndex = 7
        Me.cbxEstado.Text = "Seleccion"
        '
        'VwBodegaBindingSource
        '
        Me.VwBodegaBindingSource.DataMember = "vw_Bodega"
        Me.VwBodegaBindingSource.DataSource = Me.KelaniDataSet
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtBodega
        '
        Me.txtBodega.Location = New System.Drawing.Point(102, 40)
        Me.txtBodega.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBodega.Name = "txtBodega"
        Me.txtBodega.Size = New System.Drawing.Size(250, 30)
        Me.txtBodega.TabIndex = 6
        '
        'btmEditar
        '
        Me.btmEditar.Location = New System.Drawing.Point(226, 186)
        Me.btmEditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btmEditar.Name = "btmEditar"
        Me.btmEditar.Size = New System.Drawing.Size(126, 32)
        Me.btmEditar.TabIndex = 4
        Me.btmEditar.Text = "Editar"
        Me.btmEditar.UseVisualStyleBackColor = True
        '
        'btmIngresar
        '
        Me.btmIngresar.Location = New System.Drawing.Point(34, 186)
        Me.btmIngresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btmIngresar.Name = "btmIngresar"
        Me.btmIngresar.Size = New System.Drawing.Size(116, 32)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Estado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre :"
        '
        'BodegaBindingSource
        '
        Me.BodegaBindingSource.DataMember = "bodega"
        Me.BodegaBindingSource.DataSource = Me.KelaniDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIdBodega)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgvBodega)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(398, 325)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda y Seleccion"
        '
        'txtIdBodega
        '
        Me.txtIdBodega.Location = New System.Drawing.Point(321, 47)
        Me.txtIdBodega.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdBodega.Name = "txtIdBodega"
        Me.txtIdBodega.Size = New System.Drawing.Size(71, 30)
        Me.txtIdBodega.TabIndex = 4
        Me.txtIdBodega.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(119, 47)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(196, 30)
        Me.txtBuscar.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Buscar:"
        '
        'dgvBodega
        '
        Me.dgvBodega.AllowUserToAddRows = False
        Me.dgvBodega.AllowUserToDeleteRows = False
        Me.dgvBodega.AutoGenerateColumns = False
        Me.dgvBodega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBodega.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBodegaDataGridViewTextBoxColumn, Me.BodegaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.dgvBodega.DataSource = Me.VwBodegaBindingSource
        Me.dgvBodega.Location = New System.Drawing.Point(0, 98)
        Me.dgvBodega.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvBodega.Name = "dgvBodega"
        Me.dgvBodega.ReadOnly = True
        Me.dgvBodega.RowTemplate.Height = 24
        Me.dgvBodega.Size = New System.Drawing.Size(398, 223)
        Me.dgvBodega.TabIndex = 0
        '
        'IdBodegaDataGridViewTextBoxColumn
        '
        Me.IdBodegaDataGridViewTextBoxColumn.DataPropertyName = "idBodega"
        Me.IdBodegaDataGridViewTextBoxColumn.HeaderText = "idBodega"
        Me.IdBodegaDataGridViewTextBoxColumn.Name = "IdBodegaDataGridViewTextBoxColumn"
        Me.IdBodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BodegaTableAdapter
        '
        Me.BodegaTableAdapter.ClearBeforeFill = True
        '
        'Vw_BodegaTableAdapter
        '
        Me.Vw_BodegaTableAdapter.ClearBeforeFill = True
        '
        'frmBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 569)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmBodega"
        Me.Text = "frmBodega"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VwBodegaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBodega As TextBox
    Friend WithEvents btmEditar As Button
    Friend WithEvents btmIngresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvBodega As DataGridView
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents BodegaBindingSource As BindingSource
    Friend WithEvents BodegaTableAdapter As KelaniDataSetTableAdapters.bodegaTableAdapter
    Friend WithEvents IdBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtIdBodega As TextBox
    Friend WithEvents cbxEstado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents VwBodegaBindingSource As BindingSource
    Friend WithEvents Vw_BodegaTableAdapter As KelaniDataSetTableAdapters.vw_BodegaTableAdapter
End Class
