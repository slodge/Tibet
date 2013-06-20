using Cirrious.CrossCore.Converters;
using Cirrious.MvvmCross.ViewModels;

namespace Tibet.Core.ViewModels
{
    public class LengthValueConverter : MvxValueConverter<string, int>
    {
        protected override int Convert(string value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return 0;
            return value.Length;
        }
    }

    public class SalutationValueConverter : MvxValueConverter<int, string>
    {
        protected override string Convert(int value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value < 21)
                return "Hiya";

            return "Welcome";
        }
    }

    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        private int _counter = 200;
        public int Counter
        {
            get { return _counter; }
            set { _counter = value; RaisePropertyChanged(() => Counter); }
        }        
    }
}
