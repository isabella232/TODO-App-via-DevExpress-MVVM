namespace TodoApp.Data {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using TodoApp.Model;

    sealed class InMemoryRepository : IRepository {
        sealed class InMemoryTodoItem : TodoItem {
            public InMemoryTodoItem(int id)
                : base(id) {
            }
        }
        readonly Dictionary<int, TodoItem> dataStorage = new Dictionary<int, TodoItem>() {
                { AppModel.NewItemID, new InMemoryTodoItem(AppModel.NewItemID) },
                //
                { 1, new InMemoryTodoItem(1) {
                    Title = "Create the MainView",
                    Description = "Create a Form with application icon and NavigationFrame control.",
                    IsCompleted = true
                }},
                { 2, new InMemoryTodoItem(2) {
                    Title = "Create the AppViewModel",
                    Description = "Create a class with the Title property.",
                    IsCompleted = true
                }},
                { 3, new InMemoryTodoItem(3) {
                    Title = "Bind the AppViewModel to the MainView.",
                    Description = "Bind the Title property to the Text. Register the NavigationFrame as a service.",
                    IsCompleted = true
                }},
                { 4, new InMemoryTodoItem(4) {
                    Title = "Create the ItemsView",
                    Description = "Create an UserControl with ListBoxControl and SearchBox."
                }},
                { 5, new InMemoryTodoItem(5) {
                    Title = "Create the ItemsViewModel",
                    Description = "Create a class with the Items property."
                }},
                { 6, new InMemoryTodoItem(6) {
                    Title = "Bind the ItemsViewModel to the ItemsView.",
                    Description = "Bind the Title property to the label. Bind the Items property to the bindingSource.",
                }},
        };
        int IdGeneratorSeed;
        public InMemoryRepository() {
            IdGeneratorSeed = dataStorage.Count;
        }
        int GenerateNewId() { return IdGeneratorSeed++; }
        int IRepository.Count(Func<TodoItem, bool> filter) {
            int result = 0;
            foreach(var item in dataStorage) {
                if(item.Key != AppModel.NewItemID && (filter == null || filter(item.Value)))
                    result++;
            }
            return result;
        }
        IList<TodoItem> IRepository.LoadItems(Func<TodoItem, bool> filter) {
            BindingList<TodoItem> items = new BindingList<TodoItem>();
            foreach(var item in dataStorage) {
                if(item.Key != AppModel.NewItemID && (filter == null || filter(item.Value)))
                    items.Add(MakeCopy(item.Value));
            }
            return items;
        }
        TodoItem IRepository.LoadItem(int itemId) {
            TodoItem item;
            if(dataStorage.TryGetValue(itemId, out item))
                return MakeCopy(item);
            return null;
        }
        TodoItem IRepository.ReloadItem(IList<TodoItem> items, int id) {
            var bindingList = ((BindingList<TodoItem>)items);
            bindingList.RaiseListChangedEvents = false;
            int index = 0; TodoItem item = null;
            for(int i = 0; i < items.Count; i++) {
                if(items[i].Id == id) {
                    item = ((IRepository)this).LoadItem(id);
                    items[index = i] = item;
                }
            }
            bindingList.RaiseListChangedEvents = true;
            bindingList.ResetItem(index);
            return item;
        }
        bool IRepository.Delete(int id) {
            return (id != AppModel.NewItemID) && dataStorage.Remove(id);
        }
        int IRepository.Save(TodoItem item) {
            if(item.Id == AppModel.NewItemID) {
                int newId = GenerateNewId();
                dataStorage.Add(newId, MakeCopy(item, newId));
                return newId;
            }
            else {
                var itemToUpdate = dataStorage[item.Id];
                itemToUpdate.Title = item.Title;
                itemToUpdate.Description = item.Description;
                itemToUpdate.IsCompleted = item.IsCompleted;
                return item.Id;
            }
        }
        bool IRepository.HasChanges(int id, TodoItem item) {
            if(id == AppModel.NewItemID) {
                return
                    !string.IsNullOrEmpty(item.Title) &&
                    !string.IsNullOrEmpty(item.Description);
            }
            else {
                var itemToCheck = dataStorage[id];
                return
                    (itemToCheck.Title != item.Title) ||
                    (itemToCheck.Description != item.Description) ||
                    (itemToCheck.IsCompleted != item.IsCompleted);
            }
        }
        static TodoItem MakeCopy(TodoItem item, int? id = null) {
            int actualId = id.GetValueOrDefault(item.Id);
            return new InMemoryTodoItem(actualId) {
                Title = item.Title,
                Description = item.Description,
                IsCompleted = item.IsCompleted
            };
        }
    }
}