Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports TodoApp.Model

Namespace TodoApp.Data
    Friend NotInheritable Class InMemoryRepository
        Implements IRepository

        Friend NotInheritable Class InMemoryTodoItem
            Inherits TodoItem
            Public Sub New(ByVal id As Integer)
                MyBase.New(id)
            End Sub
        End Class
        Private IdGeneratorSeed As Integer
        ReadOnly dataStorage As Dictionary(Of Integer, TodoItem) = New Dictionary(Of Integer, TodoItem)()
        Public Sub New()
            dataStorage.Add(AppModel.NewItemID, New InMemoryTodoItem(AppModel.NewItemID))
            dataStorage.Add(1, New InMemoryTodoItem(1) With {
                .Title = "Create the MainView",
                .Description = "Create a Form with application icon and NavigationFrame control.",
                .IsCompleted = True
            })
            dataStorage.Add(2, New InMemoryTodoItem(2) With {
                .Title = "Create the AppViewModel",
                .Description = "Create a class with the Title property.",
                .IsCompleted = True
            })
            dataStorage.Add(3, New InMemoryTodoItem(3) With {
                .Title = "Bind the AppViewModel to the MainView.",
                .Description = "Bind the Title property to the Text. Register the NavigationFrame as a service.",
                .IsCompleted = True
            })
            dataStorage.Add(4, New InMemoryTodoItem(4) With {
                .Title = "Create the ItemsView",
                .Description = "Create an UserControl with ListBoxControl and SearchBox."
            })
            dataStorage.Add(5, New InMemoryTodoItem(5) With {
                .Title = "Create the ItemsViewModel",
                .Description = "Create a class with the Items property."
            })
            dataStorage.Add(6, New InMemoryTodoItem(6) With {
                .Title = "Bind the ItemsViewModel to the ItemsView.",
                .Description = "Bind the Title property to the label. Bind the Items property to the bindingSource."
            })
            Me.IdGeneratorSeed = Me.dataStorage.Count
        End Sub
        Function GenerateNewId() As Integer
            Return Math.Min(Threading.Interlocked.Increment(Me.IdGeneratorSeed), Me.IdGeneratorSeed - 1)
        End Function
        Function Count(Optional ByVal filter As Func(Of TodoApp.Model.TodoItem, Boolean) = Nothing) As Integer Implements IRepository.Count
            Dim result As Integer = 0
            For Each item In Me.dataStorage
                If item.Key <> AppModel.NewItemID AndAlso (filter Is Nothing OrElse filter(item.Value)) Then result += 1
            Next
            Return result
        End Function
        Function LoadItems(Optional ByVal filter As Func(Of TodoItem, Boolean) = Nothing) As IList(Of TodoItem) Implements IRepository.LoadItems
            Dim items As BindingList(Of TodoItem) = New BindingList(Of TodoItem)()
            For Each item In Me.dataStorage
                If item.Key <> AppModel.NewItemID AndAlso (filter Is Nothing OrElse filter(item.Value)) Then items.Add(MakeCopy(item.Value))
            Next
            Return items
        End Function
        Function LoadItem(ByVal itemId As Integer) As TodoItem Implements IRepository.LoadItem
            Dim item As TodoItem = Nothing
            If Me.dataStorage.TryGetValue(itemId, item) Then Return MakeCopy(item)
            Return Nothing
        End Function
        Function ReloadItem(ByVal items As IList(Of TodoItem), ByVal id As Integer) As TodoItem Implements IRepository.ReloadItem
            Dim bindingList = CType(items, BindingList(Of TodoItem))
            bindingList.RaiseListChangedEvents = False
            Dim index As Integer = 0
            Dim item As TodoApp.Model.TodoItem = Nothing
            For i As Integer = 0 To items.Count - 1
                If items(CInt((i))).Id = id Then
                    item = CType(Me, IRepository).LoadItem(id)
                    index = i
                    items(index) = item
                End If
            Next
            bindingList.RaiseListChangedEvents = True
            bindingList.ResetItem(index)
            Return item
        End Function
        Function Delete(ByVal id As Integer) As Boolean Implements IRepository.Delete
            Return (id <> AppModel.NewItemID) AndAlso Me.dataStorage.Remove(id)
        End Function
        Function Save(ByVal item As TodoItem) As Integer Implements IRepository.Save
            If item.Id = AppModel.NewItemID Then
                Dim newId As Integer = Me.GenerateNewId()
                Me.dataStorage.Add(newId, InMemoryRepository.MakeCopy(item, newId))
                Return newId
            Else
                Dim itemToUpdate = Me.dataStorage(item.Id)
                itemToUpdate.Title = item.Title
                itemToUpdate.Description = item.Description
                itemToUpdate.IsCompleted = item.IsCompleted
                Return item.Id
            End If
        End Function
        Function HasChanges(ByVal id As Integer, ByVal item As TodoItem) As Boolean Implements IRepository.HasChanges
            If id = AppModel.NewItemID Then
                Return Not String.IsNullOrEmpty(item.Title) AndAlso Not String.IsNullOrEmpty(item.Description)
            Else
                Dim itemToCheck = Me.dataStorage(id)
                Return (Not Equals(itemToCheck.Title, item.Title)) OrElse (Not Equals(itemToCheck.Description, item.Description)) OrElse (itemToCheck.IsCompleted <> item.IsCompleted)
            End If
        End Function
        Shared Function MakeCopy(ByVal item As TodoItem, ByVal Optional id As Integer? = Nothing) As TodoItem
            Dim actualId As Integer = id.GetValueOrDefault(item.Id)
            Return New InMemoryTodoItem(actualId) With {
                .Title = item.Title,
                .Description = item.Description,
                .IsCompleted = item.IsCompleted
            }
        End Function
    End Class
End Namespace
