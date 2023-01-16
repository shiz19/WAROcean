using System.ComponentModel;

namespace c_sharp_course_project
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.RecordsBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartGameBtn.AutoSize = true;
            this.StartGameBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartGameBtn.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameBtn.Location = new System.Drawing.Point(206, 177);
            this.StartGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(166, 42);
            this.StartGameBtn.TabIndex = 0;
            this.StartGameBtn.Text = "Начать игру";
            this.StartGameBtn.UseVisualStyleBackColor = false;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // RecordsBtn
            // 
            this.RecordsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecordsBtn.AutoSize = true;
            this.RecordsBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RecordsBtn.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordsBtn.Location = new System.Drawing.Point(206, 223);
            this.RecordsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RecordsBtn.Name = "RecordsBtn";
            this.RecordsBtn.Size = new System.Drawing.Size(166, 39);
            this.RecordsBtn.TabIndex = 2;
            this.RecordsBtn.Text = "Рекорды";
            this.RecordsBtn.UseVisualStyleBackColor = false;
            this.RecordsBtn.Click += new System.EventHandler(this.RecordsBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitBtn.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(206, 279);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(166, 42);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("NEXT ART", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(186, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "МОРСКОЙ БОЙ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuPlayerName
            // 
            this.menuPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuPlayerName.Location = new System.Drawing.Point(168, 338);
            this.menuPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuPlayerName.Name = "menuPlayerName";
            this.menuPlayerName.Size = new System.Drawing.Size(249, 29);
            this.menuPlayerName.TabIndex = 5;
            this.menuPlayerName.Text = "label1";
            this.menuPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuPlayerName.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuPlayerName);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RecordsBtn);
            this.Controls.Add(this.StartGameBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской бой";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.Label welcomeLabel;

        private System.Windows.Forms.Button RecordsBtn;

        private System.Windows.Forms.Button StartGameBtn;

        private System.Windows.Forms.Button ExitBtn;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;

        #endregion

        public System.Windows.Forms.Label menuPlayerName;
    }
}