
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class EnergyDensity<TVal> : DimensionBase<EnergyDensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(EnergyDensity<TVal>);
            
            public EnergyDensity() : base()
            {
                Exponents.Length = -1;
                Exponents.Mass = 1;
                Exponents.Time = -2;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = EnergyDensityUnit.JoulePerCubicMeter;
                
                Symbols.Add(EnergyDensityUnit.WattHourPerCubicMeter, "Wh/m³");
                Symbols.Add(EnergyDensityUnit.Yottajoulepercubicmeter, "YJ/m³");
                Symbols.Add(EnergyDensityUnit.Zettajoulepercubicmeter, "ZJ/m³");
                Symbols.Add(EnergyDensityUnit.Exajoulepercubicmeter, "EJ/m³");
                Symbols.Add(EnergyDensityUnit.Petajoulepercubicmeter, "PJ/m³");
                Symbols.Add(EnergyDensityUnit.Terajoulepercubicmeter, "TJ/m³");
                Symbols.Add(EnergyDensityUnit.Gigajoulepercubicmeter, "GJ/m³");
                Symbols.Add(EnergyDensityUnit.Megajoulepercubicmeter, "MJ/m³");
                Symbols.Add(EnergyDensityUnit.Kilojoulepercubicmeter, "kJ/m³");
                Symbols.Add(EnergyDensityUnit.Hectojoulepercubicmeter, "hJ/m³");
                Symbols.Add(EnergyDensityUnit.Dekajoulepercubicmeter, "daJ/m³");
                Symbols.Add(EnergyDensityUnit.JoulePerCubicMeter, "J/m³");
                Symbols.Add(EnergyDensityUnit.Decijoulepercubicmeter, "dJ/m³");
                Symbols.Add(EnergyDensityUnit.Centijoulepercubicmeter, "cJ/m³");
                Symbols.Add(EnergyDensityUnit.Millijoulepercubicmeter, "mJ/m³");
                Symbols.Add(EnergyDensityUnit.Microjoulepercubicmeter, "µJ/m³");
                Symbols.Add(EnergyDensityUnit.Nanojoulepercubicmeter, "nJ/m³");
                Symbols.Add(EnergyDensityUnit.Picojoulepercubicmeter, "pJ/m³");
                Symbols.Add(EnergyDensityUnit.Femtojoulepercubicmeter, "fJ/m³");
                Symbols.Add(EnergyDensityUnit.Attojoulepercubicmeter, "aJ/m³");
                Symbols.Add(EnergyDensityUnit.Zeptojoulepercubicmeter, "zJ/m³");
                Symbols.Add(EnergyDensityUnit.Yoctojoulepercubicmeter, "yJ/m³");
                
                
                ConversionFunctions.Add(EnergyDensityUnit.WattHourPerCubicMeter, "x * 3.6e+3");
                ConversionFunctions.Add(EnergyDensityUnit.Yottajoulepercubicmeter, "x * 1e24");
                ConversionFunctions.Add(EnergyDensityUnit.Zettajoulepercubicmeter, "x * 1e21");
                ConversionFunctions.Add(EnergyDensityUnit.Exajoulepercubicmeter, "x * 1e18");
                ConversionFunctions.Add(EnergyDensityUnit.Petajoulepercubicmeter, "x * 1e15");
                ConversionFunctions.Add(EnergyDensityUnit.Terajoulepercubicmeter, "x * 1e12");
                ConversionFunctions.Add(EnergyDensityUnit.Gigajoulepercubicmeter, "x * 1e9");
                ConversionFunctions.Add(EnergyDensityUnit.Megajoulepercubicmeter, "x * 1e6");
                ConversionFunctions.Add(EnergyDensityUnit.Kilojoulepercubicmeter, "x * 1e3");
                ConversionFunctions.Add(EnergyDensityUnit.Hectojoulepercubicmeter, "x * 1e2");
                ConversionFunctions.Add(EnergyDensityUnit.Dekajoulepercubicmeter, "x * 1e1");
                ConversionFunctions.Add(EnergyDensityUnit.JoulePerCubicMeter, "x * 1e0");
                ConversionFunctions.Add(EnergyDensityUnit.Decijoulepercubicmeter, "x * 1e-1");
                ConversionFunctions.Add(EnergyDensityUnit.Centijoulepercubicmeter, "x * 1e-2");
                ConversionFunctions.Add(EnergyDensityUnit.Millijoulepercubicmeter, "x * 1e-3");
                ConversionFunctions.Add(EnergyDensityUnit.Microjoulepercubicmeter, "x * 1e-6");
                ConversionFunctions.Add(EnergyDensityUnit.Nanojoulepercubicmeter, "x * 1e-9");
                ConversionFunctions.Add(EnergyDensityUnit.Picojoulepercubicmeter, "x * 1e-12");
                ConversionFunctions.Add(EnergyDensityUnit.Femtojoulepercubicmeter, "x * 1e-15");
                ConversionFunctions.Add(EnergyDensityUnit.Attojoulepercubicmeter, "x * 1e-18");
                ConversionFunctions.Add(EnergyDensityUnit.Zeptojoulepercubicmeter, "x * 1e-21");
                ConversionFunctions.Add(EnergyDensityUnit.Yoctojoulepercubicmeter, "x * 1e-24");
            }
        }
    }
