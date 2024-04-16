using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Inicio.Views.Curso.Imagenes;

namespace Inicio.ViewModel;

[ObservableObject]
public partial class VMMenuInicio
{

    [RelayCommand]
    void NavigateToEjercicios()
    {
        Shell.Current.GoToAsync("ContraseñaValida");
    }
    [RelayCommand]
    void NavigateToCurso()
    {
        Shell.Current.GoToAsync(nameof(Imagen));
    }
}
