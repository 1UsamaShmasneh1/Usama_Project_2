
namespace Hospital
{
    partial class GetTurnForm
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
            this.TextBoxEnterId = new System.Windows.Forms.TextBox();
            this.labelEnterId = new System.Windows.Forms.Label();
            this.buttonEnterId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxEnterId
            // 
            this.TextBoxEnterId.Location = new System.Drawing.Point(40, 35);
            this.TextBoxEnterId.Name = "TextBoxEnterId";
            this.TextBoxEnterId.Size = new System.Drawing.Size(100, 23);
            this.TextBoxEnterId.TabIndex = 1;
            // 
            // labelEnterId
            // 
            this.labelEnterId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnterId.Location = new System.Drawing.Point(58, 9);
            this.labelEnterId.Name = "labelEnterId";
            this.labelEnterId.Size = new System.Drawing.Size(63, 23);
            this.labelEnterId.TabIndex = 2;
            this.labelEnterId.Text = "Enter Id";
            // 
            // buttonEnterId
            // 
            this.buttonEnterId.Location = new System.Drawing.Point(40, 64);
            this.buttonEnterId.Name = "buttonEnterId";
            this.buttonEnterId.Size = new System.Drawing.Size(100, 23);
            this.buttonEnterId.TabIndex = 3;
            this.buttonEnterId.Text = "Conferm";
            this.buttonEnterId.UseVisualStyleBackColor = true;
            this.buttonEnterId.Click += new System.EventHandler(this.buttonEnterId_Click);
            // 
            // GetTurnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 102);
            this.Controls.Add(this.labelEnterId);
            this.Controls.Add(this.buttonEnterId);
            this.Controls.Add(this.TextBoxEnterId);
            this.Name = "GetTurnForm";
            this.Text = "Get Turn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEnterId;
        private System.Windows.Forms.Label labelEnterId;
        private System.Windows.Forms.Button buttonEnterId;
    }
}

