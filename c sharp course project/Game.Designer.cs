using System.ComponentModel;

namespace c_sharp_course_project.resources
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Vertical = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Horizontal = new System.Windows.Forms.RadioButton();
            this.SelectShipDirection = new System.Windows.Forms.GroupBox();
            this.SelectShip = new System.Windows.Forms.GroupBox();
            this.fourShipsLabel = new System.Windows.Forms.Label();
            this.threeShipslabel = new System.Windows.Forms.Label();
            this.twoShipsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.four = new System.Windows.Forms.RadioButton();
            this.three = new System.Windows.Forms.RadioButton();
            this.two = new System.Windows.Forms.RadioButton();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.MissTipsLabel = new System.Windows.Forms.Label();
            this.ShotTipsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.SetRandomShips = new System.Windows.Forms.Button();
            this.ClearFieldBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gamePlayerName = new System.Windows.Forms.Label();
            this.ToMainMenuBtn = new System.Windows.Forms.Button();
            this.SelectShipDirection.SuspendLayout();
            this.SelectShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vertical
            // 
            this.Vertical.AutoSize = true;
            this.Vertical.Location = new System.Drawing.Point(4, 44);
            this.Vertical.Margin = new System.Windows.Forms.Padding(2);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(160, 22);
            this.Vertical.TabIndex = 2;
            this.Vertical.TabStop = true;
            this.Vertical.Text = "По вертикали";
            this.Vertical.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Horizontal
            // 
            this.Horizontal.AutoSize = true;
            this.Horizontal.Location = new System.Drawing.Point(4, 76);
            this.Horizontal.Margin = new System.Windows.Forms.Padding(2);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(186, 22);
            this.Horizontal.TabIndex = 5;
            this.Horizontal.TabStop = true;
            this.Horizontal.Text = "По горизонтали";
            this.Horizontal.UseVisualStyleBackColor = true;
            // 
            // SelectShipDirection
            // 
            this.SelectShipDirection.AutoSize = true;
            this.SelectShipDirection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SelectShipDirection.Controls.Add(this.Vertical);
            this.SelectShipDirection.Controls.Add(this.Horizontal);
            this.SelectShipDirection.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectShipDirection.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectShipDirection.Location = new System.Drawing.Point(526, 31);
            this.SelectShipDirection.Margin = new System.Windows.Forms.Padding(2);
            this.SelectShipDirection.Name = "SelectShipDirection";
            this.SelectShipDirection.Padding = new System.Windows.Forms.Padding(2);
            this.SelectShipDirection.Size = new System.Drawing.Size(321, 124);
            this.SelectShipDirection.TabIndex = 8;
            this.SelectShipDirection.TabStop = false;
            this.SelectShipDirection.Text = "Расположение корабля";
            // 
            // SelectShip
            // 
            this.SelectShip.AutoSize = true;
            this.SelectShip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SelectShip.Controls.Add(this.fourShipsLabel);
            this.SelectShip.Controls.Add(this.threeShipslabel);
            this.SelectShip.Controls.Add(this.twoShipsLabel);
            this.SelectShip.Controls.Add(this.label3);
            this.SelectShip.Controls.Add(this.label2);
            this.SelectShip.Controls.Add(this.label1);
            this.SelectShip.Controls.Add(this.four);
            this.SelectShip.Controls.Add(this.three);
            this.SelectShip.Controls.Add(this.two);
            this.SelectShip.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectShip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectShip.Location = new System.Drawing.Point(526, 193);
            this.SelectShip.Margin = new System.Windows.Forms.Padding(2);
            this.SelectShip.Name = "SelectShip";
            this.SelectShip.Padding = new System.Windows.Forms.Padding(2);
            this.SelectShip.Size = new System.Drawing.Size(321, 172);
            this.SelectShip.TabIndex = 9;
            this.SelectShip.TabStop = false;
            this.SelectShip.Text = "Выберите длину корабля";
            // 
            // fourShipsLabel
            // 
            this.fourShipsLabel.Location = new System.Drawing.Point(193, 125);
            this.fourShipsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fourShipsLabel.Name = "fourShipsLabel";
            this.fourShipsLabel.Size = new System.Drawing.Size(67, 17);
            this.fourShipsLabel.TabIndex = 13;
            this.fourShipsLabel.Text = "0 / 1";
            this.fourShipsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fourShipsLabel.Click += new System.EventHandler(this.fourShipsLabel_Click);
            // 
            // threeShipslabel
            // 
            this.threeShipslabel.Location = new System.Drawing.Point(193, 90);
            this.threeShipslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.threeShipslabel.Name = "threeShipslabel";
            this.threeShipslabel.Size = new System.Drawing.Size(67, 20);
            this.threeShipslabel.TabIndex = 12;
            this.threeShipslabel.Text = "0 / 2";
            this.threeShipslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twoShipsLabel
            // 
            this.twoShipsLabel.Location = new System.Drawing.Point(192, 53);
            this.twoShipsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.twoShipsLabel.Name = "twoShipsLabel";
            this.twoShipsLabel.Size = new System.Drawing.Size(67, 21);
            this.twoShipsLabel.TabIndex = 11;
            this.twoShipsLabel.Text = "0 / 4";
            this.twoShipsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.twoShipsLabel.Click += new System.EventHandler(this.twoShipsLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "расставлено";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "расставлено";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "расставлено";
            // 
            // four
            // 
            this.four.AutoSize = true;
            this.four.Location = new System.Drawing.Point(4, 124);
            this.four.Margin = new System.Windows.Forms.Padding(2);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(39, 22);
            this.four.TabIndex = 2;
            this.four.TabStop = true;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            this.three.AutoSize = true;
            this.three.Location = new System.Drawing.Point(4, 90);
            this.three.Margin = new System.Windows.Forms.Padding(2);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(39, 22);
            this.three.TabIndex = 1;
            this.three.TabStop = true;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            this.two.AutoSize = true;
            this.two.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.two.Location = new System.Drawing.Point(4, 52);
            this.two.Margin = new System.Windows.Forms.Padding(2);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(39, 22);
            this.two.TabIndex = 0;
            this.two.TabStop = true;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.AutoSize = true;
            this.StartGameBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StartGameBtn.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.StartGameBtn.Location = new System.Drawing.Point(503, 496);
            this.StartGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(192, 106);
            this.StartGameBtn.TabIndex = 10;
            this.StartGameBtn.Text = "Начать игру";
            this.StartGameBtn.UseVisualStyleBackColor = false;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // MissTipsLabel
            // 
            this.MissTipsLabel.AutoSize = true;
            this.MissTipsLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MissTipsLabel.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MissTipsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MissTipsLabel.Location = new System.Drawing.Point(502, 422);
            this.MissTipsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MissTipsLabel.Name = "MissTipsLabel";
            this.MissTipsLabel.Size = new System.Drawing.Size(81, 18);
            this.MissTipsLabel.TabIndex = 12;
            this.MissTipsLabel.Text = "ПРОМАХ";
            this.MissTipsLabel.Click += new System.EventHandler(this.MissTipsLabel_Click);
            // 
            // ShotTipsLabel
            // 
            this.ShotTipsLabel.AutoSize = true;
            this.ShotTipsLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ShotTipsLabel.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShotTipsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ShotTipsLabel.Location = new System.Drawing.Point(501, 383);
            this.ShotTipsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShotTipsLabel.Name = "ShotTipsLabel";
            this.ShotTipsLabel.Size = new System.Drawing.Size(115, 18);
            this.ShotTipsLabel.TabIndex = 13;
            this.ShotTipsLabel.Text = "Попадание";
            this.ShotTipsLabel.Click += new System.EventHandler(this.ShotTipsLabel_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(503, 458);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Счет:";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.playerScoreLabel.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerScoreLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.playerScoreLabel.Location = new System.Drawing.Point(579, 458);
            this.playerScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(36, 23);
            this.playerScoreLabel.TabIndex = 15;
            this.playerScoreLabel.Text = "0";
            // 
            // SetRandomShips
            // 
            this.SetRandomShips.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SetRandomShips.Font = new System.Drawing.Font("NEXT ART", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetRandomShips.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SetRandomShips.Location = new System.Drawing.Point(712, 391);
            this.SetRandomShips.Margin = new System.Windows.Forms.Padding(2);
            this.SetRandomShips.Name = "SetRandomShips";
            this.SetRandomShips.Size = new System.Drawing.Size(135, 82);
            this.SetRandomShips.TabIndex = 16;
            this.SetRandomShips.Text = "Случайное размещение кораблей";
            this.SetRandomShips.UseVisualStyleBackColor = false;
            this.SetRandomShips.Click += new System.EventHandler(this.SetRandomShips_Click);
            // 
            // ClearFieldBtn
            // 
            this.ClearFieldBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClearFieldBtn.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearFieldBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClearFieldBtn.Location = new System.Drawing.Point(712, 491);
            this.ClearFieldBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearFieldBtn.Name = "ClearFieldBtn";
            this.ClearFieldBtn.Size = new System.Drawing.Size(135, 65);
            this.ClearFieldBtn.TabIndex = 17;
            this.ClearFieldBtn.Text = "Очистить поле";
            this.ClearFieldBtn.UseVisualStyleBackColor = false;
            this.ClearFieldBtn.Click += new System.EventHandler(this.ClearFieldBtn_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(124, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ваше поле";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1004, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Поле противника";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamePlayerName
            // 
            this.gamePlayerName.Location = new System.Drawing.Point(699, 588);
            this.gamePlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gamePlayerName.Name = "gamePlayerName";
            this.gamePlayerName.Size = new System.Drawing.Size(87, 29);
            this.gamePlayerName.TabIndex = 21;
            this.gamePlayerName.Text = "label7";
            this.gamePlayerName.Visible = false;
            this.gamePlayerName.Click += new System.EventHandler(this.gamePlayerName_Click);
            // 
            // ToMainMenuBtn
            // 
            this.ToMainMenuBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ToMainMenuBtn.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenuBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ToMainMenuBtn.Location = new System.Drawing.Point(0, 538);
            this.ToMainMenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ToMainMenuBtn.Name = "ToMainMenuBtn";
            this.ToMainMenuBtn.Size = new System.Drawing.Size(136, 79);
            this.ToMainMenuBtn.TabIndex = 22;
            this.ToMainMenuBtn.Text = "В главное меню";
            this.ToMainMenuBtn.UseVisualStyleBackColor = false;
            this.ToMainMenuBtn.Click += new System.EventHandler(this.ToMainMenuBtn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 653);
            this.Controls.Add(this.ToMainMenuBtn);
            this.Controls.Add(this.gamePlayerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClearFieldBtn);
            this.Controls.Add(this.SetRandomShips);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShotTipsLabel);
            this.Controls.Add(this.MissTipsLabel);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.SelectShip);
            this.Controls.Add(this.SelectShipDirection);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской бой";
            this.Load += new System.EventHandler(this.Game_Load);
            this.SelectShipDirection.ResumeLayout(false);
            this.SelectShipDirection.PerformLayout();
            this.SelectShip.ResumeLayout(false);
            this.SelectShip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button ToMainMenuBtn;

        public System.Windows.Forms.Label gamePlayerName;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button ClearFieldBtn;

        private System.Windows.Forms.Button SetRandomShips;

        private System.Windows.Forms.Button SEtRandomShips;

        private System.Windows.Forms.Label playerScoreLabel;

        private System.Windows.Forms.Label playerScore;

        private System.Windows.Forms.Label ShotTipsLabel;

        private System.Windows.Forms.Label MissTipsLabel;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button StartGameBtn;

        private System.Windows.Forms.Label fourShipsLabel;

        private System.Windows.Forms.Label threeShipslabel;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label twoShipsLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.RadioButton four;

        private System.Windows.Forms.RadioButton three;

        private System.Windows.Forms.RadioButton two;

        private System.Windows.Forms.GroupBox SelectShip;

        private System.Windows.Forms.GroupBox SelectShipDirection;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.RadioButton Horizontal;

        private System.Windows.Forms.RadioButton Vertical;
        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.RadioButton horizontal;

        #endregion
    }
}