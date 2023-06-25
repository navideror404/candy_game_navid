using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGame.OOP
{
    public class RedCandy : ICandy
    {
        public string Type => "Normal";

        public Color GetColor()
        {
            return Color.Red;
        }

        public double Point()
        {
            return 14d;
        }
    }
}
