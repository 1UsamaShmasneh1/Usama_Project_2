
namespace Hospital
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
            this.AddPeopleButton = new System.Windows.Forms.Button();
            this.GetTurnButton = new System.Windows.Forms.Button();
            this.SecretaryButton = new System.Windows.Forms.Button();
            this.NurseBotton = new System.Windows.Forms.Button();
            this.DoctorButton = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPeopleButton
            // 
            this.AddPeopleButton.Location = new System.Drawing.Point(12, 12);
            this.AddPeopleButton.Name = "AddPeopleButton";
            this.AddPeopleButton.Size = new System.Drawing.Size(139, 39);
            this.AddPeopleButton.TabIndex = 0;
            this.AddPeopleButton.Text = "Add People";
            this.AddPeopleButton.UseVisualStyleBackColor = true;
            this.AddPeopleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetTurnButton
            // 
            this.GetTurnButton.Location = new System.Drawing.Point(12, 57);
            this.GetTurnButton.Name = "GetTurnButton";
            this.GetTurnButton.Size = new System.Drawing.Size(139, 39);
            this.GetTurnButton.TabIndex = 1;
            this.GetTurnButton.Text = "Get Turn";
            this.GetTurnButton.UseVisualStyleBackColor = true;
            // 
            // SecretaryButton
            // 
            this.SecretaryButton.Location = new System.Drawing.Point(12, 102);
            this.SecretaryButton.Name = "SecretaryButton";
            this.SecretaryButton.Size = new System.Drawing.Size(139, 39);
            this.SecretaryButton.TabIndex = 2;
            this.SecretaryButton.Text = "Secretary";
            this.SecretaryButton.UseVisualStyleBackColor = true;
            // 
            // NurseBotton
            // 
            this.NurseBotton.Location = new System.Drawing.Point(12, 147);
            this.NurseBotton.Name = "NurseBotton";
            this.NurseBotton.Size = new System.Drawing.Size(139, 39);
            this.NurseBotton.TabIndex = 3;
            this.NurseBotton.Text = "Nurse";
            this.NurseBotton.UseVisualStyleBackColor = true;
            // 
            // DoctorButton
            // 
            this.DoctorButton.Location = new System.Drawing.Point(12, 192);
            this.DoctorButton.Name = "DoctorButton";
            this.DoctorButton.Size = new System.Drawing.Size(139, 39);
            this.DoctorButton.TabIndex = 4;
            this.DoctorButton.Text = "Doctor";
            this.DoctorButton.UseVisualStyleBackColor = true;
            // 
            // Rooms
            // 
            this.Rooms.Location = new System.Drawing.Point(12, 237);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(139, 39);
            this.Rooms.TabIndex = 5;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 290);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.DoctorButton);
            this.Controls.Add(this.NurseBotton);
            this.Controls.Add(this.SecretaryButton);
            this.Controls.Add(this.GetTurnButton);
            this.Controls.Add(this.AddPeopleButton);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddPeopleButton;
        private System.Windows.Forms.Button GetTurnButton;
        private System.Windows.Forms.Button SecretaryButton;
        private System.Windows.Forms.Button NurseBotton;
        private System.Windows.Forms.Button DoctorButton;
        private System.Windows.Forms.Button Rooms;
    }
}