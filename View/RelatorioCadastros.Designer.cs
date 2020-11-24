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
            this.pnlRelatorioCadastros = new System.Windows.Forms.Panel();
            this.repviCadastros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlRelatorioCadastros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRelatorioCadastros
            // 
            this.pnlRelatorioCadastros.Controls.Add(this.repviCadastros);
            this.pnlRelatorioCadastros.Location = new System.Drawing.Point(0, 0);
            this.pnlRelatorioCadastros.Name = "pnlRelatorioCadastros";
            this.pnlRelatorioCadastros.Size = new System.Drawing.Size(644, 487);
            this.pnlRelatorioCadastros.TabIndex = 0;
            // 
            // repviCadastros
            // 
            this.repviCadastros.AutoScroll = true;
            this.repviCadastros.LocalReport.ReportEmbeddedResource = "desktop_bitinvest_v1.View.Report2.rdlc";
            this.repviCadastros.Location = new System.Drawing.Point(0, 0);
            this.repviCadastros.Name = "repviCadastros";
            this.repviCadastros.ServerReport.BearerToken = null;
            this.repviCadastros.Size = new System.Drawing.Size(643, 487);
            this.repviCadastros.TabIndex = 0;
            // 
            // RelatorioCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 487);
            this.Controls.Add(this.pnlRelatorioCadastros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioCadastros";
            this.Text = "RelatorioCadastros";
            this.Load += new System.EventHandler(this.RelatorioCadastros_Load);
            this.pnlRelatorioCadastros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorioCadastros;
        private Microsoft.Reporting.WinForms.ReportViewer repviCadastros;
    }
}