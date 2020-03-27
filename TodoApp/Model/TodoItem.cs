namespace TodoApp.Model {
    using System.ComponentModel.DataAnnotations;

    public class TodoItem {
        protected TodoItem(int id) {
            this.Id = id;
        }
        [Display(AutoGenerateField = false)]
        public int Id {
            get;
        }
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