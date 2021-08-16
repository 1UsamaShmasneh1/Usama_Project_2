
namespace TemperatureProject
{
    partial class v
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
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddTemp = new System.Windows.Forms.Button();
            this.txtGetTemp = new System.Windows.Forms.Button();
            this.txtAddT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(324, 70);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(92, 23);
            this.txtBoxDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(422, 73);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(31, 15);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // txtAddTemp
            // 
            this.txtAddTemp.Location = new System.Drawing.Point(0, 0);
            this.txtAddTemp.Name = "txtAddTemp";
            this.txtAddTemp.Size = new System.Drawing.Size(75, 23);
            this.txtAddTemp.TabIndex = 6;
            // 
            // txtGetTemp
            // 
            this.txtGetTemp.Location = new System.Drawing.Point(325, 131);
            this.txtGetTemp.Name = "txtGetTemp";
            this.txtGetTemp.Size = new System.Drawing.Size(91, 26);
            this.txtGetTemp.TabIndex = 5;
            this.txtGetTemp.Text = "Get Temp";
            this.txtGetTemp.UseVisualStyleBackColor = true;
            this.txtGetTemp.Click += new System.EventHandler(this.txtGetTemp_Click);
            // 
            // txtAddT
            // 
            this.txtAddT.Location = new System.Drawing.Point(324, 99);
            this.txtAddT.Name = "txtAddT";
            this.txtAddT.Size = new System.Drawing.Size(91, 26);
            this.txtAddT.TabIndex = 7;
            this.txtAddT.Text = "Add Temp";
            this.txtAddT.UseVisualStyleBackColor = true;
            this.txtAddT.Click += new System.EventHandler(this.txtAddT_Click);
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 517);
            this.Controls.Add(this.txtAddT);
            this.Controls.Add(this.txtGetTemp);
            this.Controls.Add(this.txtAddTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDate);
            this.Name = "v";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtAddTemp;
        private System.Windows.Forms.Button txtGetTemp;
        private System.Windows.Forms.Button txtAddT;
    }
}

