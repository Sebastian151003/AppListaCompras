namespace AppListaCompras.Pages;

public partial class ArticulosView : ContentPage
{
	public ArticulosView()
	{
		InitializeComponent();
	}

    private async void BtnRegistroArtic_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new RegistroArticuloView());
    }

    private async void BtnLista_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListasView());
    }

    private async void BtnInicio_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DefaultView());
    }

    private async void BtnCategor_Cliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriasView());
    }
}