namespace Windows
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.Localidadesbtn = new System.Windows.Forms.Button();
            this.Provinciasbtn = new System.Windows.Forms.Button();
            this.Tiposdedocumentobtn = new System.Windows.Forms.Button();
            this.Clientesbtn = new System.Windows.Forms.Button();
            this.TiposDeMascotatsb = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.TiposDeMascotatsb,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(9, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(982, 403);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripButton5.Font = new System.Drawing.Font("Calibri", 12F);
            this.toolStripButton5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStripButton5.Image = global::Windows.Properties.Resources.dose_48px;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.MergeIndex = 1;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(162, 200);
            this.toolStripButton5.Text = "Formas Farmaceuticas";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripButton2.Font = new System.Drawing.Font("Calibri", 32F);
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripButton2.Image = global::Windows.Properties.Resources.dog_48px1;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(300, 400);
            this.toolStripButton2.Text = "Mascotas";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripButton3.Font = new System.Drawing.Font("Calibri", 12F);
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStripButton3.Image = global::Windows.Properties.Resources.doctors_bag_48px1;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.MergeIndex = 1;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(162, 200);
            this.toolStripButton3.Text = "Medicamentos";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripButton4.Font = new System.Drawing.Font("Calibri", 12F);
            this.toolStripButton4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStripButton4.Image = global::Windows.Properties.Resources.pills_48px1;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.MergeIndex = 1;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(162, 200);
            this.toolStripButton4.Text = "Tipos de Medicamentos";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Localidadesbtn
            // 
            this.Localidadesbtn.BackColor = System.Drawing.SystemColors.Window;
            this.Localidadesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Localidadesbtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Localidadesbtn.Location = new System.Drawing.Point(234, 446);
            this.Localidadesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Localidadesbtn.Name = "Localidadesbtn";
            this.Localidadesbtn.Size = new System.Drawing.Size(150, 50);
            this.Localidadesbtn.TabIndex = 8;
            this.Localidadesbtn.Text = "Localidades";
            this.Localidadesbtn.UseVisualStyleBackColor = false;
            this.Localidadesbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Provinciasbtn
            // 
            this.Provinciasbtn.BackColor = System.Drawing.SystemColors.Window;
            this.Provinciasbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Provinciasbtn.Location = new System.Drawing.Point(64, 446);
            this.Provinciasbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Provinciasbtn.Name = "Provinciasbtn";
            this.Provinciasbtn.Size = new System.Drawing.Size(150, 50);
            this.Provinciasbtn.TabIndex = 9;
            this.Provinciasbtn.Text = "Provincias";
            this.Provinciasbtn.UseVisualStyleBackColor = false;
            this.Provinciasbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tiposdedocumentobtn
            // 
            this.Tiposdedocumentobtn.BackColor = System.Drawing.SystemColors.Window;
            this.Tiposdedocumentobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tiposdedocumentobtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Tiposdedocumentobtn.Location = new System.Drawing.Point(403, 446);
            this.Tiposdedocumentobtn.Margin = new System.Windows.Forms.Padding(0);
            this.Tiposdedocumentobtn.Name = "Tiposdedocumentobtn";
            this.Tiposdedocumentobtn.Size = new System.Drawing.Size(150, 50);
            this.Tiposdedocumentobtn.TabIndex = 7;
            this.Tiposdedocumentobtn.Text = "Tipos de Documentos";
            this.Tiposdedocumentobtn.UseVisualStyleBackColor = false;
            this.Tiposdedocumentobtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Clientesbtn
            // 
            this.Clientesbtn.BackColor = System.Drawing.SystemColors.Window;
            this.Clientesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clientesbtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Clientesbtn.Location = new System.Drawing.Point(737, 435);
            this.Clientesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Clientesbtn.Name = "Clientesbtn";
            this.Clientesbtn.Size = new System.Drawing.Size(202, 81);
            this.Clientesbtn.TabIndex = 10;
            this.Clientesbtn.Text = "Clientes";
            this.Clientesbtn.UseVisualStyleBackColor = false;
            // 
            // TiposDeMascotatsb
            // 
            this.TiposDeMascotatsb.AutoSize = false;
            this.TiposDeMascotatsb.BackColor = System.Drawing.SystemColors.Window;
            this.TiposDeMascotatsb.Font = new System.Drawing.Font("Calibri", 12F);
            this.TiposDeMascotatsb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TiposDeMascotatsb.Image = global::Windows.Properties.Resources.pets_48px;
            this.TiposDeMascotatsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TiposDeMascotatsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TiposDeMascotatsb.MergeIndex = 1;
            this.TiposDeMascotatsb.Name = "TiposDeMascotatsb";
            this.TiposDeMascotatsb.Size = new System.Drawing.Size(162, 200);
            this.TiposDeMascotatsb.Text = "Tipos de Mascotas";
            this.TiposDeMascotatsb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TiposDeMascotatsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TiposDeMascotatsb.Click += new System.EventHandler(this.TiposDeMascotatsb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(986, 583);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Clientesbtn);
            this.Controls.Add(this.Tiposdedocumentobtn);
            this.Controls.Add(this.Provinciasbtn);
            this.Controls.Add(this.Localidadesbtn);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TipoDeMascotatsb;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button Localidadesbtn;
        private System.Windows.Forms.Button Provinciasbtn;
        private System.Windows.Forms.Button Tiposdedocumentobtn;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Button Clientesbtn;
        private System.Windows.Forms.ToolStripButton TiposDeMascotatsb;
    }
}

