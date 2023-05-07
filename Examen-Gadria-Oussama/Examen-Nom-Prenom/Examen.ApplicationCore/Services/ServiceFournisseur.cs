using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Examen.ApplicationCore.Services
{
    public class ServiceFournisseur : IServiceFournisseur
    {
        public List<Categorie> Categories=new List<Categorie>();
        
        public List<Fournisseur> GetFournisseurByCategory(Categorie categorie)
        {
            foreach (var c in Categories)
            {
                if (c.Equals(categorie))
                {
                    return (List<Fournisseur>)c.Produits;
                }
            }
            return new List<Fournisseur>(); 
        }
       


    }
}
