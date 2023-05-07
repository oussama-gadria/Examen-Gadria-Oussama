using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Produit
    {
        public int ProduitId { get; set; }

        [DataType(DataType.Date,ErrorMessage = "Invalid Date!")]
        public DateTime DateProd { get; set; }
        public string  Destination { get; set; }
        public string Nom { get; set; }
        public double Price { get; set; }
        public virtual List<Fournisseur> Fournisseurs { get; set; }
        public int CategorieFk { get; set; }
        [ForeignKey("CategorieFk")]
        public virtual Categorie Categorie { get; set; }
    }
}
