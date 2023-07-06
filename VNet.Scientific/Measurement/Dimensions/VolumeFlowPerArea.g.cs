
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class VolumeFlowPerArea<TVal> : DimensionBase<VolumeFlowPerAreaUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(VolumeFlowPerArea<TVal>);
            
            public VolumeFlowPerArea() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter;
                
                Symbols.Add(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, "CFM/ft²");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicYottameterpersecondpersquaremeter, "Ym³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicZettameterpersecondpersquaremeter, "Zm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicExameterpersecondpersquaremeter, "Em³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicPetameterpersecondpersquaremeter, "Pm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicTerameterpersecondpersquaremeter, "Tm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicGigameterpersecondpersquaremeter, "Gm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicMegameterpersecondpersquaremeter, "Mm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicKilometerpersecondpersquaremeter, "km³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicHectometerpersecondpersquaremeter, "hm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicDekameterpersecondpersquaremeter, "dam³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, "m³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicDecimeterpersecondpersquaremeter, "dm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicCentimeterpersecondpersquaremeter, "cm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicMillimeterpersecondpersquaremeter, "mm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicMicrometerpersecondpersquaremeter, "µm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicNanometerpersecondpersquaremeter, "nm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicPicometerpersecondpersquaremeter, "pm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicFemtometerpersecondpersquaremeter, "fm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicAttometerpersecondpersquaremeter, "am³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicZeptometerpersecondpersquaremeter, "zm³/(s·m²)");
                Symbols.Add(VolumeFlowPerAreaUnit.CubicYoctometerpersecondpersquaremeter, "ym³/(s·m²)");
                
                
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, "x / 196.850394");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicYottameterpersecondpersquaremeter, "x * 1e72");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicZettameterpersecondpersquaremeter, "x * 1e63");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicExameterpersecondpersquaremeter, "x * 1e54");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicPetameterpersecondpersquaremeter, "x * 1e45");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicTerameterpersecondpersquaremeter, "x * 1e36");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicGigameterpersecondpersquaremeter, "x * 1e27");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicMegameterpersecondpersquaremeter, "x * 1e18");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicKilometerpersecondpersquaremeter, "x * 1e9");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicHectometerpersecondpersquaremeter, "x * 1e6");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicDekameterpersecondpersquaremeter, "x * 1e3");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, "x * 1e0");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicDecimeterpersecondpersquaremeter, "x * 1e-3");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicCentimeterpersecondpersquaremeter, "x * 1e-6");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicMillimeterpersecondpersquaremeter, "x * 1e-9");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicMicrometerpersecondpersquaremeter, "x * 1e-18");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicNanometerpersecondpersquaremeter, "x * 1e-27");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicPicometerpersecondpersquaremeter, "x * 1e-36");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicFemtometerpersecondpersquaremeter, "x * 1e-45");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicAttometerpersecondpersquaremeter, "x * 1e-54");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicZeptometerpersecondpersquaremeter, "x * 1e-63");
                ConversionFunctions.Add(VolumeFlowPerAreaUnit.CubicYoctometerpersecondpersquaremeter, "x * 1e-72");
            }
        }
    }
