namespace desktop_bitinvest_v1.View
{
    partial class Clientes_Pendentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTabelaClientesPendentes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExibitDados = new Guna.UI2.WinForms.Guna2Button();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlInfosPendentes = new System.Windows.Forms.Panel();
            this.bntAbonos = new Guna.UI2.WinForms.Guna2Button();
            this.bntCadastros = new Guna.UI2.WinForms.Guna2Button();
            this.bntCadastrosPendentes = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaClientesPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTabelaClientesPendentes
            // 
            this.dataTabelaClientesPendentes.AllowDrop = true;
            this.dataTabelaClientesPendentes.AllowUserToAddRows = false;
            this.dataTabelaClientesPendentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataTabelaClientesPendentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataTabelaClientesPendentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTabelaClientesPendentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTabelaClientesPendentes.BackgroundColor = System.Drawing.Color.White;
            this.dataTabelaClientesPendentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTabelaClientesPendentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTabelaClientesPendentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataTabelaClientesPendentes.ColumnHeadersHeight = 30;
            this.dataTabelaClientesPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATA,
            this.Nome,
            this.CPF,
            this.RG});
            this.dataTabelaClientesPendentes.DoubleBuffered = true;
            this.dataTabelaClientesPendentes.EnableHeadersVisualStyles = false;
            this.dataTabelaClientesPendentes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.dataTabelaClientesPendentes.HeaderForeColor = System.Drawing.Color.White;
            this.dataTabelaClientesPendentes.Location = new System.Drawing.Point(24, 134);
            this.dataTabelaClientesPendentes.Name = "dataTabelaClientesPendentes";
            this.dataTabelaClientesPendentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTabelaClientesPendentes.Size = new System.Drawing.Size(659, 449);
            this.dataTabelaClientesPendentes.TabIndex = 3;
            // 
            // DATA
            // 
            this.DATA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DATA.HeaderText = "DATA";
            this.DATA.MinimumWidth = 70;
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 70;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "NOME";
            this.Nome.MinimumWidth = 250;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.MinimumWidth = 150;
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 150;
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.MinimumWidth = 150;
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Width = 150;
            // 
            // btnExibitDados
            // 
            this.btnExibitDados.BackColor = System.Drawing.SystemColors.Control;
            this.btnExibitDados.BorderRadius = 10;
            this.btnExibitDados.CheckedState.Parent = this.btnExibitDados;
            this.btnExibitDados.CustomImages.Parent = this.btnExibitDados;
            this.btnExibitDados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.btnExibitDados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExibitDados.ForeColor = System.Drawing.Color.White;
            this.btnExibitDados.HoverState.Parent = this.btnExibitDados;
            this.btnExibitDados.Location = new System.Drawing.Point(24, 106);
            this.btnExibitDados.Name = "btnExibitDados";
            this.btnExibitDados.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(119)))), ((int)(((byte)(31)))));
            this.btnExibitDados.ShadowDecoration.Parent = this.btnExibitDados;
            this.btnExibitDados.Size = new System.Drawing.Size(146, 22);
            this.btnExibitDados.TabIndex = 5;
            this.btnExibitDados.Text = "Exibir todos os dados";
            this.btnExibitDados.Click += new System.EventHandler(this.btnExibitDados_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderRadius = 15;
            this.txtPesquisa.BorderThickness = 0;
            this.txtPesquisa.DefaultText = "";
            this.txtPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.DisabledState.Parent = this.txtPesquisa;
            this.txtPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.FocusedState.Parent = this.txtPesquisa;
            this.txtPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.HoverState.Parent = this.txtPesquisa;
            this.txtPesquisa.Location = new System.Drawing.Point(24, 75);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.PlaceholderText = "ID, NOME, CPF, RG";
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.ShadowDecoration.Parent = this.txtPesquisa;
            this.txtPesquisa.Size = new System.Drawing.Size(459, 25);
            this.txtPesquisa.TabIndex = 4;
            // 
            // pnlInfosPendentes
            // 
            this.pnlInfosPendentes.Location = new System.Drawing.Point(725, 134);
            this.pnlInfosPendentes.Name = "pnlInfosPendentes";
            this.pnlInfosPendentes.Size = new System.Drawing.Size(346, 515);
            this.pnlInfosPendentes.TabIndex = 6;
            // 
            // bntAbonos
            // 
            this.bntAbonos.BackColor = System.Drawing.SystemColors.Control;
            this.bntAbonos.BorderRadius = 23;
            this.bntAbonos.CheckedState.Parent = this.bntAbonos;
            this.bntAbonos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAbonos.CustomImages.Parent = this.bntAbonos;
            this.bntAbonos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.bntAbonos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAbonos.ForeColor = System.Drawing.Color.White;
            this.bntAbonos.HoverState.Parent = this.bntAbonos;
            this.bntAbonos.Location = new System.Drawing.Point(24, 12);
            this.bntAbonos.Name = "bntAbonos";
            this.bntAbonos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bntAbonos.ShadowDecoration.Parent = this.bntAbonos;
            this.bntAbonos.Size = new System.Drawing.Size(180, 45);
            this.bntAbonos.TabIndex = 7;
            this.bntAbonos.Text = "    ABONOS:";
            this.bntAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bntAbonos.Click += new System.EventHandler(this.bntAbonos_Click);
            // 
            // bntCadastros
            // 
            this.bntCadastros.BackColor = System.Drawing.SystemColors.Control;
            this.bntCadastros.BorderRadius = 23;
            this.bntCadastros.CheckedState.Parent = this.bntCadastros;
            this.bntCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCadastros.CustomImages.Parent = this.bntCadastros;
            this.bntCadastros.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.bntCadastros.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastros.ForeColor = System.Drawing.Color.White;
            this.bntCadastros.HoverState.Parent = this.bntCadastros;
            this.bntCadastros.Location = new System.Drawing.Point(272, 12);
            this.bntCadastros.Name = "bntCadastros";
            this.bntCadastros.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bntCadastros.ShadowDecoration.Parent = this.bntCadastros;
            this.bntCadastros.Size = new System.Drawing.Size(211, 45);
            this.bntCadastros.TabIndex = 9;
            this.bntCadastros.Text = "    CADASTROS:";
            this.bntCadastros.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bntCadastrosPendentes
            // 
            this.bntCadastrosPendentes.BackColor = System.Drawing.SystemColors.Control;
            this.bntCadastrosPendentes.BorderRadius = 23;
            this.bntCadastrosPendentes.CheckedState.Parent = this.bntCadastrosPendentes;
            this.bntCadastrosPendentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCadastrosPendentes.CustomImages.Parent = this.bntCadastrosPendentes;
            this.bntCadastrosPendentes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.bntCadastrosPendentes.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastrosPendentes.ForeColor = System.Drawing.Color.White;
            this.bntCadastrosPendentes.HoverState.Parent = this.bntCadastrosPendentes;
            this.bntCadastrosPendentes.Location = new System.Drawing.Point(861, 12);
            this.bntCadastrosPendentes.Name = "bntCadastrosPendentes";
            this.bntCadastrosPendentes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bntCadastrosPendentes.ShadowDecoration.Parent = this.bntCadastrosPendentes;
            this.bntCadastrosPendentes.Size = new System.Drawing.Size(211, 45);
            this.bntCadastrosPendentes.TabIndex = 9;
            this.bntCadastrosPendentes.Text = "    CADASTROS:";
            this.bntCadastrosPendentes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Clientes_Pendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 700);
            this.Controls.Add(this.bntCadastros);
            this.Controls.Add(this.bntAbonos);
            this.Controls.Add(this.pnlInfosPendentes);
            this.Controls.Add(this.btnExibitDados);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dataTabelaClientesPendentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes_Pendentes";
            this.Text = "Clientes_Pendentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaClientesPendentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid dataTabelaClientesPendentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private Guna.UI2.WinForms.Guna2Button btnExibitDados;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private System.Windows.Forms.Panel pnlInfosPendentes;
        private Guna.UI2.WinForms.Guna2Button bntAbonos;
        private Guna.UI2.WinForms.Guna2Button bntCadastros;
        private Guna.UI2.WinForms.Guna2Button bntCadastrosPendentes;
    }
}