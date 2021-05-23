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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.FacturaEncBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelaniDataSet = New Sistema_Kelani.KelaniDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FacturaEncTableAdapter = New Sistema_Kelani.KelaniDataSetTableAdapters.FacturaEncTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaEncBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1106, 500)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezados"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFacturaDataGridViewTextBoxColumn, Me.NumFacturaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.NombreClDataGridViewTextBoxColumn, Me.IdentificacionDataGridViewTextBoxColumn, Me.DireccionClDataGridViewTextBoxColumn, Me.NumRUCDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.IdClienteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FacturaEncBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(28, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1072, 414)
        Me.DataGridView1.TabIndex = 2
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
        'frmVistaDeEncabezados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1130, 524)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmVistaDeEncabezados"
        Me.Text = "Encabezados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaEncBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelaniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents KelaniDataSet As KelaniDataSet
    Friend WithEvents FacturaEncBindingSource As BindingSource
    Friend WithEvents FacturaEncTableAdapter As KelaniDataSetTableAdapters.FacturaEncTableAdapter
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
