namespace desktop_bitinvest_v1
{

    partial class Clientes
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
            this.pnlClientesCadastrar = new System.Windows.Forms.Panel();
            this.dataClientes = new Guna.UI.WinForms.GunaDataGridView();
            this.bntExibir = new Guna.UI2.WinForms.Guna2Button();
            this.pnlInfos = new System.Windows.Forms.Panel();
            this.txtPesquisaPendentes = new Guna.UI2.WinForms.Guna2TextBox();
            this.bit_investDataSet1 = new desktop_bitinvest_v1.bit_investDataSet1();
            this.consultarclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultar_clientesTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.consultar_clientesTableAdapter();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlClientesCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarclientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientesCadastrar
            // 
            this.pnlClientesCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlClientesCadastrar.AutoScroll = true;
            this.pnlClientesCadastrar.AutoSize = true;
            this.pnlClientesCadastrar.Controls.Add(this.dataClientes);
            this.pnlClientesCadastrar.Controls.Add(this.bntExibir);
            this.pnlClientesCadastrar.Controls.Add(this.pnlInfos);
            this.pnlClientesCadastrar.Controls.Add(this.txtPesquisaPendentes);
            this.pnlClientesCadastrar.Location = new System.Drawing.Point(0, 1);
            this.pnlClientesCadastrar.Name = "pnlClientesCadastrar";
            this.pnlClientesCadastrar.Size = new System.Drawing.Size(1121, 701);
            this.pnlClientesCadastrar.TabIndex = 0;
            this.pnlClientesCadastrar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClientesCadastrar_Paint);
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataClientes.AutoGenerateColumns = false;
            this.dataClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataClientes.ColumnHeadersHeight = 21;
            this.dataClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sobrenomeDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.cpfcnpjDataGridViewTextBoxColumn});
            this.dataClientes.DataSource = this.consultarclientesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataClientes.EnableHeadersVisualStyles = false;
            this.dataClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataClientes.Location = new System.Drawing.Point(33, 99);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.ReadOnly = true;
            this.dataClientes.RowHeadersVisible = false;
            this.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClientes.Size = new System.Drawing.Size(672, 599);
            this.dataClientes.TabIndex = 6;
            this.dataClientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.dataClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.dataClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.dataClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataClientes.ThemeStyle.HeaderStyle.Height = 21;
            this.dataClientes.ThemeStyle.ReadOnly = true;
            this.dataClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataClientes.ThemeStyle.RowsStyle.Height = 22;
            this.dataClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.dataClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // bntExibir
            // 
            this.bntExibir.BackColor = System.Drawing.SystemColors.Control;
            this.bntExibir.BorderRadius = 16;
            this.bntExibir.CheckedState.Parent = this.bntExibir;
            this.bntExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExibir.CustomImages.Parent = this.bntExibir;
            this.bntExibir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.bntExibir.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExibir.ForeColor = System.Drawing.Color.White;
            this.bntExibir.HoverState.Parent = this.bntExibir;
            this.bntExibir.Location = new System.Drawing.Point(33, 62);
            this.bntExibir.Name = "bntExibir";
            this.bntExibir.ShadowDecoration.Parent = this.bntExibir;
            this.bntExibir.Size = new System.Drawing.Size(115, 30);
            this.bntExibir.TabIndex = 5;
            this.bntExibir.Text = "Exibir";
            this.bntExibir.Click += new System.EventHandler(this.bntExibir_Click);
            // 
            // pnlInfos
            // 
            this.pnlInfos.Location = new System.Drawing.Point(730, 26);
            this.pnlInfos.Name = "pnlInfos";
            this.pnlInfos.Size = new System.Drawing.Size(347, 605);
            this.pnlInfos.TabIndex = 2;
            // 
            // txtPesquisaPendentes
            // 
            this.txtPesquisaPendentes.BorderRadius = 15;
            this.txtPesquisaPendentes.BorderThickness = 0;
            this.txtPesquisaPendentes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisaPendentes.DefaultText = "";
            this.txtPesquisaPendentes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisaPendentes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisaPendentes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaPendentes.DisabledState.Parent = this.txtPesquisaPendentes;
            this.txtPesquisaPendentes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaPendentes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaPendentes.FocusedState.Parent = this.txtPesquisaPendentes;
            this.txtPesquisaPendentes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaPendentes.HoverState.Parent = this.txtPesquisaPendentes;
            this.txtPesquisaPendentes.Location = new System.Drawing.Point(33, 26);
            this.txtPesquisaPendentes.Name = "txtPesquisaPendentes";
            this.txtPesquisaPendentes.PasswordChar = '\0';
            this.txtPesquisaPendentes.PlaceholderText = "    ID, NOME, CPF, RG";
            this.txtPesquisaPendentes.SelectedText = "";
            this.txtPesquisaPendentes.ShadowDecoration.Parent = this.txtPesquisaPendentes;
            this.txtPesquisaPendentes.Size = new System.Drawing.Size(459, 30);
            this.txtPesquisaPendentes.TabIndex = 0;
            this.txtPesquisaPendentes.TextChanged += new System.EventHandler(this.txtPesquisaPendentes_TextChanged);
            this.txtPesquisaPendentes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesquisa);
            // 
            // bit_investDataSet1
            // 
            this.bit_investDataSet1.DataSetName = "bit_investDataSet1";
            this.bit_investDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultarclientesBindingSource
            // 
            this.consultarclientesBindingSource.DataMember = "consultar_clientes";
            this.consultarclientesBindingSource.DataSource = this.bit_investDataSet1;
            // 
            // consultar_clientesTableAdapter
            // 
            this.consultar_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "Id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "Id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sobrenomeDataGridViewTextBoxColumn
            // 
            this.sobrenomeDataGridViewTextBoxColumn.DataPropertyName = "sobrenome";
            this.sobrenomeDataGridViewTextBoxColumn.HeaderText = "sobrenome";
            this.sobrenomeDataGridViewTextBoxColumn.Name = "sobrenomeDataGridViewTextBoxColumn";
            this.sobrenomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfcnpjDataGridViewTextBoxColumn
            // 
            this.cpfcnpjDataGridViewTextBoxColumn.DataPropertyName = "cpf_cnpj";
            this.cpfcnpjDataGridViewTextBoxColumn.HeaderText = "cpf_cnpj";
            this.cpfcnpjDataGridViewTextBoxColumn.Name = "cpfcnpjDataGridViewTextBoxColumn";
            this.cpfcnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Clientes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1121, 700);
            this.Controls.Add(this.pnlClientesCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.pnlClientesCadastrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarclientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlClientesCadastrar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisaPendentes;
        private System.Windows.Forms.Panel pnlInfos;
        private Guna.UI2.WinForms.Guna2Button bntExibir;
        private Guna.UI.WinForms.GunaDataGridView dataClientes;
        private bit_investDataSet1 bit_investDataSet1;
        private System.Windows.Forms.BindingSource consultarclientesBindingSource;
        private bit_investDataSet1TableAdapters.consultar_clientesTableAdapter consultar_clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpjDataGridViewTextBoxColumn;
    }
}

