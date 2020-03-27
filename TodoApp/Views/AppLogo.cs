namespace TodoApp.Views {
    using DevExpress.XtraEditors;
    using TodoApp.ViewModels;

    public partial class AppLogo : XtraUserControl {
        public AppLogo() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            var fluent = mvvmContext.OfType<AppLogoViewModel>();
            fluent.SetBinding(greetLabel, lbl => lbl.Text, x => x.Greeting);
        }
    }
}