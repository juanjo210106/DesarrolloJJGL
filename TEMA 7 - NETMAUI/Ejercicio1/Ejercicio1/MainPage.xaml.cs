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
            
            await Navigation.PushAsync(new PerfilUsuario());
        }
    }
}
