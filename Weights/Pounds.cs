namespace RecipeUnits.Weights
{
    public class Pounds : Weight
    {
        public override string PluralName { get; set; } = "pounds";
        public override string SingularName { get; set; } = "pound";

        public Pounds()
            : base("lb", 16)
        {
        }
    }
}
