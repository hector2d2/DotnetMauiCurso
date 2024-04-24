using Inicio.Views.Curso.Diseño1.CustomControllers;

namespace Inicio.Views.Curso.Diseño1;

public partial class Diseño1 : ContentPage
{
	public List<MInfoTarjetaSeccion> Tarjetas { get; set; }


	public Diseño1()
	{
		Tarjetas = new();
		Tarjetas.Add(new MInfoTarjetaSeccion
		{
			TituloEtiqueta = "Urgent",
			ColorEtiqueta = Colors.Purple,
			Titulo = "UX Desing in Figma",
			SubTitulo = "website Ui Design for Nimm",
			Hora = "8-12 am",
			Mensajes = "2 New"
		});
		Tarjetas.Add(new MInfoTarjetaSeccion
		{
			TituloEtiqueta = "Running",
			ColorEtiqueta = Colors.Blue,
			Titulo = "Website mockup Design",
			SubTitulo = "Mockups for 3 reload app",
			Hora = "15-17 am",
			Mensajes = "8 New"
		});
		Tarjetas.Add(new MInfoTarjetaSeccion
		{
			TituloEtiqueta = "Done",
			ColorEtiqueta = Colors.Green,
			Titulo = "Local Social Media Kit",
			SubTitulo = "For new brand",
			Hora = "10-12 am",
			Mensajes = "16 New"
		});

		InitializeComponent();
	}

	public void Menu1OnTap(object sender, EventArgs e)
	{
		// pantalla1.IsVisible = true;
		pantalla2.IsVisible = false;
		pantalla3.IsVisible = false;
	}
	public void Menu2OnTap(object sender, EventArgs e)
	{
		// pantalla1.IsVisible = false;
		pantalla2.IsVisible = true;
		pantalla3.IsVisible = false;
	}
	public void Menu3OnTap(object sender, EventArgs e)
	{
		// pantalla1.IsVisible = false;
		pantalla2.IsVisible = false;
		pantalla3.IsVisible = true;
	}
}