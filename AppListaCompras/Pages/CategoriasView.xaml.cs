namespace AppListaCompras.Pages;

public partial class CategoriasView : ContentPage
{
	public CategoriasView()
	{
		InitializeComponent();
	}

    private async void BtnInicio_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new DefaultView());
    }

    private async void BtnLista_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListasView());
    }

    private async void BtnArticulo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ArticulosView());
    }
}