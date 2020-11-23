namespace Windows
{
    partial class frmProvinciasAE
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelarbtn = new System.Windows.Forms.Button();
            this.Okbtn = new System.Windows.Forms.Button();
            this.ProvinciaTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Provincia:";
            // 
            // Cancelarbtn
            // 
            this.Cancelarbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cancelarbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelarbtn.Image = global::Windows.Properties.Resources.cancel_80px;
            this.Cancelarbtn.Location = new System.Drawing.Point(410, 194);
            this.Cancelarbtn.Name = "Cancelarbtn";
            this.Cancelarbtn.Size = new System.Drawing.Size(106, 84);
            this.Cancelarbtn.TabIndex = 8;
            this.Cancelarbtn.Text = "Cancelar";
            this.Cancelarbtn.UseVisualStyleBackColor = false;
            this.Cancelarbtn.Click += new System.EventHandler(this.Cancelarbtn_Click);
            // 
            // Okbtn
            // 
            this.Okbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Okbtn.Image = global::Windows.Properties.Resources.checked_80px;
            this.Okbtn.Location = new System.Drawing.Point(61, 194);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(106, 84);
            this.Okbtn.TabIndex = 7;
            this.Okbtn.Text = "OK";
            this.Okbtn.UseVisualStyleBackColor = false;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // ProvinciaTextBox
            // 
            this.ProvinciaTextBox.Location = new System.Drawing.Point(194, 82);
            this.ProvinciaTextBox.Name = "ProvinciaTextBox";
            this.ProvinciaTextBox.Size = new System.Drawing.Size(157, 20);
            this.ProvinciaTextBox.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProvinciasAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbtn);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.ProvinciaTextBox);
            this.Name = "frmProvinciasAE";
            this.Text = "frmProvinciasAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelarbtn;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.TextBox ProvinciaTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}