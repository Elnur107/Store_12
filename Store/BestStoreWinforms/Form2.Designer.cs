namespace BestStoreWinforms
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.descriptionTxtb = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.update2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price :";
            // 
            // nameTxtb
            // 
            this.nameTxtb.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtb.Location = new System.Drawing.Point(228, 17);
            this.nameTxtb.Multiline = true;
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(214, 41);
            this.nameTxtb.TabIndex = 3;
            // 
            // descriptionTxtb
            // 
            this.descriptionTxtb.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxtb.Location = new System.Drawing.Point(228, 96);
            this.descriptionTxtb.Multiline = true;
            this.descriptionTxtb.Name = "descriptionTxtb";
            this.descriptionTxtb.Size = new System.Drawing.Size(214, 41);
            this.descriptionTxtb.TabIndex = 4;
            // 
            // maskedTextBoxPrice
            // 
            this.maskedTextBoxPrice.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPrice.Location = new System.Drawing.Point(228, 182);
            this.maskedTextBoxPrice.Mask = "000000";
            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            this.maskedTextBoxPrice.Size = new System.Drawing.Size(214, 40);
            this.maskedTextBoxPrice.TabIndex = 5;
            this.maskedTextBoxPrice.ValidatingType = typeof(int);
            // 
            // update2
            // 
            this.update2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.update2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.update2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.update2.Location = new System.Drawing.Point(526, 78);
            this.update2.Name = "update2";
            this.update2.Size = new System.Drawing.Size(180, 70);
            this.update2.TabIndex = 6;
            this.update2.Text = "Update";
            this.update2.Click += new System.EventHandler(this.update2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(719, 247);
            this.Controls.Add(this.update2);
            this.Controls.Add(this.maskedTextBoxPrice);
            this.Controls.Add(this.descriptionTxtb);
            this.Controls.Add(this.nameTxtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(737, 294);
            this.MinimumSize = new System.Drawing.Size(737, 294);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.TextBox descriptionTxtb;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
        private Guna.UI2.WinForms.Guna2Button update2;
    }
}