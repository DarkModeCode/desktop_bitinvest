using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using desktop_bitinvest_v1.bit_investDataSetTableAdapters;
using desktop_bitinvest_v1.Controller;
using desktop_bitinvest_v1.Model;

namespace desktop_bitinvest_v1
{
    public partial class Clientes : Form
    {
        UsuarioModel usuario = new UsuarioModel();

        public Clientes()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTudo_Click(object sender, EventArgs e)
        {
            dataClientes.DataSource = usuario.SelecionarClientes();
        }

        public void CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0)
            {
                Infos infos = new Infos()
                {
                    TopLevel = false,
                };
                this.pnlInfos.Controls.Add(infos);
                infos.Show();
                infos.BringToFront();

                DataGridViewRow row = dataClientes.Rows[e.RowIndex];

                var id = (int)row.Cells[0].Value;


                UsuarioModel user = new UsuarioModel();
                user.SelecionarLinhas(id);
                user.SelecionarTransacao(id);
                user.SelecionarRealBit(id);
                user.SelecionarRealEt(id);
                user.SelecionarRealLite(id);
                user.SelecionarBitcoin(id);
                user.SelecionarLitecoin(id);
                user.SelecionarEthereum(id);

                var id_usu = id.ToString();
                var transacao = Transacao.TotalTransacao.ToString();
                var saldoBitcoin = Transacao.TotalBitcoin.ToString();
                var saldoBitcoinReal = Transacao.TotalRealBit.ToString();
                var saldoEtReal = Transacao.TotalRealEt.ToString();
                var saldoEthereun = Transacao.TotalEthereum.ToString();
                var saldoLiteReal = Transacao.TotalRealLite.ToString();
                var saldoLitecoin = Transacao.TotalLiteCoin.ToString();
                
                infos.lblIdUsu.Text = row.Cells[0].Value.ToString();
                infos.lblNomeCompleto.Text = Usuario.Nome;
                infos.lblCpfUsu.Text = Usuario.cpf_cnpj;
                infos.lblRgUsu.Text = Usuario.rg;
                infos.lblTransacaoUsu.Text = transacao;
                infos.lblSaldoBitUsu.Text = saldoBitcoin;
                infos.lblRealBitUsu.Text = saldoBitcoinReal;
                infos.lblSaldoEtUsu.Text = saldoEthereun;
                infos.lblSaldoRealEtUsu.Text = saldoEtReal;
                infos.lblSaldoLiteRealUsu.Text = saldoLiteReal;
                infos.lblSaldoLiteUsu.Text = saldoLitecoin;

            }
            }
            
        

       public void dataTabelaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pesquisa(object sender, KeyPressEventArgs e)
        {
            var id = txtPesquisaPendentes.Text;
            dataClientes.DataSource = usuario.Pesquisa(id);

        }

        private void btnExibirDados_Click(object sender, EventArgs e)
        {

        }

        private IDisposable GetConnection()
        {
            throw new NotImplementedException();
        }

        private void pnlClientesCadastrar_Paint(object sender, PaintEventArgs e)
        {



        }

        private void txtPesquisaPendentes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataClientes.DataSource = usuario.SelecionarClientes();
       }

        private void bntExibir_Click(object sender, EventArgs e)
        {
            dataClientes.DataSource = usuario.SelecionarClientes();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.consultar_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.consultar_clientesTableAdapter.Fill(this.bit_investDataSet1.consultar_clientes);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.consultar_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.consultar_clientesTableAdapter.Fill(this.bit_investDataSet1.consultar_clientes);
        }
    }
}

