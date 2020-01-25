using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT365_W3_MegaDesk
{
    public class Globals
    {
        // Keep track of quote count
        public static int QuoteCount { get; set; } = 1;

        //Define min max property values for up down controls
        public const int minWidth = 24, maxWidth = 96;
        public const int minDepth = 12, maxDepth = 48;
        public const int minDrawers = 0, maxDrawers = 7;
        public const int baseCost = 200, surfaceCost = 1, drawerCost = 50;

        //A structure of the different rush types and the pricing tier for each
        public struct RushType
        {
            public int id { get; set; }
            public string description { get; set; }
            public float tier1Cost { get; set; }
            public float tier2Cost { get; set; }
            public float tier3Cost { get; set; }
        }

        //A structure of the different types of surface materials and the cost of each
        public struct SurfaceMaterials
        {
            public int id { get; set; }
            public string description { get; set; }
            public float cost { get; set; }
        }

        public static List<RushType> rushTypes = new List<RushType>();
        public static List<SurfaceMaterials> surfaceMaterials = new List<SurfaceMaterials>();
        public static List<DeskQuote> deskQuotes = new List<DeskQuote>();

        // Populate the structures with starter values.
        public static void InitializeValues()
        {
            //Initialize the SurfaceMaterials structure with values
            rushTypes.Add(new RushType { id = 0, description = "14 day", tier1Cost = 0, tier2Cost = 0, tier3Cost = 0 });
            rushTypes.Add(new RushType { id = 0, description = "3 day", tier1Cost = 60, tier2Cost = 70, tier3Cost = 80 });
            rushTypes.Add(new RushType { id = 0, description = "5 day", tier1Cost = 40, tier2Cost = 50, tier3Cost = 60 });
            rushTypes.Add(new RushType { id = 0, description = "7 day", tier1Cost = 30, tier2Cost = 35, tier3Cost = 40 });

            //Initialize the SurfaceMaterials structure with values
            surfaceMaterials.Add(new SurfaceMaterials { id = 0, description = "oak", cost = 200 });
            surfaceMaterials.Add(new SurfaceMaterials { id = 1, description = "laminate", cost = 100 });
            surfaceMaterials.Add(new SurfaceMaterials { id = 2, description = "pine", cost = 50 });
            surfaceMaterials.Add(new SurfaceMaterials { id = 3, description = "rosewood", cost = 300 });
            surfaceMaterials.Add(new SurfaceMaterials { id = 4, description = "veneer", cost = 125 });
        }

    }
}
