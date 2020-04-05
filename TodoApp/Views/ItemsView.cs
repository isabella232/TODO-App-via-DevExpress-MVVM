namespace TodoApp.Views {
    using DevExpress.Utils;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.ViewInfo;
    using TodoApp.Model;
    using TodoApp.ViewModels;

    public partial class ItemsView : XtraUserControl {
        public ItemsView() {
            InitializeComponent();
            // Initializing bindings only at runtime    
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<ItemsViewModel>();
            // Bind the Title property to the label Text
            fluent.SetBinding(titleLabel, lbl => lbl.Text, x => x.Title);
            // Bind the ShowAllItems option to the toggle switch
            fluent.SetBinding(toggleShowAll, tgl => tgl.EditValue, x => x.ShowAllItems);
            // Bind data-items to listbox
            fluent.SetBinding(todoItemBindingSource, bs => bs.DataSource, x => x.Items);
            fluent.SetBinding(listBoxControl, lb => lb.SelectedValue, x => x.SelectedItem);
            // Bind the Complete command to the context button click (with args propagation)
            fluent.WithEvent<ContextItemClickEventArgs>(listBoxControl, "ContextButtonClick")
                .EventToCommand(x => x.Complete, args => args.DataItem as TodoItem);
            // Bind the Complete command to the item double click
            fluent.WithEvent(listBoxControl, "DoubleClick")
                .EventToCommand(x => x.Edit);
            // Bind the New command
            fluent.BindCommand(btnNew, x => x.New);
        }
        // Hide check-mark image from completed tasks
        void listBoxControl1_CustomizeItem(object sender, CustomizeTemplatedItemEventArgs e) {
            var item = e.DataItem as TodoItem;
            if(!item.IsCompleted) e.TemplatedItem.Elements[nameof(TodoItem.IsCompleted)].ImageOptions.SvgImage = null;
        }
        // Check-mark button visibility customization
        void ListBoxControl1_CustomizeContextItem(object sender, ListBoxControlContextButtonCustomizeEventArgs e) {
            var item = e.Item as TodoItem;
            e.ContextItem.Visibility = item.IsCompleted ? ContextItemVisibility.Hidden : ContextItemVisibility.Auto;
        }
    }
}