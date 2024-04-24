namespace Inicio.Views.Curso.Diseño1.CustomControllers;

public partial class TarjetaSeccion : ContentView
{
	public static readonly BindableProperty InfoTarjetaProperty = BindableProperty.Create(
	   nameof(InfoTarjeta),
	   typeof(MInfoTarjetaSeccion),
	   typeof(TarjetaSeccion),
	   null
	 );

	public MInfoTarjetaSeccion InfoTarjeta
	{
		get => (MInfoTarjetaSeccion)GetValue(InfoTarjetaProperty);
		set => SetValue(InfoTarjetaProperty, value);
	}

	public TarjetaSeccion()
	{
		InitializeComponent();
	}
}