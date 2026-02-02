namespace Ejercicio1;

public partial class PerfilUsuario : ContentPage
{
	public PerfilUsuario(string nombreRecibido)
	{
		InitializeComponent();

		lblNombreUsuario.Text = nombreRecibido;
		Title = "Perfil de " + nombreRecibido;
	}


}