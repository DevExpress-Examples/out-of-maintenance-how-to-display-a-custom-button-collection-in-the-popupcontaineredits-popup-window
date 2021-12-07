Imports DevExpress.XtraEditors.Popup
Imports System.Drawing

Namespace PopupContainerCustomButtonControl

    Friend Class PopupFormCustomButtonsViewInfo
        Inherits CustomBlobPopupFormViewInfo

        ' custom properties
        Protected fCustomButtonsRect As Rectangle

        Protected fCustomButtonsSize As Size

        Public ReadOnly Property CustomButtonsRect As Rectangle
            Get
                Return fCustomButtonsRect
            End Get
        End Property

        Public ReadOnly Property CustomButtonSize As Size
            Get
                Return fCustomButtonsSize
            End Get
        End Property

        Public Const sideIndent As Integer = 5

        ' constructor
        Public Sub New(ByVal ownerPopupForm As CustomBlobPopupForm)
            MyBase.New(ownerPopupForm)
        End Sub

        ' override methods
        Protected Overrides Sub CalcContentRect(ByVal bounds As Rectangle)
            MyBase.CalcContentRect(bounds)
            fCustomButtonsRect = SizeBarRect
            fCustomButtonsSize = ButtonSize
        End Sub
    End Class
End Namespace
