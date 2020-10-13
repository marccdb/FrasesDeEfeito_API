using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrasesDeEfeito_API.Models;
using FrasesDeEfeito_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrasesDeEfeito_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrasesController : ControllerBase
    {
        private readonly IFrasesServices _iFrasesServices;

        public FrasesController(IFrasesServices iFrasesServices)
        {
            _iFrasesServices = iFrasesServices;
        }

        [HttpGet]
        public IActionResult GetFrases()
        {
            var returnedValue = _iFrasesServices.GetFrases();
            return Ok(returnedValue);
        }

        [HttpGet("{id}")]
        public IActionResult GetFraseById(int id)
        {
            var returnedValue = _iFrasesServices.GetFraseById(id);
            if (returnedValue == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(returnedValue);
            }
        }

        [HttpPost]
        public IActionResult CreateFrase(Frase frase)
        {
            _iFrasesServices.CreateFrase(frase);
            return CreatedAtAction(nameof(GetFraseById), new { frase.ID }, frase);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFrase(int id)
        {
            var fraseToDelete = _iFrasesServices.GetFraseById(id);
            if (fraseToDelete == null)
            {
                return NotFound();
            }
            else
            {
                _iFrasesServices.DeleteFrase(fraseToDelete);
                return Ok($"ID #{id} has been removed.");
            }

        }

        [HttpPut("{id}")]
        public IActionResult UpdateFrase(Frase frase)
        {

            _iFrasesServices.UpdateFrase(frase);
            return NoContent();
        }




    }
}
