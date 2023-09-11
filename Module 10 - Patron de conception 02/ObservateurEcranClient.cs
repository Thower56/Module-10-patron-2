using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_10___Patron_de_conception_02
{
    public class ObservateurEcranClient : IObserver<FactureModelEvent>
    {
        private IDisposable m_seDesabonner;
        private TextBox m_affichage;

        public ObservateurEcranClient(IObservable<FactureModelEvent> p_sujet, TextBox p_affichage)
        {
            if (p_sujet is null)
            {
                throw new ArgumentNullException(nameof(p_sujet));
            }

            if (p_affichage is null)
            {
                throw new ArgumentNullException(nameof(p_affichage));
            }

            m_seDesabonner = p_sujet.Subscribe(this);
            m_affichage = p_affichage;
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
                m_affichage.Text = $"{p_value.LigneFactureModel.Description}  {p_value.LigneFactureModel.Quantite} @ {p_value.LigneFactureModel.PrixUnitaire} ";
            }
            else if (p_value.Type == FactureModelEventType.NOUVELLE)
            {
                m_affichage.Text = "Bienvenue !";
            }
        }

        public void SeDesabonner() 
        {
            this.m_seDesabonner?.Dispose();
            this.m_seDesabonner = null;
        }
    }
}
