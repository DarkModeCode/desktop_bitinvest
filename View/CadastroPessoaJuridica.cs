using desktop_bitinvest_v1.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_bitinvest_v1.View
{
    
    public partial class CadastroPessoaJuridica : Form
    {
        public CadastroPessoaJuridica()
        {
            InitializeComponent();
        }

        private void txtNomePeJ_TextChanged(object sender, EventArgs e)
        {
            Cliente.Nome = txtNomePeJ.Text;
        }

        private void txtNomeFantasia_TextChanged(object sender, EventArgs e)
        {
            Cliente.Sobrenome = txtNomeFantasia.Text;

        }

        private void mskCNPJPeF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Cliente.cpf_cnpj = mskCNPJPeF.Text;

        }

        private void mskTelPeJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Cliente.telefone_residencial = mskTelPeJ.Text;

        }

        private void mskEmailPeJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDataFun_TextChanged(object sender, EventArgs e)
        {
            Cliente.Data_nasc_fund = txtDataFun.Text;

        }

        private void txtEmailPeJ_TextChanged(object sender, EventArgs e)
        {
            Cliente.Email = txtEmailPeJ.Text;

        }

        private void txtSenhaPeJ_TextChanged(object sender, EventArgs e)
        {
            
                Cliente.Senha = txtSenhaPeJ.Text;
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Cliente.Pais = txtPais.Text;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            Cliente.Cidade = txtCidade.Text;

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            Cliente.Estado = txtEstado.Text;

        }

        private void mskCepPeJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Cliente.Cep = mskCepPeJ.Text;

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            Cliente.Bairro = txtBairro.Text;
        }

        private void txtRuaPeJ_TextChanged(object sender, EventArgs e)
        {
            Cliente.Rua = txtRuaPeJ.Text;

        }

        private void txtNumPeJ_TextChanged(object sender, EventArgs e)
        {
            Cliente.Numero = txtNumPeJ.Text;
        }

        private void txtComplPeJ_TextChanged(object sender, EventArgs e)
        {
            Cliente.Complemento = txtComplPeJ.Text;
        }
        Bitmap bmp;
        private void bntUploadImage_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
