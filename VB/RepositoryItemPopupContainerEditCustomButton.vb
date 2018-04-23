Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Namespace PopupContainerCustomButtonControl
	Friend Class EventsArgsCustomButton
		Inherits EventArgs
		Protected protCustomButton As SimplePopupButton
		Public ReadOnly Property CustomButton() As SimplePopupButton
			Get
				Return protCustomButton
			End Get
		End Property
		Public Sub New(ByVal currentButton As SimplePopupButton)
			Me.protCustomButton = currentButton
		End Sub
	End Class

	Friend Class RepositoryItemPopupContainerEditCustomButton
		Inherits RepositoryItemPopupContainerEdit
		' static constructor which calls static registration method
		Shared Sub New()
			RegisterPopupContainerEditCustomButton()
		End Sub

		' static register method
		Public Shared Sub RegisterPopupContainerEditCustomButton()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(PopupContainerEditCustomButtonEditorName, GetType(PopupContainerEditCustomButton), GetType(RepositoryItemPopupContainerEditCustomButton), GetType(PopupContainerEditViewInfo), New ButtonEditPainter(), True))
		End Sub

		' internal editor name
		Friend Const PopupContainerEditCustomButtonEditorName As String = "PopupContainerEditCustomButton"

		' public constructor
		Public Sub New()
			MyBase.New()
			protShowCustomButton = True
			Me.protButtonsForPopup = New CustomButtonCollection()
			AddHandler protButtonsForPopup.OnCollectionChanged, AddressOf ButtonsCollections_OnCollectionChanged
		End Sub

		Private Sub ButtonsCollections_OnCollectionChanged(ByVal sender As Object, ByVal e As CustomButtonCollectionEventArgs)
			If e.CurrentAction = CollectionChangeAction.Add Then
				AddHandler e.CustomButton.Click, AddressOf CustomButton_Click
			Else
				RemoveHandler e.CustomButton.Click, AddressOf CustomButton_Click
			End If
		End Sub

		Private Sub CustomButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			RaiseEvent CustomButtonClick(Me, New EventsArgsCustomButton(TryCast(sender, SimplePopupButton)))
		End Sub

		Protected protShowCustomButton As Boolean
        <Description("Determines whether or not a custom button will be displayed on a popup form.")> _
  Public Property ShowCustomButton() As Boolean
            Get
                Return protShowCustomButton
            End Get
            Set(ByVal value As Boolean)
                If value <> protShowCustomButton Then
                    protShowCustomButton = value
                End If
            End Set
        End Property

		Private protButtonsForPopup As CustomButtonCollection
        <Localizable(True), RefreshProperties(RefreshProperties.All), Description("Returns a collection of custom buttons in the popup window."), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
  Public ReadOnly Property ButtonsForPopupWindow() As CustomButtonCollection
            Get
                Return protButtonsForPopup
            End Get
        End Property


		' ovverride property
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return PopupContainerEditCustomButtonEditorName
			End Get
		End Property

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			MyBase.Assign(item)
			Dim currentRepository As RepositoryItemPopupContainerEditCustomButton = (TryCast(item, RepositoryItemPopupContainerEditCustomButton))
			Me.ShowCustomButton = currentRepository.ShowCustomButton
			Me.protButtonsForPopup = currentRepository.protButtonsForPopup
			Events.AddHandler(CustomButtonClickEvent, currentRepository.Events(CustomButtonClickEvent))
		End Sub

		' let's define delegate and event, fires wgen custom button pressed
		Public Delegate Sub CustomButtonEventHandler(ByVal sender As Object, ByVal e As EventsArgsCustomButton)
        <Description("Fires when a custom button is pressed in the popup window."), Category(CategoryName.Events)> _
  Public Event CustomButtonClick As CustomButtonEventHandler
	End Class
End Namespace
