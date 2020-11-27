namespace desktop_bitinvest_v1.View
{
    partial class RelatorioTransacoes
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
            this.transacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bitinvestDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bit_investDataSet1 = new desktop_bitinvest_v1.bit_investDataSet1();
            this.pnlRelatorioTrans = new System.Windows.Forms.Panel();
            this.repviTransacoes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.transacaoTableAdapter = new desktop_bitinvest_v1.bit_investDataSet1TableAdapters.TransacaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitinvestDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).BeginInit();
            this.pnlRelatorioTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // transacaoBindingSource
            // 
            this.transacaoBindingSource.DataMember = "Transacao";
            this.transacaoBindingSource.DataSource = this.bitinvestDataSet1BindingSource;
            // 
            // bitinvestDataSet1BindingSource
            // 
            this.bitinvestDataSet1BindingSource.DataSource = this.bit_investDataSet1;
            this.bitinvestDataSet1BindingSource.Position = 0;
            // 
            // bit_investDataSet1
            // 
            this.bit_investDataSet1.DataSetName = "bit_investDataSet1";
            this.bit_investDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlRelatorioTrans
            // 
            this.pnlRelatorioTrans.Controls.Add(this.repviTransacoes);
            this.pnlRelatorioTrans.Location = new System.Drawing.Point(0, 1);
            this.pnlRelatorioTrans.Name = "pnlRelatorioTrans";
            this.pnlRelatorioTrans.Size = new System.Drawing.Size(644, 603);
            this.pnlRelatorioTrans.TabIndex = 0;
            // 
            // repviTransacoes
            // 
            this.repviTransacoes.AutoScroll = true;
            reportDataSource1.Name = "dataRelatorioTrans";
            reportDataSource1.Value = this.transacaoBindingSource;
            this.repviTransacoes.LocalReport.DataSources.Add(reportDataSource1);
            this.repviTransacoes.LocalReport.ReportEmbeddedResource = "desktop_bitinvest_v1.View.Report1.rdlc";
            this.repviTransacoes.Location = new System.Drawing.Point(0, 0);
            this.repviTransacoes.Name = "repviTransacoes";
            this.repviTransacoes.ServerReport.BearerToken = null;
            this.repviTransacoes.Size = new System.Drawing.Size(644, 603);
            this.repviTransacoes.TabIndex = 0;
            // 
            // transacaoTableAdapter
            // 
            this.transacaoTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioTransacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 603);
            this.Controls.Add(this.pnlRelatorioTrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioTransacoes";
            this.Text = "RelatorioTransacoes";
            this.Load += new System.EventHandler(this.RelatorioTransacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitinvestDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit_investDataSet1)).EndInit();
            this.pnlRelatorioTrans.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorioTrans;
        private Microsoft.Reporting.WinForms.ReportViewer repviTransacoes;
        private bit_investDataSet1 bit_investDataSet1;
        private System.Windows.Forms.BindingSource bitinvestDataSet1BindingSource;
        private System.Windows.Forms.BindingSource transacaoBindingSource;
        private bit_investDataSet1TableAdapters.TransacaoTableAdapter transacaoTableAdapter;
    }
}