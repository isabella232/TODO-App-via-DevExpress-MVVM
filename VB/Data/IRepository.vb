Imports System
Imports System.Collections.Generic
Imports TodoApp.Model

Namespace TodoApp.Data
    Public Interface IRepository
        Function Count(ByVal Optional filter As Func(Of TodoItem, Boolean) = Nothing) As Integer
        Function LoadItems(ByVal Optional filter As Func(Of TodoItem, Boolean) = Nothing) As IList(Of TodoItem)
        Function LoadItem(ByVal id As Integer) As TodoItem
        Function ReloadItem(ByVal items As IList(Of TodoItem), ByVal id As Integer) As TodoItem
        Function HasChanges(ByVal id As Integer, ByVal item As TodoItem) As Boolean
        Function Save(ByVal item As TodoItem) As Integer
        Function Delete(ByVal id As Integer) As Boolean
    End Interface
End Namespace
