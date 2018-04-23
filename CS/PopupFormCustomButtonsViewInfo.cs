using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Popup;
using System.Drawing;

namespace PopupContainerCustomButtonControl
{
    class PopupFormCustomButtonsViewInfo : CustomBlobPopupFormViewInfo
    {
        // custom properties
        protected Rectangle fCustomButtonsRect;
        protected Size fCustomButtonsSize;
        public Rectangle CustomButtonsRect { get { return fCustomButtonsRect; } }
        public Size CustomButtonSize { get { return fCustomButtonsSize; } }
        public const int sideIndent = 5;

        // constructor
        public PopupFormCustomButtonsViewInfo(CustomBlobPopupForm ownerPopupForm) : base(ownerPopupForm) { }

        // override methods
        protected override void CalcContentRect(Rectangle bounds)
        {
            base.CalcContentRect(bounds);
            fCustomButtonsRect = SizeBarRect;
            fCustomButtonsSize = ButtonSize;
        }
    }
}
