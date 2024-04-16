namespace Inicio.Views.Curso.Imagenes;

public partial class Imagen : ContentPage
{
	public Imagen()
	{
		InitializeComponent();
	}

	void DuckLoaded(object? sender, EventArgs e)
	{
		duckGif.IsAnimationPlaying = true;
	}
}