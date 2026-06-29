using SignupApp.VIews;

namespace SignupApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("ProfilePage", typeof(ProfilePage));
    }
}