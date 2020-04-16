Imports TodoApp.Model

Namespace TodoApp
    Public Class ReloadRequired
        Private _Id As Integer, _IsNew As Boolean
#Region "static"
        Public ReadOnly Shared All As ReloadRequired = New ReloadRequired(AppModel.NewItemID, False)

        Public Shared Function FromId(ByVal id As Integer) As ReloadRequired
            Return New ReloadRequired(id, False)
        End Function

        Public Shared Function FromNew(ByVal id As Integer) As ReloadRequired
            Return New ReloadRequired(id, True)
        End Function

#End Region
        ' Deny direct instances creation
        Private Sub New(ByVal id As Integer, ByVal isNew As Boolean)
            Me.Id = id
            Me.IsNew = isNew
        End Sub

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Private Set(ByVal value As Integer)
                _Id = value
            End Set
        End Property

        Public Property IsNew As Boolean
            Get
                Return _IsNew
            End Get
            Private Set(ByVal value As Boolean)
                _IsNew = value
            End Set
        End Property
    End Class
End Namespace
