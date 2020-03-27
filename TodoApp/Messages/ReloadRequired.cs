namespace TodoApp {
    using TodoApp.Model;

    public class ReloadRequired {
        public readonly static ReloadRequired All = new ReloadRequired(AppModel.NewItemID, false);
        //
        readonly int id;
        readonly bool isNew;
        ReloadRequired(int id, bool isNew) {
            this.id = id; this.isNew = isNew;
        }
        public int Id {
            get { return id; }
        }
        public bool IsNew {
            get { return isNew; }
        }
        public static ReloadRequired FromID(int id) {
            return new ReloadRequired(id, false);
        }
        public static ReloadRequired FromNew(int id) {
            return new ReloadRequired(id, true);
        }
    }
}