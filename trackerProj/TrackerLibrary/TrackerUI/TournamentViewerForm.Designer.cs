namespace TrackerUI
{
    partial class TournamentVDashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchUpListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.scoreTeam1Label = new System.Windows.Forms.Label();
            this.team1textboxScore = new System.Windows.Forms.TextBox();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.team2score = new System.Windows.Forms.Label();
            this.team2textboxscore = new System.Windows.Forms.TextBox();
            this.VsLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 20);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(322, 74);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tournamentName.Location = new System.Drawing.Point(328, 20);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(233, 74);
            this.tournamentName.TabIndex = 0;
            this.tournamentName.Text = "<None>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundLabel.Location = new System.Drawing.Point(31, 103);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(112, 45);
            this.roundLabel.TabIndex = 0;
            this.roundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            this.roundDropdown.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(170, 115);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(182, 33);
            this.roundDropdown.TabIndex = 1;
            this.roundDropdown.Text = "Choose";
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(170, 163);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(191, 36);
            this.unplayedOnlyCheckBox.TabIndex = 2;
            this.unplayedOnlyCheckBox.Text = "UnplayedOnly";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchUpListBox
            // 
            this.MatchUpListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchUpListBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MatchUpListBox.FormattingEnabled = true;
            this.MatchUpListBox.ItemHeight = 25;
            this.MatchUpListBox.Location = new System.Drawing.Point(31, 205);
            this.MatchUpListBox.Name = "MatchUpListBox";
            this.MatchUpListBox.Size = new System.Drawing.Size(321, 202);
            this.MatchUpListBox.TabIndex = 3;
            this.MatchUpListBox.SelectedIndexChanged += new System.EventHandler(this.MatchUpListBox_SelectedIndexChanged);
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.teamOneName.Location = new System.Drawing.Point(413, 187);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(148, 32);
            this.teamOneName.TabIndex = 4;
            this.teamOneName.Text = "<team one>";
            // 
            // scoreTeam1Label
            // 
            this.scoreTeam1Label.AutoSize = true;
            this.scoreTeam1Label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreTeam1Label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.scoreTeam1Label.Location = new System.Drawing.Point(413, 229);
            this.scoreTeam1Label.Name = "scoreTeam1Label";
            this.scoreTeam1Label.Size = new System.Drawing.Size(86, 38);
            this.scoreTeam1Label.TabIndex = 4;
            this.scoreTeam1Label.Text = "Score";
            // 
            // team1textboxScore
            // 
            this.team1textboxScore.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.team1textboxScore.Location = new System.Drawing.Point(505, 237);
            this.team1textboxScore.Name = "team1textboxScore";
            this.team1textboxScore.Size = new System.Drawing.Size(150, 31);
            this.team1textboxScore.TabIndex = 5;
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.teamTwoName.Location = new System.Drawing.Point(415, 328);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(146, 32);
            this.teamTwoName.TabIndex = 4;
            this.teamTwoName.Text = "<team two>";
            // 
            // team2score
            // 
            this.team2score.AutoSize = true;
            this.team2score.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.team2score.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.team2score.Location = new System.Drawing.Point(415, 360);
            this.team2score.Name = "team2score";
            this.team2score.Size = new System.Drawing.Size(86, 38);
            this.team2score.TabIndex = 4;
            this.team2score.Text = "Score";
            // 
            // team2textboxscore
            // 
            this.team2textboxscore.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.team2textboxscore.Location = new System.Drawing.Point(507, 368);
            this.team2textboxscore.Name = "team2textboxscore";
            this.team2textboxscore.Size = new System.Drawing.Size(150, 31);
            this.team2textboxscore.TabIndex = 5;
            // 
            // VsLabel
            // 
            this.VsLabel.AutoSize = true;
            this.VsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.VsLabel.Location = new System.Drawing.Point(413, 284);
            this.VsLabel.Name = "VsLabel";
            this.VsLabel.Size = new System.Drawing.Size(62, 32);
            this.VsLabel.TabIndex = 4;
            this.VsLabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            this.ScoreButton.BackColor = System.Drawing.Color.White;
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ScoreButton.Location = new System.Drawing.Point(662, 298);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(126, 41);
            this.ScoreButton.TabIndex = 6;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VsLabel);
            this.Controls.Add(this.team2textboxscore);
            this.Controls.Add(this.team2score);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.team1textboxScore);
            this.Controls.Add(this.scoreTeam1Label);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.MatchUpListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "TournamentViewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox MatchUpListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label scoreTeam1Label;
        private System.Windows.Forms.TextBox team1textboxScore;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label team2score;
        private System.Windows.Forms.TextBox team2textboxscore;
        private System.Windows.Forms.Label VsLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

