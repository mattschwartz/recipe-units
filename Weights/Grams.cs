namespace RecipeUnits.Weights
{
    public class Grams : Weight
    {
        public override string PluralName { get; set; } = "grams";

        public override string SingularName { get; set; } = "gram";
        public Grams()
            : base("g", 0.035274)
        {
        }
    }
}
