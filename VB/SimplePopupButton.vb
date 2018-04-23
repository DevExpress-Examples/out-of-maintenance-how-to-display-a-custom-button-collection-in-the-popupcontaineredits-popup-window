Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
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
		Private privateDefaultBehavior As PopupButtonStyle
		Public Property DefaultBehavior() As PopupButtonStyle
			Get
				Return privateDefaultBehavior
			End Get
			Set(ByVal value As PopupButtonStyle)
				privateDefaultBehavior = value
			End Set
		End Property
		Public Overrides Function ToString() As String
			Return Me.DefaultBehavior.ToString()
		End Function
	End Class

	Friend Class CustomButtonEventsArgs
		Inherits EventArgs
		Protected protCustomButton As SimplePopupButton
		Public ReadOnly Property CustomButton() As SimplePopupButton
			Get
				Return protCustomButton
			End Get
		End Property
		Public Sub New(ByVal paramButton As SimplePopupButton)
			Me.protCustomButton = paramButton
		End Sub
	End Class

	Friend Class CustomButtonCollectionEventArgs
		Inherits CustomButtonEventsArgs
		Protected protCurrentAction As CollectionChangeAction
		Public ReadOnly Property CurrentAction() As CollectionChangeAction
			Get
				Return protCurrentAction
			End Get
		End Property
		Public Sub New(ByVal paramButton As SimplePopupButton, ByVal paramAction As CollectionChangeAction)
			MyBase.New(paramButton)
			Me.protCurrentAction = paramAction
		End Sub
	End Class


	<ListBindable(False), TypeConverter(GetType(DevExpress.Utils.Design.UniversalCollectionTypeConverter))> _
	Friend Class CustomButtonCollection
		Inherits CollectionBase
        <Description("Gets a button at the specified position.")> _
  Default Public ReadOnly Property Item(ByVal index As Integer) As SimplePopupButton
            Get
                Return TryCast(List(index), SimplePopupButton)
            End Get
        End Property

		Public Overridable Function Add(ByVal button As SimplePopupButton) As Integer
			Dim res As Integer = IndexOf(button)
			If res = -1 Then
				res = List.Add(button)
			End If
			Return res
		End Function
		Public Overridable Function IndexOf(ByVal button As SimplePopupButton) As Integer
			Return List.IndexOf(button)
		End Function
		Public Overridable Function Contains(ByVal button As SimplePopupButton) As Boolean
			Return List.Contains(button)
		End Function
		Public Overridable Sub Insert(ByVal index As Integer, ByVal button As SimplePopupButton)
			If Contains(button) Then
				Return
			End If
			List.Insert(index, button)
		End Sub

		Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal item As Object)
			RaiseEvent OnCollectionChanged(Me, New CustomButtonCollectionEventArgs((TryCast(item, SimplePopupButton)), CollectionChangeAction.Add))
		End Sub
		Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal item As Object)
			RaiseEvent OnCollectionChanged(Me, New CustomButtonCollectionEventArgs((TryCast(item, SimplePopupButton)), CollectionChangeAction.Remove))
		End Sub

		Public Delegate Sub SimpleButtonCollectionEvenrHandler(ByVal sender As Object, ByVal e As CustomButtonCollectionEventArgs)
		Public Event OnCollectionChanged As SimpleButtonCollectionEvenrHandler
	End Class
End Namespace
