using System.Globalization;

namespace Inicio.Converters;

public class ConvertirAlturaCuadrado : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
       if(value == null)
       return 0;

       double tamañoTotalAltura = (double)value;

       return tamañoTotalAltura / 4;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
