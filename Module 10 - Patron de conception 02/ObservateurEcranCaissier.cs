using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_10___Patron_de_conception_02
{
    public class ObservateurEcranCaissier : IObserver<FactureModelEvent>
    {

        private IDisposable m_seDesabonner;
        private DataGridView m_dgvFactureModel;
        private TextBox m_total;

        public ObservateurEcranCaissier(IObservable<FactureModelEvent> p_sujet, DataGridView dgvFactureModel, TextBox total)
        {
            m_seDesabonner = p_sujet.Subscribe(this);
            m_dgvFactureModel = dgvFactureModel;
            m_total = total;
        }

        public void SeDesabonner() 
        {
            this.m_seDesabonner?.Dispose();
            this.m_seDesabonner = null;
        }

        public void OnCompleted()
        {
            this.SeDesabonner();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(FactureModelEvent p_value)
        {
            if (p_value.Type == FactureModelEventType.AJOUT_LIGNE)
            {
                m_dgvFactureModel.Rows.Add(p_value.LigneFactureModel);
            }
            else if (p_value.Type == FactureModelEventType.NOUVELLE)
            {
                m_dgvFactureModel.DataSource = null;
                m_dgvFactureModel.Rows.Clear();
            }
        }
    }
}
