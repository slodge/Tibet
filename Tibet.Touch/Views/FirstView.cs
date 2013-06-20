using System.Collections.Generic;
using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Tibet.Touch.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.White};
            base.ViewDidLoad();

            var label = new UILabel(new RectangleF(10, 10, 300, 40));
            Add(label);
            var textField = new UITextField(new RectangleF(10, 50, 300, 40));
            Add(textField);
            var textField2 = new UITextField(new RectangleF(10, 90, 300, 40));
            Add(textField2);

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(textField).To(vm => vm.Hello);
            set.Bind(textField2).To(vm => vm.Counter);
            set.Apply();

            this.AddBindings(new Dictionary<object, string>()
                {
                    { label, "Text Salutation(Counter + Length(Hello)) + ' ' + Hello" }
                });

        }
    }
}