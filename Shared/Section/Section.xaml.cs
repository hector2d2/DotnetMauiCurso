namespace Inicio.Shared.Section;

public partial class Section : ContentView
{
	public static readonly BindableProperty RouteNameProperty = BindableProperty.Create(
	   nameof(RouteName),
	   typeof(string),
	   typeof(Section),
	   ""
	 );

	public string RouteName
	{
		get => (string)GetValue(RouteNameProperty);
		set => SetValue(RouteNameProperty, value);
	}
	
	public static readonly BindableProperty TitleProperty = BindableProperty.Create(
		nameof(Title),
		typeof(string),
		typeof(Section),
		""
	);

	public string Title
	{
		get => (string)GetValue(TitleProperty);
		set => SetValue(TitleProperty, value);
	}

	public Section()
	{
		InitializeComponent();
	}

	public void OnSectionComponentTapped(object obj, EventArgs eventArgs)
	{
		Shell.Current.GoToAsync(RouteName);
	}
}