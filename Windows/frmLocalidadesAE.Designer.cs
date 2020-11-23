namespace Windows
{
    partial class frmLocalidadesAE
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
            this.LocalidadTextBox = new System.Windows.Forms.TextBox();
            this.ProvinciatextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelarbtn = new System.Windows.Forms.Button();
            this.Okbtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Localidad:";
            // 
            // LocalidadTextBox
            // 
            this.LocalidadTextBox.Location = new System.Drawing.Point(193, 80);
            this.LocalidadTextBox.Name = "LocalidadTextBox";
            this.LocalidadTextBox.Size = new System.Drawing.Size(157, 20);
            this.LocalidadTextBox.TabIndex = 10;
            // 
            // ProvinciatextBox1
            // 
            this.ProvinciatextBox1.Location = new System.Drawing.Point(193, 137);
            this.ProvinciatextBox1.Name = "ProvinciatextBox1";
            this.ProvinciatextBox1.Size = new System.Drawing.Size(157, 20);
            this.ProvinciatextBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Provincia:";
            // 
            // Cancelarbtn
            // 
            this.Cancelarbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cancelarbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelarbtn.Image = global::Windows.Properties.Resources.cancel_80px;
            this.Cancelarbtn.Location = new System.Drawing.Point(409, 192);
            this.Cancelarbtn.Name = "Cancelarbtn";
            this.Cancelarbtn.Size = new System.Drawing.Size(106, 84);
            this.Cancelarbtn.TabIndex = 12;
            this.Cancelarbtn.Text = "Cancelar";
            this.Cancelarbtn.UseVisualStyleBackColor = false;
            this.Cancelarbtn.Click += new System.EventHandler(this.Cancelarbtn_Click);
            // 
            // Okbtn
            // 
            this.Okbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Okbtn.Image = global::Windows.Properties.Resources.checked_80px;
            this.Okbtn.Location = new System.Drawing.Point(60, 192);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(106, 84);
            this.Okbtn.TabIndex = 11;
            this.Okbtn.Text = "OK";
            this.Okbtn.UseVisualStyleBackColor = false;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLocalidadesAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProvinciatextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbtn);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.LocalidadTextBox);
            this.Name = "frmLocalidadesAE";
            this.Text = "frmLocalidadesAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelarbtn;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.TextBox LocalidadTextBox;
        private System.Windows.Forms.TextBox ProvinciatextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}