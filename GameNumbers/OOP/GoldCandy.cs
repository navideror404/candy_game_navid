using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGame.OOP
{
    internal class GoldCandy : ICandy
    {
        public string Type => "Golden";

        public Color GetColor()
        {
            return Color.Gold;
        }

        public double Point()
        {
            return 50d;
        }
    }
}
