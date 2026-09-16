using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Entities
{
    public class Turma
    {
        public int Id { get; set; }
        public int Curso_ID { get; set; }
        public string Nome { get; set; }
        
        public ICollection<Matricula> Matriculas { get; set; }
        public Curso Curso { get; set; }
    }
}
