
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MassFlow<TVal> : DimensionBase<MassFlowUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MassFlow<TVal>);
            
            public MassFlow() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 1;
                Exponents.Time = -1;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = MassFlowUnit.GramPerSecond;
                
                Symbols.Add(MassFlowUnit.GramPerDay, "g/d");
                Symbols.Add(MassFlowUnit.GramPerHour, "g/h");
                Symbols.Add(MassFlowUnit.KilogramPerHour, "kg/h");
                Symbols.Add(MassFlowUnit.KilogramPerMinute, "kg/min");
                Symbols.Add(MassFlowUnit.TonnePerHour, "t/h");
                Symbols.Add(MassFlowUnit.PoundPerDay, "lb/d");
                Symbols.Add(MassFlowUnit.PoundPerHour, "lb/h");
                Symbols.Add(MassFlowUnit.PoundPerMinute, "lb/min");
                Symbols.Add(MassFlowUnit.PoundPerSecond, "lb/s");
                Symbols.Add(MassFlowUnit.TonnePerDay, "t/d");
                Symbols.Add(MassFlowUnit.ShortTonPerHour, "short tn/h");
                Symbols.Add(MassFlowUnit.Yottagrampersecond, "Yg/s");
                Symbols.Add(MassFlowUnit.Zettagrampersecond, "Zg/s");
                Symbols.Add(MassFlowUnit.Exagrampersecond, "Eg/s");
                Symbols.Add(MassFlowUnit.Petagrampersecond, "Pg/s");
                Symbols.Add(MassFlowUnit.Teragrampersecond, "Tg/s");
                Symbols.Add(MassFlowUnit.Gigagrampersecond, "Gg/s");
                Symbols.Add(MassFlowUnit.Megagrampersecond, "Mg/s");
                Symbols.Add(MassFlowUnit.Kilogrampersecond, "kg/s");
                Symbols.Add(MassFlowUnit.Hectogrampersecond, "hg/s");
                Symbols.Add(MassFlowUnit.Dekagrampersecond, "dag/s");
                Symbols.Add(MassFlowUnit.GramPerSecond, "g/s");
                Symbols.Add(MassFlowUnit.Decigrampersecond, "dg/s");
                Symbols.Add(MassFlowUnit.Centigrampersecond, "cg/s");
                Symbols.Add(MassFlowUnit.Milligrampersecond, "mg/s");
                Symbols.Add(MassFlowUnit.Microgrampersecond, "µg/s");
                Symbols.Add(MassFlowUnit.Nanogrampersecond, "ng/s");
                Symbols.Add(MassFlowUnit.Picogrampersecond, "pg/s");
                Symbols.Add(MassFlowUnit.Femtogrampersecond, "fg/s");
                Symbols.Add(MassFlowUnit.Attogrampersecond, "ag/s");
                Symbols.Add(MassFlowUnit.Zeptogrampersecond, "zg/s");
                Symbols.Add(MassFlowUnit.Yoctogrampersecond, "yg/s");
                
                PluralSymbols.Add(MassFlowUnit.Yottagrampersecond, "Yg/S");
                PluralSymbols.Add(MassFlowUnit.Zettagrampersecond, "Zg/S");
                PluralSymbols.Add(MassFlowUnit.Exagrampersecond, "Eg/S");
                PluralSymbols.Add(MassFlowUnit.Petagrampersecond, "Pg/S");
                PluralSymbols.Add(MassFlowUnit.Teragrampersecond, "Tg/S");
                PluralSymbols.Add(MassFlowUnit.Gigagrampersecond, "Gg/S");
                PluralSymbols.Add(MassFlowUnit.Megagrampersecond, "Mg/S");
                PluralSymbols.Add(MassFlowUnit.Kilogrampersecond, "kg/S");
                PluralSymbols.Add(MassFlowUnit.Hectogrampersecond, "hg/S");
                PluralSymbols.Add(MassFlowUnit.Dekagrampersecond, "dag/S");
                PluralSymbols.Add(MassFlowUnit.GramPerSecond, "g/S");
                PluralSymbols.Add(MassFlowUnit.Decigrampersecond, "dg/S");
                PluralSymbols.Add(MassFlowUnit.Centigrampersecond, "cg/S");
                PluralSymbols.Add(MassFlowUnit.Milligrampersecond, "mg/S");
                PluralSymbols.Add(MassFlowUnit.Microgrampersecond, "µg/S");
                PluralSymbols.Add(MassFlowUnit.Nanogrampersecond, "ng/S");
                PluralSymbols.Add(MassFlowUnit.Picogrampersecond, "pg/S");
                PluralSymbols.Add(MassFlowUnit.Femtogrampersecond, "fg/S");
                PluralSymbols.Add(MassFlowUnit.Attogrampersecond, "ag/S");
                PluralSymbols.Add(MassFlowUnit.Zeptogrampersecond, "zg/S");
                PluralSymbols.Add(MassFlowUnit.Yoctogrampersecond, "yg/S");
                
                ConversionFunctions.Add(MassFlowUnit.GramPerDay, "x / 86400");
                ConversionFunctions.Add(MassFlowUnit.GramPerHour, "x / 3600");
                ConversionFunctions.Add(MassFlowUnit.KilogramPerHour, "x / 3.6");
                ConversionFunctions.Add(MassFlowUnit.KilogramPerMinute, "x / 0.06");
                ConversionFunctions.Add(MassFlowUnit.TonnePerHour, "1000 * x / 3.6");
                ConversionFunctions.Add(MassFlowUnit.PoundPerDay, "x / 190.47936");
                ConversionFunctions.Add(MassFlowUnit.PoundPerHour, "x / 7.93664");
                ConversionFunctions.Add(MassFlowUnit.PoundPerMinute, "x / 0.132277");
                ConversionFunctions.Add(MassFlowUnit.PoundPerSecond, "x * 453.59237");
                ConversionFunctions.Add(MassFlowUnit.TonnePerDay, "x / 0.0864000");
                ConversionFunctions.Add(MassFlowUnit.ShortTonPerHour, "x * 251.9957611");
                ConversionFunctions.Add(MassFlowUnit.Yottagrampersecond, "x * 1e24");
                ConversionFunctions.Add(MassFlowUnit.Zettagrampersecond, "x * 1e21");
                ConversionFunctions.Add(MassFlowUnit.Exagrampersecond, "x * 1e18");
                ConversionFunctions.Add(MassFlowUnit.Petagrampersecond, "x * 1e15");
                ConversionFunctions.Add(MassFlowUnit.Teragrampersecond, "x * 1e12");
                ConversionFunctions.Add(MassFlowUnit.Gigagrampersecond, "x * 1e9");
                ConversionFunctions.Add(MassFlowUnit.Megagrampersecond, "x * 1e6");
                ConversionFunctions.Add(MassFlowUnit.Kilogrampersecond, "x * 1e3");
                ConversionFunctions.Add(MassFlowUnit.Hectogrampersecond, "x * 1e2");
                ConversionFunctions.Add(MassFlowUnit.Dekagrampersecond, "x * 1e1");
                ConversionFunctions.Add(MassFlowUnit.GramPerSecond, "x * 1e0");
                ConversionFunctions.Add(MassFlowUnit.Decigrampersecond, "x * 1e-1");
                ConversionFunctions.Add(MassFlowUnit.Centigrampersecond, "x * 1e-2");
                ConversionFunctions.Add(MassFlowUnit.Milligrampersecond, "x * 1e-3");
                ConversionFunctions.Add(MassFlowUnit.Microgrampersecond, "x * 1e-6");
                ConversionFunctions.Add(MassFlowUnit.Nanogrampersecond, "x * 1e-9");
                ConversionFunctions.Add(MassFlowUnit.Picogrampersecond, "x * 1e-12");
                ConversionFunctions.Add(MassFlowUnit.Femtogrampersecond, "x * 1e-15");
                ConversionFunctions.Add(MassFlowUnit.Attogrampersecond, "x * 1e-18");
                ConversionFunctions.Add(MassFlowUnit.Zeptogrampersecond, "x * 1e-21");
                ConversionFunctions.Add(MassFlowUnit.Yoctogrampersecond, "x * 1e-24");
            }
        }
    }
