namespace AppExamenFinal.Views;

public partial class BienvenidaPage : ContentPage
{
	public BienvenidaPage()
	{
		InitializeComponent();
	}

    private async void BtnIngresar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PreguntaPage());
    }
}