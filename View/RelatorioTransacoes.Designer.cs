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
            this.pnlRelatorioTrans = new System.Windows.Forms.Panel();
            this.repviTransacoes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlRelatorioTrans.SuspendLayout();
            this.SuspendLayout();
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
            this.repviTransacoes.LocalReport.ReportEmbeddedResource = "desktop_bitinvest_v1.View.Report1.rdlc";
            this.repviTransacoes.Location = new System.Drawing.Point(0, 0);
            this.repviTransacoes.Name = "repviTransacoes";
            this.repviTransacoes.ServerReport.BearerToken = null;
            this.repviTransacoes.Size = new System.Drawing.Size(644, 603);
            this.repviTransacoes.TabIndex = 0;
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
            this.pnlRelatorioTrans.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorioTrans;
        private Microsoft.Reporting.WinForms.ReportViewer repviTransacoes;
    }
}