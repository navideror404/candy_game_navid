using CandyGame.OOP;
using GameNumbers.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GameNumbers
{
    public partial class GameBoardForm : Form
    {
        Color[,] _arr;
        private TimeSpan _startTime; 
        private int _size;
        private Button _button1, _button2;
        public static int count = 0;

        private Game game;
        public GameBoardForm()
        {
            _size = 7;
            game = new Game(9000);
            _arr = new Color[_size, _size];

            CleanButtons();
            InitializeComponent();
        }

        private void CleanButtons()
        {
            _button1 = _button2 = null;
        }
        private bool GetNeighbours(Point p1, Point p2)
        {

            var neighbors_p1 = new List<string>()
            {
                $"{p1.X - 1}{p1.Y}",
                $"{p1.X + 1}{p1.Y}",
                $"{p1.X}{p1.Y - 1}",
                $"{p1.X}{p1.Y + 1}",
            };

            var p2_str = $"{p2.X}{p2.Y}";
            neighbors_p1 = neighbors_p1.Where(n => !n.Contains("-") && !n.Contains("7")).ToList();

            return neighbors_p1.Any(n => n == p2_str);
        }

        private IEnumerable<Button> GetPlayButtons()
        {
            return Controls.OfType<Button>().Where(b => b.Name != "startButton" && b.AccessibleName.Length == 2);
        }

        private void InitilizeButtons()
        {
            var buttons = GetPlayButtons()
                .ToList();
            
            int index = 0;
            var candies = game.GetCandies;

            for (int k = 0; k < _size * _size; k++)
            {
                var p = ArrayPosition(buttons[index].AccessibleName);
                int i = p.X, j = p.Y;
                _arr[i, j] = candies[i, j].GetColor();
                buttons[index].BackColor = _arr[i, j];
                index++;

                Thread.Sleep(1);
            }
        }

        private Point ArrayPosition(string buttonName)
        {
            int row = int.Parse(buttonName[0].ToString());
            int col = int.Parse(buttonName[1].ToString());

            return new Point(row, col);
        }

        private void GameBoardForm_Load(object sender, EventArgs e)
        {
            ButtonEnabled(true);
        }

        private void StartGame()
        {
            ChangeButtonColor(GetPlayButtons().ToList(), Color.Black);
            startButton.Enabled = gameTime.Enabled = false;

            Thread.Sleep(1500);
            
            InitilizeButtons();
            _startTime = new TimeSpan(0, (int)gameTime.Value, 0);
            ButtonEnabled(true);

            
            gameTimer.Start();
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void ChangeButtonColor(List<Button> buttons, Color color)
        {
            foreach (var button in buttons)
                button.ForeColor = color;
        }

        private void SwapButtonsColor(Button b1, Button b2)
        {
            var temp = b1.BackColor;
            b1.BackColor = b2.BackColor;
            b2.BackColor = temp;
        }

        private async void GameResult(string title, Color color)
        {
            timeRemainder.Text = title;
            timeRemainder.ForeColor = color;

            for (int i = 0; i < 5; i++)
            {
                ChangeButtonColor(GetPlayButtons().ToList(), Color.WhiteSmoke);
                await Task.Delay(500);
                ChangeButtonColor(GetPlayButtons().ToList(), color);
                await Task.Delay(500);
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            _startTime = new TimeSpan(_startTime.Hours, _startTime.Minutes, _startTime.Seconds - 1);
            timeRemainder.Text = $"Remain: {_startTime.Minutes}:{_startTime.Seconds}";

            if (_startTime.Minutes == 0 && _startTime.Seconds == 0)
            {
                GameResult("You Lose.", Color.DarkRed);
                gameTimer.Stop();
                updateLabelTimer.Stop();
                ButtonEnabled(false);
            }
        }

        private void ButtonEnabled(bool state)
        {
            foreach (var button in GetPlayButtons())
                button.Enabled = state;
        }

        private void updateLabelTimer_Tick(object sender, EventArgs e)
        {
            countLabel.Text = $"#: {count}";

            if (game.isWin)
            {
                updateLabelTimer.Enabled = false;
                gameTimer.Stop();
                ButtonEnabled(false);
                GameResult("Bot Win.", Color.Cyan);
            }

        }

        
        private void timeRemainder_Click(object sender, EventArgs e)
        {
            
        }

        private async void game_buttons_Click(object sender, EventArgs e)
        {
            
            if (_button1  == null)
            {
                _button1 = (Button)sender;
            }
            else if (_button2 == null)
            {
                _button2 = (Button)sender;

                var pos1 = ArrayPosition(_button1.AccessibleName);
                var pos2 = ArrayPosition(_button2.AccessibleName);

                countLabel.Text = $"#: {++count}";

                if (GetNeighbours(pos1, pos2))
                {
                    ChangeButtonColor(new List<Button>() { _button1, _button2 }, Color.Lime);
                    await Task.Delay(1000);

                    SwapButtonsColor(_button1, _button2);
                    ChangeButtonColor(GetPlayButtons().ToList(), Color.Black);
                    game.Swap(pos1, pos2);

                    game.UpdateBoard();

                    InitilizeButtons();
                    Text = $":Score Needed To Win: {game.LeftOverScore}";

                    if (game.isWin)
                    {
                        gameTimer.Stop();
                        ButtonEnabled(false);
                        GameResult("You Win.", Color.Cyan);
                    }
                }
                else
                {
                    ChangeButtonColor(new List<Button>() { _button1, _button2 }, Color.DarkRed);
                    await Task.Delay(1000);

                    ChangeButtonColor(GetPlayButtons().ToList(), Color.Black);
                }

                CleanButtons();
            }

        }
    }
}
