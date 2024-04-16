using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inicio.ViewModel;

[ObservableObject]
public partial class VMMain
{
    [ObservableProperty]
    string txtResultado1 = "";
    [ObservableProperty]
    string txtInput = "";

    public VMMain()
    {
    }


    public void NavigateSecondPage()
    {
        Shell.Current.GoToAsync("SecondPage");
    }


    [RelayCommand]
    public void CopyTextInput()
    {
        TxtResultado1 = TxtInput;
    }
}
