using AppListaCompras.Modelos;

namespace AppListaCompras.Pages;

public partial class LoginView : ContentPage
{
    public LoginView()
    {
        InitializeComponent();
    }
    //private ModeloUsuarios usuLogeado = new ModeloUsuarios();
    private async void BtnAceptar_Clicked(object sender, EventArgs e)
    {
        var datosusuario = new ModeloUsuarios()
        {
            Nombre = txtUsuario.Text,
            Contraseña = txtContrasena.Text
        };
        bool respuesta = App.UsuRepo.ValidarLogin(datosusuario);

        if (respuesta)
            await Navigation.PushAsync(new DefaultView());
        else
            DisplayAlert("Aviso", App.UsuRepo.StatusMessage, "Aceptar");

    }
}