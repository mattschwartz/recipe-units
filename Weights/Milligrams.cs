namespace RecipeUnits.Weights
{
    public class Milligrams : Weight
    {
        public override string PluralName { get; set; } = "milligrams";

        public override string SingularName { get; set; } = "milligram";

        public Milligrams()
            : base("mg", 35.274)
        {
        }
    }
}
