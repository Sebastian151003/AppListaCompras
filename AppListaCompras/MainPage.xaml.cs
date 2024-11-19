namespace AppListaCompras
{
    using Pages;
    public partial class MainPage : ContentPage
    {

        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void RegistroBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroView());
        }


        private async void BtnIniciar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginView());

        }
    }

}
