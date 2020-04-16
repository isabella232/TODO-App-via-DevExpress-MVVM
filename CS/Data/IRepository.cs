namespace TodoApp.Data {
    using System;
    using System.Collections.Generic;
    using TodoApp.Model;

    public interface IRepository {
        int Count(Func<TodoItem, bool> filter = null);
        IList<TodoItem> LoadItems(Func<TodoItem, bool> filter = null);
        TodoItem LoadItem(int id);
        TodoItem ReloadItem(IList<TodoItem> items, int id);
        bool HasChanges(int id, TodoItem item);
        int Save(TodoItem item);
        bool Delete(int id);
    }
}