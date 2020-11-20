namespace desktop_bitinvest_v1
{
    partial class Clientes_Cadastrar
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
            this.cboTipoPessoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlCadCliente = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.bntCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlCadCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTipoPessoa
            // 
            this.cboTipoPessoa.BackColor = System.Drawing.Color.Transparent;
            this.cboTipoPessoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.cboTipoPessoa.BorderRadius = 18;
            this.cboTipoPessoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPessoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.cboTipoPessoa.FocusedColor = System.Drawing.Color.Empty;
            this.cboTipoPessoa.FocusedState.Parent = this.cboTipoPessoa;
            this.cboTipoPessoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboTipoPessoa.ForeColor = System.Drawing.Color.White;
            this.cboTipoPessoa.FormattingEnabled = true;
            this.cboTipoPessoa.HoverState.Parent = this.cboTipoPessoa;
            this.cboTipoPessoa.ItemHeight = 30;
            this.cboTipoPessoa.Items.AddRange(new object[] {
            "               PESSOA FÍSICA",
            "             PESSOA JURÍDICA"});
            this.cboTipoPessoa.ItemsAppearance.Parent = this.cboTipoPessoa;
            this.cboTipoPessoa.Location = new System.Drawing.Point(12, 21);
            this.cboTipoPessoa.Name = "cboTipoPessoa";
            this.cboTipoPessoa.ShadowDecoration.Parent = this.cboTipoPessoa;
            this.cboTipoPessoa.Size = new System.Drawing.Size(257, 36);
            this.cboTipoPessoa.TabIndex = 0;
            this.cboTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // pnlCadCliente
            // 
            this.pnlCadCliente.Controls.Add(this.guna2Button1);
            this.pnlCadCliente.Controls.Add(this.bntCadastrar);
            this.pnlCadCliente.Controls.Add(this.panel2);
            this.pnlCadCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlCadCliente.Name = "pnlCadCliente";
            this.pnlCadCliente.Size = new System.Drawing.Size(1104, 661);
            this.pnlCadCliente.TabIndex = 1;
            this.pnlCadCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadCliente_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.BorderRadius = 23;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(478, 598);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(261, 45);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "CANCELAR";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.bntCadastrar.BorderRadius = 23;
            this.bntCadastrar.CheckedState.Parent = this.bntCadastrar;
            this.bntCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCadastrar.CustomImages.Parent = this.bntCadastrar;
            this.bntCadastrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.bntCadastrar.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastrar.ForeColor = System.Drawing.Color.White;
            this.bntCadastrar.HoverState.Parent = this.bntCadastrar;
            this.bntCadastrar.Location = new System.Drawing.Point(127, 598);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(184)))), ((int)(((byte)(10)))));
            this.bntCadastrar.ShadowDecoration.Parent = this.bntCadastrar;
            this.bntCadastrar.Size = new System.Drawing.Size(261, 45);
            this.bntCadastrar.TabIndex = 5;
            this.bntCadastrar.Text = "CADASTRAR";
            this.bntCadastrar.Click += new System.EventHandler(this.bntCadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 508);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Clientes_Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 661);
            this.Controls.Add(this.cboTipoPessoa);
            this.Controls.Add(this.pnlCadCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes_Cadastrar";
            this.Text = "Clientes_Cadastrar";
            this.pnlCadCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cboTipoPessoa;
        private System.Windows.Forms.Panel pnlCadCliente;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button bntCadastrar;
    }
}