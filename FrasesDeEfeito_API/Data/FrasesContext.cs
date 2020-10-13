using FrasesDeEfeito_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrasesDeEfeito_API.Data
{
    public class FrasesContext : DbContext
    {

        public FrasesContext(DbContextOptions<FrasesContext> options) : base (options)
        {

        }

        public DbSet<Frase> Frases { get; set; }


    }
}
