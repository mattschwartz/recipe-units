namespace RecipeUnits
{
    public class Single : IUnit
    {
        public string Abbreviation { get; set; }

        public double Amount { get; set; }

        public string PluralName { get; set; }

        public string SingularName { get; set; }

        public UnitType UnitType { get; } = UnitType.Count;
    }
}
