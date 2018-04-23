using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraEditors.Popup;

namespace PopupContainerCustomButtonControl
{
    class PopupContainerEditCustomButton : PopupContainerEdit
    {
        // static constructor
        static PopupContainerEditCustomButton() { RepositoryItemPopupContainerEditCustomButton.RegisterPopupContainerEditCustomButton(); }

        // public constructor
        public PopupContainerEditCustomButton() { }

        // ovverride property
        public override string EditorTypeName
        {
            get { return RepositoryItemPopupContainerEditCustomButton.PopupContainerEditCustomButtonEditorName; }
        }

        // property as corresponded repositoryitem
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemPopupContainerEditCustomButton Properties
        {
            get { return base.Properties as RepositoryItemPopupContainerEditCustomButton; }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            if (Properties.PopupControl == null) return null;
            else return new PopupContainerFormCustomButton(this);
        }
    }
}
