using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_JuliaLassig
{

    public enum DeskTopMaterial
    {
        laminate,
        oak,
        rosewood,
        veneer,
        pine
    }

    public class Desk
    {

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;


        public Desk()
        {


        }
        //getters/setters
        #region
        public int NumDrawers { get; set; }
        public DeskTopMaterial Material { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }  


        #endregion

        public int GetDesktopArea()
        {
            //multiply the depth by the width for the desktop area
            int desktopArea = Width * Depth;
            return desktopArea;
        }



    }
}
