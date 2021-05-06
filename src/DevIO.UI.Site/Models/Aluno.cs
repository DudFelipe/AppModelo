using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Models
{
    public class Aluno
    {
        public Aluno()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; } //O Entity Framework já entende que Id é uma chave primaria
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
