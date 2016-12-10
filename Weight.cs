using System;

namespace RecipeUnits
{
    public class Weight : IUnit
    {
        public string Abbreviation { get; set; }
        public double Amount { get; set; }
        public virtual string PluralName { get; set; }
        public virtual string SingularName { get; set; }
        public double RatioToOunces { get; set; }
        public UnitType UnitType { get; } = UnitType.Weight;

        public Weight()
        {
        }

        public Weight(string abbreviation, double ratioToOunces)
        {
            Abbreviation = abbreviation;
            RatioToOunces = ratioToOunces;
        }

        public Ounces ToOunces()
        {
            return new Ounces
            {
                Amount = Amount * RatioToOunces
            };
        }

        public Weight FromOunces(Ounces oz)
        {
            Amount = oz.Amount / RatioToOunces;

            return this;
        }

        public FluidOunces ToFluidOunces(double conversionFactor)
        {
            return ToOunces().ToFluidOunces(conversionFactor);
        }

        public Volume ToVolume(Volume volume, double conversionFactor)
        {
            FluidOunces floz = ToFluidOunces(conversionFactor);
            return volume.FromFluidOunces(floz);
        }

        public Volume ToVolume<TVolume>(double conversionFactor)
            where TVolume : Volume
        {
            FluidOunces floz = ToFluidOunces(conversionFactor);
            var instance = Activator.CreateInstance<TVolume>();

            return instance.FromFluidOunces(floz);
        }

        public Weight ToWeight(Weight weight)
        {
            Ounces oz = ToOunces();
            return weight.FromOunces(oz);
        }

        public Weight ToWeight<TWeight>()
            where TWeight : Weight
        {
            Ounces oz = ToOunces();
            var instance = Activator.CreateInstance<Weight>();

            return instance.FromOunces(oz);
        }
    }
}
