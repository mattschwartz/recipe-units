namespace RecipeUnits.Volumes
{
    public class Liters : Volume
    {
        public override string PluralName { get; set; } = "liters";

        public override string SingularName { get; set; } = "liter";

        public Liters() 
            : base("L", 33.814)
        {
        }
    }
}
