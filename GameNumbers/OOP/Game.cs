using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CandyGame.OOP
{
    internal class Game
    {
        private const int SIZE = 7;
        private ICandy[,] candies;

        private double min_score;
        private double now_score;
        public double LeftOverScore { get{ return min_score - now_score; } }
        public bool isWin { get { return min_score <= now_score; } }

        List<ICandy> GetAllCandies => new List<ICandy>
        {
            new RedCandy(),
            new BlueCandy(),
            new GreenCandy(),
            new GoldCandy(),
            new AquaCandy(),
            new DarkCandy(),
            new PinkCandy(),
            new SnowCandy(),
        };

        public ICandy[, ] GetCandies { get { return candies; } }

        private ICandy GenerateCandy
        {
            get
            {
                Thread.Sleep(5);
                return GetAllCandies[new Random().Next(GetAllCandies.Count)];
            }
        }

        public Game(double min_score) 
        {
            this.min_score = min_score;
            now_score = 0;

            candies = new ICandy[SIZE, SIZE];
            int index = GetAllCandies.Count;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    Thread.Sleep(1);
                    candies[i, j] = GenerateCandy;
                }
            }

        }


        public void Swap(Point p1, Point p2)
        {
            var temp_candy = candies[p1.X, p1.Y];
            candies[p1.Y, p1.X] = candies[p2.X, p2.Y];
            candies[p2.X, p2.Y] = temp_candy;
        }

        public void UpdateBoard()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int i = 0; i < SIZE; i++)
                {
                    for (int j = 0; j < SIZE - 3; j++)
                    {
                        if (candies[i, j].GetColor() == candies[i, j + 1].GetColor() &&
                            candies[i, j + 1].GetColor() == candies[i, j + 2].GetColor())
                        {
                            now_score = now_score + candies[i, j].Point() * 3;

                            for (int k = 0; k < 3; k++)
                            {
                                candies[i, j + k] = GenerateCandy;
                            }
                            break;

                        }
                    }
                }

                for (int j = 0; j < SIZE; j++)
                {
                    for (int i = 0; i < SIZE - 3; i++)
                    {
                        if (candies[i, j].GetColor() == candies[i + 1, j].GetColor() &&
                            candies[i + 1, j].GetColor() == candies[i + 2, j].GetColor())
                        {

                            now_score = now_score + candies[i, j].Point() * 3;
                            var s = candies[i, j];
                            for (int k = 0; k < 3; k++)
                            {
                                candies[i + k, j] = GenerateCandy;
                            }

                            break;
                        }
                    }
                }
            }

        }
    }
}
