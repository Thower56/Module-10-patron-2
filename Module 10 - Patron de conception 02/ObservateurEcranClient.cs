using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_10___Patron_de_conception_02
{
    public class ObservateurEcranClient
    {
        private IDisposable m_serDesabonner;
        private TextBox m_affichage;

        public ObservateurEcranClient(IObservable<FactureModelEvent> p_sujet, )
    }
}
