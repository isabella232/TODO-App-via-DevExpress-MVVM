namespace TodoApp.Views {
    using DevExpress.XtraEditors;
    using TodoApp.ViewModels;

    public partial class ItemView : XtraUserControl {
        public ItemView() {
            InitializeComponent();
            // Initializing bindings only at runtime    
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ItemViewModel>();
            // Bind the Title property to the label Text
            fluent.SetBinding(titleLabel, lbl => lbl.Text, x => x.Title);
            // Bind commands to buttons
            fluent.BindCommand(btnBack, x => x.Close);
            fluent.BindCommand(btnSave, x => x.Save);
            fluent.BindCommand(btnDelete, x => x.Delete);
            // Bind datasource to editors
            fluent.SetObjectDataSourceBinding(todoItemBindingSource, x => x.Item, x => x.Update);
        }
    }
}