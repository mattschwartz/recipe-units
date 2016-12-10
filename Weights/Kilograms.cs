namespace RecipeUnits.Weights
{
    public class Kilograms : Weight
    {
        public override string PluralName { get; set; } = "kilograms";

        public override string SingularName { get; set; } = "kilogram";

        public Kilograms()
            : base("kg", 35.274)
        {
        }
    }
}
