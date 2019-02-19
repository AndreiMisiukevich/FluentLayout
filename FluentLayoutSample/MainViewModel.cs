using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using System.IO;
namespace FluentLayoutSample
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            Text = "Click button to change me";
            ButtonTitle = "I am BUTTON";
        }

        private ICommand _clickCommand;
        public ICommand ClickCommand => _clickCommand ?? (_clickCommand = new Command(() =>
        {
            Text = Path.GetRandomFileName();
        }));

        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropChanged();
            }
        }

        private string _buttonTitle;
        public string ButtonTitle
        {
            get => _buttonTitle;
            set
            {
                _buttonTitle = value;
                OnPropChanged();
            }
        }

        public Color StackColor => Color.Black;

        protected void OnPropChanged([CallerMemberName] string propName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
