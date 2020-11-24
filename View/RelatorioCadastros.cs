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
    public partial class RelatorioCadastros : Form
    {
        public RelatorioCadastros()
        {
            InitializeComponent();
        }

        private void RelatorioCadastros_Load(object sender, EventArgs e)
        {

            this.repviCadastros.RefreshReport();
        }
    }
}
