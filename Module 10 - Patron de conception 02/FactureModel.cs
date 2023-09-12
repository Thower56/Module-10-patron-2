using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10___Patron_de_conception_02
{
    public class FactureModel : IObservable<FactureModelEvent>
    {
        private List<LigneFactureModel> m_lignesFactureModel;
        private List<IObserver<FactureModelEvent>> m_observateurs;
        public decimal Total{ get; private set; }
        public FactureModel()
        {
            m_lignesFactureModel = new List<LigneFactureModel>();
        }
        public IDisposable Subscribe(IObserver<FactureModelEvent> p_observateur)
        {
            if (p_observateur is null)
            {
                throw new ArgumentNullException(nameof(p_observateur));
            }
            this.m_observateurs.Add(p_observateur);

            return new UnsubscriberFactureModel(m_observateurs, p_observateur);
        }


        public List<LigneFactureModel> LigneFactureModel 
        {
            get { return m_lignesFactureModel; }
            set { this.m_lignesFactureModel = value; }
        }

        public void AjouterLigneFactureModel(LigneFactureModel p_ligneFactureMode) 
        {
            m_lignesFactureModel.Add(p_ligneFactureMode);
            FactureModelEvent factureModel = new FactureModelEvent();
            factureModel.LigneFactureModel = p_ligneFactureMode;
            factureModel.FactureModel = this;
            factureModel.Type = FactureModelEventType.AJOUT_LIGNE;

            foreach (IObserver<FactureModelEvent> o in m_observateurs) 
            {
                o.OnNext(factureModel);
            }
        }
        public void Nouvelle() 
        {
            m_lignesFactureModel.Clear();
        }

        
    }
}
