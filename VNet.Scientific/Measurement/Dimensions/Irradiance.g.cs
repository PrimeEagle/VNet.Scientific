
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Irradiance<TVal> : DimensionBase<IrradianceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Irradiance<TVal>);
            
            public Irradiance() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 1;
                Exponents.Time = -3;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = IrradianceUnit.WattPerSquareMeter;
                
                Symbols.Add(IrradianceUnit.WattPerSquareCentimeter, "W/cm²");
                Symbols.Add(IrradianceUnit.Yottawattpersquaremeter, "YW/m²");
                Symbols.Add(IrradianceUnit.Zettawattpersquaremeter, "ZW/m²");
                Symbols.Add(IrradianceUnit.Exawattpersquaremeter, "EW/m²");
                Symbols.Add(IrradianceUnit.Petawattpersquaremeter, "PW/m²");
                Symbols.Add(IrradianceUnit.Terawattpersquaremeter, "TW/m²");
                Symbols.Add(IrradianceUnit.Gigawattpersquaremeter, "GW/m²");
                Symbols.Add(IrradianceUnit.Megawattpersquaremeter, "MW/m²");
                Symbols.Add(IrradianceUnit.Kilowattpersquaremeter, "kW/m²");
                Symbols.Add(IrradianceUnit.Hectowattpersquaremeter, "hW/m²");
                Symbols.Add(IrradianceUnit.Dekawattpersquaremeter, "daW/m²");
                Symbols.Add(IrradianceUnit.WattPerSquareMeter, "W/m²");
                Symbols.Add(IrradianceUnit.Deciwattpersquaremeter, "dW/m²");
                Symbols.Add(IrradianceUnit.Centiwattpersquaremeter, "cW/m²");
                Symbols.Add(IrradianceUnit.Milliwattpersquaremeter, "mW/m²");
                Symbols.Add(IrradianceUnit.Microwattpersquaremeter, "µW/m²");
                Symbols.Add(IrradianceUnit.Nanowattpersquaremeter, "nW/m²");
                Symbols.Add(IrradianceUnit.Picowattpersquaremeter, "pW/m²");
                Symbols.Add(IrradianceUnit.Femtowattpersquaremeter, "fW/m²");
                Symbols.Add(IrradianceUnit.Attowattpersquaremeter, "aW/m²");
                Symbols.Add(IrradianceUnit.Zeptowattpersquaremeter, "zW/m²");
                Symbols.Add(IrradianceUnit.Yoctowattpersquaremeter, "yW/m²");
                
                
                ConversionFunctions.Add(IrradianceUnit.WattPerSquareCentimeter, "x * 10000");
                ConversionFunctions.Add(IrradianceUnit.Yottawattpersquaremeter, "x * 1e24");
                ConversionFunctions.Add(IrradianceUnit.Zettawattpersquaremeter, "x * 1e21");
                ConversionFunctions.Add(IrradianceUnit.Exawattpersquaremeter, "x * 1e18");
                ConversionFunctions.Add(IrradianceUnit.Petawattpersquaremeter, "x * 1e15");
                ConversionFunctions.Add(IrradianceUnit.Terawattpersquaremeter, "x * 1e12");
                ConversionFunctions.Add(IrradianceUnit.Gigawattpersquaremeter, "x * 1e9");
                ConversionFunctions.Add(IrradianceUnit.Megawattpersquaremeter, "x * 1e6");
                ConversionFunctions.Add(IrradianceUnit.Kilowattpersquaremeter, "x * 1e3");
                ConversionFunctions.Add(IrradianceUnit.Hectowattpersquaremeter, "x * 1e2");
                ConversionFunctions.Add(IrradianceUnit.Dekawattpersquaremeter, "x * 1e1");
                ConversionFunctions.Add(IrradianceUnit.WattPerSquareMeter, "x * 1e0");
                ConversionFunctions.Add(IrradianceUnit.Deciwattpersquaremeter, "x * 1e-1");
                ConversionFunctions.Add(IrradianceUnit.Centiwattpersquaremeter, "x * 1e-2");
                ConversionFunctions.Add(IrradianceUnit.Milliwattpersquaremeter, "x * 1e-3");
                ConversionFunctions.Add(IrradianceUnit.Microwattpersquaremeter, "x * 1e-6");
                ConversionFunctions.Add(IrradianceUnit.Nanowattpersquaremeter, "x * 1e-9");
                ConversionFunctions.Add(IrradianceUnit.Picowattpersquaremeter, "x * 1e-12");
                ConversionFunctions.Add(IrradianceUnit.Femtowattpersquaremeter, "x * 1e-15");
                ConversionFunctions.Add(IrradianceUnit.Attowattpersquaremeter, "x * 1e-18");
                ConversionFunctions.Add(IrradianceUnit.Zeptowattpersquaremeter, "x * 1e-21");
                ConversionFunctions.Add(IrradianceUnit.Yoctowattpersquaremeter, "x * 1e-24");
            }
        }
    }
