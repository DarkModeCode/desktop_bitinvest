namespace desktop_bitinvest_v1.View
{
    partial class RelatorioCadastros
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.transacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet1 = new desktop_bitinvest_v1.bit_investDataSet1();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet = new desktop_bitinvest_v1.bit_investDataSet();
            this.loginclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultar_clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet11 = new desktop_bitinvest_v1.bit_investDataSet1();
            this.pnlRelatorioCadastros = new System.Windows.Forms.Panel();
            this.repviCadastros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.ClienteTableAdapter();
            this.perfilTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.PerfilTableAdapter();
            this.transacaoTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.TransacaoTableAdapter();
            this.moedasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moedasTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.MoedasTableAdapter();
            this.usuariosTableAdapter = new desktop_bitinvest_v1.bit_investDataSetTableAdapters.UsuariosTableAdapter();
            this.login_clienteTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.login_clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultar_clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet11)).BeginInit();
            this.pnlRelatorioCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedasBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bit_investDataSet;
            // 
            // bit_investDataSet
            // 
            this.bit_investDataSet.DataSetName = "bit_investDataSet";
            this.bit_investDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginclienteBindingSource
            // 
            this.loginclienteBindingSource.DataMember = "login_cliente";
            this.loginclienteBindingSource.DataSource = this.bit_investDataSet1;
            // 
            // consultar_clientesBindingSource
            // 
            this.consultar_clientesBindingSource.DataMember = "consultar_clientes";
            this.consultar_clientesBindingSource.DataSource = this.bit_investDataSet1;
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "Perfil";
            this.perfilBindingSource.DataSource = this.bit_investDataSet11;
            // 
            // bit_investDataSet11
            // 
            this.bit_investDataSet11.DataSetName = "bit_investDataSet1";
            this.bit_investDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlRelatorioCadastros
            // 
            this.pnlRelatorioCadastros.Controls.Add(this.repviCadastros);
            this.pnlRelatorioCadastros.Location = new System.Drawing.Point(0, 0);
            this.pnlRelatorioCadastros.Name = "pnlRelatorioCadastros";
            this.pnlRelatorioCadastros.Size = new System.Drawing.Size(749, 603);
            this.pnlRelatorioCadastros.TabIndex = 0;
            // 
            // repviCadastros
            // 
            this.repviCadastros.AutoScroll = true;
            reportDataSource1.Name = "Transacoes";
            reportDataSource1.Value = this.transacaoBindingSource;
            reportDataSource2.Name = "Clientes";
            reportDataSource2.Value = this.usuariosBindingSource;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.loginclienteBindingSource;
            this.repviCadastros.LocalReport.DataSources.Add(reportDataSource1);
            this.repviCadastros.LocalReport.DataSources.Add(reportDataSource2);
            this.repviCadastros.LocalReport.DataSources.Add(reportDataSource3);
            this.repviCadastros.LocalReport.ReportEmbeddedResource = "desktop_bitinvest_v1.View.Report2.rdlc";
            this.repviCadastros.Location = new System.Drawing.Point(0, 0);
            this.repviCadastros.Name = "repviCadastros";
            this.repviCadastros.ServerReport.BearerToken = null;
            this.repviCadastros.Size = new System.Drawing.Size(749, 603);
            this.repviCadastros.TabIndex = 0;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bit_investDataSet11;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // transacaoTableAdapter
            // 
            this.transacaoTableAdapter.ClearBeforeFill = true;
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
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // login_clienteTableAdapter
            // 
            this.login_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 603);
            this.Controls.Add(this.pnlRelatorioCadastros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioCadastros";
            this.Text = "RelatorioCadastros";
            this.Load += new System.EventHandler(this.RelatorioCadastros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultar_clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet11)).EndInit();
            this.pnlRelatorioCadastros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorioCadastros;
        private bit_investDataSet1 bit_investDataSet1;
        private System.Windows.Forms.BindingSource consultar_clientesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer repviCadastros;
        private bit_investDataSet1 bit_investDataSet11;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private bit_investDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private bit_investDataSet1TableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.BindingSource transacaoBindingSource;
        private bit_investDataSet1TableAdapters.TransacaoTableAdapter transacaoTableAdapter;
        private System.Windows.Forms.BindingSource moedasBindingSource;
        private bit_investDataSet1TableAdapters.MoedasTableAdapter moedasTableAdapter;
        private bit_investDataSet bit_investDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private bit_investDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource loginclienteBindingSource;
        private bit_investDataSet1TableAdapters.login_clienteTableAdapter login_clienteTableAdapter;
    }
}