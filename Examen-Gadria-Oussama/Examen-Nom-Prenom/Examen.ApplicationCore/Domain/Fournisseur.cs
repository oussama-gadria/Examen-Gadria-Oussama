using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Fournisseur
    {
        [Key]
        public int Identifiant { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        [MaxLength(12)]
        [MinLength(3)]
        public string Nom { get; set; }
        public virtual List<Produit> Produits { get; set;}
    }
}
