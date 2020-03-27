namespace TodoApp.ViewModels {
    using System;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using TodoApp.Data;

    public class AppLogoViewModel {
        protected IRepository Repository {
            get { return this.GetRequiredService<IRepository>(); }
        }
        public string Greeting {
            get {
                int uncompletedCount = Repository.Count(x => !x.IsCompleted);
                return
                    Size("Hello " + Environment.UserName + "!", 4) + "<br><br>" +
                    Size("You have " + uncompletedCount.ToString() + " incompleted tasks for now.", 2) + "<br><br>" +
                    Size("Have a good day!", 4);

            }
        }
        string Size(string text, int delta) {
            return "<size=+" + delta.ToString() + ">" + text + "</size>";
        }
    }
}