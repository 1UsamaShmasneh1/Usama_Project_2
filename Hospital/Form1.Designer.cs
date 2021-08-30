
namespace Hospital
{
    partial class Form1
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
            this.GetTurn = new System.Windows.Forms.GroupBox();
            this.buttonEnterId = new System.Windows.Forms.Button();
            this.labelEnterId = new System.Windows.Forms.Label();
            this.TextBoxEnterId = new System.Windows.Forms.TextBox();
            this.GetTurn.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetTurn
            // 
            this.GetTurn.Controls.Add(this.buttonEnterId);
            this.GetTurn.Controls.Add(this.labelEnterId);
            this.GetTurn.Controls.Add(this.TextBoxEnterId);
            this.GetTurn.Location = new System.Drawing.Point(0, 2);
            this.GetTurn.Name = "GetTurn";
            this.GetTurn.Size = new System.Drawing.Size(124, 94);
            this.GetTurn.TabIndex = 1;
            this.GetTurn.TabStop = false;
            this.GetTurn.Text = "GetTurn";
            // 
            // buttonEnterId
            // 
            this.buttonEnterId.Location = new System.Drawing.Point(12, 65);
            this.buttonEnterId.Name = "buttonEnterId";
            this.buttonEnterId.Size = new System.Drawing.Size(100, 23);
            this.buttonEnterId.TabIndex = 3;
            this.buttonEnterId.Text = "Conferm";
            this.buttonEnterId.UseVisualStyleBackColor = true;
            this.buttonEnterId.Click += new System.EventHandler(this.buttonEnterId_Click);
            // 
            // labelEnterId
            // 
            this.labelEnterId.AutoSize = true;
            this.labelEnterId.Location = new System.Drawing.Point(42, 19);
            this.labelEnterId.Name = "labelEnterId";
            this.labelEnterId.Size = new System.Drawing.Size(47, 15);
            this.labelEnterId.TabIndex = 2;
            this.labelEnterId.Text = "Enter Id";
            // 
            // TextBoxEnterId
            // 
            this.TextBoxEnterId.Location = new System.Drawing.Point(12, 37);
            this.TextBoxEnterId.Name = "TextBoxEnterId";
            this.TextBoxEnterId.Size = new System.Drawing.Size(100, 23);
            this.TextBoxEnterId.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetTurn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GetTurn.ResumeLayout(false);
            this.GetTurn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GetTurn;
        private System.Windows.Forms.Label labelEnterId;
        private System.Windows.Forms.TextBox TextBoxEnterId;
        private System.Windows.Forms.Button buttonEnterId;
    }
}

