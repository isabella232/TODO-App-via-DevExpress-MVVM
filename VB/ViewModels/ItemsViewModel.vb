Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports TodoApp.Data
Imports TodoApp.Model

Namespace TodoApp.ViewModels
    Public Class ItemsViewModel
        Public Sub New()
            Title = "What needs to be done?"
            ShowAllItems = True
            ' Start listen the ReloadRequired message
            Messenger.Default.Register(Me, New System.Action(Of ReloadRequired)(AddressOf OnReloadRequired))
        End Sub
        Protected ReadOnly Property Repository As IRepository
            Get
                Return GetRequiredService(Of IRepository)()
            End Get
        End Property
        Sub OnReloadRequired(ByVal message As ReloadRequired)
            If message Is ReloadRequired.All OrElse message.IsNew Then
                ' Reload all Items when new item added or explicit reload requested
                ReloadItems(ShowAllItems)
            Else
                ' Reload the specific item within the Items collection
                Dim item = Repository.ReloadItem(Items, message.Id)
                If item Is SelectedItem Then SelectedItem = item
            End If
        End Sub
        Sub ReloadItems(ByVal showAll As Boolean)
            ' Saving selection information
            Dim savedId As Integer = If(SelectedItem IsNot Nothing, SelectedItem.Id, AppModel.NewItemID)
            If showAll Then
                ' Load all items 
                Items = Repository.LoadItems()
            Else
                ' Load incompleted items only
                Items = Repository.LoadItems(Function(x) Not x.IsCompleted)
            End If
            ' Restoring selection 
            SelectedItem = If(Items.FirstOrDefault(Function(x) x.Id = savedId), SelectedItem)
        End Sub
        ' View's title
        Public ReadOnly Property Title As String
        ' Items collection to display
        Public Overridable Property Items As IList(Of TodoItem)
        ' Current selected item
        Public Overridable Property SelectedItem As TodoItem
        ' Display option
        Public Overridable Property ShowAllItems As Boolean
        Protected Sub OnItemsChanged()
            SelectedItem = Items.FirstOrDefault()
        End Sub
        Protected Sub OnSelectedItemChanged()
            RaiseCanExecuteChanged(Sub(x) x.Edit())
        End Sub
        Protected Sub OnShowAllItemsChanged()
            ReloadItems(ShowAllItems)
        End Sub
        Protected ReadOnly Property NavigationService As INavigationService
            Get
                Return GetService(Of INavigationService)()
            End Get
        End Property
        Public Sub [New]()
            NavigationService.Navigate(NameOf(Views.ItemView), AppModel.NewItemID, Me)
        End Sub
        Public Function CanEdit() As Boolean
            Return SelectedItem IsNot Nothing
        End Function
        Public Sub Edit()
            NavigationService.Navigate(NameOf(Views.ItemView), SelectedItem.Id, Me)
        End Sub
        Public Sub Complete(ByVal item As TodoItem)
            item.IsCompleted = True
            If Repository.HasChanges(item.Id, item) Then
                Dim itemId As Integer = Repository.Save(item)
                ' Sending the ReloadRequired message for the specific item
                Messenger.Default.Send(ReloadRequired.FromId(itemId))
            End If
        End Sub
    End Class
End Namespace
