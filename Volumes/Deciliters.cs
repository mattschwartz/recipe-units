namespace RecipeUnits.Volumes
{
    public class Deciliters : Volume
    {
        public override string PluralName { get; set; } = "deciliters";

        public override string SingularName { get; set; } = "deciliter";

        public Deciliters() 
            : base("dL", 3.3814)
        {
        }
    }
}
