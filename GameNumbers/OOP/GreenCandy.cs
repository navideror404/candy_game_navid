using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGame.OOP
{
    internal class GreenCandy : ICandy
    {
        public string Type => "Normal";

        public Color GetColor()
        {
            return Color.Green;
        }

        public double Point()
        {
            return 24d;
        }
    }
    
}
