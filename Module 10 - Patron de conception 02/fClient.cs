using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_10___Patron_de_conception_02
{
    public partial class fClient : Form
    {
        private FactureModel m_factureModel;
        public fClient()
        {
            InitializeComponent();
        }

        public fClient(FactureModel p_FactureModel)
        {
            InitializeComponent();
            m_factureModel = p_FactureModel;
        }

        public FactureModel FactureModel { get { return m_factureModel; } }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fClient_Load(object sender, EventArgs e)
        {

        }
    }
}
