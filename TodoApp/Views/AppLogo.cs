namespace TodoApp.Views {
    using DevExpress.XtraEditors;
    using TodoApp.ViewModels;

    public partial class AppLogo : XtraUserControl {
        public AppLogo() {
            InitializeComponent();
            // Initializing bindings only at runtime   
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<AppLogoViewModel>();
            // Bind the Greeting property to the label Text
            fluent.SetBinding(greetLabel, lbl => lbl.Text, x => x.Greeting);
        }
    }
}