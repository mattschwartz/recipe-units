namespace RecipeUnits
{
    public class Ounces : IUnit
    {
        public string Abbreviation { get; } = "oz";
        public double Amount { get; set; }
        public string PluralName { get; } = "ounces";
        public string SingularName { get; } = "ounce";
        public UnitType UnitType { get; } = UnitType.Weight;

        public FluidOunces ToFluidOunces(double conversionFactor)
        {
            return new FluidOunces
            {
                Amount = Amount * conversionFactor
            };
        }
    }
}
