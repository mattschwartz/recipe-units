namespace RecipeUnits
{
    public class FluidOunces : IUnit
    {
        public string Abbreviation { get; } = "fl oz";
        public double Amount { get; set; }
        public string PluralName { get; } = "fluid ounces";
        public string SingularName { get; } = "fluid ounce";
        public UnitType UnitType { get; } = UnitType.Volume;

        public Ounces ToOunces(double conversionFactor)
        {
            return new Ounces
            {
                Amount = Amount * conversionFactor
            };
        }
    }
}
