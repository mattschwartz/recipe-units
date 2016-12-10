namespace RecipeUnits.Volumes
{
    public class Tablespoons : Volume
    {
        public override string PluralName { get; set; } = "tablespoons";

        public override string SingularName { get; set; } = "tablespoon";

        public Tablespoons() 
            : base("tbsp", 0.5)
        {
        }
    }
}
