namespace RecipeUnits.Volumes
{
    public class Pints : Volume
    {
        public override string PluralName { get; set; } = "pints";

        public override string SingularName { get; set; } = "pint";

        public Pints() 
            : base("pt", 16)
        {
        }
    }
}
