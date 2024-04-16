namespace Inicio;

public class SecondPage : ContentPage
{
	public SecondPage()
	{
		Title = "Second Page";
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}