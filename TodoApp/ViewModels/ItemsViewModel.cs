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
            Messenger.Default.Register<ReloadRequired>(this, OnReloadRequired);
        }
        protected IRepository Repository {
            get { return this.GetRequiredService<IRepository>(); }
        }
        void OnReloadRequired(ReloadRequired message) {
            if(message == ReloadRequired.All || message.IsNew)
                ReloadItems(ShowAllItems);
            else {
                var item = Repository.ReloadItem(Items, message.Id);
                if(item == SelectedItem) 
                    SelectedItem = item;
            }
        }
        void ReloadItems(bool showAll) {
            int savedId = (SelectedItem != null) ? SelectedItem.Id : AppModel.NewItemID;
            if(showAll)
                Items = Repository.LoadItems();
            else
                Items = Repository.LoadItems(x => !x.IsCompleted);
            SelectedItem = Items.FirstOrDefault(x => x.Id == savedId) ?? SelectedItem;
        }
        public string Title {
            get;
            private set;
        }
        public virtual IList<TodoItem> Items {
            get;
            protected set;
        }
        public virtual TodoItem SelectedItem {
            get;
            set;
        }
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
    }
}