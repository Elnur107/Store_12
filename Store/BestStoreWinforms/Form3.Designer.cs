namespace BestStoreWinforms
{
    partial class Form3
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
            this.newNameTxtb = new System.Windows.Forms.TextBox();
            this.newdescriptionTxtb = new System.Windows.Forms.TextBox();
            this.newmaskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price :";
            // 
            // newNameTxtb
            // 
            this.newNameTxtb.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNameTxtb.Location = new System.Drawing.Point(221, 15);
            this.newNameTxtb.Multiline = true;
            this.newNameTxtb.Name = "newNameTxtb";
            this.newNameTxtb.Size = new System.Drawing.Size(214, 41);
            this.newNameTxtb.TabIndex = 4;
            // 
            // newdescriptionTxtb
            // 
            this.newdescriptionTxtb.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newdescriptionTxtb.Location = new System.Drawing.Point(221, 93);
            this.newdescriptionTxtb.Multiline = true;
            this.newdescriptionTxtb.Name = "newdescriptionTxtb";
            this.newdescriptionTxtb.Size = new System.Drawing.Size(214, 41);
            this.newdescriptionTxtb.TabIndex = 5;
            // 
            // newmaskedTextBoxPrice
            // 
            this.newmaskedTextBoxPrice.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newmaskedTextBoxPrice.Location = new System.Drawing.Point(221, 181);
            this.newmaskedTextBoxPrice.Mask = "000000";
            this.newmaskedTextBoxPrice.Name = "newmaskedTextBoxPrice";
            this.newmaskedTextBoxPrice.Size = new System.Drawing.Size(214, 40);
            this.newmaskedTextBoxPrice.TabIndex = 6;
            this.newmaskedTextBoxPrice.ValidatingType = typeof(int);
            // 
            // addBtn
            // 
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.addBtn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addBtn.Location = new System.Drawing.Point(490, 78);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(180, 70);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add ";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(719, 247);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.newmaskedTextBoxPrice);
            this.Controls.Add(this.newdescriptionTxtb);
            this.Controls.Add(this.newNameTxtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newNameTxtb;
        private System.Windows.Forms.TextBox newdescriptionTxtb;
        private System.Windows.Forms.MaskedTextBox newmaskedTextBoxPrice;
        private Guna.UI2.WinForms.Guna2Button addBtn;
    }
}