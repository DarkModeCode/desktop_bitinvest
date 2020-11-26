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
            this.pnlClientesCadastrar = new System.Windows.Forms.Panel();
            this.dataTabelaClientes = new System.Windows.Forms.DataGridView();
            this.bitinvestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet = new desktop_bitinvest_v1.bit_investDataSet();
            this.pnlInfos = new System.Windows.Forms.Panel();
            this.txtPesquisaPendentes = new Guna.UI2.WinForms.Guna2TextBox();
            this.bit_investDataSet1 = new desktop_bitinvest_v1.bit_investDataSet();
            this.bit_investDataSet2 = new desktop_bitinvest_v1.bit_investDataSet();
            this.bit_investDataSet3 = new desktop_bitinvest_v1.bit_investDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlClientesCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitinvestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientesCadastrar
            // 
            this.pnlClientesCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlClientesCadastrar.AutoScroll = true;
            this.pnlClientesCadastrar.AutoSize = true;
            this.pnlClientesCadastrar.Controls.Add(this.button1);
            this.pnlClientesCadastrar.Controls.Add(this.dataTabelaClientes);
            this.pnlClientesCadastrar.Controls.Add(this.pnlInfos);
            this.pnlClientesCadastrar.Controls.Add(this.txtPesquisaPendentes);
            this.pnlClientesCadastrar.Location = new System.Drawing.Point(0, -19);
            this.pnlClientesCadastrar.Name = "pnlClientesCadastrar";
            this.pnlClientesCadastrar.Size = new System.Drawing.Size(1121, 739);
            this.pnlClientesCadastrar.TabIndex = 0;
            this.pnlClientesCadastrar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClientesCadastrar_Paint);
            // 
            // dataTabelaClientes
            // 
            this.dataTabelaClientes.AutoGenerateColumns = false;
            this.dataTabelaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabelaClientes.DataSource = this.bitinvestDataSetBindingSource;
            this.dataTabelaClientes.Location = new System.Drawing.Point(33, 90);
            this.dataTabelaClientes.Name = "dataTabelaClientes";
            this.dataTabelaClientes.Size = new System.Drawing.Size(597, 260);
            this.dataTabelaClientes.TabIndex = 3;
            this.dataTabelaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabelaClientes_CellContentClick_1);
            // 
            // bitinvestDataSetBindingSource
            // 
            this.bitinvestDataSetBindingSource.DataSource = this.bit_investDataSet;
            this.bitinvestDataSetBindingSource.Position = 0;
            // 
            // bit_investDataSet
            // 
            this.bit_investDataSet.DataSetName = "bit_investDataSet";
            this.bit_investDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlInfos
            // 
            this.pnlInfos.Location = new System.Drawing.Point(735, 90);
            this.pnlInfos.Name = "pnlInfos";
            this.pnlInfos.Size = new System.Drawing.Size(347, 541);
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
            this.bit_investDataSet1.DataSetName = "bit_investDataSet";
            this.bit_investDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bit_investDataSet2
            // 
            this.bit_investDataSet2.DataSetName = "bit_investDataSet";
            this.bit_investDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bit_investDataSet3
            // 
            this.bit_investDataSet3.DataSetName = "bit_investDataSet";
            this.bit_investDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.pnlClientesCadastrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitinvestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlClientesCadastrar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisaPendentes;
        private System.Windows.Forms.Panel pnlInfos;
        private System.Windows.Forms.BindingSource bitinvestDataSetBindingSource;
        private bit_investDataSet bit_investDataSet;
        private bit_investDataSet bit_investDataSet1;
        private bit_investDataSet bit_investDataSet2;
        private System.Windows.Forms.DataGridView dataTabelaClientes;
        private bit_investDataSet bit_investDataSet3;
        private System.Windows.Forms.Button button1;
    }
}

