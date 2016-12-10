using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeUnits.Volumes
{
    public class Gills : Volume
    {
        public override string PluralName { get; set; } = "gills";

        public override string SingularName { get; set; } = "gill";

        public Gills() 
            : base("gill", 3.3814)
        {
        }
    }
}
