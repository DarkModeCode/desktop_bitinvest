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
            this.consultar_clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet1 = new desktop_bitinvest_v1.bit_investDataSet1();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet11 = new desktop_bitinvest_v1.bit_investDataSet1();
            this.pnlRelatorioCadastros = new System.Windows.Forms.Panel();
            this.repviCadastros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.ClienteTableAdapter();
            this.perfilTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.PerfilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consultar_clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet11)).BeginInit();
            this.pnlRelatorioCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // consultar_clientesBindingSource
            // 
            this.consultar_clientesBindingSource.DataMember = "consultar_clientes";
            this.consultar_clientesBindingSource.DataSource = this.bit_investDataSet1;
            // 
            // bit_investDataSet1
            // 
            this.bit_investDataSet1.DataSetName = "bit_investDataSet1";
            this.bit_investDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.pnlRelatorioCadastros.Size = new System.Drawing.Size(714, 603);
            this.pnlRelatorioCadastros.TabIndex = 0;
            // 
            // repviCadastros
            // 
            this.repviCadastros.AutoScroll = true;
            reportDataSource1.Name = "Clientes";
            reportDataSource1.Value = this.clienteBindingSource;
            this.repviCadastros.LocalReport.DataSources.Add(reportDataSource1);
            this.repviCadastros.LocalReport.ReportEmbeddedResource = "desktop_bitinvest_v1.View.Report2.rdlc";
            this.repviCadastros.Location = new System.Drawing.Point(0, 0);
            this.repviCadastros.Name = "repviCadastros";
            this.repviCadastros.ServerReport.BearerToken = null;
            this.repviCadastros.Size = new System.Drawing.Size(711, 603);
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
            // RelatorioCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 603);
            this.Controls.Add(this.pnlRelatorioCadastros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioCadastros";
            this.Text = "RelatorioCadastros";
            this.Load += new System.EventHandler(this.RelatorioCadastros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultar_clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet11)).EndInit();
            this.pnlRelatorioCadastros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
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
    }
}