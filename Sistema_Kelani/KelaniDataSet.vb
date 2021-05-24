Partial Class KelaniDataSet
    Partial Public Class bodegaDataTable
        Private Sub bodegaDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.bodegaColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace KelaniDataSetTableAdapters
    Partial Public Class vwProductosTableAdapter
    End Class

    Partial Public Class ProductoTableAdapter
    End Class
End Namespace

Namespace KelaniDataSetTableAdapters
    Partial Public Class VwClientesTableAdapter
    End Class
End Namespace
