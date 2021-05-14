<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategoriaP
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvCategoria = New System.Windows.Forms.DataGridView()
        Me.id_CategoriaP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdCat = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombreCatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.CategoriaTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.CategoriaTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DgvCategoria)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda y Seleccion"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(109, 30)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(353, 24)
        Me.txtBuscar.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar:"
        '
        'DgvCategoria
        '
        Me.DgvCategoria.AllowUserToAddRows = False
        Me.DgvCategoria.AllowUserToDeleteRows = False
        Me.DgvCategoria.AutoGenerateColumns = False
        Me.DgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_CategoriaP, Me.NombreCatDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.DgvCategoria.DataSource = Me.CategoriaBindingSource
        Me.DgvCategoria.Location = New System.Drawing.Point(6, 60)
        Me.DgvCategoria.Name = "DgvCategoria"
        Me.DgvCategoria.ReadOnly = True
        Me.DgvCategoria.Size = New System.Drawing.Size(456, 209)
        Me.DgvCategoria.TabIndex = 0
        '
        'id_CategoriaP
        '
        Me.id_CategoriaP.DataPropertyName = "id_CategoriaP"
        Me.id_CategoriaP.HeaderText = "id_CategoriaP"
        Me.id_CategoriaP.Name = "id_CategoriaP"
        Me.id_CategoriaP.ReadOnly = True
        Me.id_CategoriaP.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdCat)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnIngresar)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtCategoria)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 208)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'txtIdCat
        '
        Me.txtIdCat.Location = New System.Drawing.Point(401, 63)
        Me.txtIdCat.Name = "txtIdCat"
        Me.txtIdCat.Size = New System.Drawing.Size(61, 26)
        Me.txtIdCat.TabIndex = 18
        Me.txtIdCat.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(360, 158)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(88, 29)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(196, 158)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(92, 29)
        Me.btnEditar.TabIndex = 16
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(23, 158)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(97, 29)
        Me.btnIngresar.TabIndex = 15
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(123, 91)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(223, 24)
        Me.txtDescripcion.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Descripción:"
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(123, 36)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(223, 24)
        Me.txtCategoria.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre:"
        '
        'NombreCatDataGridViewTextBoxColumn
        '
        Me.NombreCatDataGridViewTextBoxColumn.DataPropertyName = "nombreCat"
        Me.NombreCatDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.NombreCatDataGridViewTextBoxColumn.Name = "NombreCatDataGridViewTextBoxColumn"
        Me.NombreCatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.KelaniDataSet
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'frmCategoriaP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(491, 513)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCategoriaP"
        Me.Text = "Categorias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvCategoria As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As KelaniDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents id_CategoriaP As DataGridViewTextBoxColumn
    Friend WithEvents NombreCatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtIdCat As TextBox
End Class
