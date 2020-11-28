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
            this.consultarclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet1 = new desktop_bitinvest_v1.bit_investDataSet1();
            this.bntExibir = new Guna.UI2.WinForms.Guna2Button();
            this.pnlInfos = new System.Windows.Forms.Panel();
            this.txtPesquisaPendentes = new Guna.UI2.WinForms.Guna2TextBox();
            this.consultar_clientesTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.consultar_clientesTableAdapter();
            this.Cliente = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter1 = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.ClienteTableAdapter();
            this.usuario_tem_perfilTableAdapter1 = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.usuario_tem_perfilTableAdapter();
            this.usuariosTableAdapter1 = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.UsuariosTableAdapter();
            this.clienteconsultarclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuario_tem_perfilTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.usuario_tem_perfilTableAdapter();
            this.usuariosTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.UsuariosTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet2 = new desktop_bitinvest_v1.bit_investDataSet2();
            this.clienteTableAdapter = new desktop_bitinvest_v1.bit_investDataSet2TableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new desktop_bitinvest_v1.bit_investDataSet2TableAdapters.TableAdapterManager();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlClientesCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteconsultarclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
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
            this.pnlClientesCadastrar.Location = new System.Drawing.Point(10, 12);
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
            this.dataClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClientes_CellContentClick);
            // 
            // consultarclientesBindingSource
            // 
            this.consultarclientesBindingSource.DataMember = "consultar_clientes";
            this.consultarclientesBindingSource.DataSource = this.bit_investDataSet1;
            this.consultarclientesBindingSource.CurrentChanged += new System.EventHandler(this.consultarclientesBindingSource_CurrentChanged);
            // 
            // bit_investDataSet1
            // 
            this.bit_investDataSet1.DataSetName = "bit_investDataSet1";
            this.bit_investDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // consultar_clientesTableAdapter
            // 
            this.consultar_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // Cliente
            // 
            this.Cliente.DataMember = "Cliente";
            this.Cliente.DataSource = this.bit_investDataSet1;
            this.Cliente.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // usuario_tem_perfilTableAdapter1
            // 
            this.usuario_tem_perfilTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // clienteconsultarclientesBindingSource
            // 
            this.clienteconsultarclientesBindingSource.DataMember = "Cliente_consultar_clientes";
            this.clienteconsultarclientesBindingSource.DataSource = this.Cliente;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            // 
            // usuario_tem_perfilTableAdapter
            // 
            this.usuario_tem_perfilTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bit_investDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Cliente_consultar_clientes";
            this.bindingSource2.DataSource = this.Cliente;
            // 
            // bit_investDataSet2
            // 
            this.bit_investDataSet2.DataSetName = "bit_investDataSet2";
            this.bit_investDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.analise_tem_perfilTableAdapter = null;
            this.tableAdapterManager.AnaliseTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancoTableAdapter = null;
            this.tableAdapterManager.Cadastros_excluidosTableAdapter = null;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.Dados_bancariosTableAdapter = null;
            this.tableAdapterManager.EnderecoTableAdapter = null;
            this.tableAdapterManager.esqueci_senhaTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.GraficosTableAdapter = null;
            this.tableAdapterManager.MoedasTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.RelatoriosTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TransacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = desktop_bitinvest_v1.bit_investDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuario_tem_perfilTableAdapter = null;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1141, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
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
            this.ClientSize = new System.Drawing.Size(1141, 722);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.pnlClientesCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.pnlClientesCadastrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteconsultarclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
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
        private System.Windows.Forms.BindingSource Cliente;
        private bit_investDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter1;
        private bit_investDataSet1TableAdapters.usuario_tem_perfilTableAdapter usuario_tem_perfilTableAdapter1;
        private bit_investDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private System.Windows.Forms.BindingSource clienteconsultarclientesBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private bit_investDataSet1TableAdapters.usuario_tem_perfilTableAdapter usuario_tem_perfilTableAdapter;
        private bit_investDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private bit_investDataSet2 bit_investDataSet2;
        private bit_investDataSet2TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private bit_investDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpjDataGridViewTextBoxColumn;
    }
}

