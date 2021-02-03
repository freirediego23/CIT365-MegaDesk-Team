using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Echegaray
{
    public enum DesktopMaterialList
    {
        Oak =200, 
        Laminate = 100, 
        Pine = 50, 
        Rosewood = 300, 
        Veneer = 125,
    }

    class Desk
    {

        public const double minWidth = 24;
        public const double maxWidth = 96;
        public const double minDepth = 12;
        public const double maxDepth = 48;

        public int width { get; set; }
        public int depth { get; set; }
        public int drawers { get; set; }
    }


}
