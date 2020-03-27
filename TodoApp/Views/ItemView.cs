namespace TodoApp.Views {
    using DevExpress.XtraEditors;
    using TodoApp.ViewModels;

    public partial class ItemView : XtraUserControl {
        public ItemView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            var fluent = mvvmContext.OfType<ItemViewModel>();
            fluent.BindCommand(btnBack, x => x.Close);
            fluent.BindCommand(btnSave, x => x.Save);
            fluent.BindCommand(btnDelete, x => x.Delete);
            fluent.SetBinding(titleLabel, lbl => lbl.Text, x => x.Title);
            fluent.SetObjectDataSourceBinding(todoItemBindingSource, x => x.Item, x => x.Update);
        }
    }
}