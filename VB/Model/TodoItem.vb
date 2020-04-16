Imports System.ComponentModel.DataAnnotations

Namespace TodoApp.Model
    Public Class TodoItem
        Private _Id As Integer

        ' Deny direct item creation (available for data storage only)
        Protected Sub New(ByVal id As Integer)
            Me.Id = id
        End Sub

        ' Key field (for data storage).  Hidden from UI
        <Display(AutoGenerateField:=False)>
        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Private Set(ByVal value As Integer)
                _Id = value
            End Set
        End Property

        ' Data fields
        Public Property Title As String
        Public Property Description As String
        Public Property IsCompleted As Boolean
    End Class
End Namespace
