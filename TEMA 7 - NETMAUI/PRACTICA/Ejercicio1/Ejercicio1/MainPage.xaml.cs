namespace Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "Invitado";
            }


            await Navigation.PushAsync(new PerfilUsuario(nombre));
        }
    }
}
