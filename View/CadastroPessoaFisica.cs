﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using desktop_bitinvest_v1.Controller;
using System.IO;
using System.Drawing.Imaging;

namespace desktop_bitinvest_v1.View
{
    public partial class CadastroPessoaFisica : Form
    {
        public CadastroPessoaFisica()
        {
            InitializeComponent();
        }

        public static List<string> carregaListaPaises()
        {
            //cria uma lista de paises
            List<string> CulturaLista = new List<string>();
            //Obtem a cultura especifica a partir da classe CultureInfo
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo getCulture in getCultureInfo)
            {
                //cria um objeto da classe RegionInfo
                RegionInfo GetRegionInfo = new RegionInfo(getCulture.LCID);
                //Incluir cada nome de pais no arraylist
                if (!(CulturaLista.Contains(GetRegionInfo.DisplayName)))
                {
                    CulturaLista.Add(GetRegionInfo.DisplayName);
                }
            }
            //ordena o array usando o método sort para obter os paises em ordem alfabética
            CulturaLista.Sort();
            //retorna a lista de paises
            return CulturaLista;
        }
        private void combPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void txtNomePeF_TextChanged(object sender, EventArgs e)
        {
            Cliente.Nome = txtNomePeF.Text;
        }

        private void txtSobrenomePeF_TextChanged(object sender, EventArgs e)
        {
            Cliente.Sobrenome = txtSobrenomePeF.Text;
        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
         //   Cliente.cpf_cnpj = mskCPF.Text;

        }

        private void mskRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCelularPeF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTelPeF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
       //     Cliente.telefone_residencial = mskTelPeF.Text;

        }

        private void mskEmailPeF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtRendaMensal_TextChanged(object sender, EventArgs e)
        {
            Cliente.RendaMensal = txtRendaMensal.Text;

        }

        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {
            Cliente.Data_nasc_fund = txtDataNasc.Text;

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
                Cliente.Senha = txtSenha.Text;
            

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Cliente.Email = txtEmail.Text;

        }

        private void combCidPeF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combEstPeF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            Cliente.Cidade = txtCidade.Text;

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            Cliente.Estado = txtEstado.Text;

        }

        private void mskCepPeF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            Cliente.Bairro = txtBairro.Text;

        }

        private void txtRuaPeF_TextChanged(object sender, EventArgs e)
        {
            Cliente.Rua = txtRuaPeF.Text;

        }

        private void txtNumPeF_TextChanged(object sender, EventArgs e)
        {
            Cliente.Numero = txtNumPeF.Text;

        }

        private void txtComplPeF_TextChanged(object sender, EventArgs e)
        {
            Cliente.Complemento = txtComplPeF.Text;

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            Cliente.cpf_cnpj = txtCpf.Text;
        }

        private void txtTelefoneR_TextChanged(object sender, EventArgs e)
        {
            Cliente.telefone_residencial = txtTelefoneR.Text;
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {
            Cliente.Pais = txtPais.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           



        }
        Bitmap bmp;

        private void button1_Click_1(object sender, EventArgs e)
        {
            MemoryStream memory = new MemoryStream(Cliente.Foto_Frente);
            MemoryStream memoryT = new MemoryStream(Cliente.Foto_Tras);
            MemoryStream memoryS = new MemoryStream(Cliente.Foto_Selfie);
        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.AutoScroll = true;
            panel2.Parent = this;
        }
        private void picDocFrente_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string nome = openFileDialog1.FileName;
                bmp = new Bitmap(nome);
                picDocFrente.Image = bmp;
                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Jpeg);
                byte[] foto = memory.ToArray();
                memory.Position = 0;
                memory.Read(foto, 0, foto.Length);
                Cliente.Foto_Frente = foto;
            }
        }

        private void picDocVerso_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string nome = openFileDialog1.FileName;
                bmp = new Bitmap(nome);
                picDocVerso.Image = bmp;

                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Jpeg);
                byte[] fotoT = memory.ToArray();
                memory.Position = 0;
                memory.Read(fotoT, 0, fotoT.Length);
                Cliente.Foto_Tras = fotoT;
            }
        }

        private void picSelfieDoc_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string nome = openFileDialog1.FileName;
                bmp = new Bitmap(nome);
                picSelfieDoc.Image = bmp;
                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Jpeg);

                byte[] fotoS = memory.ToArray();
                memory.Position = 0;
                memory.Read(fotoS, 0, fotoS.Length);
                Cliente.Foto_Selfie = fotoS;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Cliente.celular = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Cliente.Cep = textBox2.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Cliente.rg = textBox3.Text;

        }
    }
    }

