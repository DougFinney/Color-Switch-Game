namespace Color_Switch_Game
{
    partial class Form1
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
            this.gameDisplay = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.blockOne = new System.Windows.Forms.PictureBox();
            this.blockTwo = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // gameDisplay
            // 
            this.gameDisplay.BackColor = System.Drawing.Color.Black;
            this.gameDisplay.Controls.Add(this.player);
            this.gameDisplay.Controls.Add(this.blockTwo);
            this.gameDisplay.Controls.Add(this.blockOne);
            this.gameDisplay.Location = new System.Drawing.Point(3, 7);
            this.gameDisplay.Name = "gameDisplay";
            this.gameDisplay.Size = new System.Drawing.Size(454, 534);
            this.gameDisplay.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(496, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 329);
            this.listBox1.TabIndex = 1;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(491, 28);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(110, 29);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 120);
            this.label1.TabIndex = 3;
            this.label1.Text = "Press Space To Change Color\r\nPress R To Restart The Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blockOne
            // 
            this.blockOne.BackColor = System.Drawing.Color.Yellow;
            this.blockOne.Location = new System.Drawing.Point(0, 21);
            this.blockOne.Name = "blockOne";
            this.blockOne.Size = new System.Drawing.Size(454, 30);
            this.blockOne.TabIndex = 0;
            this.blockOne.TabStop = false;
            this.blockOne.Tag = "block";
            // 
            // blockTwo
            // 
            this.blockTwo.BackColor = System.Drawing.Color.Red;
            this.blockTwo.Location = new System.Drawing.Point(0, 142);
            this.blockTwo.Name = "blockTwo";
            this.blockTwo.Size = new System.Drawing.Size(454, 30);
            this.blockTwo.TabIndex = 1;
            this.blockTwo.TabStop = false;
            this.blockTwo.Tag = "block";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(167, 446);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 50);
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gameDisplay);
            this.Name = "Form1";
            this.Text = "Color Switch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyIsPressed);
            this.gameDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blockOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameDisplay;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox blockTwo;
        private System.Windows.Forms.PictureBox blockOne;
        private System.Windows.Forms.Timer GameTimer;
    }
}

