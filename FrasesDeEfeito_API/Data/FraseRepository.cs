using FrasesDeEfeito_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace FrasesDeEfeito_API.Data
{
    public class FraseRepository : IFraseRepository
    {

        readonly FrasesContext _frasesContext;

        public FraseRepository(FrasesContext frasesContext)
        {
            _frasesContext = frasesContext;
        }


        public void CreateFrase(Frase frase)
        {
            _frasesContext.Add(frase);
        }

        public void DeleteFrase(Frase frase)
        {
            _frasesContext.Remove(frase);
        }

        public IEnumerable<Frase> GetFrases()
        {
            return _frasesContext.Frases.ToList();
        }

        public Frase GetFraseById(int id)
        {
            return _frasesContext.Frases.FirstOrDefault(x => x.ID == id);
        }

        public bool SaveChanges()
        {
            return _frasesContext.SaveChanges() > 1;
        }

        public void UpdateFrase(Frase frase)
        {
            _frasesContext.Update(frase);
        }
    }
}
