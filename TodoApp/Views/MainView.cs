namespace TodoApp {
    using DevExpress.Utils.MVVM.Services;
    using DevExpress.XtraEditors;
    using TodoApp.ViewModels;

    public partial class MainView : XtraForm {
        public MainView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode) {
                InitializeNavigation();
                InitializeBindings();
            }
        }
        void InitializeNavigation() {
            var navigationService = NavigationService.Create(navigationFrame);
            mvvmContext.RegisterService(navigationService);
        }
        void InitializeBindings() {
            var fluent = mvvmContext.OfType<AppViewModel>();
            fluent.WithEvent(this, nameof(Load))
                .EventToCommand(x => x.OnLoad);
            fluent.SetBinding(this, f => f.Text, x => x.Title);
        }
    }
}