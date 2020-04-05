namespace TodoApp.ViewModels {
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using TodoApp.Data;
    using TodoApp.Model;

    public class ItemViewModel : ISupportParameter {
        public ItemViewModel() {
            // Start listen the ReloadRequired message 
            Messenger.Default.Register<ReloadRequired>(this, OnReloadRequired);
        }
        void OnReloadRequired(ReloadRequired message) {
            if(message.IsNew) ReloadItem(message.Id);
        }
        object ISupportParameter.Parameter {
            get { return Item; }
            set { ReloadItem((int)value); }
        }
        protected IRepository Repository {
            get { return this.GetRequiredService<IRepository>(); }
        }
        void ReloadItem(int id) {
            Item = Repository.LoadItem(id);
        }
        // Current item
        public virtual TodoItem Item {
            get;
            protected set;
        }
        // Modification flag
        public virtual bool HasChanges {
            get;
            protected set;
        }
        // View's Title
        public string Title {
            get {
                if(Item == null)
                    return string.Empty;
                var suffix = (HasChanges ? "*" : string.Empty);
                if(IsNew)
                    return "New task" + suffix;
                else
                    return "Task #" + Item.Id.ToString() + suffix;
            }
        }
        bool IsNew {
            get { return Item.Id == AppModel.NewItemID; }
        }
        protected void OnItemChanged() {
            HasChanges = false;
            this.RaisePropertyChanged(x => x.Title);
            this.RaiseCanExecuteChanged(x => x.Save());
            this.RaiseCanExecuteChanged(x => x.Delete());
        }
        protected void OnHasChangesChanged() {
            this.RaisePropertyChanged(x => x.Title);
            this.RaiseCanExecuteChanged(x => x.Save());
        }
        public void Update() {
            HasChanges = Repository.HasChanges(Item.Id, Item);
        }
        public bool CanSave() {
            return (Item != null) && HasChanges;
        }
        public void Save() {
            bool isNew = IsNew;
            int savedId = Repository.Save(Item);
            if(isNew) {
                // Sending the ReloadRequired message for new item
                Messenger.Default.Send(ReloadRequired.FromNew(savedId));
            }
            else {
                // Sending the ReloadRequired message for the specific item
                Messenger.Default.Send(ReloadRequired.FromId(savedId));
            }

            HasChanges = false;
        }
        public bool CanDelete() {
            return (Item != null) && !IsNew;
        }
        public void Delete() {
            if(Repository.Delete(Item.Id)) {
                // Sending the ReloadRequired message for all items
                Messenger.Default.Send(ReloadRequired.All);
                Close();
            }
        }
        protected INavigationService NavigationService {
            get { return this.GetService<INavigationService>(); }
        }
        public void Close() {
            var document = NavigationService.Current as IDocument;
            NavigationService.GoBack();
            if(document != null)
                document.Close(true);
        }
    }
}