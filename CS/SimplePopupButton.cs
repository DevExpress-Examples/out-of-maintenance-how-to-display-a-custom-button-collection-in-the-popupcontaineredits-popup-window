using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Collections;
using System.ComponentModel;

namespace PopupContainerCustomButtonControl
{
    public enum PopupButtonStyle
    { 
        Ok, Close, Custom
    }

    class SimplePopupButton : SimpleButton
    {
        public PopupButtonStyle DefaultBehavior { get; set; }
        public override string ToString()
        {
            return this.DefaultBehavior.ToString();
        }
    }

    internal class CustomButtonEventsArgs : EventArgs
    {
        protected SimplePopupButton protCustomButton;
        public SimplePopupButton CustomButton { get { return protCustomButton; } }
        public CustomButtonEventsArgs(SimplePopupButton paramButton)
        {
            this.protCustomButton = paramButton;
        }
    }

    internal class CustomButtonCollectionEventArgs : CustomButtonEventsArgs
    {
        protected CollectionChangeAction protCurrentAction;
        public CollectionChangeAction CurrentAction { get { return protCurrentAction; } }
        public CustomButtonCollectionEventArgs(SimplePopupButton paramButton, CollectionChangeAction paramAction) : base(paramButton)
        {
            this.protCurrentAction = paramAction;
        }
    }


    [ListBindable(false), TypeConverter(typeof(DevExpress.Utils.Design.UniversalCollectionTypeConverter))]
    class CustomButtonCollection : CollectionBase
    {
        [Description("Gets a button at the specified position.")]
        public SimplePopupButton this[int index] { get { return List[index] as SimplePopupButton; } }

        public virtual int Add(SimplePopupButton button)
        {
            int res = IndexOf(button);
            if (res == -1) res = List.Add(button);
            return res;
        }
        public virtual int IndexOf(SimplePopupButton button) { return List.IndexOf(button); }
        public virtual bool Contains(SimplePopupButton button) { return List.Contains(button); }
        public virtual void Insert(int index, SimplePopupButton button)
        {
            if (Contains(button)) return;
            List.Insert(index, button);
        }

        protected override void OnInsertComplete(int index, object item)
        {
            if (OnCollectionChanged != null) {
                OnCollectionChanged(this, new CustomButtonCollectionEventArgs((item as SimplePopupButton), CollectionChangeAction.Add));        		 
	        }
        }
        protected override void OnRemoveComplete(int index, object item)
        {
            if (OnCollectionChanged != null) {
                OnCollectionChanged(this, new CustomButtonCollectionEventArgs((item as SimplePopupButton), CollectionChangeAction.Remove));
	        }
        }

        public delegate void SimpleButtonCollectionEvenrHandler(object sender, CustomButtonCollectionEventArgs e);
        public event SimpleButtonCollectionEvenrHandler OnCollectionChanged;    
    }
}
