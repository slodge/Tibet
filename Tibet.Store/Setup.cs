using System.Reflection;
using Cirrious.MvvmCross.BindingEx.WindowsShared;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsStore.Platform;
using Windows.UI.Xaml.Controls;

namespace Tibet.Store
{
    public class Setup : MvxStoreSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();

            var builder = new MvxWindowsBindingBuilder(MvxWindowsBindingBuilder.BindingType.MvvmCross,
                                                       typeof (Core.App).GetTypeInfo().Assembly);
            builder.DoRegistration();
        }
    }
}