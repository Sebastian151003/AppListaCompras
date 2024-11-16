namespace AppListaCompras.Pages;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private async void BtnAceptar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new DefaultView());
    }
}