using Inicio.Views.Curso.Diseño1;
using Inicio.Views.Curso.Imagenes;
using Inicio.Views.Curso.MenuCurso;
using Inicio.Views.Ejercicios.MenuEjercicios;
using Inicio.Views.Ejercicios.TocaElCuadrado;
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
		Routing.RegisterRoute(nameof(TocaElCuadrado),typeof(TocaElCuadrado));
		Routing.RegisterRoute(nameof(Diseño1),typeof(Diseño1));
	}
}
