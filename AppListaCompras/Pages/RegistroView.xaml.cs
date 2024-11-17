using AppListaCompras.Modelos;

namespace AppListaCompras.Pages;

public partial class RegistroView : ContentPage
{
    public RegistroView()
    {
        InitializeComponent();
    }

    private async void btnRegistro_Clicked(object sender, EventArgs e)
    {
        var datosusuario = new ModeloUsuarios()
        {
            Nombre = txtNombre.Text,
            Contraseña = txtContrasena.Text,
            Correo = txtCorreo.Text,
            Telefono = txtTelefono.Text,
            FechaCreacion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
        };
        bool respuesta = App.UsuRepo.AddNewUsuario(datosusuario);

        DisplayAlert("Aviso", App.UsuRepo.StatusMessage, "Aceptar");

        if (respuesta)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}