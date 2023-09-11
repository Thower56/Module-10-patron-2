using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10___Patron_de_conception_02
{
    public class ObservateurFactureModel : IObserver<FactureModelEvent>
    {
        private IDisposable m_seDesabonner;
        private Action<FactureModelEvent> m_action;

        public ObservateurFactureModel(IObservable<FactureModelEvent> p_sujet, Action<FactureModelEvent> action)
        {
            m_seDesabonner = p_sujet.Subscribe(this);
            m_action = action;
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
            this.m_action(p_value);
        }

        public void SeDesabonner()
        {
            this.m_seDesabonner?.Dispose();
            this.m_seDesabonner = null;
        }
    }
}
