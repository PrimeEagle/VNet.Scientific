// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Measurement;

public static partial class UnitDefinition
{
    public static readonly Dictionary<string, Tuple<float[], Enum>> Components = new()
    {
        {"Scalar", new Tuple<float[],Enum>
        (
            new float[]{ 0, 0, 0, 0, 0, 0, 0 },
            ScalarUnit.None
        )},
        {"Length", new Tuple<float[], Enum>
        (
            new float[]{ 1, 0, 0, 0, 0, 0, 0 },
            LengthUnit.Meter
        )},
        {"Mass", new Tuple<float[], Enum>
        (
            new float[]{ 0, 1, 0, 0, 0, 0, 0 },
            MassUnit.Gram
        )},
        {"Time", new Tuple<float[], Enum>
        (
            new float[]{ 0, 0, 1, 0, 0, 0, 0 },
            TimeUnit.Second
        )},
        {"ElectricalCurrent", new Tuple<float[], Enum>
        (
            new float[]{ 0, 0, 0, 1, 0, 0, 0 },
            ElectricalCurrentUnit.Amp
        )},
        {"LuminousIntensity", new Tuple<float[], Enum>
        (
            new float[]{ 0, 0, 0, 0, 1, 0, 0 },
            LengthUnit.Meter
        )},
        {"Temperature", new Tuple<float[], Enum>
        (
            new float[]{ 0, 0, 0, 0, 0, 1, 0 },
            LuminousIntensityUnit.Candela
        )},
        {"Amount", new Tuple<float[], Enum>
        (
            new float[]{ 0, 0, 0, 0, 0, 0, 1 },
            AmountUnit.Unit
        )},
//         { Dimension.Area, (new float[] { 2, 0, 0, 0, 0, 0, 0 }) },
//    { Dimension.Volume, (new float[] { 3, 0, 0, 0, 0, 0, 0 }) },
//    { Dimension.Speed, (new float[] { 1, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.Acceleration, (new float[] { 1, 0, -2, 0, 0, 0, 0 }) },
//    { Dimension.Force, (new float[] { 1, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.Pressure, (new float[] { -1, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.Energy, (new float[] { 2, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.Power, (new float[] { 2, 1, -3, 0, 0, 0, 0 }) },
//    { Dimension.ElectricCharge, (new float[] { 0, 0, 1, 1, 0, 0, 0 }) },
//    { Dimension.ElectricPotential, (new float[] { 2, 1, -3, -1, 0, 0, 0 }) },
//    { Dimension.ElectricResistance, (new float[] { 2, 1, -2, -2, 0, 0, 0 }) },
//    { Dimension.ElectricCurrentDensity, (new float[] { 0, 1, -3, 1, 0, 0, 0 }) },
//    { Dimension.MagneticFieldStrength, (new float[] { 0, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.Inductance, (new float[] { 2, 1, -2, -2, 0, 0, 0 }) },
//    { Dimension.CatalyticActivity, (new float[] { 0, 0, -1, 0, 0, 0, 1 }) },
//    { Dimension.Radioactivity, (new float[] { 0, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.SpecificVolume, (new float[] { -3, 0, 0, 0, 0, 0, 0 }) },
//    { Dimension.Density, (new float[] { -3, 1, 0, 0, 0, 0, 0 }) },
//    { Dimension.Torque, (new float[] { 2, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.DynamicViscosity, (new float[] { -1, 1, -1, 0, 0, 0, 0 }) },
//    { Dimension.KinematicViscosity, (new float[] { 2, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.ElectricConductance, (new float[] { -2, -1, 3, 2, 0, 0, 0 }) },
//    { Dimension.ElectricCapacitance, (new float[] { -2, -1, 4, 2, 0, 0, 0 }) },
//    { Dimension.MagneticFlux, (new float[] { 2, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.MagneticFluxDensity, (new float[] { 0, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.ElectricFieldPotential, (new float[] { 2, 1, -3, -1, 0, 0, 0 }) },
//    { Dimension.ElectricPotentialGradient, (new float[] { -2, -1, 3, 1, 0, 0, 0 }) },
//    { Dimension.ElectricChargeDensity, (new float[] { -3, -1, 1, 1, 0, 0, 0 }) },
//    { Dimension.MagneticSusceptibility, (new float[] { 0, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.MagneticFieldDensity, (new float[] { 0, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.MagneticFieldGradient, (new float[] { 0, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.MagneticFieldFluxDensity, (new float[] { 0, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.MagneticFieldFlux, (new float[] { 2, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.HeatTransferRate, (new float[] { 2, 1, -3, 0, 0, -1, 0 }) },
//    { Dimension.HeatTransferCoefficient, (new float[] { -1, 1, -3, 0, 0, -1, 0 }) },
//    { Dimension.ElectricChargeFlowRate, (new float[] { 0, 0, 1, 1, 0, 0, 0 }) },
//    { Dimension.MagneticSusceptibility, (new float[] { 0, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.MagneticFieldIntensity, (new float[] { 0, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.MagneticMoment, (new float[] { 0, 1, 0, 0, 0, 0, 0 }) },
//    { Dimension.MagneticFluxDensity, (new float[] { 0, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.ElectricFieldPotential, (new float[] { 2, 1, -3, -1, 0, 0, 0 }) },
//    { Dimension.ElectricPotentialGradient, (new float[] { -2, -1, 3, 1, 0, 0, 0 }) },
//    { Dimension.ElectricChargeDensity, (new float[] { -3, -1, 1, 1, 0, 0, 0 }) },
//    { Dimension.MagneticSusceptibility, (new float[] { 0, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.MagneticFieldDensity, (new float[] { 0, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.MagneticFieldGradient, (new float[] { 0, 1, -2, -1, 0, 0, 0 }) },
//    { Dimension.Momentum, (new float[] { 1, 1, -1, 0, 0, 0, 0 }) },
//    { Dimension.Impulse, (new float[] { 1, 1, -1, 0, 0, 0, 0 }) },
//    { Dimension.Jerk, (new float[] { 1, 0, -3, 0, 0, 0, 0 }) },
//    { Dimension.Snap, (new float[] { 1, 0, -4, 0, 0, 0, 0 }) },
//    { Dimension.Crackle, (new float[] { 1, 0, -5, 0, 0, 0, 0 }) },
//    { Dimension.Pop, (new float[] { 1, 0, -6, 0, 0, 0, 0 }) },
//    { Dimension.Density, (new float[] { -3, 1, 0, 0, 0, 0, 0 }) },
//    { Dimension.Pressure, (new float[] { -1, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.Viscosity, (new float[] { -1, 1, -1, 0, 0, 0, 0 }) },
//    { Dimension.ThermalConductivity, (new float[] { 1, 1, -3, 0, 0, -1, 0 }) },
//    { Dimension.HeatCapacity, (new float[] { 2, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.Entropy, (new float[] { 2, 1, -2, 0, 0, -1, 0 }) },
//    { Dimension.MomentOfForce, (new float[] { 2, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.RotationalSpeed, (new float[] { 0, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.Torque, (new float[] { 2, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.Power, (new float[] { 2, 1, -3, 0, 0, 0, 0 }) },
//    { Dimension.Pressure, (new float[] { -1, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.SpecificHeatCapacity, (new float[] { 2, 1, -2, 0, 0, -1, 0 }) },
//    { Dimension.ThermalExpansion, (new float[] { 0, 0, -1, 0, 0, -1, 0 }) },
//    { Dimension.MomentOfInertia, (new float[] { 2, 1, 0, 0, 0, 0, 0 }) },
//    { Dimension.TorquePerAngle, (new float[] { 2, 1, -2, 0, 0, 0, 0 }, new float[] { 0, 0, 0, 0, 0, 0, 1 }) },
//    { Dimension.Stiffness, (new float[] { -1, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.SpringConstant, (new float[] { -1, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.Thrust, (new float[] { 1, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.Drag, (new float[] { 1, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.Lift, (new float[] { 1, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.AngularVelocity, (new float[] { 0, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.AngularAcceleration, (new float[] { 0, 0, -2, 0, 0, 0, 0 }) },
//    { Dimension.OrbitalPeriod, (new float[] { 0, 0, 1, 0, 0, 0, 0 }) },
//    { Dimension.Action, (new float[] { 2, 1, -1, 0, 0, 0, 0 }) },
//    { Dimension.PlankConstant, (new float[] { 2, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.Frequency, (new float[] { 0, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.Wavenumber, (new float[] { -1, 0, 1, 0, 0, 0, 0 }) },
//    { Dimension.AngularMomentum, (new float[] { 2, 1, -1, 0, 0, 0, 0 }) },
//    { Dimension.Frequency, (new float[] { 0, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.Amplitude, (new float[] { 0, 1, 0, 0, 0, 0, 0 }) },
//    { Dimension.Phase, (new float[] { 0, 0, 0, 0, 0, 0, 0 }) },
//    { Dimension.SignalPower, (new float[] { 2, 1, -3, 0, 0, 0, 0 }) },
//    { Dimension.SignalEnergy, (new float[] { 2, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.SignalToNoiseRatio, (new float[] { 0, 0, 0, 0, 0, 0, 0 }) },
//    { Dimension.SpectralDensity, (new float[] { -1, 1, 0, 0, 0, 0, 0 }) },
//    { Dimension.Bandwidth, (new float[] { -1, 0, 1, 0, 0, 0, 0 }) },
//    { Dimension.FilterGain, (new float[] { 0, 0, 0, 0, 0, 0, 0 }) },
//    { Dimension.Delay, (new float[] { 0, 0, 1, 0, 0, 0, 0 }) },
//    { Dimension.Distortion, (new float[] { 0, 0, 0, 0, 0, 0, 0 }) },
//    { Dimension.BloodPressure, (new float[] { -1, 1, -2, 0, 0, 0, 0 }) },
//    { Dimension.HeartRate, (new float[] { 0, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.RespiratoryRate, (new float[] { 0, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.BloodFlow, (new float[] { 3, 1, -1, 0, 0, 0, 0 }) },
//    { Dimension.BloodVelocity, (new float[] { 1, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.OxygenSaturation, (new float[] { 0, 0, 0, 0, 0, 0, 0 }) },
//    { Dimension.CardiacOutput, (new float[] { 3, 1, -1, 0, 0, 0, 0 }) },
//    { Dimension.BodyTemperature, (new float[] { 0, 1, 0, 0, 0, -1, 0 }) },
//    { Dimension.BrainWaveFrequency, (new float[] { 0, 0, -1, 0, 0, 0, 0 }) },
//    { Dimension.Electroencephalogram, (new float[] { 2, 1, -2, 0, 0, 0, 0 }) }
    };
}