namespace AppListaCompras.Pages;

public partial class ListasView : ContentPage
{
	public ListasView()
	{
		InitializeComponent();
	}

    private async void BtnRegistroList_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new RegistroListaView());
    }

    private async void BtnInicio_Cliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DefaultView());
    }

    private async void BtnArticulo_Cliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ArticulosView());
    }

    private async void BtnCategor_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriasView());
    }
}