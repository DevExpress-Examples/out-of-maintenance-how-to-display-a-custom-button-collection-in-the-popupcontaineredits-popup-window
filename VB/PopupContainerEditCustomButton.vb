Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Popup

Namespace PopupContainerCustomButtonControl
	Friend Class PopupContainerEditCustomButton
		Inherits PopupContainerEdit
		' static constructor
		Shared Sub New()
			RepositoryItemPopupContainerEditCustomButton.RegisterPopupContainerEditCustomButton()
		End Sub

		' public constructor
		Public Sub New()
		End Sub

		' ovverride property
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemPopupContainerEditCustomButton.PopupContainerEditCustomButtonEditorName
			End Get
		End Property

		' property as corresponded repositoryitem
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemPopupContainerEditCustomButton
			Get
				Return TryCast(MyBase.Properties, RepositoryItemPopupContainerEditCustomButton)
			End Get
		End Property

		Protected Overrides Function CreatePopupForm() As PopupBaseForm
			If Properties.PopupControl Is Nothing Then
				Return Nothing
			Else
				Return New PopupContainerFormCustomButton(Me)
			End If
		End Function
	End Class
End Namespace
