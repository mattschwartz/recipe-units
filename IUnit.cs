namespace RecipeUnits
{
    public interface IUnit
    {
        string Abbreviation { get; }
        double Amount { get; set; }
        string SingularName { get; }
        string PluralName { get; }
        UnitType UnitType { get; }
    }
}
