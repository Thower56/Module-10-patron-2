using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10___Patron_de_conception_02
{
    public class LigneFactureModel
    {
        public LigneFactureModel(string description, decimal quantite, decimal prixUnitaire)
        {
            Description = description;
            Quantite = quantite;
            PrixUnitaire = prixUnitaire;
        }

        public string Description { get; set; }
        public decimal Quantite { get; set; }
        public decimal PrixUnitaire { get; set; }


    }
}
