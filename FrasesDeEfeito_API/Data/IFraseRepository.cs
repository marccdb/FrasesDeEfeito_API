using FrasesDeEfeito_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrasesDeEfeito_API.Data
{
    public interface IFraseRepository
    {
        bool SaveChanges();

        IEnumerable<Frase> GetFrases();
        Frase GetFraseById(int id);
        void CreateFrase(Frase frase);
        void DeleteFrase(Frase frase);
        void UpdateFrase(Frase frase);

    }
}
