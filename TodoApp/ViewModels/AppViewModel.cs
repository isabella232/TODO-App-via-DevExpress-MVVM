namespace TodoApp.ViewModels {
    using System.Threading.Tasks;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using TodoApp.Data;

    public class AppViewModel {
        static AppViewModel() {
            // registering global service
            ServiceContainer.Default.RegisterService(new InMemoryRepository());
        }
        public AppViewModel() {
            Title = "Getting started witn MVVM - Todo App";
        }
        public string Title {
            get;
            private set;
        }
        protected INavigationService NavigationService {
            get { return this.GetService<INavigationService>(); }
        }
        public async Task OnLoad() {
            // Show Logo screen
            NavigationService.Navigate(nameof(Views.AppLogo), null, this, false);
            await Task.Delay(2000);
            // Show Items screen
            NavigationService.Navigate(nameof(Views.ItemsView), null, this, true);
        }
    }
}