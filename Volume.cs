using System;

namespace RecipeUnits
{
    public class Volume : IUnit
    {
        public string Abbreviation { get; set; }
        public double Amount { get; set; }
        public virtual string PluralName { get; set; }
        public virtual string SingularName { get; set; }
        public double RatioToFluidOunces { get; set; }
        public UnitType UnitType { get; } = UnitType.Volume;

        public Volume()
        {
        }

        public Volume(string abbreviation, double ratioToFluidOunces)
        {
            Abbreviation = abbreviation;
            RatioToFluidOunces = ratioToFluidOunces;
        }

        public FluidOunces ToFluidOunces()
        {
            return new FluidOunces
            {
                Amount = Amount * RatioToFluidOunces
            };
        }

        public Volume FromFluidOunces(FluidOunces floz)
        {
            Amount = floz.Amount / RatioToFluidOunces;

            return this;
        }

        public Ounces ToOunces(double conversionFactor)
        {
            return ToFluidOunces().ToOunces(conversionFactor);
        }

        public Volume ToVolume(Volume volume)
        {
            FluidOunces floz = ToFluidOunces();
            return volume.FromFluidOunces(floz);
        }

        public Volume ToVolume<TVolume>()
            where TVolume : Volume
        {
            FluidOunces floz = ToFluidOunces();
            var instance = Activator.CreateInstance<Volume>();

            return instance.FromFluidOunces(floz);
        }

        public Weight ToWeight(Weight weight, double conversionFactor)
        {
            Ounces oz = ToOunces(conversionFactor);
            return weight.FromOunces(oz);
        }

        public Weight ToWeight<TWeight>(double conversionFactor)
            where TWeight : Weight
        {
            Ounces oz = ToOunces(conversionFactor);
            var instance = Activator.CreateInstance<Weight>();

            return instance.FromOunces(oz);
        }
    }
}
