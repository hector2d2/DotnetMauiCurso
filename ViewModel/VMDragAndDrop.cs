using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inicio.ViewModel;

[ObservableObject]
public partial class VMDragAndDrop
{
    [ObservableProperty]
    List<(int, int)> numeros;

    [ObservableProperty]
    List<int> respuestas;

    int Resultado = 0;

    [ObservableProperty]
    int position = 0;

    public VMDragAndDrop()
    {
        Numeros = new List<(int, int)>(){
            (1,3),
            (2,4),
            (5,8),
            (5,5)
        };
        Respuestas = new List<int>(){
            4,5,6,1,10,13,56,201,0,9,10
        };
    }

    [RelayCommand]
    void SoltarResultado()
    {
        int resultadoCorrecto = Numeros[Position].Item1 + Numeros[Position].Item2; 
        if(resultadoCorrecto == Resultado)
        {
            if(Position < Numeros.Count)
            Position++;
        }else{
            Shell.Current.DisplayAlert("DragAndDrop","Respuesta incorrecta. Intenta de nuevo","OK");
        }
    }

    [RelayCommand]
    void AgarroResultado(int resultadoSeleccionado)
    {
        Resultado = resultadoSeleccionado;
    }

}
