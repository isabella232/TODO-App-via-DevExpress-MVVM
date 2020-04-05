namespace TodoApp.Model {
    using System.ComponentModel.DataAnnotations;

    public class TodoItem {
        // Deny direct item creation (available for data storage only)
        protected TodoItem(int id) {
            this.Id = id;
        }
        // Key field (for data storage).  Hidden from UI
        [Display(AutoGenerateField = false)]
        public int Id {
            get;
            private set;
        }
        // Data fields
        public string Title {
            get; 
            set;
        }
        public string Description {
            get; 
            set;
        }
        public bool IsCompleted {
            get; 
            set;
        }
    }
}