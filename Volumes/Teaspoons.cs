namespace RecipeUnits.Volumes
{
    public class Teaspoons : Volume
    {
        public override string PluralName { get; set; } = "teaspoons";

        public override string SingularName { get; set; } = "teaspoon";

        public Teaspoons() 
            : base("tsp", 0.166667)
        {
        }
    }
}
