using Plugin.Maui.Audio;
using PM2E3ALEKS.Views;
using PM2E3ALEKS.Controllers;
using PM2E3ALEKS.Models;

namespace PM2E3ALEKS
{
    public partial class App : Application
    {
        public static FirebaseController db = new FirebaseController();
        public static Notas nota;

        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new PaginaPrincipal(AudioManager.Current));

        }
    }
}
