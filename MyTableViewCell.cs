using System;
using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using StarWarsSample.Core;
using StarWarsSample.Core.Models;
using UIKit;

namespace StarWarsSample.iOS.Views.Cells
{
    public partial class MyTableViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("MyTableViewCell");
        public static readonly UINib Nib;

        static MyTableViewCell()
        {
            Nib = UINib.FromName("MyTableViewCell", NSBundle.MainBundle);
            
        }

        protected MyTableViewCell(IntPtr handle) : base(handle)
        {

            CompleteUI();
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<MyTableViewCell, Note>();
                set.Bind(TextLabel).To(v => v.Header);
                set.Apply();
            });
           
        }

        private void CompleteUI()
        {
            this.SelectionStyle = UITableViewCellSelectionStyle.None;
        }
    }
}
