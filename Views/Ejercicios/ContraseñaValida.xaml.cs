namespace MauiApp1;

public partial class ContraseñaValida : ContentPage
{
	bool canChangePassword = false;
	public ContraseñaValida()
	{
		InitializeComponent();
	}
	
	 public void OnEntryTextChange(object sender, TextChangedEventArgs e)
	{
		canChangePassword =  e.NewTextValue.Length >= 8 && e.NewTextValue != ContraseñaAnterior.Text;
		txtValidacion1.TextColor = e.NewTextValue.Length >= 8 ? Colors.Green : Colors.Red;
		txtValidacion2.TextColor = e.NewTextValue != ContraseñaAnterior.Text ? Colors.Green : Colors.Red;
		// BtnCambiarContraseña.IsEnabled = canChangePassword;
		// BtnCambiarContraseña.IsVisible = canChangePassword;
	}

	public void OnBtnCambiarContraseñaClicked(object e, EventArgs args)
	{
		if(canChangePassword)
			Shell.Current.DisplayAlert("Cambio de Contraseña","Se ha cambiado la contraseña","OK");
	}
}