using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10___Patron_de_conception_02
{
    public class UnsubscriberFactureModel : IDisposable
    {
        private IObserver<FactureModelEvent> m_observer;
        private List<IObserver<FactureModelEvent>> m_observers;

        public UnsubscriberFactureModel(List<IObserver<FactureModelEvent>> p_observers, IObserver<FactureModelEvent> p_observer)
        {
            m_observer = p_observer;
            m_observers = p_observers;
        }

        public void Dispose()
        {
            m_observers.Remove(m_observer);
        }
    }
}
