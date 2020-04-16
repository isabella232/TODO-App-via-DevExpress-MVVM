Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports TodoApp.Data
Imports TodoApp.Model

Namespace TodoApp.ViewModels
    Public Class ItemViewModel
        Implements ISupportParameter
        Public Sub New()
            ' Start listen the ReloadRequired message 
            Messenger.Default.Register(Me, New System.Action(Of ReloadRequired)(AddressOf OnReloadRequired))
        End Sub
        Sub OnReloadRequired(ByVal message As ReloadRequired)
            If message.IsNew Then ReloadItem(message.Id)
        End Sub
        Property Parameter As Object Implements ISupportParameter.Parameter
            Get
                Return Item
            End Get
            Set(ByVal value As Object)
                ReloadItem(CInt(value))
            End Set
        End Property
        Protected ReadOnly Property Repository As IRepository
            Get
                Return GetRequiredService(Of IRepository)()
            End Get
        End Property
        Sub ReloadItem(ByVal id As Integer)
            Item = Repository.LoadItem(id)
        End Sub
        ' Current item
        Public Overridable Property Item As TodoItem
        ' Modification flag
        Public Overridable Property HasChanges As Boolean
        ' View's Title
        Public ReadOnly Property Title As String
            Get
                If Item Is Nothing Then Return String.Empty
                Dim suffix = If(HasChanges, "*", String.Empty)
                If IsNew Then
                    Return "New task" & suffix
                Else
                    Return "Task #" & Item.Id.ToString() & suffix
                End If
            End Get
        End Property
        ReadOnly Property IsNew As Boolean
            Get
                Return Item.Id = AppModel.NewItemID
            End Get
        End Property
        Protected Sub OnItemChanged()
            HasChanges = False
            RaisePropertyChanged(Function(x) x.Title)
            RaiseCanExecuteChanged(Sub(x) x.Save())
            RaiseCanExecuteChanged(Sub(x) x.Delete())
        End Sub
        Protected Sub OnHasChangesChanged()
            RaisePropertyChanged(Function(x) x.Title)
            RaiseCanExecuteChanged(Sub(x) x.Save())
        End Sub
        Public Sub Update()
            HasChanges = Repository.HasChanges(Item.Id, Item)
        End Sub
        Public Function CanSave() As Boolean
            Return Item IsNot Nothing AndAlso HasChanges
        End Function
        Public Sub Save()
            Dim isNew As Boolean = Me.IsNew
            Dim savedId As Integer = Repository.Save(Item)
            If isNew Then
                ' Sending the ReloadRequired message for new item
                Messenger.Default.Send(ReloadRequired.FromNew(savedId))
            Else
                ' Sending the ReloadRequired message for the specific item
                Messenger.Default.Send(ReloadRequired.FromId(savedId))
            End If
            HasChanges = False
        End Sub
        Public Function CanDelete() As Boolean
            Return Item IsNot Nothing AndAlso Not IsNew
        End Function
        Public Sub Delete()
            If Repository.Delete(Item.Id) Then
                ' Sending the ReloadRequired message for all items
                Messenger.Default.Send(ReloadRequired.All)
                Close()
            End If
        End Sub
        Protected ReadOnly Property NavigationService As INavigationService
            Get
                Return GetService(Of INavigationService)()
            End Get
        End Property
        Public Sub Close()
            Dim document = TryCast(NavigationService.Current, IDocument)
            NavigationService.GoBack()
            If document IsNot Nothing Then document.Close(True)
        End Sub
    End Class
End Namespace
