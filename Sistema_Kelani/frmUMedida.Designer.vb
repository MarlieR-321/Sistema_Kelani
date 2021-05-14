<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUMedida
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvUMedidas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbreviaturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdMedida = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtAbreviatura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMedida = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnidadMedidaTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.unidadMedidaTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvUMedidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadMedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DgvUMedidas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 277)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda y Seleccion"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(93, 30)
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
        'DgvUMedidas
        '
        Me.DgvUMedidas.AllowUserToAddRows = False
        Me.DgvUMedidas.AllowUserToDeleteRows = False
        Me.DgvUMedidas.AutoGenerateColumns = False
        Me.DgvUMedidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUMedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUMedidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.NombreMedidaDataGridViewTextBoxColumn, Me.AbreviaturaDataGridViewTextBoxColumn})
        Me.DgvUMedidas.DataSource = Me.UnidadMedidaBindingSource
        Me.DgvUMedidas.Location = New System.Drawing.Point(6, 60)
        Me.DgvUMedidas.Name = "DgvUMedidas"
        Me.DgvUMedidas.ReadOnly = True
        Me.DgvUMedidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvUMedidas.Size = New System.Drawing.Size(456, 209)
        Me.DgvUMedidas.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_U_Medida"
        Me.Column1.HeaderText = "id_U_Medida"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'NombreMedidaDataGridViewTextBoxColumn
        '
        Me.NombreMedidaDataGridViewTextBoxColumn.DataPropertyName = "nombreMedida"
        Me.NombreMedidaDataGridViewTextBoxColumn.HeaderText = "Medida"
        Me.NombreMedidaDataGridViewTextBoxColumn.Name = "NombreMedidaDataGridViewTextBoxColumn"
        Me.NombreMedidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AbreviaturaDataGridViewTextBoxColumn
        '
        Me.AbreviaturaDataGridViewTextBoxColumn.DataPropertyName = "abreviatura"
        Me.AbreviaturaDataGridViewTextBoxColumn.HeaderText = "Abreviatura"
        Me.AbreviaturaDataGridViewTextBoxColumn.Name = "AbreviaturaDataGridViewTextBoxColumn"
        Me.AbreviaturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadMedidaBindingSource
        '
        Me.UnidadMedidaBindingSource.DataMember = "unidadMedida"
        Me.UnidadMedidaBindingSource.DataSource = Me.KelaniDataSet
        '
        'KelaniDataSet
        '
        Me.KelaniDataSet.DataSetName = "KelaniDataSet"
        Me.KelaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdMedida)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnIngresar)
        Me.GroupBox2.Controls.Add(Me.txtAbreviatura)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtMedida)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 208)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'txtIdMedida
        '
        Me.txtIdMedida.Location = New System.Drawing.Point(412, 68)
        Me.txtIdMedida.Name = "txtIdMedida"
        Me.txtIdMedida.Size = New System.Drawing.Size(49, 26)
        Me.txtIdMedida.TabIndex = 18
        Me.txtIdMedida.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(374, 158)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(88, 29)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(201, 158)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(92, 29)
        Me.btnEditar.TabIndex = 16
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(12, 158)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(97, 29)
        Me.btnIngresar.TabIndex = 15
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.Location = New System.Drawing.Point(123, 91)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(223, 24)
        Me.txtAbreviatura.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Abreviatura:"
        '
        'txtMedida
        '
        Me.txtMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedida.Location = New System.Drawing.Point(123, 36)
        Me.txtMedida.Name = "txtMedida"
        Me.txtMedida.Size = New System.Drawing.Size(223, 24)
        Me.txtMedida.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Medida:"
        '
        'UnidadMedidaTableAdapter
        '
        Me.UnidadMedidaTableAdapter.ClearBeforeFill = True
        '
        'frmUMedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 513)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUMedida"
        Me.Text = "Unidades de Medida"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvUMedidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadMedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvUMedidas As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtAbreviatura As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMedida As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents UnidadMedidaBindingSource As BindingSource
    Friend WithEvents UnidadMedidaTableAdapter As KelaniDataSetTableAdapters.unidadMedidaTableAdapter
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbreviaturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtIdMedida As TextBox
End Class
