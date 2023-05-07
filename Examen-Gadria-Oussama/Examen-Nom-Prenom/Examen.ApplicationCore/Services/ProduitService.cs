using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ProduitService : Service<Produit>, IProduit
    {
        List<Chimique> produitsChimiques = new List<Chimique>();
        public ProduitService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public List<Chimique> GetProduitsChimiquesByPrix(double prix)
        {

            return produitsChimiques
                .Where(p => p.Price > prix)
                .OrderBy(p => p.Price)
                .Take(5)
                .ToList();
        }
        public float GetMoyennePrixOfProduitBiologique(Categorie categorie)
        {
            double total = 0;
            int count = 0;
            foreach (var p in categorie.Produits)
            {
                if (p is Biologique)
                {
                    total += p.Price;
                    count++;
                }
            }
            return ((float)(total / count));
        }
    }
}
