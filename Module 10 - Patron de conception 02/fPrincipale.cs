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
        public fPrincipale()
        {
            InitializeComponent();
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
                decimal total = nudPrix.Value * nudQuantite.Value;
                string[] newRow = { tbDescription.Text, nudQuantite.Value.ToString(), nudPrix.Value.ToString(), total.ToString() };
                DGVProduits.Rows.Add(newRow);
            }
            updateTotal();
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void updateTotal()
        {
            decimal sum = 0;
            sum += DGVProduits.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[3].Value));
            tbTotal.Text = sum.ToString();
        }
    
    }
}
