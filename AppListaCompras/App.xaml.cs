namespace AppListaCompras
{
    public partial class App : Application
    {
        public static UsuarioRepository UsuRepo { get; set; }
        public App(UsuarioRepository usuarioRepository)
        {
            InitializeComponent();

            MainPage = new AppShell();
            UsuRepo = usuarioRepository;
        }
    }
}
