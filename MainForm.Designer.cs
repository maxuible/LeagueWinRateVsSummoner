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
            txtNumOfTimesOnSameTeam = new TextBox();
            txtNumOfTimesOnEnemyTeam = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtWinsOnSameTeam = new TextBox();
            label10 = new Label();
            txtLosesOnSameTeam = new TextBox();
            label11 = new Label();
            txtWinsOnEnemyTeam = new TextBox();
            txtLosesOnEnemyTeam = new TextBox();
            label12 = new Label();
            txtStatus = new TextBox();
            label13 = new Label();
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
            // txtNumOfTimesOnSameTeam
            // 
            txtNumOfTimesOnSameTeam.Location = new Point(306, 267);
            txtNumOfTimesOnSameTeam.Name = "txtNumOfTimesOnSameTeam";
            txtNumOfTimesOnSameTeam.Size = new Size(78, 23);
            txtNumOfTimesOnSameTeam.TabIndex = 15;
            // 
            // txtNumOfTimesOnEnemyTeam
            // 
            txtNumOfTimesOnEnemyTeam.Location = new Point(620, 267);
            txtNumOfTimesOnEnemyTeam.Name = "txtNumOfTimesOnEnemyTeam";
            txtNumOfTimesOnEnemyTeam.Size = new Size(78, 23);
            txtNumOfTimesOnEnemyTeam.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 270);
            label7.Name = "label7";
            label7.Size = new Size(160, 15);
            label7.TabIndex = 17;
            label7.Text = "Num Of times on same team";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(446, 270);
            label8.Name = "label8";
            label8.Size = new Size(168, 15);
            label8.TabIndex = 18;
            label8.Text = "Num Of times on Enemy team";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(117, 301);
            label9.Name = "label9";
            label9.Size = new Size(183, 15);
            label9.TabIndex = 19;
            label9.Text = "Wins with Player 2 on Same Team";
            // 
            // txtWinsOnSameTeam
            // 
            txtWinsOnSameTeam.Location = new Point(306, 296);
            txtWinsOnSameTeam.Name = "txtWinsOnSameTeam";
            txtWinsOnSameTeam.Size = new Size(78, 23);
            txtWinsOnSameTeam.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(114, 328);
            label10.Name = "label10";
            label10.Size = new Size(186, 15);
            label10.TabIndex = 21;
            label10.Text = "Loses with Player 2 on Same Team";
            // 
            // txtLosesOnSameTeam
            // 
            txtLosesOnSameTeam.Location = new Point(306, 325);
            txtLosesOnSameTeam.Name = "txtLosesOnSameTeam";
            txtLosesOnSameTeam.Size = new Size(78, 23);
            txtLosesOnSameTeam.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(424, 301);
            label11.Name = "label11";
            label11.Size = new Size(190, 15);
            label11.TabIndex = 23;
            label11.Text = "Wins with Player 2 on Enemy Team";
            // 
            // txtWinsOnEnemyTeam
            // 
            txtWinsOnEnemyTeam.Location = new Point(620, 296);
            txtWinsOnEnemyTeam.Name = "txtWinsOnEnemyTeam";
            txtWinsOnEnemyTeam.Size = new Size(78, 23);
            txtWinsOnEnemyTeam.TabIndex = 24;
            // 
            // txtLosesOnEnemyTeam
            // 
            txtLosesOnEnemyTeam.Location = new Point(620, 325);
            txtLosesOnEnemyTeam.Name = "txtLosesOnEnemyTeam";
            txtLosesOnEnemyTeam.Size = new Size(78, 23);
            txtLosesOnEnemyTeam.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(421, 328);
            label12.Name = "label12";
            label12.Size = new Size(193, 15);
            label12.TabIndex = 26;
            label12.Text = "Loses with Player 2 on Enemy Team";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(563, 415);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(225, 23);
            txtStatus.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(563, 397);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 28;
            label13.Text = "Status";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(txtStatus);
            Controls.Add(label12);
            Controls.Add(txtLosesOnEnemyTeam);
            Controls.Add(txtWinsOnEnemyTeam);
            Controls.Add(label11);
            Controls.Add(txtLosesOnSameTeam);
            Controls.Add(label10);
            Controls.Add(txtWinsOnSameTeam);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtNumOfTimesOnEnemyTeam);
            Controls.Add(txtNumOfTimesOnSameTeam);
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
        private TextBox txtNumOfTimesOnSameTeam;
        private TextBox txtNumOfTimesOnEnemyTeam;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtWinsOnSameTeam;
        private Label label10;
        private TextBox txtLosesOnSameTeam;
        private Label label11;
        private TextBox txtWinsOnEnemyTeam;
        private TextBox txtLosesOnEnemyTeam;
        private Label label12;
        private TextBox txtStatus;
        private Label label13;
    }
}