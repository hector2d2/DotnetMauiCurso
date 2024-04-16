using Inicio.Views.Curso.Imagenes;
using MauiApp1;

namespace Inicio;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("SecondPage",typeof(SecondPage));
		Routing.RegisterRoute("ContraseñaValida",typeof(ContraseñaValida));
		Routing.RegisterRoute(nameof(Imagen),typeof(Imagen));
	}
}
