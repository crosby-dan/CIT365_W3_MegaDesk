using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT365_W3_MegaDesk
{
    public class Desk
    {

        public double width { get; set; }
        public double depth { get; set; }
        public int drawers { get; set; }
        public Globals.SurfaceMaterials surfaceMaterial { get; set; }
    }
}
