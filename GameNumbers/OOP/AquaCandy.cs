using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGame.OOP
{
    internal class AquaCandy : ICandy
    {
        public string Type => "Normal";

        public Color GetColor()
        {
            return Color.Aqua;
        }

        public double Point()
        {
            return 29d;
        }
    }
}
