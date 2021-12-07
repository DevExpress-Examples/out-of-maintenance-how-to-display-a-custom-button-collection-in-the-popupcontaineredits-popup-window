Namespace PopupContainerWithOKButton

    Partial Class MainForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.checkEditShowCustomButton = New DevExpress.XtraEditors.CheckEdit()
            Me.label1 = New System.Windows.Forms.Label()
            Me.popupContainerEditCustomButtonForTest = New PopupContainerCustomButtonControl.PopupContainerEditCustomButton()
            Me.simplePopupButtonOK = New PopupContainerCustomButtonControl.SimplePopupButton()
            Me.simplePopupButtonClose = New PopupContainerCustomButtonControl.SimplePopupButton()
            Me.simplePopupButtonMessage = New PopupContainerCustomButtonControl.SimplePopupButton()
            Me.popupContainerControlForTest = New DevExpress.XtraEditors.PopupContainerControl()
            Me.buttonEditSample = New DevExpress.XtraEditors.ButtonEdit()
            Me.simplePopupButton2 = New PopupContainerCustomButtonControl.SimplePopupButton()
            Me.SimpleButtonOk = New PopupContainerCustomButtonControl.SimplePopupButton()
            Me.SimpleButtonClose = New PopupContainerCustomButtonControl.SimplePopupButton()
            Me.SimpleButtonMessage = New PopupContainerCustomButtonControl.SimplePopupButton()
            CType((Me.checkEditShowCustomButton.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupContainerEditCustomButtonForTest.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupContainerControlForTest), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControlForTest.SuspendLayout()
            CType((Me.buttonEditSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' checkEditShowCustomButton
            ' 
            Me.checkEditShowCustomButton.Location = New System.Drawing.Point(15, 135)
            Me.checkEditShowCustomButton.Name = "checkEditShowCustomButton"
            Me.checkEditShowCustomButton.Properties.Caption = "Show custom button in popup window"
            AddHandler Me.checkEditShowCustomButton.Properties.EditValueChanged, New System.EventHandler(AddressOf Me.checkEditShowCustomButton_Properties_EditValueChanged)
            Me.checkEditShowCustomButton.Size = New System.Drawing.Size(251, 19)
            Me.checkEditShowCustomButton.TabIndex = 2
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(10, 165)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(40, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Status:"
            ' 
            ' popupContainerEditCustomButtonForTest
            ' 
            Me.popupContainerEditCustomButtonForTest.Location = New System.Drawing.Point(11, 10)
            Me.popupContainerEditCustomButtonForTest.Name = "popupContainerEditCustomButtonForTest"
            Me.popupContainerEditCustomButtonForTest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.popupContainerEditCustomButtonForTest.Properties.ButtonsForPopupWindow.Add(Me.simplePopupButtonOK)
            Me.popupContainerEditCustomButtonForTest.Properties.ButtonsForPopupWindow.Add(Me.simplePopupButtonClose)
            Me.popupContainerEditCustomButtonForTest.Properties.ButtonsForPopupWindow.Add(Me.simplePopupButtonMessage)
            Me.popupContainerEditCustomButtonForTest.Properties.PopupControl = Me.popupContainerControlForTest
            Me.popupContainerEditCustomButtonForTest.Properties.ShowCustomButton = True
            AddHandler Me.popupContainerEditCustomButtonForTest.Properties.CustomButtonClick, New PopupContainerCustomButtonControl.RepositoryItemPopupContainerEditCustomButton.CustomButtonEventHandler(AddressOf Me.popupContainerEditCustomButtonForTest_Properties_CustomButtonClick)
            AddHandler Me.popupContainerEditCustomButtonForTest.Properties.QueryResultValue, New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(AddressOf Me.popupContainerEditCustomButtonForTest_Properties_QueryResultValue)
            Me.popupContainerEditCustomButtonForTest.Size = New System.Drawing.Size(252, 20)
            Me.popupContainerEditCustomButtonForTest.TabIndex = 3
            ' 
            ' simplePopupButtonOK
            ' 
            Me.simplePopupButtonOK.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Ok
            Me.simplePopupButtonOK.Location = New System.Drawing.Point(0, 0)
            Me.simplePopupButtonOK.Name = "simplePopupButtonOK"
            Me.simplePopupButtonOK.Size = New System.Drawing.Size(75, 23)
            Me.simplePopupButtonOK.TabIndex = 0
            Me.simplePopupButtonOK.Text = "Ok"
            ' 
            ' simplePopupButtonClose
            ' 
            Me.simplePopupButtonClose.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Close
            Me.simplePopupButtonClose.Location = New System.Drawing.Point(0, 0)
            Me.simplePopupButtonClose.Name = "simplePopupButtonClose"
            Me.simplePopupButtonClose.Size = New System.Drawing.Size(75, 23)
            Me.simplePopupButtonClose.TabIndex = 0
            Me.simplePopupButtonClose.Text = "Close"
            ' 
            ' simplePopupButtonMessage
            ' 
            Me.simplePopupButtonMessage.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Custom
            Me.simplePopupButtonMessage.Location = New System.Drawing.Point(0, 0)
            Me.simplePopupButtonMessage.Name = "simplePopupButtonMessage"
            Me.simplePopupButtonMessage.Size = New System.Drawing.Size(75, 23)
            Me.simplePopupButtonMessage.TabIndex = 0
            Me.simplePopupButtonMessage.Tag = "Custom buttom Tag text"
            Me.simplePopupButtonMessage.Text = "Message"
            ' 
            ' popupContainerControlForTest
            ' 
            Me.popupContainerControlForTest.Controls.Add(Me.buttonEditSample)
            Me.popupContainerControlForTest.Location = New System.Drawing.Point(13, 37)
            Me.popupContainerControlForTest.Name = "popupContainerControlForTest"
            Me.popupContainerControlForTest.Size = New System.Drawing.Size(254, 94)
            Me.popupContainerControlForTest.TabIndex = 0
            ' 
            ' buttonEditSample
            ' 
            Me.buttonEditSample.Location = New System.Drawing.Point(6, 10)
            Me.buttonEditSample.Name = "buttonEditSample"
            Me.buttonEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.buttonEditSample.Size = New System.Drawing.Size(245, 20)
            Me.buttonEditSample.TabIndex = 0
            ' 
            ' simplePopupButton2
            ' 
            Me.simplePopupButton2.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Ok
            Me.simplePopupButton2.Location = New System.Drawing.Point(0, 0)
            Me.simplePopupButton2.Name = "simplePopupButton2"
            Me.simplePopupButton2.Size = New System.Drawing.Size(75, 23)
            Me.simplePopupButton2.TabIndex = 0
            Me.simplePopupButton2.Text = "simplePopupButton2"
            ' 
            ' SimpleButtonOk
            ' 
            Me.SimpleButtonOk.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Ok
            Me.SimpleButtonOk.Location = New System.Drawing.Point(0, 0)
            Me.SimpleButtonOk.Name = "SimpleButtonOk"
            Me.SimpleButtonOk.Size = New System.Drawing.Size(75, 23)
            Me.SimpleButtonOk.TabIndex = 0
            Me.SimpleButtonOk.Text = "Ok"
            ' 
            ' SimpleButtonClose
            ' 
            Me.SimpleButtonClose.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Close
            Me.SimpleButtonClose.Location = New System.Drawing.Point(0, 0)
            Me.SimpleButtonClose.Name = "SimpleButtonClose"
            Me.SimpleButtonClose.Size = New System.Drawing.Size(75, 23)
            Me.SimpleButtonClose.TabIndex = 0
            Me.SimpleButtonClose.Text = "Close"
            ' 
            ' SimpleButtonMessage
            ' 
            Me.SimpleButtonMessage.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Ok
            Me.SimpleButtonMessage.Location = New System.Drawing.Point(0, 0)
            Me.SimpleButtonMessage.Name = "SimpleButtonMessage"
            Me.SimpleButtonMessage.Size = New System.Drawing.Size(75, 23)
            Me.SimpleButtonMessage.TabIndex = 0
            Me.SimpleButtonMessage.Tag = "It's work also in grid"
            Me.SimpleButtonMessage.Text = "Message"
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(288, 186)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.popupContainerEditCustomButtonForTest)
            Me.Controls.Add(Me.checkEditShowCustomButton)
            Me.Controls.Add(Me.popupContainerControlForTest)
            Me.Name = "MainForm"
            Me.Text = "Example main form"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.MainForm_Load)
            CType((Me.checkEditShowCustomButton.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupContainerEditCustomButtonForTest.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupContainerControlForTest), System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControlForTest.ResumeLayout(False)
            CType((Me.buttonEditSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

'#End Region
        Private checkEditShowCustomButton As DevExpress.XtraEditors.CheckEdit

        Private popupContainerControlForTest As DevExpress.XtraEditors.PopupContainerControl

        Private buttonEditSample As DevExpress.XtraEditors.ButtonEdit

        Private simplePopupButton2 As PopupContainerCustomButtonControl.SimplePopupButton

        Private popupContainerEditCustomButtonForTest As PopupContainerCustomButtonControl.PopupContainerEditCustomButton

        Private simplePopupButtonOK As PopupContainerCustomButtonControl.SimplePopupButton

        Private simplePopupButtonClose As PopupContainerCustomButtonControl.SimplePopupButton

        Private simplePopupButtonMessage As PopupContainerCustomButtonControl.SimplePopupButton

        Private label1 As System.Windows.Forms.Label

        Private SimpleButtonOk As PopupContainerCustomButtonControl.SimplePopupButton

        Private SimpleButtonClose As PopupContainerCustomButtonControl.SimplePopupButton

        Private SimpleButtonMessage As PopupContainerCustomButtonControl.SimplePopupButton
    End Class
End Namespace
