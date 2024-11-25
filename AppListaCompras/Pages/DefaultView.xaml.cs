namespace AppListaCompras.Pages;

public partial class DefaultView : ContentPage
{
	public DefaultView()
	{
		InitializeComponent();

	}

    private async void BtnArticulos_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new ArticulosView());
    }

    private async void BtnCategorias_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriasView());
    }

    private async void BtnListas_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListasView());
    }
}