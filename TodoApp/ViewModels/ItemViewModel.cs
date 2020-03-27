namespace TodoApp.ViewModels {
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using TodoApp.Data;
    using TodoApp.Model;

    public class ItemViewModel : ISupportParameter {
        public ItemViewModel() {
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
        public virtual TodoItem Item {
            get;
            protected set;
        }
        public virtual bool HasChanges {
            get;
            protected set;
        }
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
            int id = Repository.Save(Item);
            Messenger.Default.Send(isNew ? ReloadRequired.FromNew(id) : ReloadRequired.FromID(id));
            HasChanges = false;
        }
        public bool CanDelete() {
            return (Item != null) && !IsNew;
        }
        public void Delete() {
            if(Repository.Delete(Item.Id)) {
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