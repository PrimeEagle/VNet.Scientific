
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MagneticField<TVal> : DimensionBase<MagneticFieldUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MagneticField<TVal>);
            
            public MagneticField() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = -1;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = MagneticFieldUnit.Tesla;
                
                Symbols.Add(MagneticFieldUnit.Gauss, "G");
                Symbols.Add(MagneticFieldUnit.Yottatesla, "YT");
                Symbols.Add(MagneticFieldUnit.Zettatesla, "ZT");
                Symbols.Add(MagneticFieldUnit.Exatesla, "ET");
                Symbols.Add(MagneticFieldUnit.Petatesla, "PT");
                Symbols.Add(MagneticFieldUnit.Teratesla, "TT");
                Symbols.Add(MagneticFieldUnit.Gigatesla, "GT");
                Symbols.Add(MagneticFieldUnit.Megatesla, "MT");
                Symbols.Add(MagneticFieldUnit.Kilotesla, "kT");
                Symbols.Add(MagneticFieldUnit.Hectotesla, "hT");
                Symbols.Add(MagneticFieldUnit.Dekatesla, "daT");
                Symbols.Add(MagneticFieldUnit.Tesla, "T");
                Symbols.Add(MagneticFieldUnit.Decitesla, "dT");
                Symbols.Add(MagneticFieldUnit.Centitesla, "cT");
                Symbols.Add(MagneticFieldUnit.Millitesla, "mT");
                Symbols.Add(MagneticFieldUnit.Microtesla, "µT");
                Symbols.Add(MagneticFieldUnit.Nanotesla, "nT");
                Symbols.Add(MagneticFieldUnit.Picotesla, "pT");
                Symbols.Add(MagneticFieldUnit.Femtotesla, "fT");
                Symbols.Add(MagneticFieldUnit.Attotesla, "aT");
                Symbols.Add(MagneticFieldUnit.Zeptotesla, "zT");
                Symbols.Add(MagneticFieldUnit.Yoctotesla, "yT");
                
                
                ConversionFunctions.Add(MagneticFieldUnit.Gauss, "x / 1e4");
                ConversionFunctions.Add(MagneticFieldUnit.Yottatesla, "x * 1e24");
                ConversionFunctions.Add(MagneticFieldUnit.Zettatesla, "x * 1e21");
                ConversionFunctions.Add(MagneticFieldUnit.Exatesla, "x * 1e18");
                ConversionFunctions.Add(MagneticFieldUnit.Petatesla, "x * 1e15");
                ConversionFunctions.Add(MagneticFieldUnit.Teratesla, "x * 1e12");
                ConversionFunctions.Add(MagneticFieldUnit.Gigatesla, "x * 1e9");
                ConversionFunctions.Add(MagneticFieldUnit.Megatesla, "x * 1e6");
                ConversionFunctions.Add(MagneticFieldUnit.Kilotesla, "x * 1e3");
                ConversionFunctions.Add(MagneticFieldUnit.Hectotesla, "x * 1e2");
                ConversionFunctions.Add(MagneticFieldUnit.Dekatesla, "x * 1e1");
                ConversionFunctions.Add(MagneticFieldUnit.Tesla, "x * 1e0");
                ConversionFunctions.Add(MagneticFieldUnit.Decitesla, "x * 1e-1");
                ConversionFunctions.Add(MagneticFieldUnit.Centitesla, "x * 1e-2");
                ConversionFunctions.Add(MagneticFieldUnit.Millitesla, "x * 1e-3");
                ConversionFunctions.Add(MagneticFieldUnit.Microtesla, "x * 1e-6");
                ConversionFunctions.Add(MagneticFieldUnit.Nanotesla, "x * 1e-9");
                ConversionFunctions.Add(MagneticFieldUnit.Picotesla, "x * 1e-12");
                ConversionFunctions.Add(MagneticFieldUnit.Femtotesla, "x * 1e-15");
                ConversionFunctions.Add(MagneticFieldUnit.Attotesla, "x * 1e-18");
                ConversionFunctions.Add(MagneticFieldUnit.Zeptotesla, "x * 1e-21");
                ConversionFunctions.Add(MagneticFieldUnit.Yoctotesla, "x * 1e-24");
            }
        }
    }
