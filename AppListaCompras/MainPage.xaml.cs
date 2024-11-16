namespace AppListaCompras
{
    using Pages;
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void RegistrarBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroView());
        }
    }

}
