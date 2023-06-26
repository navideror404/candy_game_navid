namespace GameNumbers
{
    public partial class GameBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timeRemainder = new System.Windows.Forms.Label();
            this.updateLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.countLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameTime)).BeginInit();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.AccessibleName = "00";
            this.button_1.BackColor = System.Drawing.Color.Gray;
            this.button_1.Enabled = false;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Location = new System.Drawing.Point(14, 12);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(82, 63);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "█";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button_2
            // 
            this.button_2.AccessibleName = "01";
            this.button_2.BackColor = System.Drawing.Color.Gray;
            this.button_2.Enabled = false;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Location = new System.Drawing.Point(102, 12);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(82, 63);
            this.button_2.TabIndex = 0;
            this.button_2.Text = "█";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button_3
            // 
            this.button_3.AccessibleName = "02";
            this.button_3.BackColor = System.Drawing.Color.Gray;
            this.button_3.Enabled = false;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Location = new System.Drawing.Point(190, 12);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(82, 63);
            this.button_3.TabIndex = 0;
            this.button_3.Text = "█";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button_4
            // 
            this.button_4.AccessibleName = "10";
            this.button_4.BackColor = System.Drawing.Color.Gray;
            this.button_4.Enabled = false;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Location = new System.Drawing.Point(14, 81);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(82, 63);
            this.button_4.TabIndex = 0;
            this.button_4.Text = "█";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button_5
            // 
            this.button_5.AccessibleName = "11";
            this.button_5.BackColor = System.Drawing.Color.Gray;
            this.button_5.Enabled = false;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Location = new System.Drawing.Point(102, 81);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(82, 63);
            this.button_5.TabIndex = 0;
            this.button_5.Text = "█";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button_6
            // 
            this.button_6.AccessibleName = "12";
            this.button_6.BackColor = System.Drawing.Color.Gray;
            this.button_6.Enabled = false;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Location = new System.Drawing.Point(190, 81);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(82, 63);
            this.button_6.TabIndex = 0;
            this.button_6.Text = "█";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button_7
            // 
            this.button_7.AccessibleName = "20";
            this.button_7.BackColor = System.Drawing.Color.Gray;
            this.button_7.Enabled = false;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Location = new System.Drawing.Point(14, 150);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(82, 63);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "█";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button_8
            // 
            this.button_8.AccessibleName = "21";
            this.button_8.BackColor = System.Drawing.Color.Gray;
            this.button_8.Enabled = false;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Location = new System.Drawing.Point(102, 150);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(82, 63);
            this.button_8.TabIndex = 0;
            this.button_8.Text = "█";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button_9
            // 
            this.button_9.AccessibleName = "22";
            this.button_9.BackColor = System.Drawing.Color.Gray;
            this.button_9.Enabled = false;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Location = new System.Drawing.Point(190, 150);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(82, 63);
            this.button_9.TabIndex = 0;
            this.button_9.Text = "█";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(455, 509);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(153, 33);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // gameTime
            // 
            this.gameTime.Location = new System.Drawing.Point(110, 514);
            this.gameTime.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.gameTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gameTime.Name = "gameTime";
            this.gameTime.Size = new System.Drawing.Size(55, 31);
            this.gameTime.TabIndex = 4;
            this.gameTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gameTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer(Min):";
            // 
            // timeRemainder
            // 
            this.timeRemainder.Location = new System.Drawing.Point(261, 518);
            this.timeRemainder.Name = "timeRemainder";
            this.timeRemainder.Size = new System.Drawing.Size(185, 25);
            this.timeRemainder.TabIndex = 3;
            this.timeRemainder.Text = "Remain:";
            this.timeRemainder.Click += new System.EventHandler(this.timeRemainder_Click);
            // 
            // updateLabelTimer
            // 
            this.updateLabelTimer.Interval = 10;
            this.updateLabelTimer.Tick += new System.EventHandler(this.updateLabelTimer_Tick);
            // 
            // countLabel
            // 
            this.countLabel.Location = new System.Drawing.Point(170, 516);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(85, 27);
            this.countLabel.TabIndex = 3;
            this.countLabel.Text = "#:";
            // 
            // button1
            // 
            this.button1.AccessibleName = "03";
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(278, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "█";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "04";
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(366, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "█";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "13";
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(278, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 63);
            this.button3.TabIndex = 0;
            this.button3.Text = "█";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "05";
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(454, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 63);
            this.button4.TabIndex = 0;
            this.button4.Text = "█";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button5
            // 
            this.button5.AccessibleName = "23";
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(278, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 63);
            this.button5.TabIndex = 0;
            this.button5.Text = "█";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button6
            // 
            this.button6.AccessibleName = "14";
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(366, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 63);
            this.button6.TabIndex = 0;
            this.button6.Text = "█";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button7
            // 
            this.button7.AccessibleName = "15";
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.Enabled = false;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(454, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 63);
            this.button7.TabIndex = 0;
            this.button7.Text = "█";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button8
            // 
            this.button8.AccessibleName = "24";
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.Enabled = false;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(366, 150);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 63);
            this.button8.TabIndex = 0;
            this.button8.Text = "█";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button9
            // 
            this.button9.AccessibleName = "25";
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.Enabled = false;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(454, 150);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 63);
            this.button9.TabIndex = 0;
            this.button9.Text = "█";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button10
            // 
            this.button10.AccessibleName = "06";
            this.button10.BackColor = System.Drawing.Color.Gray;
            this.button10.Enabled = false;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(542, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 63);
            this.button10.TabIndex = 0;
            this.button10.Text = "█";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button11
            // 
            this.button11.AccessibleName = "16";
            this.button11.BackColor = System.Drawing.Color.Gray;
            this.button11.Enabled = false;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(542, 81);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 63);
            this.button11.TabIndex = 0;
            this.button11.Text = "█";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button12
            // 
            this.button12.AccessibleName = "26";
            this.button12.BackColor = System.Drawing.Color.Gray;
            this.button12.Enabled = false;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(542, 150);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 63);
            this.button12.TabIndex = 0;
            this.button12.Text = "█";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button13
            // 
            this.button13.AccessibleName = "30";
            this.button13.BackColor = System.Drawing.Color.Gray;
            this.button13.Enabled = false;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(14, 219);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 63);
            this.button13.TabIndex = 0;
            this.button13.Text = "█";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button14
            // 
            this.button14.AccessibleName = "31";
            this.button14.BackColor = System.Drawing.Color.Gray;
            this.button14.Enabled = false;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(102, 219);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 63);
            this.button14.TabIndex = 0;
            this.button14.Text = "█";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button15
            // 
            this.button15.AccessibleName = "33";
            this.button15.BackColor = System.Drawing.Color.Gray;
            this.button15.Enabled = false;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(278, 219);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(82, 63);
            this.button15.TabIndex = 0;
            this.button15.Text = "█";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button16
            // 
            this.button16.AccessibleName = "40";
            this.button16.BackColor = System.Drawing.Color.Gray;
            this.button16.Enabled = false;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(14, 288);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(82, 63);
            this.button16.TabIndex = 0;
            this.button16.Text = "█";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button17
            // 
            this.button17.AccessibleName = "34";
            this.button17.BackColor = System.Drawing.Color.Gray;
            this.button17.Enabled = false;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(366, 219);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(82, 63);
            this.button17.TabIndex = 0;
            this.button17.Text = "█";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button18
            // 
            this.button18.AccessibleName = "32";
            this.button18.BackColor = System.Drawing.Color.Gray;
            this.button18.Enabled = false;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(190, 219);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(82, 63);
            this.button18.TabIndex = 0;
            this.button18.Text = "█";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button19
            // 
            this.button19.AccessibleName = "43";
            this.button19.BackColor = System.Drawing.Color.Gray;
            this.button19.Enabled = false;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(278, 288);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(82, 63);
            this.button19.TabIndex = 0;
            this.button19.Text = "█";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button20
            // 
            this.button20.AccessibleName = "50";
            this.button20.BackColor = System.Drawing.Color.Gray;
            this.button20.Enabled = false;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(14, 357);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(82, 63);
            this.button20.TabIndex = 0;
            this.button20.Text = "█";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button21
            // 
            this.button21.AccessibleName = "35";
            this.button21.BackColor = System.Drawing.Color.Gray;
            this.button21.Enabled = false;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(454, 219);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(82, 63);
            this.button21.TabIndex = 0;
            this.button21.Text = "█";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button22
            // 
            this.button22.AccessibleName = "36";
            this.button22.BackColor = System.Drawing.Color.Gray;
            this.button22.Enabled = false;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(542, 219);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(82, 63);
            this.button22.TabIndex = 0;
            this.button22.Text = "█";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button23
            // 
            this.button23.AccessibleName = "53";
            this.button23.BackColor = System.Drawing.Color.Gray;
            this.button23.Enabled = false;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(278, 357);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(82, 63);
            this.button23.TabIndex = 0;
            this.button23.Text = "█";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button24
            // 
            this.button24.AccessibleName = "41";
            this.button24.BackColor = System.Drawing.Color.Gray;
            this.button24.Enabled = false;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(102, 288);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(82, 63);
            this.button24.TabIndex = 0;
            this.button24.Text = "█";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button25
            // 
            this.button25.AccessibleName = "44";
            this.button25.BackColor = System.Drawing.Color.Gray;
            this.button25.Enabled = false;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(366, 288);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(82, 63);
            this.button25.TabIndex = 0;
            this.button25.Text = "█";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button26
            // 
            this.button26.AccessibleName = "42";
            this.button26.BackColor = System.Drawing.Color.Gray;
            this.button26.Enabled = false;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Location = new System.Drawing.Point(190, 288);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(82, 63);
            this.button26.TabIndex = 0;
            this.button26.Text = "█";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button27
            // 
            this.button27.AccessibleName = "45";
            this.button27.BackColor = System.Drawing.Color.Gray;
            this.button27.Enabled = false;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Location = new System.Drawing.Point(454, 288);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(82, 63);
            this.button27.TabIndex = 0;
            this.button27.Text = "█";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button28
            // 
            this.button28.AccessibleName = "46";
            this.button28.BackColor = System.Drawing.Color.Gray;
            this.button28.Enabled = false;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Location = new System.Drawing.Point(542, 288);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(82, 63);
            this.button28.TabIndex = 0;
            this.button28.Text = "█";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button29
            // 
            this.button29.AccessibleName = "51";
            this.button29.BackColor = System.Drawing.Color.Gray;
            this.button29.Enabled = false;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Location = new System.Drawing.Point(102, 357);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(82, 63);
            this.button29.TabIndex = 0;
            this.button29.Text = "█";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button30
            // 
            this.button30.AccessibleName = "54";
            this.button30.BackColor = System.Drawing.Color.Gray;
            this.button30.Enabled = false;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Location = new System.Drawing.Point(366, 357);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(82, 63);
            this.button30.TabIndex = 0;
            this.button30.Text = "█";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button31
            // 
            this.button31.AccessibleName = "52";
            this.button31.BackColor = System.Drawing.Color.Gray;
            this.button31.Enabled = false;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Location = new System.Drawing.Point(190, 357);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(82, 63);
            this.button31.TabIndex = 0;
            this.button31.Text = "█";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button32
            // 
            this.button32.AccessibleName = "55";
            this.button32.BackColor = System.Drawing.Color.Gray;
            this.button32.Enabled = false;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Location = new System.Drawing.Point(454, 357);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(82, 63);
            this.button32.TabIndex = 0;
            this.button32.Text = "█";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button33
            // 
            this.button33.AccessibleName = "56";
            this.button33.BackColor = System.Drawing.Color.Gray;
            this.button33.Enabled = false;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Location = new System.Drawing.Point(542, 357);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(82, 63);
            this.button33.TabIndex = 0;
            this.button33.Text = "█";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button34
            // 
            this.button34.AccessibleName = "60";
            this.button34.BackColor = System.Drawing.Color.Gray;
            this.button34.Enabled = false;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Location = new System.Drawing.Point(15, 426);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(82, 63);
            this.button34.TabIndex = 0;
            this.button34.Text = "█";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button35
            // 
            this.button35.AccessibleName = "63";
            this.button35.BackColor = System.Drawing.Color.Gray;
            this.button35.Enabled = false;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Location = new System.Drawing.Point(279, 426);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(82, 63);
            this.button35.TabIndex = 0;
            this.button35.Text = "█";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button36
            // 
            this.button36.AccessibleName = "61";
            this.button36.BackColor = System.Drawing.Color.Gray;
            this.button36.Enabled = false;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Location = new System.Drawing.Point(103, 426);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(82, 63);
            this.button36.TabIndex = 0;
            this.button36.Text = "█";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button37
            // 
            this.button37.AccessibleName = "64";
            this.button37.BackColor = System.Drawing.Color.Gray;
            this.button37.Enabled = false;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Location = new System.Drawing.Point(367, 426);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(82, 63);
            this.button37.TabIndex = 0;
            this.button37.Text = "█";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button38
            // 
            this.button38.AccessibleName = "62";
            this.button38.BackColor = System.Drawing.Color.Gray;
            this.button38.Enabled = false;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Location = new System.Drawing.Point(191, 426);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(82, 63);
            this.button38.TabIndex = 0;
            this.button38.Text = "█";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button39
            // 
            this.button39.AccessibleName = "65";
            this.button39.BackColor = System.Drawing.Color.Gray;
            this.button39.Enabled = false;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Location = new System.Drawing.Point(455, 426);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(82, 63);
            this.button39.TabIndex = 0;
            this.button39.Text = "█";
            this.button39.UseVisualStyleBackColor = false;
            this.button39.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // button40
            // 
            this.button40.AccessibleName = "66";
            this.button40.BackColor = System.Drawing.Color.Gray;
            this.button40.Enabled = false;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Location = new System.Drawing.Point(543, 426);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(82, 63);
            this.button40.TabIndex = 0;
            this.button40.Text = "█";
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.game_buttons_Click);
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 565);
            this.Controls.Add(this.gameTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeRemainder);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button_1);
            this.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GameBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameBoardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.NumericUpDown gameTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeRemainder;
        private System.Windows.Forms.Timer updateLabelTimer;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
    }
}

