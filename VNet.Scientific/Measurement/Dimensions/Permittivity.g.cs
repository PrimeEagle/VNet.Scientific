
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Permittivity<TVal> : DimensionBase<PermittivityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Permittivity<TVal>);
            
            public Permittivity() : base()
            {
                DimensionComponent.Exponents.Length = -3;
                DimensionComponent.Exponents.Mass = -1;
                DimensionComponent.Exponents.Time = 4;
                DimensionComponent.Exponents.ElectricalCurrent = 2;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = PermittivityUnit.FaradPerMeter;
                
                Symbols.Add(PermittivityUnit.Yottafaradpermeter, "YF/m");
                Symbols.Add(PermittivityUnit.Zettafaradpermeter, "ZF/m");
                Symbols.Add(PermittivityUnit.Exafaradpermeter, "EF/m");
                Symbols.Add(PermittivityUnit.Petafaradpermeter, "PF/m");
                Symbols.Add(PermittivityUnit.Terafaradpermeter, "TF/m");
                Symbols.Add(PermittivityUnit.Gigafaradpermeter, "GF/m");
                Symbols.Add(PermittivityUnit.Megafaradpermeter, "MF/m");
                Symbols.Add(PermittivityUnit.Kilofaradpermeter, "kF/m");
                Symbols.Add(PermittivityUnit.Hectofaradpermeter, "hF/m");
                Symbols.Add(PermittivityUnit.Dekafaradpermeter, "daF/m");
                Symbols.Add(PermittivityUnit.FaradPerMeter, "F/m");
                Symbols.Add(PermittivityUnit.Decifaradpermeter, "dF/m");
                Symbols.Add(PermittivityUnit.Centifaradpermeter, "cF/m");
                Symbols.Add(PermittivityUnit.Millifaradpermeter, "mF/m");
                Symbols.Add(PermittivityUnit.Microfaradpermeter, "µF/m");
                Symbols.Add(PermittivityUnit.Nanofaradpermeter, "nF/m");
                Symbols.Add(PermittivityUnit.Picofaradpermeter, "pF/m");
                Symbols.Add(PermittivityUnit.Femtofaradpermeter, "fF/m");
                Symbols.Add(PermittivityUnit.Attofaradpermeter, "aF/m");
                Symbols.Add(PermittivityUnit.Zeptofaradpermeter, "zF/m");
                Symbols.Add(PermittivityUnit.Yoctofaradpermeter, "yF/m");
                
                
                ConversionFunctions.Add(PermittivityUnit.Yottafaradpermeter, "x * 1e24");
                ConversionFunctions.Add(PermittivityUnit.Zettafaradpermeter, "x * 1e21");
                ConversionFunctions.Add(PermittivityUnit.Exafaradpermeter, "x * 1e18");
                ConversionFunctions.Add(PermittivityUnit.Petafaradpermeter, "x * 1e15");
                ConversionFunctions.Add(PermittivityUnit.Terafaradpermeter, "x * 1e12");
                ConversionFunctions.Add(PermittivityUnit.Gigafaradpermeter, "x * 1e9");
                ConversionFunctions.Add(PermittivityUnit.Megafaradpermeter, "x * 1e6");
                ConversionFunctions.Add(PermittivityUnit.Kilofaradpermeter, "x * 1e3");
                ConversionFunctions.Add(PermittivityUnit.Hectofaradpermeter, "x * 1e2");
                ConversionFunctions.Add(PermittivityUnit.Dekafaradpermeter, "x * 1e1");
                ConversionFunctions.Add(PermittivityUnit.FaradPerMeter, "x * 1e0");
                ConversionFunctions.Add(PermittivityUnit.Decifaradpermeter, "x * 1e-1");
                ConversionFunctions.Add(PermittivityUnit.Centifaradpermeter, "x * 1e-2");
                ConversionFunctions.Add(PermittivityUnit.Millifaradpermeter, "x * 1e-3");
                ConversionFunctions.Add(PermittivityUnit.Microfaradpermeter, "x * 1e-6");
                ConversionFunctions.Add(PermittivityUnit.Nanofaradpermeter, "x * 1e-9");
                ConversionFunctions.Add(PermittivityUnit.Picofaradpermeter, "x * 1e-12");
                ConversionFunctions.Add(PermittivityUnit.Femtofaradpermeter, "x * 1e-15");
                ConversionFunctions.Add(PermittivityUnit.Attofaradpermeter, "x * 1e-18");
                ConversionFunctions.Add(PermittivityUnit.Zeptofaradpermeter, "x * 1e-21");
                ConversionFunctions.Add(PermittivityUnit.Yoctofaradpermeter, "x * 1e-24");
            }
        }
    }
