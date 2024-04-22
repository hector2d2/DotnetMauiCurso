using CommunityToolkit.Mvvm.ComponentModel;

namespace Inicio.Models;

[ObservableObject]
public partial class MCuadrado
{
    public int Dato{get; set;}

    [ObservableProperty]
    public Color currentColor;
}
