Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports System.Drawing

Namespace PopupContainerCustomButtonControl
	Friend Class PopupContainerFormCustomButton
		Inherits PopupContainerForm
		' constructor
		Public Sub New(ByVal ownerEdit As PopupContainerEditCustomButton)
			MyBase.New(ownerEdit)
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			Dim currentEditor As PopupContainerEditCustomButton = TryCast(OwnerEdit, PopupContainerEditCustomButton)
			If currentEditor IsNot Nothing Then
				For Each sbCustomButton As SimplePopupButton In currentEditor.Properties.ButtonsForPopupWindow
					If Controls.Contains(sbCustomButton) Then
						Controls.Remove(sbCustomButton)
						If sbCustomButton.DefaultBehavior = PopupButtonStyle.Ok Then
							RemoveHandler sbCustomButton.Click, AddressOf customButton_OkClick
						End If
						If sbCustomButton.DefaultBehavior = PopupButtonStyle.Close Then
							RemoveHandler sbCustomButton.Click, AddressOf customButton_CancelClick
						End If
					End If
				Next sbCustomButton
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Shadows ReadOnly Property Properties() As RepositoryItemPopupContainerEditCustomButton
			Get
				Dim edit As PopupContainerEditCustomButton = TryCast(OwnerEdit, PopupContainerEditCustomButton)
				If edit Is Nothing Then
					Return Nothing
				End If
				Return edit.Properties
			End Get
		End Property

		Protected Overrides Function CreateViewInfo() As PopupBaseFormViewInfo
			Return New PopupFormCustomButtonsViewInfo(Me)
		End Function

		Protected Overrides Sub UpdateControlPositionsCore()
			MyBase.UpdateControlPositionsCore()
			Dim currentEditor As PopupContainerEditCustomButton = TryCast(OwnerEdit, PopupContainerEditCustomButton)
			Dim currentViewInfo As PopupFormCustomButtonsViewInfo = (TryCast(ViewInfo, PopupFormCustomButtonsViewInfo))
			If currentEditor IsNot Nothing Then
				Dim customButtonsBound As Rectangle = currentViewInfo.CustomButtonsRect
				Dim buttonsForPopupWindowCount As Integer = currentEditor.Properties.ButtonsForPopupWindow.Count
				If buttonsForPopupWindowCount > 0 Then
                    Dim iMaxCustomButtonWidth As Integer = Convert.ToInt32((customButtonsBound.Width - (buttonsForPopupWindowCount - 1) * PopupFormCustomButtonsViewInfo.sideIndent) / buttonsForPopupWindowCount)
					Dim iCurrentX As Integer = customButtonsBound.X
					If currentEditor.Properties.ShowCustomButton Then
						fShowOkButton = False
						fCloseButtonStyle = BlobCloseButtonStyle.None
						For Each customButton As SimplePopupButton In currentEditor.Properties.ButtonsForPopupWindow
							Dim iCurrentCustomButtonWidth As Integer = customButton.Size.Width
							If iCurrentCustomButtonWidth > iMaxCustomButtonWidth Then
								iCurrentCustomButtonWidth = iMaxCustomButtonWidth
							End If
							customButton.Bounds = New Rectangle(iCurrentX, customButtonsBound.Y, iCurrentCustomButtonWidth, customButtonsBound.Height)
							Controls.Add(customButton)
							iCurrentX += iCurrentCustomButtonWidth + PopupFormCustomButtonsViewInfo.sideIndent
							If customButton.DefaultBehavior = PopupButtonStyle.Ok Then
								AddHandler customButton.Click, AddressOf customButton_OkClick
							End If
							If customButton.DefaultBehavior = PopupButtonStyle.Close Then
								AddHandler customButton.Click, AddressOf customButton_CancelClick
							End If
						Next customButton
					End If
				End If
			End If
		End Sub

		Private Sub customButton_CancelClick(ByVal sender As Object, ByVal e As EventArgs)
			OwnerEdit.CancelPopup()
		End Sub

		Private Sub customButton_OkClick(ByVal sender As Object, ByVal e As EventArgs)
			OwnerEdit.ClosePopup()
		End Sub
	End Class
End Namespace
