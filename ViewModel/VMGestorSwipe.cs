using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inicio.ViewModel;

[ObservableObject]
public partial class VMGestorSwipe
{
    [ObservableProperty]
    string direccion = "";

    [RelayCommand]
    void DeslizarIzq()
    {
        Direccion = "Se deslizo hacia la Izquierda";
    }
    [RelayCommand]
    void DeslizarDer()
    {
        Direccion = "Se deslizo hacia la Derecha";
    }

    [RelayCommand]
    void Deslizar(string direccion)
    {
        Direccion = $"Se deslizo hacia la {direccion}";
    }

}
