Imports DevExpress.XtraEditors
Imports TodoApp.ViewModels

Namespace TodoApp.Views
    Public Partial Class AppLogo
        Inherits XtraUserControl
        Public Sub New()
            InitializeComponent()
            ' Initializing bindings only at runtime   
            If Not mvvmContext.IsDesignMode Then InitializeBindings()
        End Sub
        Sub InitializeBindings()
            ' Initialize the Fluent API
            Dim fluent = mvvmContext.OfType(Of AppLogoViewModel)()
            ' Bind the Greeting property to the label Text
            fluent.SetBinding(greetLabel, Function(lbl) lbl.Text, Function(x) x.Greeting)
        End Sub
    End Class
End Namespace
