using GameNumbers.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNumbers
{
    public partial class GameBoardForm : Form
    {
        public static Color[, ] _arr, _finalArray;
        private TimeSpan _startTime; 
        private int _size;
        private Button _button1, _button2;
        private string EMPTY_PATH = " ";
        public static string NewState = "";
        public static int count = 0;
        public GameBoardForm()
        {
            _size = 7;

            CleanButtons();
            _arr = new Color[_size, _size];
            _finalArray = new Color[_size, _size];
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

        private Button GetEmptyPlayButton()
        {
            return GetPlayButtons().Where(b => b.Text == EMPTY_PATH).FirstOrDefault();
        }

        private void ClearButtons()
        {
            List<Color> colors = new List<Color>()
            { 
                Color.Red, Color.Green, Color.Blue, Color.Magenta, Color.Yellow, Color.Orange,
            };
            foreach (var button in GetPlayButtons())
                button.BackColor = colors[new Random().Next(colors.Count)];
        }
        private void InitilizeButtonsRandom(Color[, ] arr)
        {
            ClearButtons();
            var buttons = GetPlayButtons()
                .ToList()
                .Shuffle();

            int i = 0;
            List<Color> colors = new List<Color>()
            {
                Color.Red, Color.Green, Color.Blue, Color.Magenta, Color.Yellow, Color.Orange,
            };
            for (int num = 1; num <= (_size * _size) - 1; num++)
            {
                buttons[i].Text = "█";
                buttons[i].BackColor = colors[new Random().Next(colors.Count)];
                i++;
                Thread.Sleep(1);
            }

            UpdateMatrix(arr);
        }

        private void UpdateMatrix(Color[, ] arr)
        {
            foreach (var button in GetPlayButtons())
            {
                var pos = ArrayPosition(button);
                arr[pos.X, pos.Y] = button.BackColor;
            }
        }
        
        private bool IsWin()
        {
            for (int i = 0; i < _size; i++)
                for (int j = 0; j < _size; j++)
                    if (_arr[i, j] != _finalArray[i, j])
                        return false;

            return true;
        }
        private void GameBoardForm_Load(object sender, EventArgs e)
        {
            ButtonEnabled(true);
        }

        private void StartGame()
        {
            InitilizeButtonsRandom(_finalArray);
            ChangeButtonColor(GetPlayButtons().ToList(), Color.Black);
            startButton.Enabled = gameTime.Enabled = false;

            Thread.Sleep(3000);
            
            InitilizeButtonsRandom(_arr);
            _startTime = new TimeSpan(0, (int)gameTime.Value, 0);
            ButtonEnabled(true);

            foreach (var radio in Controls.OfType<RadioButton>())
                radio.Enabled = false;

            gameTimer.Start();
        }
        
        private int[, ] String2IntMatrix(string[, ] arr)
        {
            int[,] result = new int[_size, _size];
            for (int i = 0; i < _size; i++)
                for (int j = 0; j < _size; j++)
                    result[i, j] = arr[i, j] == " " ? 0 : int.Parse(arr[i, j]);

            return result;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private Point ArrayPosition(Button button)
        {
            return ArrayPosition(button.AccessibleName);
        }

        private Point ArrayPosition(string buttonName)
        {
            int row = int.Parse(buttonName[0].ToString());
            int col = int.Parse(buttonName[1].ToString());

            return new Point(row, col);
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

            if (IsWin())
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

                var pos1 = ArrayPosition(_button1);
                var pos2 = ArrayPosition(_button2);

                if (GetNeighbours(pos1, pos2))
                {
                    ChangeButtonColor(new List<Button>() { _button1, _button2 }, Color.Lime);
                    await Task.Delay(1000);
                    ChangeButtonColor(new List<Button>() { _button1, _button2 }, Color.Lime);

                    countLabel.Text = $"#: {++count}";
                    SwapButtonsColor(_button1, _button2);
                    UpdateMatrix(_arr);
                    ChangeButtonColor(GetPlayButtons().ToList(), Color.Black);

                    if (IsWin())
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
