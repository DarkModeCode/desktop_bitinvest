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
            this.btnFotoFrente = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFotoSelfie = new System.Windows.Forms.Button();
            this.btnFotoTras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 208);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFotoFrente
            // 
            this.btnFotoFrente.Location = new System.Drawing.Point(57, 306);
            this.btnFotoFrente.Name = "btnFotoFrente";
            this.btnFotoFrente.Size = new System.Drawing.Size(152, 47);
            this.btnFotoFrente.TabIndex = 1;
            this.btnFotoFrente.Text = "Imagem Frente";
            this.btnFotoFrente.UseVisualStyleBackColor = true;
            this.btnFotoFrente.Click += new System.EventHandler(this.btnFotoFrente_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(650, 414);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 24);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(306, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 208);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(624, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(308, 208);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnFotoSelfie
            // 
            this.btnFotoSelfie.Location = new System.Drawing.Point(706, 306);
            this.btnFotoSelfie.Name = "btnFotoSelfie";
            this.btnFotoSelfie.Size = new System.Drawing.Size(152, 47);
            this.btnFotoSelfie.TabIndex = 5;
            this.btnFotoSelfie.Text = "Imagem Selfie";
            this.btnFotoSelfie.UseVisualStyleBackColor = true;
            this.btnFotoSelfie.Click += new System.EventHandler(this.btnFotoSelfie_Click);
            // 
            // btnFotoTras
            // 
            this.btnFotoTras.Location = new System.Drawing.Point(360, 306);
            this.btnFotoTras.Name = "btnFotoTras";
            this.btnFotoTras.Size = new System.Drawing.Size(152, 47);
            this.btnFotoTras.TabIndex = 5;
            this.btnFotoTras.Text = "Imagem Tras";
            this.btnFotoTras.UseVisualStyleBackColor = true;
            this.btnFotoTras.Click += new System.EventHandler(this.btnFotoTras_Click);
            // 
            // Fotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 447);
            this.Controls.Add(this.btnFotoTras);
            this.Controls.Add(this.btnFotoSelfie);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFotoFrente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Fotos";
            this.Text = "Fotos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFotoFrente;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFotoSelfie;
        private System.Windows.Forms.Button btnFotoTras;
    }
}