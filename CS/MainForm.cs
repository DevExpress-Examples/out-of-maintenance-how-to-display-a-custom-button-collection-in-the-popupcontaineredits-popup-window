using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors;

namespace PopupContainerWithOKButton
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void checkEditShowCustomButton_Properties_EditValueChanged(object sender, EventArgs e)
        {
            popupContainerEditCustomButtonForTest.Properties.ShowCustomButton = (bool)checkEditShowCustomButton.EditValue;
            Control currentPopupWindow = (popupContainerEditCustomButtonForTest as IPopupControl).PopupWindow;
            if (currentPopupWindow != null) currentPopupWindow.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkEditShowCustomButton.EditValue = true;
        }


        private void popupContainerEditCustomButtonForTest_Properties_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            e.Value = buttonEditSample.EditValue;
        }

        private void popupContainerEditCustomButtonForTest_Properties_CustomButtonClick(object sender, PopupContainerCustomButtonControl.EventsArgsCustomButton e)
        {
            if (e.CustomButton.Text == "Ok")
                label1.Text = "Status: button Ok is pressed";
            else if (e.CustomButton.Text == "Close")
                label1.Text = "Status: button Close is pressed";
            else
                label1.Text = "Status: " + e.CustomButton.Tag.ToString();
        }
    }
}
