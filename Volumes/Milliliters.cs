namespace RecipeUnits.Volumes
{
    public class Milliliters : Volume
    {
        public override string PluralName { get; set; } = "milliliters";

        public override string SingularName { get; set; } = "milliliter";

        public Milliliters() 
            : base("mL", 0.033814)
        {
        }
    }
}
