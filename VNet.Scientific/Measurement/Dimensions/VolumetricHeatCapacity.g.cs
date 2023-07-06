
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class VolumetricHeatCapacity<TVal> : DimensionBase<VolumetricHeatCapacityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(VolumetricHeatCapacity<TVal>);
            
            public VolumetricHeatCapacity() : base()
            {
                DimensionComponent.Exponents.Length = -1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = -1;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin;
                
                Symbols.Add(VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius, "J/m³·°C");
                Symbols.Add(VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius, "cal/cm³·°C");
                Symbols.Add(VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit, "BTU/ft³·°F");
                Symbols.Add(VolumetricHeatCapacityUnit.Yottajoulepercubicmeterkelvin, "YJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Zettajoulepercubicmeterkelvin, "ZJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Exajoulepercubicmeterkelvin, "EJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Petajoulepercubicmeterkelvin, "PJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Terajoulepercubicmeterkelvin, "TJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Gigajoulepercubicmeterkelvin, "GJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Megajoulepercubicmeterkelvin, "MJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Kilojoulepercubicmeterkelvin, "kJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Hectojoulepercubicmeterkelvin, "hJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Dekajoulepercubicmeterkelvin, "daJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin, "J/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Decijoulepercubicmeterkelvin, "dJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Centijoulepercubicmeterkelvin, "cJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Millijoulepercubicmeterkelvin, "mJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Microjoulepercubicmeterkelvin, "µJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Nanojoulepercubicmeterkelvin, "nJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Picojoulepercubicmeterkelvin, "pJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Femtojoulepercubicmeterkelvin, "fJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Attojoulepercubicmeterkelvin, "aJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Zeptojoulepercubicmeterkelvin, "zJ/m³·K");
                Symbols.Add(VolumetricHeatCapacityUnit.Yoctojoulepercubicmeterkelvin, "yJ/m³·K");
                
                
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius, "x");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius, "x / 2.388459e-7");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit, "x / 1.4910660e-5");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Yottajoulepercubicmeterkelvin, "x * 1e24");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Zettajoulepercubicmeterkelvin, "x * 1e21");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Exajoulepercubicmeterkelvin, "x * 1e18");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Petajoulepercubicmeterkelvin, "x * 1e15");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Terajoulepercubicmeterkelvin, "x * 1e12");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Gigajoulepercubicmeterkelvin, "x * 1e9");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Megajoulepercubicmeterkelvin, "x * 1e6");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Kilojoulepercubicmeterkelvin, "x * 1e3");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Hectojoulepercubicmeterkelvin, "x * 1e2");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Dekajoulepercubicmeterkelvin, "x * 1e1");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin, "x * 1e0");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Decijoulepercubicmeterkelvin, "x * 1e-1");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Centijoulepercubicmeterkelvin, "x * 1e-2");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Millijoulepercubicmeterkelvin, "x * 1e-3");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Microjoulepercubicmeterkelvin, "x * 1e-6");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Nanojoulepercubicmeterkelvin, "x * 1e-9");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Picojoulepercubicmeterkelvin, "x * 1e-12");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Femtojoulepercubicmeterkelvin, "x * 1e-15");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Attojoulepercubicmeterkelvin, "x * 1e-18");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Zeptojoulepercubicmeterkelvin, "x * 1e-21");
                ConversionFunctions.Add(VolumetricHeatCapacityUnit.Yoctojoulepercubicmeterkelvin, "x * 1e-24");
            }
        }
    }
