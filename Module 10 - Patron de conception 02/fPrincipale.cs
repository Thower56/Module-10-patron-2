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
    public partial class fPrincipale : Form
    {
        private FactureModel m_FactureModel = new FactureModel();
        private fClient m_ecranClient;
        public fPrincipale()
        {
            InitializeComponent();
            m_ecranClient = new fClient(m_FactureModel);
            m_FactureModel.Subscribe(new ObservateurFactureModel(factureModel, (valeur) => { .(valeur); });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetupDataGridView()
        {

        }

        private void fPrincipale_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void bSimuler_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text != string.Empty && nudPrix.Value != 0 && nudQuantite.Value != 0)
            {
                foreach(IObserver o in m)
            }
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            ;
        }
    
    }
}
