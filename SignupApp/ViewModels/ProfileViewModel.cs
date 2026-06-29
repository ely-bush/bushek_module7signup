using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SignupApp.ViewModels
{
    [QueryProperty(nameof(Username), "username")]
    [QueryProperty(nameof(Email), "email")]
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private string _username, _email;

        public string Username
        {
            get => _username;
            set { _username = Uri.UnescapeDataString(value ?? ""); OnPropertyChanged(); }
        }

        public string Email
        {
            get => _email;
            set { _email = Uri.UnescapeDataString(value ?? ""); OnPropertyChanged(); }
        }

        public ICommand SignOutCommand { get; }

        public ProfileViewModel()
        {
            SignOutCommand = new Command(async () =>
                await Shell.Current.GoToAsync("//SignupPage"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}