namespace PopupContainerWithOKButton
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkEditShowCustomButton = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.popupContainerEditCustomButtonForTest = new PopupContainerCustomButtonControl.PopupContainerEditCustomButton();
            this.simplePopupButtonOK = new PopupContainerCustomButtonControl.SimplePopupButton();
            this.simplePopupButtonClose = new PopupContainerCustomButtonControl.SimplePopupButton();
            this.simplePopupButtonMessage = new PopupContainerCustomButtonControl.SimplePopupButton();
            this.popupContainerControlForTest = new DevExpress.XtraEditors.PopupContainerControl();
            this.buttonEditSample = new DevExpress.XtraEditors.ButtonEdit();
            this.simplePopupButton2 = new PopupContainerCustomButtonControl.SimplePopupButton();
            this.SimpleButtonOk = new PopupContainerCustomButtonControl.SimplePopupButton();
            this.SimpleButtonClose = new PopupContainerCustomButtonControl.SimplePopupButton();
            this.SimpleButtonMessage = new PopupContainerCustomButtonControl.SimplePopupButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowCustomButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEditCustomButtonForTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControlForTest)).BeginInit();
            this.popupContainerControlForTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditSample.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEditShowCustomButton
            // 
            this.checkEditShowCustomButton.Location = new System.Drawing.Point(15, 135);
            this.checkEditShowCustomButton.Name = "checkEditShowCustomButton";
            this.checkEditShowCustomButton.Properties.Caption = "Show custom button in popup window";
            this.checkEditShowCustomButton.Properties.EditValueChanged += new System.EventHandler(this.checkEditShowCustomButton_Properties_EditValueChanged);
            this.checkEditShowCustomButton.Size = new System.Drawing.Size(251, 19);
            this.checkEditShowCustomButton.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // popupContainerEditCustomButtonForTest
            // 
            this.popupContainerEditCustomButtonForTest.Location = new System.Drawing.Point(11, 10);
            this.popupContainerEditCustomButtonForTest.Name = "popupContainerEditCustomButtonForTest";
            this.popupContainerEditCustomButtonForTest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupContainerEditCustomButtonForTest.Properties.ButtonsForPopupWindow.Add(this.simplePopupButtonOK);
            this.popupContainerEditCustomButtonForTest.Properties.ButtonsForPopupWindow.Add(this.simplePopupButtonClose);
            this.popupContainerEditCustomButtonForTest.Properties.ButtonsForPopupWindow.Add(this.simplePopupButtonMessage);
            this.popupContainerEditCustomButtonForTest.Properties.PopupControl = this.popupContainerControlForTest;
            this.popupContainerEditCustomButtonForTest.Properties.ShowCustomButton = true;
            this.popupContainerEditCustomButtonForTest.Properties.CustomButtonClick += new PopupContainerCustomButtonControl.RepositoryItemPopupContainerEditCustomButton.CustomButtonEventHandler(this.popupContainerEditCustomButtonForTest_Properties_CustomButtonClick);
            this.popupContainerEditCustomButtonForTest.Properties.QueryResultValue += new DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(this.popupContainerEditCustomButtonForTest_Properties_QueryResultValue);
            this.popupContainerEditCustomButtonForTest.Size = new System.Drawing.Size(252, 20);
            this.popupContainerEditCustomButtonForTest.TabIndex = 3;
            // 
            // simplePopupButtonOK
            // 
            this.simplePopupButtonOK.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Ok;
            this.simplePopupButtonOK.Location = new System.Drawing.Point(0, 0);
            this.simplePopupButtonOK.Name = "simplePopupButtonOK";
            this.simplePopupButtonOK.Size = new System.Drawing.Size(75, 23);
            this.simplePopupButtonOK.TabIndex = 0;
            this.simplePopupButtonOK.Text = "Ok";
            // 
            // simplePopupButtonClose
            // 
            this.simplePopupButtonClose.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Close;
            this.simplePopupButtonClose.Location = new System.Drawing.Point(0, 0);
            this.simplePopupButtonClose.Name = "simplePopupButtonClose";
            this.simplePopupButtonClose.Size = new System.Drawing.Size(75, 23);
            this.simplePopupButtonClose.TabIndex = 0;
            this.simplePopupButtonClose.Text = "Close";
            // 
            // simplePopupButtonMessage
            // 
            this.simplePopupButtonMessage.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Custom;
            this.simplePopupButtonMessage.Location = new System.Drawing.Point(0, 0);
            this.simplePopupButtonMessage.Name = "simplePopupButtonMessage";
            this.simplePopupButtonMessage.Size = new System.Drawing.Size(75, 23);
            this.simplePopupButtonMessage.TabIndex = 0;
            this.simplePopupButtonMessage.Tag = "Custom buttom Tag text";
            this.simplePopupButtonMessage.Text = "Message";
            // 
            // popupContainerControlForTest
            // 
            this.popupContainerControlForTest.Controls.Add(this.buttonEditSample);
            this.popupContainerControlForTest.Location = new System.Drawing.Point(13, 37);
            this.popupContainerControlForTest.Name = "popupContainerControlForTest";
            this.popupContainerControlForTest.Size = new System.Drawing.Size(254, 94);
            this.popupContainerControlForTest.TabIndex = 0;
            // 
            // buttonEditSample
            // 
            this.buttonEditSample.Location = new System.Drawing.Point(6, 10);
            this.buttonEditSample.Name = "buttonEditSample";
            this.buttonEditSample.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditSample.Size = new System.Drawing.Size(245, 20);
            this.buttonEditSample.TabIndex = 0;
            // 
            // simplePopupButton2
            // 
            this.simplePopupButton2.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Ok;
            this.simplePopupButton2.Location = new System.Drawing.Point(0, 0);
            this.simplePopupButton2.Name = "simplePopupButton2";
            this.simplePopupButton2.Size = new System.Drawing.Size(75, 23);
            this.simplePopupButton2.TabIndex = 0;
            this.simplePopupButton2.Text = "simplePopupButton2";
            // 
            // SimpleButtonOk
            // 
            this.SimpleButtonOk.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Ok;
            this.SimpleButtonOk.Location = new System.Drawing.Point(0, 0);
            this.SimpleButtonOk.Name = "SimpleButtonOk";
            this.SimpleButtonOk.Size = new System.Drawing.Size(75, 23);
            this.SimpleButtonOk.TabIndex = 0;
            this.SimpleButtonOk.Text = "Ok";
            // 
            // SimpleButtonClose
            // 
            this.SimpleButtonClose.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Close;
            this.SimpleButtonClose.Location = new System.Drawing.Point(0, 0);
            this.SimpleButtonClose.Name = "SimpleButtonClose";
            this.SimpleButtonClose.Size = new System.Drawing.Size(75, 23);
            this.SimpleButtonClose.TabIndex = 0;
            this.SimpleButtonClose.Text = "Close";
            // 
            // SimpleButtonMessage
            // 
            this.SimpleButtonMessage.DefaultBehavior = PopupContainerCustomButtonControl.PopupButtonStyle.Ok;
            this.SimpleButtonMessage.Location = new System.Drawing.Point(0, 0);
            this.SimpleButtonMessage.Name = "SimpleButtonMessage";
            this.SimpleButtonMessage.Size = new System.Drawing.Size(75, 23);
            this.SimpleButtonMessage.TabIndex = 0;
            this.SimpleButtonMessage.Tag = "It\'s work also in grid";
            this.SimpleButtonMessage.Text = "Message";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.popupContainerEditCustomButtonForTest);
            this.Controls.Add(this.checkEditShowCustomButton);
            this.Controls.Add(this.popupContainerControlForTest);
            this.Name = "MainForm";
            this.Text = "Example main form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowCustomButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEditCustomButtonForTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControlForTest)).EndInit();
            this.popupContainerControlForTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditSample.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkEditShowCustomButton;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControlForTest;
        private DevExpress.XtraEditors.ButtonEdit buttonEditSample;
        private PopupContainerCustomButtonControl.SimplePopupButton simplePopupButton2;
        private PopupContainerCustomButtonControl.PopupContainerEditCustomButton popupContainerEditCustomButtonForTest;
        private PopupContainerCustomButtonControl.SimplePopupButton simplePopupButtonOK;
        private PopupContainerCustomButtonControl.SimplePopupButton simplePopupButtonClose;
        private PopupContainerCustomButtonControl.SimplePopupButton simplePopupButtonMessage;
        private System.Windows.Forms.Label label1;
        private PopupContainerCustomButtonControl.SimplePopupButton SimpleButtonOk;
        private PopupContainerCustomButtonControl.SimplePopupButton SimpleButtonClose;
        private PopupContainerCustomButtonControl.SimplePopupButton SimpleButtonMessage;
    }
}

