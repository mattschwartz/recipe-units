namespace RecipeUnits.Volumes
{
    public class Quarts : Volume
    {
        public override string PluralName { get; set; } = "quarts";

        public override string SingularName { get; set; } = "quart";

        public Quarts() 
            : base("qt", 32)
        {
        }
    }
}
