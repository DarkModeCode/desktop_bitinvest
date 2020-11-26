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
            this.bntExibir = new Guna.UI2.WinForms.Guna2Button();
            this.dataTabelaClientes = new System.Windows.Forms.DataGridView();
            this.bitinvestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet = new desktop_bitinvest_v1.bit_investDataSet();
            this.pnlInfos = new System.Windows.Forms.Panel();
            this.txtPesquisaPendentes = new Guna.UI2.WinForms.Guna2TextBox();
            this.bit_investDataSet1 = new desktop_bitinvest_v1.bit_investDataSet();
            this.bit_investDataSet2 = new desktop_bitinvest_v1.bit_investDataSet();
            this.bit_investDataSet3 = new desktop_bitinvest_v1.bit_investDataSet();
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
            this.pnlClientesCadastrar.Controls.Add(this.bntExibir);
            this.pnlClientesCadastrar.Controls.Add(this.dataTabelaClientes);
            this.pnlClientesCadastrar.Controls.Add(this.pnlInfos);
            this.pnlClientesCadastrar.Controls.Add(this.txtPesquisaPendentes);
            this.pnlClientesCadastrar.Location = new System.Drawing.Point(0, 1);
            this.pnlClientesCadastrar.Name = "pnlClientesCadastrar";
            this.pnlClientesCadastrar.Size = new System.Drawing.Size(1121, 698);
            this.pnlClientesCadastrar.TabIndex = 0;
            this.pnlClientesCadastrar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClientesCadastrar_Paint);
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
            // dataTabelaClientes
            // 
            this.dataTabelaClientes.AutoGenerateColumns = false;
            this.dataTabelaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabelaClientes.DataSource = this.bitinvestDataSetBindingSource;
            this.dataTabelaClientes.Location = new System.Drawing.Point(33, 98);
            this.dataTabelaClientes.Name = "dataTabelaClientes";
            this.dataTabelaClientes.Size = new System.Drawing.Size(650, 533);
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
        private Guna.UI2.WinForms.Guna2Button bntExibir;
    }
}

