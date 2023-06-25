using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGame.OOP
{
    internal class BlueCandy : ICandy
    {
        public string Type => "Normal";

        public Color GetColor()
        {
            return Color.Blue;
        }

        public double Point()
        {
            return 18d;
        }
    }
}
