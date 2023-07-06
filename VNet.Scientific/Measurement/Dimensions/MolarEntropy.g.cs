
    // Auto-generated for VNet on 2023-07-05 10:24:46
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MolarEntropy<TVal> : DimensionBase<MolarEntropyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MolarEntropy<TVal>);
            
            public MolarEntropy() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = -1;
                DimensionComponent.Exponents.Amount = -1;
                
                DefaultUnit = MolarEntropyUnit.JoulePerMoleKelvin;
                
                
                ConversionFunctions.Add(MolarEntropyUnit.Yottajoulepermolekelvin, "x * 1e24");
                ConversionFunctions.Add(MolarEntropyUnit.Zettajoulepermolekelvin, "x * 1e21");
                ConversionFunctions.Add(MolarEntropyUnit.Exajoulepermolekelvin, "x * 1e18");
                ConversionFunctions.Add(MolarEntropyUnit.Petajoulepermolekelvin, "x * 1e15");
                ConversionFunctions.Add(MolarEntropyUnit.Terajoulepermolekelvin, "x * 1e12");
                ConversionFunctions.Add(MolarEntropyUnit.Gigajoulepermolekelvin, "x * 1e9");
                ConversionFunctions.Add(MolarEntropyUnit.Megajoulepermolekelvin, "x * 1e6");
                ConversionFunctions.Add(MolarEntropyUnit.Kilojoulepermolekelvin, "x * 1e3");
                ConversionFunctions.Add(MolarEntropyUnit.Hectojoulepermolekelvin, "x * 1e2");
                ConversionFunctions.Add(MolarEntropyUnit.Dekajoulepermolekelvin, "x * 1e1");
                ConversionFunctions.Add(MolarEntropyUnit.JoulePerMoleKelvin, "x * 1e0");
                ConversionFunctions.Add(MolarEntropyUnit.Decijoulepermolekelvin, "x * 1e-1");
                ConversionFunctions.Add(MolarEntropyUnit.Centijoulepermolekelvin, "x * 1e-2");
                ConversionFunctions.Add(MolarEntropyUnit.Millijoulepermolekelvin, "x * 1e-3");
                ConversionFunctions.Add(MolarEntropyUnit.Microjoulepermolekelvin, "x * 1e-6");
                ConversionFunctions.Add(MolarEntropyUnit.Nanojoulepermolekelvin, "x * 1e-9");
                ConversionFunctions.Add(MolarEntropyUnit.Picojoulepermolekelvin, "x * 1e-12");
                ConversionFunctions.Add(MolarEntropyUnit.Femtojoulepermolekelvin, "x * 1e-15");
                ConversionFunctions.Add(MolarEntropyUnit.Attojoulepermolekelvin, "x * 1e-18");
                ConversionFunctions.Add(MolarEntropyUnit.Zeptojoulepermolekelvin, "x * 1e-21");
                ConversionFunctions.Add(MolarEntropyUnit.Yoctojoulepermolekelvin, "x * 1e-24");
            }
        }
    }
