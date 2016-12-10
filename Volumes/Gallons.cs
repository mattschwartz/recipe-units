namespace RecipeUnits.Volumes
{
    public class Gallons : Volume
    {
        public override string PluralName { get; set; } = "gallons";

        public override string SingularName { get; set; } = "gallon";

        public Gallons() 
            : base("gal", 128)
        {
        }
    }
}
