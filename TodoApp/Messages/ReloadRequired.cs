namespace TodoApp {
    using TodoApp.Model;

    public class ReloadRequired {
        #region static
        public readonly static ReloadRequired All = new ReloadRequired(AppModel.NewItemID, false);
        public static ReloadRequired FromId(int id) {
            return new ReloadRequired(id, false);
        }
        public static ReloadRequired FromNew(int id) {
            return new ReloadRequired(id, true);
        }
        #endregion static
        // Deny direct instances creation
        ReloadRequired(int id, bool isNew) {
            this.Id = id; 
            this.IsNew = isNew;
        }
        public int Id {
            get;
            private set;
        }
        public bool IsNew {
            get;
            private set;
        }
    }
}