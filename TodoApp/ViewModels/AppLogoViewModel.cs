namespace TodoApp.ViewModels {
    using System;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using TodoApp.Data;

    // This is ViewModel for our Start Screen
    public class AppLogoViewModel {
        protected IRepository Repository {
            get { return this.GetRequiredService<IRepository>(); }
        }
        public string Greeting {
            get {
                // Read this count from DB
                int uncompletedCount = Repository.Count(x => !x.IsCompleted);
                return
                    Size("Hello " + Environment.UserName + "!", 4) + DoubleLineBreak +
                    Size("You have " + uncompletedCount.ToString() + " incompleted tasks for now.", 2) + DoubleLineBreak +
                    Size("Have a good day!", 4);
            }
        }
        // Helper method and constant for creating the html-string
        const string DoubleLineBreak = "<br><br>";
        string Size(string text, int delta) {
            return "<size=+" + delta.ToString() + ">" + text + "</size>";
        }
    }
}