namespace TodoApp.ViewModels {
    using System.Threading.Tasks;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using TodoApp.Data;

    public class AppViewModel {
        static AppViewModel() {
            // Registering global service for data-storage
            ServiceContainer.Default.RegisterService(new InMemoryRepository());
        }
        // This is ViewModel for our Application
        public AppViewModel() {
            Title = "Getting started witn MVVM - Todo App (C#)";
        }
        // This is our Application's Title
        public string Title {
            get;
            private set;
        }
        protected INavigationService NavigationService {
            get { return this.GetService<INavigationService>(); }
        }
        public async Task OnShown() {
            // Show Logo screen
            NavigationService.Navigate(nameof(Views.AppLogo), null, this, false);
            // Wait some time before showing ItemsView
            await Task.Delay(2000);
            // Show Items screen
            NavigationService.Navigate(nameof(Views.ItemsView), null, this, true);
        }
    }
}