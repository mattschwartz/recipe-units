namespace RecipeUnits.Volumes
{
    public class Cups : Volume
    {
        public override string PluralName { get; set; } = "cups";

        public override string SingularName { get; set; } = "cup";

        public Cups()
            : base("c", 8)
        {
        }
    }
}
