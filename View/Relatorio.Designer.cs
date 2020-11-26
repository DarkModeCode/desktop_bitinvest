namespace desktop_bitinvest_v1.View
{
    partial class Relatorio
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
            this.pnlRelatorio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoRelatorio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bntHistorico = new Guna.UI2.WinForms.Guna2Button();
            this.bntSalvarRelatorio = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRelatorio
            // 
            this.pnlRelatorio.AutoScroll = true;
            this.pnlRelatorio.BackColor = System.Drawing.Color.White;
            this.pnlRelatorio.Controls.Add(this.label1);
            this.pnlRelatorio.Location = new System.Drawing.Point(12, 72);
            this.pnlRelatorio.Name = "pnlRelatorio";
            this.pnlRelatorio.Size = new System.Drawing.Size(644, 603);
            this.pnlRelatorio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma das opções de relatório";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboTipoRelatorio
            // 
            this.cboTipoRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.cboTipoRelatorio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.cboTipoRelatorio.BorderRadius = 18;
            this.cboTipoRelatorio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoRelatorio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.cboTipoRelatorio.FocusedColor = System.Drawing.Color.Empty;
            this.cboTipoRelatorio.FocusedState.Parent = this.cboTipoRelatorio;
            this.cboTipoRelatorio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboTipoRelatorio.ForeColor = System.Drawing.Color.White;
            this.cboTipoRelatorio.FormattingEnabled = true;
            this.cboTipoRelatorio.HoverState.Parent = this.cboTipoRelatorio;
            this.cboTipoRelatorio.ItemHeight = 30;
            this.cboTipoRelatorio.Items.AddRange(new object[] {
            "             RELATÓRIO DE TRANSAÇÕES",
            "              RELATÓRIO DE CADASTROS"});
            this.cboTipoRelatorio.ItemsAppearance.Parent = this.cboTipoRelatorio;
            this.cboTipoRelatorio.Location = new System.Drawing.Point(12, 17);
            this.cboTipoRelatorio.Name = "cboTipoRelatorio";
            this.cboTipoRelatorio.ShadowDecoration.Parent = this.cboTipoRelatorio;
            this.cboTipoRelatorio.Size = new System.Drawing.Size(366, 36);
            this.cboTipoRelatorio.TabIndex = 1;
            this.cboTipoRelatorio.SelectedIndexChanged += new System.EventHandler(this.cboTipoRelatorio_SelectedIndexChanged);
            // 
            // bntHistorico
            // 
            this.bntHistorico.BackColor = System.Drawing.SystemColors.Control;
            this.bntHistorico.BorderRadius = 18;
            this.bntHistorico.CheckedState.Parent = this.bntHistorico;
            this.bntHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntHistorico.CustomImages.Parent = this.bntHistorico;
            this.bntHistorico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.bntHistorico.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHistorico.ForeColor = System.Drawing.Color.White;
            this.bntHistorico.HoverState.Parent = this.bntHistorico;
            this.bntHistorico.Location = new System.Drawing.Point(476, 17);
            this.bntHistorico.Name = "bntHistorico";
            this.bntHistorico.ShadowDecoration.Parent = this.bntHistorico;
            this.bntHistorico.Size = new System.Drawing.Size(180, 36);
            this.bntHistorico.TabIndex = 5;
            this.bntHistorico.Text = "Histórico de Relatórios";
            // 
            // bntSalvarRelatorio
            // 
            this.bntSalvarRelatorio.BackColor = System.Drawing.SystemColors.Control;
            this.bntSalvarRelatorio.BorderRadius = 18;
            this.bntSalvarRelatorio.CheckedState.Parent = this.bntSalvarRelatorio;
            this.bntSalvarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSalvarRelatorio.CustomImages.Parent = this.bntSalvarRelatorio;
            this.bntSalvarRelatorio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.bntSalvarRelatorio.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalvarRelatorio.ForeColor = System.Drawing.Color.White;
            this.bntSalvarRelatorio.HoverState.Parent = this.bntSalvarRelatorio;
            this.bntSalvarRelatorio.Location = new System.Drawing.Point(812, 296);
            this.bntSalvarRelatorio.Name = "bntSalvarRelatorio";
            this.bntSalvarRelatorio.ShadowDecoration.Parent = this.bntSalvarRelatorio;
            this.bntSalvarRelatorio.Size = new System.Drawing.Size(143, 36);
            this.bntSalvarRelatorio.TabIndex = 6;
            this.bntSalvarRelatorio.Text = "Salvar";
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 698);
            this.Controls.Add(this.bntSalvarRelatorio);
            this.Controls.Add(this.bntHistorico);
            this.Controls.Add(this.cboTipoRelatorio);
            this.Controls.Add(this.pnlRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.pnlRelatorio.ResumeLayout(false);
            this.pnlRelatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorio;
        private Guna.UI2.WinForms.Guna2ComboBox cboTipoRelatorio;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button bntHistorico;
        private Guna.UI2.WinForms.Guna2Button bntSalvarRelatorio;
    }
}