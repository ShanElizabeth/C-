namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.TeamNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectMmeberComboBox = new System.Windows.Forms.ComboBox();
            this.AddMemberTeamButton = new System.Windows.Forms.Button();
            this.CreateMemButtonteam = new System.Windows.Forms.Button();
            this.firstnameLabelForm = new System.Windows.Forms.Label();
            this.firstNameValueTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameLabelCreateTeam = new System.Windows.Forms.Label();
            this.LastNameValueCreatTeam = new System.Windows.Forms.TextBox();
            this.EmailLabelCreateForm = new System.Windows.Forms.Label();
            this.EmailTextBoxValue = new System.Windows.Forms.TextBox();
            this.CellphoneCerateMemberLabel = new System.Windows.Forms.Label();
            this.CellPhoneCreateMmeberValue = new System.Windows.Forms.TextBox();
            this.AddNewMemberGroupbox = new System.Windows.Forms.GroupBox();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.DeletedSelectedMembersButoon = new System.Windows.Forms.Button();
            this.AddNewMemberGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateTeamLabel.Location = new System.Drawing.Point(12, 9);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(196, 45);
            this.CreateTeamLabel.TabIndex = 0;
            this.CreateTeamLabel.Text = "Create Team";
            this.CreateTeamLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.BackColor = System.Drawing.Color.White;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeamNameLabel.Location = new System.Drawing.Point(12, 73);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(179, 45);
            this.TeamNameLabel.TabIndex = 1;
            this.TeamNameLabel.Text = "Team Name";
            this.TeamNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(12, 177);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(300, 45);
            this.SelectTeamMemberLabel.TabIndex = 2;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // TeamNameTextBox
            // 
            this.TeamNameTextBox.Location = new System.Drawing.Point(23, 132);
            this.TeamNameTextBox.Name = "TeamNameTextBox";
            this.TeamNameTextBox.Size = new System.Drawing.Size(274, 31);
            this.TeamNameTextBox.TabIndex = 3;
            this.TeamNameTextBox.TextChanged += new System.EventHandler(this.TeamNameTextBox_TextChanged);
            // 
            // SelectMmeberComboBox
            // 
            this.SelectMmeberComboBox.FormattingEnabled = true;
            this.SelectMmeberComboBox.Location = new System.Drawing.Point(23, 237);
            this.SelectMmeberComboBox.Name = "SelectMmeberComboBox";
            this.SelectMmeberComboBox.Size = new System.Drawing.Size(274, 33);
            this.SelectMmeberComboBox.TabIndex = 4;
            // 
            // AddMemberTeamButton
            // 
            this.AddMemberTeamButton.Location = new System.Drawing.Point(70, 296);
            this.AddMemberTeamButton.Name = "AddMemberTeamButton";
            this.AddMemberTeamButton.Size = new System.Drawing.Size(166, 34);
            this.AddMemberTeamButton.TabIndex = 5;
            this.AddMemberTeamButton.Text = "Add Member";
            this.AddMemberTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateMemButtonteam
            // 
            this.CreateMemButtonteam.Location = new System.Drawing.Point(211, 279);
            this.CreateMemButtonteam.Name = "CreateMemButtonteam";
            this.CreateMemButtonteam.Size = new System.Drawing.Size(166, 34);
            this.CreateMemButtonteam.TabIndex = 5;
            this.CreateMemButtonteam.Text = "CreateMember";
            this.CreateMemButtonteam.UseVisualStyleBackColor = true;
            // 
            // firstnameLabelForm
            // 
            this.firstnameLabelForm.AutoSize = true;
            this.firstnameLabelForm.BackColor = System.Drawing.Color.White;
            this.firstnameLabelForm.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameLabelForm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.firstnameLabelForm.Location = new System.Drawing.Point(2, 48);
            this.firstnameLabelForm.Name = "firstnameLabelForm";
            this.firstnameLabelForm.Size = new System.Drawing.Size(122, 32);
            this.firstnameLabelForm.TabIndex = 1;
            this.firstnameLabelForm.Text = "First Name";
            this.firstnameLabelForm.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstNameValueTxtBox
            // 
            this.firstNameValueTxtBox.Location = new System.Drawing.Point(156, 51);
            this.firstNameValueTxtBox.Name = "firstNameValueTxtBox";
            this.firstNameValueTxtBox.Size = new System.Drawing.Size(274, 31);
            this.firstNameValueTxtBox.TabIndex = 3;
            // 
            // LastNameLabelCreateTeam
            // 
            this.LastNameLabelCreateTeam.AutoSize = true;
            this.LastNameLabelCreateTeam.BackColor = System.Drawing.Color.White;
            this.LastNameLabelCreateTeam.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabelCreateTeam.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LastNameLabelCreateTeam.Location = new System.Drawing.Point(2, 104);
            this.LastNameLabelCreateTeam.Name = "LastNameLabelCreateTeam";
            this.LastNameLabelCreateTeam.Size = new System.Drawing.Size(121, 32);
            this.LastNameLabelCreateTeam.TabIndex = 1;
            this.LastNameLabelCreateTeam.Text = "Last Name";
            this.LastNameLabelCreateTeam.Click += new System.EventHandler(this.label2_Click);
            // 
            // LastNameValueCreatTeam
            // 
            this.LastNameValueCreatTeam.Location = new System.Drawing.Point(156, 107);
            this.LastNameValueCreatTeam.Name = "LastNameValueCreatTeam";
            this.LastNameValueCreatTeam.Size = new System.Drawing.Size(274, 31);
            this.LastNameValueCreatTeam.TabIndex = 3;
            // 
            // EmailLabelCreateForm
            // 
            this.EmailLabelCreateForm.AutoSize = true;
            this.EmailLabelCreateForm.BackColor = System.Drawing.Color.White;
            this.EmailLabelCreateForm.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabelCreateForm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmailLabelCreateForm.Location = new System.Drawing.Point(1, 157);
            this.EmailLabelCreateForm.Name = "EmailLabelCreateForm";
            this.EmailLabelCreateForm.Size = new System.Drawing.Size(68, 32);
            this.EmailLabelCreateForm.TabIndex = 1;
            this.EmailLabelCreateForm.Text = "Email";
            this.EmailLabelCreateForm.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmailTextBoxValue
            // 
            this.EmailTextBoxValue.Location = new System.Drawing.Point(155, 160);
            this.EmailTextBoxValue.Name = "EmailTextBoxValue";
            this.EmailTextBoxValue.Size = new System.Drawing.Size(274, 31);
            this.EmailTextBoxValue.TabIndex = 3;
            // 
            // CellphoneCerateMemberLabel
            // 
            this.CellphoneCerateMemberLabel.AutoSize = true;
            this.CellphoneCerateMemberLabel.BackColor = System.Drawing.Color.White;
            this.CellphoneCerateMemberLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellphoneCerateMemberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CellphoneCerateMemberLabel.Location = new System.Drawing.Point(2, 215);
            this.CellphoneCerateMemberLabel.Name = "CellphoneCerateMemberLabel";
            this.CellphoneCerateMemberLabel.Size = new System.Drawing.Size(115, 32);
            this.CellphoneCerateMemberLabel.TabIndex = 1;
            this.CellphoneCerateMemberLabel.Text = "CellPhone";
            this.CellphoneCerateMemberLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CellPhoneCreateMmeberValue
            // 
            this.CellPhoneCreateMmeberValue.Location = new System.Drawing.Point(156, 218);
            this.CellPhoneCreateMmeberValue.Name = "CellPhoneCreateMmeberValue";
            this.CellPhoneCreateMmeberValue.Size = new System.Drawing.Size(274, 31);
            this.CellPhoneCreateMmeberValue.TabIndex = 3;
            // 
            // AddNewMemberGroupbox
            // 
            this.AddNewMemberGroupbox.Controls.Add(this.firstNameValueTxtBox);
            this.AddNewMemberGroupbox.Controls.Add(this.CellPhoneCreateMmeberValue);
            this.AddNewMemberGroupbox.Controls.Add(this.CreateMemButtonteam);
            this.AddNewMemberGroupbox.Controls.Add(this.CellphoneCerateMemberLabel);
            this.AddNewMemberGroupbox.Controls.Add(this.firstnameLabelForm);
            this.AddNewMemberGroupbox.Controls.Add(this.EmailTextBoxValue);
            this.AddNewMemberGroupbox.Controls.Add(this.LastNameLabelCreateTeam);
            this.AddNewMemberGroupbox.Controls.Add(this.EmailLabelCreateForm);
            this.AddNewMemberGroupbox.Controls.Add(this.LastNameValueCreatTeam);
            this.AddNewMemberGroupbox.Location = new System.Drawing.Point(12, 372);
            this.AddNewMemberGroupbox.Name = "AddNewMemberGroupbox";
            this.AddNewMemberGroupbox.Size = new System.Drawing.Size(496, 337);
            this.AddNewMemberGroupbox.TabIndex = 6;
            this.AddNewMemberGroupbox.TabStop = false;
            this.AddNewMemberGroupbox.Text = "Add New Member";
            this.AddNewMemberGroupbox.Enter += new System.EventHandler(this.AddNewMemberGroupbox_Enter);
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 25;
            this.teamMembersListBox.Location = new System.Drawing.Point(638, 73);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(283, 529);
            this.teamMembersListBox.TabIndex = 7;
            this.teamMembersListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.Location = new System.Drawing.Point(892, 675);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(166, 34);
            this.CreateTeamButton.TabIndex = 5;
            this.CreateTeamButton.Text = "CreateTeam";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // DeletedSelectedMembersButoon
            // 
            this.DeletedSelectedMembersButoon.Location = new System.Drawing.Point(927, 296);
            this.DeletedSelectedMembersButoon.Name = "DeletedSelectedMembersButoon";
            this.DeletedSelectedMembersButoon.Size = new System.Drawing.Size(166, 34);
            this.DeletedSelectedMembersButoon.TabIndex = 5;
            this.DeletedSelectedMembersButoon.Text = "Delete Selected";
            this.DeletedSelectedMembersButoon.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 744);
            this.Controls.Add(this.DeletedSelectedMembersButoon);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.AddNewMemberGroupbox);
            this.Controls.Add(this.AddMemberTeamButton);
            this.Controls.Add(this.SelectMmeberComboBox);
            this.Controls.Add(this.TeamNameTextBox);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.CreateTeamLabel);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team ";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.AddNewMemberGroupbox.ResumeLayout(false);
            this.AddNewMemberGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.Label CreateTeamLabel;
        private System.Windows.Forms.Label TeamLabelName;
        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label SelectTeamMemLabel;
        private System.Windows.Forms.ComboBox SelectTeamValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox TeamNameTextBox;
        private System.Windows.Forms.GroupBox CreateMemberBox;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button DeleteSelectedMemberButton;
        private System.Windows.Forms.Label CreateTeamHeader;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.ComboBox SelectMmeberComboBox;
        private System.Windows.Forms.Button AddMemberTeamButton;
        private System.Windows.Forms.Button CreateMemButtonteam;
        private System.Windows.Forms.Label firstnameLabelForm;
        private System.Windows.Forms.TextBox firstNameValueTxtBox;
        private System.Windows.Forms.Label LastNameLabelCreateTeam;
        private System.Windows.Forms.TextBox LastNameValueCreatTeam;
        private System.Windows.Forms.Label EmailLabelCreateForm;
        private System.Windows.Forms.TextBox EmailTextBoxValue;
        private System.Windows.Forms.Label CellphoneCerateMemberLabel;
        private System.Windows.Forms.TextBox CellPhoneCreateMmeberValue;
        private System.Windows.Forms.GroupBox AddNewMemberGroupbox;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.Button DeletedSelectedMembersButoon;
    }
}