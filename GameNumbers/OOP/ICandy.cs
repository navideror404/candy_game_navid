using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGame.OOP
{
    internal interface ICandy
    {
        string Type { get; }
        double Point();
        Color GetColor();
    }
}
