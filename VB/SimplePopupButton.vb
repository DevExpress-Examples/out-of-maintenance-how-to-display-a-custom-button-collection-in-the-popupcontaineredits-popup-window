Imports System
Imports DevExpress.XtraEditors
Imports System.Collections
Imports System.ComponentModel

Namespace PopupContainerCustomButtonControl

    Public Enum PopupButtonStyle
        Ok
        Close
        Custom
    End Enum

    Friend Class SimplePopupButton
        Inherits SimpleButton

        Public Property DefaultBehavior As PopupButtonStyle

        Public Overrides Function ToString() As String
            Return DefaultBehavior.ToString()
        End Function
    End Class

    Friend Class CustomButtonEventsArgs
        Inherits EventArgs

        Protected protCustomButton As SimplePopupButton

        Public ReadOnly Property CustomButton As SimplePopupButton
            Get
                Return protCustomButton
            End Get
        End Property

        Public Sub New(ByVal paramButton As SimplePopupButton)
            protCustomButton = paramButton
        End Sub
    End Class

    Friend Class CustomButtonCollectionEventArgs
        Inherits CustomButtonEventsArgs

        Protected protCurrentAction As CollectionChangeAction

        Public ReadOnly Property CurrentAction As CollectionChangeAction
            Get
                Return protCurrentAction
            End Get
        End Property

        Public Sub New(ByVal paramButton As SimplePopupButton, ByVal paramAction As CollectionChangeAction)
            MyBase.New(paramButton)
            protCurrentAction = paramAction
        End Sub
    End Class

    <ListBindable(False), TypeConverter(GetType(DevExpress.Utils.Design.UniversalCollectionTypeConverter))>
    Friend Class CustomButtonCollection
        Inherits CollectionBase

        <Description("Gets a button at the specified position.")>
        Default Public ReadOnly Property Item(ByVal index As Integer) As SimplePopupButton
            Get
                Return TryCast(List(index), SimplePopupButton)
            End Get
        End Property

        Public Overridable Function Add(ByVal button As SimplePopupButton) As Integer
            Dim res As Integer = IndexOf(button)
            If res = -1 Then res = List.Add(button)
            Return res
        End Function

        Public Overridable Function IndexOf(ByVal button As SimplePopupButton) As Integer
            Return List.IndexOf(button)
        End Function

        Public Overridable Function Contains(ByVal button As SimplePopupButton) As Boolean
            Return List.Contains(button)
        End Function

        Public Overridable Sub Insert(ByVal index As Integer, ByVal button As SimplePopupButton)
            If Contains(button) Then Return
            List.Insert(index, button)
        End Sub

        Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal item As Object)
            RaiseEvent OnCollectionChanged(Me, New CustomButtonCollectionEventArgs(TryCast(item, SimplePopupButton), CollectionChangeAction.Add))
        End Sub

        Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal item As Object)
            RaiseEvent OnCollectionChanged(Me, New CustomButtonCollectionEventArgs(TryCast(item, SimplePopupButton), CollectionChangeAction.Remove))
        End Sub

        Public Delegate Sub SimpleButtonCollectionEvenrHandler(ByVal sender As Object, ByVal e As CustomButtonCollectionEventArgs)

        Public Event OnCollectionChanged As SimpleButtonCollectionEvenrHandler
    End Class
End Namespace
