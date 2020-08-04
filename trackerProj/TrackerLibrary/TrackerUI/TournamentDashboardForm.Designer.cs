namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.LoadTournamentBtn = new System.Windows.Forms.Button();
            this.CreateTournamentBtn = new System.Windows.Forms.Button();
            this.TournamentDashboardHeaderLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadExistingComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LoadTournamentBtn
            // 
            this.LoadTournamentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadTournamentBtn.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadTournamentBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadTournamentBtn.Location = new System.Drawing.Point(206, 281);
            this.LoadTournamentBtn.Name = "LoadTournamentBtn";
            this.LoadTournamentBtn.Size = new System.Drawing.Size(241, 60);
            this.LoadTournamentBtn.TabIndex = 0;
            this.LoadTournamentBtn.Text = "LoadTournament";
            this.LoadTournamentBtn.UseVisualStyleBackColor = true;
            this.LoadTournamentBtn.Click += new System.EventHandler(this.LoadTournamentBtn_Click);
            // 
            // CreateTournamentBtn
            // 
            this.CreateTournamentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateTournamentBtn.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateTournamentBtn.Location = new System.Drawing.Point(206, 476);
            this.CreateTournamentBtn.Name = "CreateTournamentBtn";
            this.CreateTournamentBtn.Size = new System.Drawing.Size(241, 60);
            this.CreateTournamentBtn.TabIndex = 0;
            this.CreateTournamentBtn.Text = "CreateTournament";
            this.CreateTournamentBtn.UseVisualStyleBackColor = true;
            this.CreateTournamentBtn.Click += new System.EventHandler(this.LoadTournamentBtn_Click);
            // 
            // TournamentDashboardHeaderLabel
            // 
            this.TournamentDashboardHeaderLabel.AutoSize = true;
            this.TournamentDashboardHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentDashboardHeaderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TournamentDashboardHeaderLabel.Location = new System.Drawing.Point(145, 9);
            this.TournamentDashboardHeaderLabel.Name = "TournamentDashboardHeaderLabel";
            this.TournamentDashboardHeaderLabel.Size = new System.Drawing.Size(362, 45);
            this.TournamentDashboardHeaderLabel.TabIndex = 0;
            this.TournamentDashboardHeaderLabel.Text = "Tournament  Dashboard";
            this.TournamentDashboardHeaderLabel.Click += new System.EventHandler(this.TournamentDashboardHeaderLabel_Click);
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(133, 107);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(386, 45);
            this.loadExistingTournamentLabel.TabIndex = 0;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // LoadExistingComboBox
            // 
            this.LoadExistingComboBox.FormattingEnabled = true;
            this.LoadExistingComboBox.Location = new System.Drawing.Point(144, 198);
            this.LoadExistingComboBox.Name = "LoadExistingComboBox";
            this.LoadExistingComboBox.Size = new System.Drawing.Size(364, 33);
            this.LoadExistingComboBox.TabIndex = 1;
            // 
            // TournamentDashboardForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 615);
            this.Controls.Add(this.LoadExistingComboBox);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.TournamentDashboardHeaderLabel);
            this.Controls.Add(this.CreateTournamentBtn);
            this.Controls.Add(this.LoadTournamentBtn);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashboardHeader;
        private System.Windows.Forms.Label LoadExistingTourLabel;
        private System.Windows.Forms.ComboBox LoadTournamentComboBox;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadTournamentBtn;
        private System.Windows.Forms.Button CreateTournamentBtn;
        private System.Windows.Forms.Label TournamentDashboardHeaderLabel;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.ComboBox LoadExistingComboBox;
    }
}