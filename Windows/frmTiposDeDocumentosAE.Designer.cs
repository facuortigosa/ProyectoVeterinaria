namespace Windows
{
    partial class frmTiposDeDocumentosAE
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
            this.TipoDeDocumentoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Cancelarbtn = new System.Windows.Forms.Button();
            this.Okbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoDeDocumentoTextBox
            // 
            this.TipoDeDocumentoTextBox.Location = new System.Drawing.Point(201, 84);
            this.TipoDeDocumentoTextBox.Name = "TipoDeDocumentoTextBox";
            this.TipoDeDocumentoTextBox.Size = new System.Drawing.Size(157, 20);
            this.TipoDeDocumentoTextBox.TabIndex = 1;
            this.TipoDeDocumentoTextBox.TextChanged += new System.EventHandler(this.TipoDeDocumentoTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Documento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cancelarbtn
            // 
            this.Cancelarbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cancelarbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelarbtn.Image = global::Windows.Properties.Resources.cancel_80px;
            this.Cancelarbtn.Location = new System.Drawing.Point(417, 196);
            this.Cancelarbtn.Name = "Cancelarbtn";
            this.Cancelarbtn.Size = new System.Drawing.Size(106, 84);
            this.Cancelarbtn.TabIndex = 4;
            this.Cancelarbtn.Text = "Cancelar";
            this.Cancelarbtn.UseVisualStyleBackColor = false;
            this.Cancelarbtn.Click += new System.EventHandler(this.Cancelarbtn_Click_1);
            // 
            // Okbtn
            // 
            this.Okbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Okbtn.Image = global::Windows.Properties.Resources.checked_80px;
            this.Okbtn.Location = new System.Drawing.Point(68, 196);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(106, 84);
            this.Okbtn.TabIndex = 3;
            this.Okbtn.Text = "OK";
            this.Okbtn.UseVisualStyleBackColor = false;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click_1);
            // 
            // frmTiposDeDocumentosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbtn);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.TipoDeDocumentoTextBox);
            this.Name = "frmTiposDeDocumentosAE";
            this.Text = "frmTiposDeDocumentosAE";
            this.Load += new System.EventHandler(this.frmTiposDeDocumentosAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TipoDeDocumentoTextBox;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.Button Cancelarbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}