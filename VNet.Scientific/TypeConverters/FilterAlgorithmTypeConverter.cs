using System.ComponentModel;
using System.Globalization;
using VNet.Scientific.Filtering.Algorithms;

namespace VNet.Scientific.TypeConverters;

public class FilterAlgorithmTypeConverter : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
    {
        return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
    }

    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
    {
        var typeName = value as string;
        if (string.IsNullOrWhiteSpace(typeName)) return base.ConvertFrom(context, culture, value);

        var type = Type.GetType(typeName);
        if (type != null && typeof(IFilterAlgorithm).IsAssignableFrom(type))
        {
            return Activator.CreateInstance(type);
        }
        return base.ConvertFrom(context, culture, value);
    }
}