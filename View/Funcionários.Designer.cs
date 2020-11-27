namespace desktop_bitinvest_v1.View
{
    partial class Funcionários
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
            this.txtPesquisaFunc = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataFuncionarios = new Guna.UI.WinForms.GunaDataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultarfuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bitinvestDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet1 = new desktop_bitinvest_v1.bit_investDataSet1();
            this.usuario_tem_perfilTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.usuario_tem_perfilTableAdapter();
            this.usuariosTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.TableAdapterManager();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.FuncionarioTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKusuariotIdus6477ECF3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKFuncionarIdus797309D9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultar_funcionarioTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.consultar_funcionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarfuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitinvestDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKusuariotIdus6477ECF3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFuncionarIdus797309D9BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaFunc
            // 
            this.txtPesquisaFunc.BorderRadius = 15;
            this.txtPesquisaFunc.BorderThickness = 0;
            this.txtPesquisaFunc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisaFunc.DefaultText = "";
            this.txtPesquisaFunc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisaFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisaFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaFunc.DisabledState.Parent = this.txtPesquisaFunc;
            this.txtPesquisaFunc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaFunc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaFunc.FocusedState.Parent = this.txtPesquisaFunc;
            this.txtPesquisaFunc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaFunc.HoverState.Parent = this.txtPesquisaFunc;
            this.txtPesquisaFunc.IconLeft = global::desktop_bitinvest_v1.Properties.Resources.Icon_ionic_ios_search;
            this.txtPesquisaFunc.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.txtPesquisaFunc.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtPesquisaFunc.IconRightSize = new System.Drawing.Size(15, 15);
            this.txtPesquisaFunc.Location = new System.Drawing.Point(12, 12);
            this.txtPesquisaFunc.Name = "txtPesquisaFunc";
            this.txtPesquisaFunc.PasswordChar = '\0';
            this.txtPesquisaFunc.PlaceholderText = "    ID, NOME, CPF, RG";
            this.txtPesquisaFunc.SelectedText = "";
            this.txtPesquisaFunc.ShadowDecoration.Parent = this.txtPesquisaFunc;
            this.txtPesquisaFunc.Size = new System.Drawing.Size(459, 30);
            this.txtPesquisaFunc.TabIndex = 3;
            // 
            // dataFuncionarios
            // 
            this.dataFuncionarios.AllowUserToAddRows = false;
            this.dataFuncionarios.AllowUserToDeleteRows = false;
            this.dataFuncionarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataFuncionarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataFuncionarios.AutoGenerateColumns = false;
            this.dataFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dataFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataFuncionarios.ColumnHeadersHeight = 21;
            this.dataFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nome,
            this.sobrenome,
            this.rg,
            this.cpf_cnpj});
            this.dataFuncionarios.DataSource = this.consultarfuncionarioBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFuncionarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataFuncionarios.EnableHeadersVisualStyles = false;
            this.dataFuncionarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataFuncionarios.Location = new System.Drawing.Point(12, 77);
            this.dataFuncionarios.Name = "dataFuncionarios";
            this.dataFuncionarios.ReadOnly = true;
            this.dataFuncionarios.RowHeadersVisible = false;
            this.dataFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFuncionarios.Size = new System.Drawing.Size(672, 599);
            this.dataFuncionarios.TabIndex = 4;
            this.dataFuncionarios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataFuncionarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.dataFuncionarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataFuncionarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataFuncionarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.dataFuncionarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataFuncionarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataFuncionarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataFuncionarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.dataFuncionarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataFuncionarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataFuncionarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataFuncionarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataFuncionarios.ThemeStyle.HeaderStyle.Height = 21;
            this.dataFuncionarios.ThemeStyle.ReadOnly = true;
            this.dataFuncionarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataFuncionarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataFuncionarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataFuncionarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataFuncionarios.ThemeStyle.RowsStyle.Height = 22;
            this.dataFuncionarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(26)))));
            this.dataFuncionarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFuncionarios_CellContentClick);
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "Id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // sobrenome
            // 
            this.sobrenome.DataPropertyName = "sobrenome";
            this.sobrenome.HeaderText = "Sobrenome";
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.ReadOnly = true;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg";
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            // 
            // cpf_cnpj
            // 
            this.cpf_cnpj.DataPropertyName = "cpf_cnpj";
            this.cpf_cnpj.HeaderText = "CPF";
            this.cpf_cnpj.Name = "cpf_cnpj";
            this.cpf_cnpj.ReadOnly = true;
            // 
            // consultarfuncionarioBindingSource
            // 
            this.consultarfuncionarioBindingSource.DataMember = "consultar_funcionario";
            this.consultarfuncionarioBindingSource.DataSource = this.bitinvestDataSet1BindingSource;
            // 
            // bitinvestDataSet1BindingSource
            // 
            this.bitinvestDataSet1BindingSource.DataSource = this.bit_investDataSet1;
            this.bitinvestDataSet1BindingSource.Position = 0;
            this.bitinvestDataSet1BindingSource.CurrentChanged += new System.EventHandler(this.bitinvestDataSet1BindingSource_CurrentChanged);
            // 
            // bit_investDataSet1
            // 
            this.bit_investDataSet1.DataSetName = "bit_investDataSet1";
            this.bit_investDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuario_tem_perfilTableAdapter
            // 
            this.usuario_tem_perfilTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.analise_tem_perfilTableAdapter = null;
            this.tableAdapterManager.AnaliseTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancoTableAdapter = null;
            this.tableAdapterManager.Cadastros_excluidosTableAdapter = null;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
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
            this.tableAdapterManager.UpdateOrder = desktop_bitinvest_v1.bit_investDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuario_tem_perfilTableAdapter = null;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.bitinvestDataSet1BindingSource;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bitinvestDataSet1BindingSource;
            // 
            // fKusuariotIdus6477ECF3BindingSource
            // 
            this.fKusuariotIdus6477ECF3BindingSource.DataMember = "FK__usuario_t__Id_us__6477ECF3";
            this.fKusuariotIdus6477ECF3BindingSource.DataSource = this.usuariosBindingSource;
            // 
            // fKFuncionarIdus797309D9BindingSource
            // 
            this.fKFuncionarIdus797309D9BindingSource.DataMember = "FK__Funcionar__Id_us__797309D9";
            this.fKFuncionarIdus797309D9BindingSource.DataSource = this.usuariosBindingSource;
            // 
            // consultar_funcionarioTableAdapter
            // 
            this.consultar_funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // Funcionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 698);
            this.Controls.Add(this.dataFuncionarios);
            this.Controls.Add(this.txtPesquisaFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionários";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.Funcionários_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarfuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitinvestDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKusuariotIdus6477ECF3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFuncionarIdus797309D9BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtPesquisaFunc;
        private Guna.UI.WinForms.GunaDataGridView dataFuncionarios;
        private bit_investDataSet1TableAdapters.usuario_tem_perfilTableAdapter usuario_tem_perfilTableAdapter;
        private System.Windows.Forms.BindingSource bitinvestDataSet1BindingSource;
        private bit_investDataSet1 bit_investDataSet1;
        private bit_investDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private bit_investDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private bit_investDataSet1TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.BindingSource fKusuariotIdus6477ECF3BindingSource;
        private System.Windows.Forms.BindingSource fKFuncionarIdus797309D9BindingSource;
        private System.Windows.Forms.BindingSource consultarfuncionarioBindingSource;
        private bit_investDataSet1TableAdapters.consultar_funcionarioTableAdapter consultar_funcionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_cnpj;
    }
}