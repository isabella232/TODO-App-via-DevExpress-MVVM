Imports DevExpress.XtraEditors
Imports TodoApp.ViewModels

Namespace TodoApp.Views
    Public Partial Class ItemView
        Inherits XtraUserControl
        Public Sub New()
            InitializeComponent()
            ' Initializing bindings only at runtime    
            If Not mvvmContext.IsDesignMode Then InitializeBindings()
        End Sub
        Sub InitializeBindings()
            ' Initialize the Fluent API
            Dim fluent = mvvmContext.OfType(Of ItemViewModel)()
            ' Bind the Title property to the label Text
            fluent.SetBinding(titleLabel, Function(lbl) lbl.Text, Function(x) x.Title)
            ' Bind commands to buttons
            fluent.BindCommand(btnBack, Sub(x) x.Close())
            fluent.BindCommand(btnSave, Sub(x) x.Save())
            fluent.BindCommand(btnDelete, Sub(x) x.Delete())
            ' Bind datasource to editors
            fluent.SetObjectDataSourceBinding(todoItemBindingSource, Function(x) x.Item, Sub(x) x.Update())
        End Sub
    End Class
End Namespace
