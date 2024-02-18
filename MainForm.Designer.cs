namespace LeagueWinRateVsSummoner
{
    partial class MainForm
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
            txtPlayer1Name = new TextBox();
            txtPlayer1Tag = new TextBox();
            btnPlayer1GetPUUID = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPlayer1PUUID = new TextBox();
            txtPlayer2PUUID = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnPlayer2GetPUUID = new Button();
            txtPlayer2Tag = new TextBox();
            txtPlayer2Name = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnCalculateWinrate = new Button();
            SuspendLayout();
            // 
            // txtPlayer1Name
            // 
            txtPlayer1Name.Location = new Point(138, 25);
            txtPlayer1Name.Name = "txtPlayer1Name";
            txtPlayer1Name.Size = new Size(246, 23);
            txtPlayer1Name.TabIndex = 0;
            // 
            // txtPlayer1Tag
            // 
            txtPlayer1Tag.Location = new Point(138, 54);
            txtPlayer1Tag.Name = "txtPlayer1Tag";
            txtPlayer1Tag.Size = new Size(100, 23);
            txtPlayer1Tag.TabIndex = 1;
            // 
            // btnPlayer1GetPUUID
            // 
            btnPlayer1GetPUUID.Location = new Point(12, 83);
            btnPlayer1GetPUUID.Name = "btnPlayer1GetPUUID";
            btnPlayer1GetPUUID.Size = new Size(120, 23);
            btnPlayer1GetPUUID.TabIndex = 2;
            btnPlayer1GetPUUID.Text = "GetPUUID";
            btnPlayer1GetPUUID.UseVisualStyleBackColor = true;
            btnPlayer1GetPUUID.Click += btnPlayer1GetPUUID_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 3;
            label1.Text = "Summoner Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 4;
            label2.Text = "Tag";
            // 
            // txtPlayer1PUUID
            // 
            txtPlayer1PUUID.Location = new Point(138, 83);
            txtPlayer1PUUID.Name = "txtPlayer1PUUID";
            txtPlayer1PUUID.Size = new Size(650, 23);
            txtPlayer1PUUID.TabIndex = 5;
            // 
            // txtPlayer2PUUID
            // 
            txtPlayer2PUUID.Location = new Point(138, 211);
            txtPlayer2PUUID.Name = "txtPlayer2PUUID";
            txtPlayer2PUUID.Size = new Size(650, 23);
            txtPlayer2PUUID.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 10;
            label3.Text = "Tag";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 9;
            label4.Text = "Summoner Name";
            // 
            // btnPlayer2GetPUUID
            // 
            btnPlayer2GetPUUID.Location = new Point(12, 211);
            btnPlayer2GetPUUID.Name = "btnPlayer2GetPUUID";
            btnPlayer2GetPUUID.Size = new Size(120, 23);
            btnPlayer2GetPUUID.TabIndex = 8;
            btnPlayer2GetPUUID.Text = "GetPUUID";
            btnPlayer2GetPUUID.UseVisualStyleBackColor = true;
            btnPlayer2GetPUUID.Click += btnPlayer2GetPUUID_Click;
            // 
            // txtPlayer2Tag
            // 
            txtPlayer2Tag.Location = new Point(138, 182);
            txtPlayer2Tag.Name = "txtPlayer2Tag";
            txtPlayer2Tag.Size = new Size(100, 23);
            txtPlayer2Tag.TabIndex = 7;
            // 
            // txtPlayer2Name
            // 
            txtPlayer2Name.Location = new Point(138, 153);
            txtPlayer2Name.Name = "txtPlayer2Name";
            txtPlayer2Name.Size = new Size(246, 23);
            txtPlayer2Name.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 7);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 12;
            label5.Text = "Player 1 (YOU)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 135);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 13;
            label6.Text = "Player 2 (ENEMY)";
            // 
            // btnCalculateWinrate
            // 
            btnCalculateWinrate.Location = new Point(12, 266);
            btnCalculateWinrate.Name = "btnCalculateWinrate";
            btnCalculateWinrate.Size = new Size(120, 23);
            btnCalculateWinrate.TabIndex = 14;
            btnCalculateWinrate.Text = "Calculate winrate";
            btnCalculateWinrate.UseVisualStyleBackColor = true;
            btnCalculateWinrate.Click += btnCalculateWinrate_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculateWinrate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPlayer2PUUID);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnPlayer2GetPUUID);
            Controls.Add(txtPlayer2Tag);
            Controls.Add(txtPlayer2Name);
            Controls.Add(txtPlayer1PUUID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPlayer1GetPUUID);
            Controls.Add(txtPlayer1Tag);
            Controls.Add(txtPlayer1Name);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlayer1Name;
        private TextBox txtPlayer1Tag;
        private Button btnPlayer1GetPUUID;
        private Label label1;
        private Label label2;
        private TextBox txtPlayer1PUUID;
        private TextBox txtPlayer2PUUID;
        private Label label3;
        private Label label4;
        private Button btnPlayer2GetPUUID;
        private TextBox txtPlayer2Tag;
        private TextBox txtPlayer2Name;
        private Label label5;
        private Label label6;
        private Button btnCalculateWinrate;
    }
}