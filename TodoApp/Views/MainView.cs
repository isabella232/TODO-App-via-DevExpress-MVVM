namespace TodoApp {
    using DevExpress.Utils.MVVM.Services;
    using DevExpress.XtraEditors;
    using TodoApp.ViewModels;

    public partial class MainView : XtraForm {
        public MainView() {
            InitializeComponent();
            // Initializing bindings only at runtime  
            if(!mvvmContext.IsDesignMode) {
                InitializeNavigation();
                InitializeBindings();
            }
        }
        void InitializeNavigation() {
            // creating the NavigationFrame as INavigationService
            var navigationService = NavigationService.Create(navigationFrame);
            // registering the service instance
            mvvmContext.RegisterService(navigationService);
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<AppViewModel>();
            // Bind the OnShown command to the Shown event
            fluent.WithEvent(this, "Shown")
                .EventToCommand(x => x.OnShown);
        }
        void InitializeBindings() {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<AppViewModel>();
            // Bind the Title property to the Text
            fluent.SetBinding(this, view => view.Text, x => x.Title);
        }
    }
}