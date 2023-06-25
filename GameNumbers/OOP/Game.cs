using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CandyGame.OOP
{
    internal class Game
    {
        private const int SIZE = 7;
        private ICandy[,] candies;

        List<ICandy> GetAllCandies => new List<ICandy>
        {
            new RedCandy(),
            new BlueCandy(),
            new GreenCandy(),
            new GoldCandy(),
        };

        public Game() 
        {

            candies = new ICandy[SIZE, SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    candies[i, j] = GetAllCandies[(int)Math.Pow(j, 3) % 3];
                }
            }

        }
    }
}
