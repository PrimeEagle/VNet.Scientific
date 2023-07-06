
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class DynamicViscosity<TVal> : DimensionBase<DynamicViscosityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(DynamicViscosity<TVal>);
            
            public DynamicViscosity() : base()
            {
                DimensionComponent.Exponents.Length = -1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = DynamicViscosityUnit.NewtonSecondPerMeterSquared;
                
                Symbols.Add(DynamicViscosityUnit.PascalSecond, "Pa·s");
                Symbols.Add(DynamicViscosityUnit.Poise, "P");
                Symbols.Add(DynamicViscosityUnit.Reyn, "reyn");
                Symbols.Add(DynamicViscosityUnit.PoundForceSecondPerSquareInch, "lbf·s/in²");
                Symbols.Add(DynamicViscosityUnit.PoundForceSecondPerSquareFoot, "lbf·s/ft²");
                Symbols.Add(DynamicViscosityUnit.PoundPerFootSecond, "lb/ft·s");
                Symbols.Add(DynamicViscosityUnit.Yottanewtonsecondpermetersquared, "YNs/m²");
                Symbols.Add(DynamicViscosityUnit.Zettanewtonsecondpermetersquared, "ZNs/m²");
                Symbols.Add(DynamicViscosityUnit.Exanewtonsecondpermetersquared, "ENs/m²");
                Symbols.Add(DynamicViscosityUnit.Petanewtonsecondpermetersquared, "PNs/m²");
                Symbols.Add(DynamicViscosityUnit.Teranewtonsecondpermetersquared, "TNs/m²");
                Symbols.Add(DynamicViscosityUnit.Giganewtonsecondpermetersquared, "GNs/m²");
                Symbols.Add(DynamicViscosityUnit.Meganewtonsecondpermetersquared, "MNs/m²");
                Symbols.Add(DynamicViscosityUnit.Kilonewtonsecondpermetersquared, "kNs/m²");
                Symbols.Add(DynamicViscosityUnit.Hectonewtonsecondpermetersquared, "hNs/m²");
                Symbols.Add(DynamicViscosityUnit.Dekanewtonsecondpermetersquared, "daNs/m²");
                Symbols.Add(DynamicViscosityUnit.NewtonSecondPerMeterSquared, "Ns/m²");
                Symbols.Add(DynamicViscosityUnit.Decinewtonsecondpermetersquared, "dNs/m²");
                Symbols.Add(DynamicViscosityUnit.Centinewtonsecondpermetersquared, "cNs/m²");
                Symbols.Add(DynamicViscosityUnit.Millinewtonsecondpermetersquared, "mNs/m²");
                Symbols.Add(DynamicViscosityUnit.Micronewtonsecondpermetersquared, "µNs/m²");
                Symbols.Add(DynamicViscosityUnit.Nanonewtonsecondpermetersquared, "nNs/m²");
                Symbols.Add(DynamicViscosityUnit.Piconewtonsecondpermetersquared, "pNs/m²");
                Symbols.Add(DynamicViscosityUnit.Femtonewtonsecondpermetersquared, "fNs/m²");
                Symbols.Add(DynamicViscosityUnit.Attonewtonsecondpermetersquared, "aNs/m²");
                Symbols.Add(DynamicViscosityUnit.Zeptonewtonsecondpermetersquared, "zNs/m²");
                Symbols.Add(DynamicViscosityUnit.Yoctonewtonsecondpermetersquared, "yNs/m²");
                
                PluralSymbols.Add(DynamicViscosityUnit.PascalSecond, "PaS");
                
                ConversionFunctions.Add(DynamicViscosityUnit.PascalSecond, "x");
                ConversionFunctions.Add(DynamicViscosityUnit.Poise, "x / 10");
                ConversionFunctions.Add(DynamicViscosityUnit.Reyn, "x * 6.8947572931683613e3");
                ConversionFunctions.Add(DynamicViscosityUnit.PoundForceSecondPerSquareInch, "x * 6.8947572931683613e3");
                ConversionFunctions.Add(DynamicViscosityUnit.PoundForceSecondPerSquareFoot, "x * 4.7880258980335843e1");
                ConversionFunctions.Add(DynamicViscosityUnit.PoundPerFootSecond, "x * 1.4881639");
                ConversionFunctions.Add(DynamicViscosityUnit.Yottanewtonsecondpermetersquared, "x * 1e24");
                ConversionFunctions.Add(DynamicViscosityUnit.Zettanewtonsecondpermetersquared, "x * 1e21");
                ConversionFunctions.Add(DynamicViscosityUnit.Exanewtonsecondpermetersquared, "x * 1e18");
                ConversionFunctions.Add(DynamicViscosityUnit.Petanewtonsecondpermetersquared, "x * 1e15");
                ConversionFunctions.Add(DynamicViscosityUnit.Teranewtonsecondpermetersquared, "x * 1e12");
                ConversionFunctions.Add(DynamicViscosityUnit.Giganewtonsecondpermetersquared, "x * 1e9");
                ConversionFunctions.Add(DynamicViscosityUnit.Meganewtonsecondpermetersquared, "x * 1e6");
                ConversionFunctions.Add(DynamicViscosityUnit.Kilonewtonsecondpermetersquared, "x * 1e3");
                ConversionFunctions.Add(DynamicViscosityUnit.Hectonewtonsecondpermetersquared, "x * 1e2");
                ConversionFunctions.Add(DynamicViscosityUnit.Dekanewtonsecondpermetersquared, "x * 1e1");
                ConversionFunctions.Add(DynamicViscosityUnit.NewtonSecondPerMeterSquared, "x * 1e0");
                ConversionFunctions.Add(DynamicViscosityUnit.Decinewtonsecondpermetersquared, "x * 1e-1");
                ConversionFunctions.Add(DynamicViscosityUnit.Centinewtonsecondpermetersquared, "x * 1e-2");
                ConversionFunctions.Add(DynamicViscosityUnit.Millinewtonsecondpermetersquared, "x * 1e-3");
                ConversionFunctions.Add(DynamicViscosityUnit.Micronewtonsecondpermetersquared, "x * 1e-6");
                ConversionFunctions.Add(DynamicViscosityUnit.Nanonewtonsecondpermetersquared, "x * 1e-9");
                ConversionFunctions.Add(DynamicViscosityUnit.Piconewtonsecondpermetersquared, "x * 1e-12");
                ConversionFunctions.Add(DynamicViscosityUnit.Femtonewtonsecondpermetersquared, "x * 1e-15");
                ConversionFunctions.Add(DynamicViscosityUnit.Attonewtonsecondpermetersquared, "x * 1e-18");
                ConversionFunctions.Add(DynamicViscosityUnit.Zeptonewtonsecondpermetersquared, "x * 1e-21");
                ConversionFunctions.Add(DynamicViscosityUnit.Yoctonewtonsecondpermetersquared, "x * 1e-24");
            }
        }
    }
