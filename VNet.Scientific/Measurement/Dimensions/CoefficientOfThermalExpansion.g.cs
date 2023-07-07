
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class CoefficientOfThermalExpansion<TVal> : DimensionBase<CoefficientOfThermalExpansionUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(CoefficientOfThermalExpansion<TVal>);
            
            public CoefficientOfThermalExpansion() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = -1;
                Exponents.Amount = 0;
                
                DefaultUnit = CoefficientOfThermalExpansionUnit.InverseKelvin;
                
                Symbols.Add(CoefficientOfThermalExpansionUnit.InverseKelvin, "K⁻¹");
                Symbols.Add(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, "°C⁻¹");
                Symbols.Add(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, "°F⁻¹");
                
                PluralSymbols.Add(CoefficientOfThermalExpansionUnit.InverseKelvin, "1/K");
                PluralSymbols.Add(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, "1/°C");
                PluralSymbols.Add(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, "1/°F");
                
                ConversionFunctions.Add(CoefficientOfThermalExpansionUnit.InverseKelvin, "x");
                ConversionFunctions.Add(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, "x");
                ConversionFunctions.Add(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, "x * 9 / 5");
            }
        }
    }
