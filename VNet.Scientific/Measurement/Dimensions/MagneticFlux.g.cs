
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MagneticFlux<TVal> : DimensionBase<MagneticFluxUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MagneticFlux<TVal>);
            
            public MagneticFlux() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = -1;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = MagneticFluxUnit.Weber;
                
                Symbols.Add(MagneticFluxUnit.Yottaweber, "YWb");
                Symbols.Add(MagneticFluxUnit.Zettaweber, "ZWb");
                Symbols.Add(MagneticFluxUnit.Exaweber, "EWb");
                Symbols.Add(MagneticFluxUnit.Petaweber, "PWb");
                Symbols.Add(MagneticFluxUnit.Teraweber, "TWb");
                Symbols.Add(MagneticFluxUnit.Gigaweber, "GWb");
                Symbols.Add(MagneticFluxUnit.Megaweber, "MWb");
                Symbols.Add(MagneticFluxUnit.Kiloweber, "kWb");
                Symbols.Add(MagneticFluxUnit.Hectoweber, "hWb");
                Symbols.Add(MagneticFluxUnit.Dekaweber, "daWb");
                Symbols.Add(MagneticFluxUnit.Weber, "Wb");
                Symbols.Add(MagneticFluxUnit.Deciweber, "dWb");
                Symbols.Add(MagneticFluxUnit.Centiweber, "cWb");
                Symbols.Add(MagneticFluxUnit.Milliweber, "mWb");
                Symbols.Add(MagneticFluxUnit.Microweber, "µWb");
                Symbols.Add(MagneticFluxUnit.Nanoweber, "nWb");
                Symbols.Add(MagneticFluxUnit.Picoweber, "pWb");
                Symbols.Add(MagneticFluxUnit.Femtoweber, "fWb");
                Symbols.Add(MagneticFluxUnit.Attoweber, "aWb");
                Symbols.Add(MagneticFluxUnit.Zeptoweber, "zWb");
                Symbols.Add(MagneticFluxUnit.Yoctoweber, "yWb");
                
                
                ConversionFunctions.Add(MagneticFluxUnit.Yottaweber, "x * 1e24");
                ConversionFunctions.Add(MagneticFluxUnit.Zettaweber, "x * 1e21");
                ConversionFunctions.Add(MagneticFluxUnit.Exaweber, "x * 1e18");
                ConversionFunctions.Add(MagneticFluxUnit.Petaweber, "x * 1e15");
                ConversionFunctions.Add(MagneticFluxUnit.Teraweber, "x * 1e12");
                ConversionFunctions.Add(MagneticFluxUnit.Gigaweber, "x * 1e9");
                ConversionFunctions.Add(MagneticFluxUnit.Megaweber, "x * 1e6");
                ConversionFunctions.Add(MagneticFluxUnit.Kiloweber, "x * 1e3");
                ConversionFunctions.Add(MagneticFluxUnit.Hectoweber, "x * 1e2");
                ConversionFunctions.Add(MagneticFluxUnit.Dekaweber, "x * 1e1");
                ConversionFunctions.Add(MagneticFluxUnit.Weber, "x * 1e0");
                ConversionFunctions.Add(MagneticFluxUnit.Deciweber, "x * 1e-1");
                ConversionFunctions.Add(MagneticFluxUnit.Centiweber, "x * 1e-2");
                ConversionFunctions.Add(MagneticFluxUnit.Milliweber, "x * 1e-3");
                ConversionFunctions.Add(MagneticFluxUnit.Microweber, "x * 1e-6");
                ConversionFunctions.Add(MagneticFluxUnit.Nanoweber, "x * 1e-9");
                ConversionFunctions.Add(MagneticFluxUnit.Picoweber, "x * 1e-12");
                ConversionFunctions.Add(MagneticFluxUnit.Femtoweber, "x * 1e-15");
                ConversionFunctions.Add(MagneticFluxUnit.Attoweber, "x * 1e-18");
                ConversionFunctions.Add(MagneticFluxUnit.Zeptoweber, "x * 1e-21");
                ConversionFunctions.Add(MagneticFluxUnit.Yoctoweber, "x * 1e-24");
            }
        }
    }
