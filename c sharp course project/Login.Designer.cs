namespace c_sharp_course_project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.enterBtn = new System.Windows.Forms.Button();
            this.enterNameLabal = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.enterBtn.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterBtn.ForeColor = System.Drawing.Color.Black;
            this.enterBtn.Location = new System.Drawing.Point(57, 248);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(237, 44);
            this.enterBtn.TabIndex = 0;
            this.enterBtn.Text = "Войти";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // enterNameLabal
            // 
            this.enterNameLabal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterNameLabal.AutoEllipsis = true;
            this.enterNameLabal.BackColor = System.Drawing.SystemColors.Highlight;
            this.enterNameLabal.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNameLabal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enterNameLabal.Location = new System.Drawing.Point(57, 70);
            this.enterNameLabal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterNameLabal.Name = "enterNameLabal";
            this.enterNameLabal.Size = new System.Drawing.Size(237, 64);
            this.enterNameLabal.TabIndex = 1;
            this.enterNameLabal.Text = "Введите ваше имя или никнейм, чтобы продолжить";
            this.enterNameLabal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nickname
            // 
            this.nickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nickname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickname.Location = new System.Drawing.Point(57, 179);
            this.nickname.Margin = new System.Windows.Forms.Padding(2);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(239, 27);
            this.nickname.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 354);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.enterNameLabal);
            this.Controls.Add(this.enterBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской бой";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.TextBox nickname;

        private System.Windows.Forms.Button enterBtn;

        private System.Windows.Forms.Label enterNameLabal;

        private System.Windows.Forms.TextBox playerName;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}