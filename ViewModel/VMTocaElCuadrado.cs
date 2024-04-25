using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Inicio.Models;

namespace Inicio.ViewModel;

[ObservableObject]
public partial class VMTocaElCuadrado
{
    [ObservableProperty]
    List<MCuadrado> cuadricula = new List<MCuadrado>();

    public VMTocaElCuadrado()
    {
        for (int i = 0; i < 16; i++)
        {
            Cuadricula.Add(new MCuadrado
            {
                Dato = i,
                CurrentColor = Colors.White
            });
        }
        CambiaColor();
    }

    void CambiaColor()
    {
        Random random = new Random();
        int totalCuadricula = Cuadricula.Count;
        int num = random.Next(totalCuadricula);
        Cuadricula[num].CurrentColor = Colors.Green;
    }

    [RelayCommand]
    void TocoElCuadrado(MCuadrado cuadradoTocado)
    {
        cuadradoTocado.CurrentColor = Colors.White;
        CambiaColor();
    }
}
