namespace desktop_bitinvest_v1.View
{
    partial class Trans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlExibirInfosTrans = new System.Windows.Forms.Panel();
            this.dataTransacoes = new Guna.UI.WinForms.GunaDataGridView();
            this.tipo_transacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtn_moeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet1 = new desktop_bitinvest_v1.bit_investDataSet1();
            this.txtPesquisaTransaçoes = new Guna.UI2.WinForms.Guna2TextBox();
            this.transacaoTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.TransacaoTableAdapter();
            this.idmoedasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moedasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moedasTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.MoedasTableAdapter();
            this.consultartransacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultar_transacoesTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.consultar_transacoesTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultartransacoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlExibirInfosTrans);
            this.panel1.Controls.Add(this.dataTransacoes);
            this.panel1.Controls.Add(this.txtPesquisaTransaçoes);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 698);
            this.panel1.TabIndex = 0;
            // 
            // pnlExibirInfosTrans
            // 
            this.pnlExibirInfosTrans.Location = new System.Drawing.Point(702, 58);
            this.pnlExibirInfosTrans.Name = "pnlExibirInfosTrans";
            this.pnlExibirInfosTrans.Size = new System.Drawing.Size(344, 541);
            this.pnlExibirInfosTrans.TabIndex = 4;
            // 
            // dataTransacoes
            // 
            this.dataTransacoes.AllowUserToAddRows = false;
            this.dataTransacoes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.dataTransacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTransacoes.AutoGenerateColumns = false;
            this.dataTransacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTransacoes.BackgroundColor = System.Drawing.Color.White;
            this.dataTransacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTransacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTransacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTransacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTransacoes.ColumnHeadersHeight = 21;
            this.dataTransacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo_transacao,
            this.qtn_moeda,
            this.idmoedasDataGridViewTextBoxColumn,
            this.Column1});
            this.dataTransacoes.DataSource = this.consultartransacoesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTransacoes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTransacoes.EnableHeadersVisualStyles = false;
            this.dataTransacoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTransacoes.Location = new System.Drawing.Point(12, 58);
            this.dataTransacoes.Name = "dataTransacoes";
            this.dataTransacoes.RowHeadersVisible = false;
            this.dataTransacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTransacoes.Size = new System.Drawing.Size(672, 599);
            this.dataTransacoes.TabIndex = 3;
            this.dataTransacoes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataTransacoes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTransacoes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTransacoes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTransacoes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.dataTransacoes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTransacoes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTransacoes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTransacoes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.dataTransacoes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTransacoes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTransacoes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTransacoes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTransacoes.ThemeStyle.HeaderStyle.Height = 21;
            this.dataTransacoes.ThemeStyle.ReadOnly = false;
            this.dataTransacoes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTransacoes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTransacoes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTransacoes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTransacoes.ThemeStyle.RowsStyle.Height = 22;
            this.dataTransacoes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTransacoes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tipo_transacao
            // 
            this.tipo_transacao.DataPropertyName = "tipo_transacao";
            this.tipo_transacao.HeaderText = "Tipo";
            this.tipo_transacao.Name = "tipo_transacao";
            // 
            // qtn_moeda
            // 
            this.qtn_moeda.DataPropertyName = "qtn_moeda";
            this.qtn_moeda.HeaderText = "Moeda";
            this.qtn_moeda.Name = "qtn_moeda";
            // 
            // transacaoBindingSource
            // 
            this.transacaoBindingSource.DataMember = "Transacao";
            this.transacaoBindingSource.DataSource = this.bit_investDataSet1;
            // 
            // bit_investDataSet1
            // 
            this.bit_investDataSet1.DataSetName = "bit_investDataSet1";
            this.bit_investDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPesquisaTransaçoes
            // 
            this.txtPesquisaTransaçoes.BorderRadius = 15;
            this.txtPesquisaTransaçoes.BorderThickness = 0;
            this.txtPesquisaTransaçoes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisaTransaçoes.DefaultText = "";
            this.txtPesquisaTransaçoes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisaTransaçoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisaTransaçoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaTransaçoes.DisabledState.Parent = this.txtPesquisaTransaçoes;
            this.txtPesquisaTransaçoes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaTransaçoes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaTransaçoes.FocusedState.Parent = this.txtPesquisaTransaçoes;
            this.txtPesquisaTransaçoes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaTransaçoes.HoverState.Parent = this.txtPesquisaTransaçoes;
            this.txtPesquisaTransaçoes.IconLeft = global::desktop_bitinvest_v1.Properties.Resources.Icon_ionic_ios_search;
            this.txtPesquisaTransaçoes.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.txtPesquisaTransaçoes.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtPesquisaTransaçoes.IconRightSize = new System.Drawing.Size(15, 15);
            this.txtPesquisaTransaçoes.Location = new System.Drawing.Point(12, 16);
            this.txtPesquisaTransaçoes.Name = "txtPesquisaTransaçoes";
            this.txtPesquisaTransaçoes.PasswordChar = '\0';
            this.txtPesquisaTransaçoes.PlaceholderText = "    ID, NOME, CPF, RG";
            this.txtPesquisaTransaçoes.SelectedText = "";
            this.txtPesquisaTransaçoes.ShadowDecoration.Parent = this.txtPesquisaTransaçoes;
            this.txtPesquisaTransaçoes.Size = new System.Drawing.Size(459, 30);
            this.txtPesquisaTransaçoes.TabIndex = 2;
            // 
            // transacaoTableAdapter
            // 
            this.transacaoTableAdapter.ClearBeforeFill = true;
            // 
            // idmoedasDataGridViewTextBoxColumn
            // 
            this.idmoedasDataGridViewTextBoxColumn.DataPropertyName = "id_moedas";
            this.idmoedasDataGridViewTextBoxColumn.HeaderText = "id_moedas";
            this.idmoedasDataGridViewTextBoxColumn.Name = "idmoedasDataGridViewTextBoxColumn";
            this.idmoedasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moedasBindingSource
            // 
            this.moedasBindingSource.DataMember = "Moedas";
            this.moedasBindingSource.DataSource = this.bit_investDataSet1;
            // 
            // moedasTableAdapter
            // 
            this.moedasTableAdapter.ClearBeforeFill = true;
            // 
            // consultartransacoesBindingSource
            // 
            this.consultartransacoesBindingSource.DataMember = "consultar_transacoes";
            this.consultartransacoesBindingSource.DataSource = this.bit_investDataSet1;
            // 
            // consultar_transacoesTableAdapter
            // 
            this.consultar_transacoesTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tipo_transacao";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 698);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trans";
            this.Text = "Trans";
            this.Load += new System.EventHandler(this.Trans_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTransacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultartransacoesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisaTransaçoes;
        private Guna.UI.WinForms.GunaDataGridView dataTransacoes;
        private System.Windows.Forms.Panel pnlExibirInfosTrans;
        private bit_investDataSet1 bit_investDataSet1;
        private System.Windows.Forms.BindingSource transacaoBindingSource;
        private bit_investDataSet1TableAdapters.TransacaoTableAdapter transacaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_transacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtn_moeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmoedasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource moedasBindingSource;
        private bit_investDataSet1TableAdapters.MoedasTableAdapter moedasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.BindingSource consultartransacoesBindingSource;
        private bit_investDataSet1TableAdapters.consultar_transacoesTableAdapter consultar_transacoesTableAdapter;
    }
}