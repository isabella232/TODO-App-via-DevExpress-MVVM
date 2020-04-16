Imports System.Threading.Tasks
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports TodoApp.Data

Namespace TodoApp.ViewModels
    Public Class AppViewModel
        Shared Sub New()
            ' Registering global service for data-storage
            ServiceContainer.Default.RegisterService(New InMemoryRepository())
        End Sub
        ' This is ViewModel for our Application
        Public Sub New()
            Title = "Getting started witn MVVM - Todo App (Visual Basic)"
        End Sub
        ' This is our Application's Title
        Public ReadOnly Property Title As String
        Protected ReadOnly Property NavigationService As INavigationService
            Get
                Return GetService(Of INavigationService)()
            End Get
        End Property
        Public Async Function OnShown() As Task
            ' Show Logo screen
            NavigationService.Navigate(NameOf(Views.AppLogo), Nothing, Me, False)
            ' Wait some time before showing ItemsView
            Await Task.Delay(2000)
            ' Show Items screen
            NavigationService.Navigate(NameOf(Views.ItemsView), Nothing, Me, True)
        End Function
    End Class
End Namespace
