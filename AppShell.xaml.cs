using Inicio.Views.Curso.Imagenes;
using Inicio.Views.Curso.MenuCurso;
using Inicio.Views.Ejercicios.MenuEjercicios;
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
		Routing.RegisterRoute(nameof(MenuEjercicios),typeof(MenuEjercicios));
		Routing.RegisterRoute(nameof(MenuCurso),typeof(MenuCurso));
	}
}
