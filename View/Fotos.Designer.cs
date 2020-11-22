namespace desktop_bitinvest_v1.View
{
    partial class Fotos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFotoFrente = new Guna.UI2.WinForms.Guna2Button();
            this.btnFotoTras = new Guna.UI2.WinForms.Guna2Button();
            this.btnFotoSelfie = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(22, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(408, 411);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 24);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Location = new System.Drawing.Point(383, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 600);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.Location = new System.Drawing.Point(744, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(355, 600);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnFotoFrente
            // 
            this.btnFotoFrente.BackColor = System.Drawing.SystemColors.Control;
            this.btnFotoFrente.BorderRadius = 23;
            this.btnFotoFrente.CheckedState.Parent = this.btnFotoFrente;
            this.btnFotoFrente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFotoFrente.CustomImages.Parent = this.btnFotoFrente;
            this.btnFotoFrente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.btnFotoFrente.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFotoFrente.ForeColor = System.Drawing.Color.White;
            this.btnFotoFrente.HoverState.Parent = this.btnFotoFrente;
            this.btnFotoFrente.Location = new System.Drawing.Point(124, 642);
            this.btnFotoFrente.Name = "btnFotoFrente";
            this.btnFotoFrente.ShadowDecoration.Parent = this.btnFotoFrente;
            this.btnFotoFrente.Size = new System.Drawing.Size(156, 45);
            this.btnFotoFrente.TabIndex = 38;
            this.btnFotoFrente.Text = "FRENTE";
            this.btnFotoFrente.Click += new System.EventHandler(this.btnFotoFrente_Click_1);
            // 
            // btnFotoTras
            // 
            this.btnFotoTras.BackColor = System.Drawing.SystemColors.Control;
            this.btnFotoTras.BorderRadius = 23;
            this.btnFotoTras.CheckedState.Parent = this.btnFotoTras;
            this.btnFotoTras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFotoTras.CustomImages.Parent = this.btnFotoTras;
            this.btnFotoTras.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.btnFotoTras.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFotoTras.ForeColor = System.Drawing.Color.White;
            this.btnFotoTras.HoverState.Parent = this.btnFotoTras;
            this.btnFotoTras.Location = new System.Drawing.Point(503, 642);
            this.btnFotoTras.Name = "btnFotoTras";
            this.btnFotoTras.ShadowDecoration.Parent = this.btnFotoTras;
            this.btnFotoTras.Size = new System.Drawing.Size(132, 45);
            this.btnFotoTras.TabIndex = 39;
            this.btnFotoTras.Text = "TRÁS";
            this.btnFotoTras.Click += new System.EventHandler(this.btnFotoTras_Click);
            // 
            // btnFotoSelfie
            // 
            this.btnFotoSelfie.BackColor = System.Drawing.SystemColors.Control;
            this.btnFotoSelfie.BorderRadius = 23;
            this.btnFotoSelfie.CheckedState.Parent = this.btnFotoSelfie;
            this.btnFotoSelfie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFotoSelfie.CustomImages.Parent = this.btnFotoSelfie;
            this.btnFotoSelfie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.btnFotoSelfie.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFotoSelfie.ForeColor = System.Drawing.Color.White;
            this.btnFotoSelfie.HoverState.Parent = this.btnFotoSelfie;
            this.btnFotoSelfie.Location = new System.Drawing.Point(856, 642);
            this.btnFotoSelfie.Name = "btnFotoSelfie";
            this.btnFotoSelfie.ShadowDecoration.Parent = this.btnFotoSelfie;
            this.btnFotoSelfie.Size = new System.Drawing.Size(144, 45);
            this.btnFotoSelfie.TabIndex = 40;
            this.btnFotoSelfie.Text = "SELFIE";
            this.btnFotoSelfie.Click += new System.EventHandler(this.btnFotoSelfie_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 699);
            this.panel1.TabIndex = 41;
            // 
            // Fotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 699);
            this.Controls.Add(this.btnFotoSelfie);
            this.Controls.Add(this.btnFotoTras);
            this.Controls.Add(this.btnFotoFrente);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fotos";
            this.Text = "Fotos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnFotoFrente;
        private Guna.UI2.WinForms.Guna2Button btnFotoTras;
        private Guna.UI2.WinForms.Guna2Button btnFotoSelfie;
        private System.Windows.Forms.Panel panel1;
    }
}