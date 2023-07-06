
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class CoefficientOfThermalExpansion<TVal> : DimensionBase<CoefficientOfThermalExpansionUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(CoefficientOfThermalExpansion<TVal>);
            
            public CoefficientOfThermalExpansion() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = -1;
                DimensionComponent.Exponents.Amount = 0;
                
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
