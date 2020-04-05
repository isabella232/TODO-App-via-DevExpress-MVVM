namespace TodoApp.ViewModels {
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using TodoApp.Data;
    using TodoApp.Model;

    public class ItemsViewModel {
        public ItemsViewModel() {
            Title = "What needs to be done?";
            ShowAllItems = true;
            // Start listen the ReloadRequired message
            Messenger.Default.Register<ReloadRequired>(this, OnReloadRequired);
        }
        protected IRepository Repository {
            get { return this.GetRequiredService<IRepository>(); }
        }
        void OnReloadRequired(ReloadRequired message) {
            if(message == ReloadRequired.All || message.IsNew) {
                // Reload all Items when new item added or explicit reload requested
                ReloadItems(ShowAllItems);
            }
            else {
                // Reload the specific item within the Items collection
                var item = Repository.ReloadItem(Items, message.Id);
                if(item == SelectedItem)
                    SelectedItem = item;
            }
        }
        void ReloadItems(bool showAll) {
            // Saving selection information
            int savedId = (SelectedItem != null) ? SelectedItem.Id : AppModel.NewItemID;
            if(showAll) {
                // Load all items 
                Items = Repository.LoadItems();
            }
            else {
                // Load incompleted items only
                Items = Repository.LoadItems(x => !x.IsCompleted);
            }
            // Restoring selection 
            SelectedItem = Items.FirstOrDefault(x => x.Id == savedId) ?? SelectedItem;
        }
        // View's title
        public string Title {
            get;
            private set;
        }
        // Items collection to display
        public virtual IList<TodoItem> Items {
            get;
            protected set;
        }
        // Current selected item
        public virtual TodoItem SelectedItem {
            get;
            set;
        }
        // Display option
        public virtual bool ShowAllItems {
            get;
            set;
        }
        protected void OnItemsChanged() {
            SelectedItem = Items.FirstOrDefault();
        }
        protected void OnSelectedItemChanged() {
            this.RaiseCanExecuteChanged(x => x.Edit());
        }
        protected void OnShowAllItemsChanged() {
            ReloadItems(ShowAllItems);
        }
        protected INavigationService NavigationService {
            get { return this.GetService<INavigationService>(); }
        }
        public void New() {
            NavigationService.Navigate(nameof(Views.ItemView), AppModel.NewItemID, this);
        }
        public bool CanEdit() {
            return SelectedItem != null;
        }
        public void Edit() {
            NavigationService.Navigate(nameof(Views.ItemView), SelectedItem.Id, this);
        }
        public void Complete(TodoItem item) {
            item.IsCompleted = true;
            if(Repository.HasChanges(item.Id, item)) {
                int itemId = Repository.Save(item);
                // Sending the ReloadRequired message for the specific item
                Messenger.Default.Send(ReloadRequired.FromId(itemId));
            }
        }
    }
}