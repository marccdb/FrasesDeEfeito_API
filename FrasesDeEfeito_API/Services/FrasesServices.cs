using FrasesDeEfeito_API.Data;
using FrasesDeEfeito_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrasesDeEfeito_API.Services
{
    public class FrasesServices : IFrasesServices
    {

        readonly IFraseRepository _iFraseRepository;

        public FrasesServices(IFraseRepository fraseRepository)
        {
            _iFraseRepository = fraseRepository;
        }


        public void CreateFrase(Frase frase)
        {
            _iFraseRepository.CreateFrase(frase);
            _iFraseRepository.SaveChanges();
        }

        public void DeleteFrase(Frase frase)
        {
            _iFraseRepository.DeleteFrase(frase);
            _iFraseRepository.SaveChanges();
        }

        public Frase GetFraseById(int id)
        {
            return _iFraseRepository.GetFraseById(id);
        }

        public IEnumerable<Frase> GetFrases()
        {
            return _iFraseRepository.GetFrases();
        }

        public bool SaveChanges()
        {
            return _iFraseRepository.SaveChanges();
        }

        public void UpdateFrase(Frase frase)
        {
            _iFraseRepository.UpdateFrase(frase);
            _iFraseRepository.SaveChanges();
        }
    }
}
