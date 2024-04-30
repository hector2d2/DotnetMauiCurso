namespace Inicio.Views.Curso.Gestores;

public partial class GestorPan : ContentPage
{
	double panX, panY;
	public GestorPan()
	{
		InitializeComponent();
	}

	void OnPanUpdated(object sender, PanUpdatedEventArgs e)
	{
		switch (e.StatusType)
		{
			case GestureStatus.Running:
				// Translate and pan.
				double boundsX = Content.Width;
				double boundsY = Content.Height;
				Img.TranslationX = Math.Clamp(panX + e.TotalX, -boundsX, boundsX);
				Img.TranslationY = Math.Clamp(panY + e.TotalY, -boundsY, boundsY);
				break;

			case GestureStatus.Completed:
				// Store the translation applied during the pan
				panX = Img.TranslationX;
				panY = Img.TranslationY;
				break;
		}
	}
}