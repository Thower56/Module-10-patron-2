using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10___Patron_de_conception_02
{
    internal class FactureModel
    {
        private List<LigneFactureModel> m_lignesFactureModel;
        private List<IObserver<FactureModelEvent>> m_observateurs;
        public decimal Total{ get; private set; }
        FactureModel() { }
        public IDisposable Subscride(IObserver<FactureModelEvent> p_observateur)
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
            set 
            {
                this.m_lignesFactureModel = value;
                this.In
            }
        }

        public void AjouterLigneFactureModel(LigneFactureModel p_ligneFactureMode) { ; }
        public void Nouvelle() { ; }
    }
}
