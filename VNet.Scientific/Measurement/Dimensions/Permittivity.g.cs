
    // Auto-generated for VNet on 2023-07-05 10:24:46
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
