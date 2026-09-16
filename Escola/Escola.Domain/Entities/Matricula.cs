using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Entities
{
    public class Matricula
    {
        public int Id { get; set; }
        public int Turma_ID { get; set; }
        public int Usuario_ID { get; set; }  
        public DateTime DataMatricula { get; set; }
        public DateTime DataExpiracao { get; set; }

        public ICollection<Nota> Notas { get; set; }
        public Usuario Usuario { get; set; }
        public Turma Turma { get; set; }
    }
}
