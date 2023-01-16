using System.ComponentModel;

namespace c_sharp_course_project
{
    partial class Records
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.label1 = new System.Windows.Forms.Label();
            this.ToMainMenuBtn = new System.Windows.Forms.Button();
            this.RecordsTable = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsPlayerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(387, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рекорды";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ToMainMenuBtn
            // 
            this.ToMainMenuBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToMainMenuBtn.AutoSize = true;
            this.ToMainMenuBtn.BackColor = System.Drawing.Color.Tomato;
            this.ToMainMenuBtn.Font = new System.Drawing.Font("NEXT ART", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenuBtn.Location = new System.Drawing.Point(353, 481);
            this.ToMainMenuBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToMainMenuBtn.Name = "ToMainMenuBtn";
            this.ToMainMenuBtn.Size = new System.Drawing.Size(166, 30);
            this.ToMainMenuBtn.TabIndex = 1;
            this.ToMainMenuBtn.Text = "Назад";
            this.ToMainMenuBtn.UseVisualStyleBackColor = false;
            this.ToMainMenuBtn.Click += new System.EventHandler(this.ToMainMenuBtn_Click);
            // 
            // RecordsTable
            // 
            this.RecordsTable.AllowUserToAddRows = false;
            this.RecordsTable.AllowUserToDeleteRows = false;
            this.RecordsTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecordsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecordsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RecordsTable.BackgroundColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RecordsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.playerScore});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.RecordsTable.Location = new System.Drawing.Point(178, 148);
            this.RecordsTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RecordsTable.Name = "RecordsTable";
            this.RecordsTable.ReadOnly = true;
            this.RecordsTable.RowHeadersWidth = 51;
            this.RecordsTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RecordsTable.RowTemplate.Height = 33;
            this.RecordsTable.Size = new System.Drawing.Size(522, 327);
            this.RecordsTable.TabIndex = 2;
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Имя";
            this.PlayerName.MinimumWidth = 6;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // playerScore
            // 
            this.playerScore.HeaderText = "Счёт";
            this.playerScore.MinimumWidth = 6;
            this.playerScore.Name = "playerScore";
            this.playerScore.ReadOnly = true;
            // 
            // recordsPlayerName
            // 
            this.recordsPlayerName.Location = new System.Drawing.Point(413, 513);
            this.recordsPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recordsPlayerName.Name = "recordsPlayerName";
            this.recordsPlayerName.Size = new System.Drawing.Size(67, 15);
            this.recordsPlayerName.TabIndex = 3;
            this.recordsPlayerName.Text = "label2";
            this.recordsPlayerName.Visible = false;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 658);
            this.Controls.Add(this.recordsPlayerName);
            this.Controls.Add(this.RecordsTable);
            this.Controls.Add(this.ToMainMenuBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.TransparencyKey = System.Drawing.SystemColors.GrayText;
            ((System.ComponentModel.ISupportInitialize)(this.RecordsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.Label recordsPlayerName;

        private System.Windows.Forms.DataGridViewTextBoxColumn playerScore;

        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;

        private System.Windows.Forms.DataGridView RecordsTable;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Button ToMainMenuBtn;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}