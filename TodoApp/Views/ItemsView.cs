namespace TodoApp.Views {
    using DevExpress.Utils;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.ViewInfo;
    using TodoApp.Model;
    using TodoApp.ViewModels;

    public partial class ItemsView : XtraUserControl {
        public ItemsView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            var fluent = mvvmContext.OfType<ItemsViewModel>();
            fluent.BindCommand(btnNew, x => x.New);
            fluent.WithEvent(listBoxControl, nameof(listBoxControl.DoubleClick))
                .EventToCommand(x => x.Edit);
            fluent.SetBinding(titleLabel, lbl => lbl.Text, x => x.Title);
            fluent.SetBinding(toggleShowAll, tgl => tgl.EditValue, x => x.ShowAllItems);
            fluent.SetBinding(todoItemBindingSource, bs => bs.DataSource, x => x.Items);
            fluent.SetBinding(listBoxControl, lb => lb.SelectedValue, x => x.SelectedItem);
        }
        void listBoxControl1_CustomizeItem(object sender, CustomizeTemplatedItemEventArgs e) {
            var item = e.DataItem as TodoItem;
            if(!item.IsCompleted)
                e.TemplatedItem.Elements[nameof(TodoItem.IsCompleted)].ImageOptions.SvgImage = null;
        }
        void ListBoxControl1_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            listBoxControl.BeginUpdate();
            var item = e.DataItem as TodoItem;
            item.IsCompleted = !item.IsCompleted;
            listBoxControl.EndUpdate();
        }
        void ListBoxControl1_CustomizeContextItem(object sender, ListBoxControlContextButtonCustomizeEventArgs e) {
            var item = e.Item as TodoItem;
            e.ContextItem.Visibility = item.IsCompleted ? ContextItemVisibility.Hidden : ContextItemVisibility.Auto;
        }
    }
}