using AppExamenFinal.Views;

namespace AppExamenFinal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BienvenidaPage();
        }
    }
}
