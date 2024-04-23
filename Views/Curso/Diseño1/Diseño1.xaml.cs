namespace Inicio.Views.Curso.Diseño1;

public partial class Diseño1 : ContentPage
{
	public Diseño1()
	{
		InitializeComponent();
	}

	public void Menu1OnTap(object sender, EventArgs e)
	{
		pantalla1.IsVisible = true;
		pantalla2.IsVisible = false;
		pantalla3.IsVisible = false;
	}
	public void Menu2OnTap(object sender, EventArgs e)
	{
		pantalla1.IsVisible = false;
		pantalla2.IsVisible = true;
		pantalla3.IsVisible = false;
	}
	public void Menu3OnTap(object sender, EventArgs e)
	{
		pantalla1.IsVisible = false;
		pantalla2.IsVisible = false;
		pantalla3.IsVisible = true;
	}
}