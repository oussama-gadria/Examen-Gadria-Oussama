using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Categorie
    {
        private object value;

        public Categorie()
        {
        }

        public Categorie(object value)
        {
            this.value = value;
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public virtual IList<Produit> Produits { get; set; }
    }
}
