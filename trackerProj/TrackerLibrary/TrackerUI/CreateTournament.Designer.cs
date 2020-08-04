namespace TrackerUI
{
    partial class CreateTournament
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
            this.addTeamButton = new System.Windows.Forms.Button();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.createTournamentTitle = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.textBoxTournamentName = new System.Windows.Forms.TextBox();
            this.TeamPlayersLabel = new System.Windows.Forms.Label();
            this.CreatePrizeButtom = new System.Windows.Forms.Button();
            this.EntryFeeTextBox = new System.Windows.Forms.TextBox();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.listBoxPrizes = new System.Windows.Forms.ListBox();
            this.TeamPlayerPrizeLabel = new System.Windows.Forms.Label();
            this.deletePrizeButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.White;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addTeamButton.Location = new System.Drawing.Point(95, 302);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(126, 41);
            this.addTeamButton.TabIndex = 6;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SelectTeamLabel.Location = new System.Drawing.Point(3, 222);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(156, 38);
            this.SelectTeamLabel.TabIndex = 4;
            this.SelectTeamLabel.Text = "SelectTeam";
            this.SelectTeamLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EntryFeeLabel.Location = new System.Drawing.Point(3, 166);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(124, 38);
            this.EntryFeeLabel.TabIndex = 4;
            this.EntryFeeLabel.Text = "EntryFee";
            this.EntryFeeLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 25;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(368, 111);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(310, 127);
            this.tournamentPlayersListBox.TabIndex = 3;
            this.tournamentPlayersListBox.SelectedIndexChanged += new System.EventHandler(this.MatchUpListBox_SelectedIndexChanged);
            // 
            // createTournamentTitle
            // 
            this.createTournamentTitle.AutoSize = true;
            this.createTournamentTitle.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createTournamentTitle.Location = new System.Drawing.Point(-11, -9);
            this.createTournamentTitle.Name = "createTournamentTitle";
            this.createTournamentTitle.Size = new System.Drawing.Size(478, 74);
            this.createTournamentTitle.TabIndex = 0;
            this.createTournamentTitle.Text = "Create Tournament";
            this.createTournamentTitle.Click += new System.EventHandler(this.label6_Click);
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TournamentNameLabel.Location = new System.Drawing.Point(3, 65);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(284, 45);
            this.TournamentNameLabel.TabIndex = 0;
            this.TournamentNameLabel.Text = "Tournament Name";
            this.TournamentNameLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxTournamentName
            // 
            this.textBoxTournamentName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxTournamentName.Location = new System.Drawing.Point(12, 113);
            this.textBoxTournamentName.Name = "textBoxTournamentName";
            this.textBoxTournamentName.Size = new System.Drawing.Size(305, 31);
            this.textBoxTournamentName.TabIndex = 5;
            this.textBoxTournamentName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TeamPlayersLabel
            // 
            this.TeamPlayersLabel.AutoSize = true;
            this.TeamPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamPlayersLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeamPlayersLabel.Location = new System.Drawing.Point(360, 70);
            this.TeamPlayersLabel.Name = "TeamPlayersLabel";
            this.TeamPlayersLabel.Size = new System.Drawing.Size(193, 38);
            this.TeamPlayersLabel.TabIndex = 4;
            this.TeamPlayersLabel.Text = "Teams/Players";
            this.TeamPlayersLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CreatePrizeButtom
            // 
            this.CreatePrizeButtom.BackColor = System.Drawing.Color.White;
            this.CreatePrizeButtom.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButtom.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CreatePrizeButtom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreatePrizeButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButtom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeButtom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreatePrizeButtom.Location = new System.Drawing.Point(95, 370);
            this.CreatePrizeButtom.Name = "CreatePrizeButtom";
            this.CreatePrizeButtom.Size = new System.Drawing.Size(126, 41);
            this.CreatePrizeButtom.TabIndex = 6;
            this.CreatePrizeButtom.Text = "CreatePrize";
            this.CreatePrizeButtom.UseVisualStyleBackColor = false;
            this.CreatePrizeButtom.Click += new System.EventHandler(this.button1_Click);
            // 
            // EntryFeeTextBox
            // 
            this.EntryFeeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EntryFeeTextBox.Location = new System.Drawing.Point(144, 174);
            this.EntryFeeTextBox.Name = "EntryFeeTextBox";
            this.EntryFeeTextBox.Size = new System.Drawing.Size(134, 31);
            this.EntryFeeTextBox.TabIndex = 5;
            this.EntryFeeTextBox.Text = "0";
            this.EntryFeeTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(12, 263);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(305, 33);
            this.selectTeamDropDown.TabIndex = 1;
            this.selectTeamDropDown.Text = "Choose";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(209, 233);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(108, 25);
            this.createNewTeamLink.TabIndex = 7;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create Team";
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.BackColor = System.Drawing.Color.White;
            this.deleteTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteTeamButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteTeamButton.Location = new System.Drawing.Point(684, 151);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(104, 76);
            this.deleteTeamButton.TabIndex = 6;
            this.deleteTeamButton.Text = "Delete Selected";
            this.deleteTeamButton.UseVisualStyleBackColor = false;
            this.deleteTeamButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPrizes
            // 
            this.listBoxPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPrizes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBoxPrizes.FormattingEnabled = true;
            this.listBoxPrizes.ItemHeight = 25;
            this.listBoxPrizes.Location = new System.Drawing.Point(368, 311);
            this.listBoxPrizes.Name = "listBoxPrizes";
            this.listBoxPrizes.Size = new System.Drawing.Size(310, 127);
            this.listBoxPrizes.TabIndex = 3;
            this.listBoxPrizes.SelectedIndexChanged += new System.EventHandler(this.MatchUpListBox_SelectedIndexChanged);
            // 
            // TeamPlayerPrizeLabel
            // 
            this.TeamPlayerPrizeLabel.AutoSize = true;
            this.TeamPlayerPrizeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamPlayerPrizeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeamPlayerPrizeLabel.Location = new System.Drawing.Point(360, 270);
            this.TeamPlayerPrizeLabel.Name = "TeamPlayerPrizeLabel";
            this.TeamPlayerPrizeLabel.Size = new System.Drawing.Size(193, 38);
            this.TeamPlayerPrizeLabel.TabIndex = 4;
            this.TeamPlayerPrizeLabel.Text = "Teams/Players";
            this.TeamPlayerPrizeLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // deletePrizeButton
            // 
            this.deletePrizeButton.BackColor = System.Drawing.Color.White;
            this.deletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deletePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletePrizeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletePrizeButton.Location = new System.Drawing.Point(684, 351);
            this.deletePrizeButton.Name = "deletePrizeButton";
            this.deletePrizeButton.Size = new System.Drawing.Size(104, 74);
            this.deletePrizeButton.TabIndex = 6;
            this.deletePrizeButton.Text = "Delete Selected";
            this.deletePrizeButton.UseVisualStyleBackColor = false;
            this.deletePrizeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(249, 481);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(249, 58);
            this.createTournamentButton.TabIndex = 8;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deletePrizeButton);
            this.Controls.Add(this.TeamPlayerPrizeLabel);
            this.Controls.Add(this.listBoxPrizes);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.EntryFeeTextBox);
            this.Controls.Add(this.CreatePrizeButtom);
            this.Controls.Add(this.TeamPlayersLabel);
            this.Controls.Add(this.textBoxTournamentName);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.createTournamentTitle);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.addTeamButton);
            this.Name = "CreateTournament";
            this.Text = "CreateTournament";
            this.Load += new System.EventHandler(this.CreateTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label createTournamentTitle;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox textBoxTournamentName;
        private System.Windows.Forms.Label TeamPlayersLabel;
        private System.Windows.Forms.Button CreatePrizeButtom;
        private System.Windows.Forms.TextBox EntryFeeTextBox;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.ListBox listBoxPrizes;
        private System.Windows.Forms.Label TeamPlayerPrizeLabel;
        private System.Windows.Forms.Button deletePrizeButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}