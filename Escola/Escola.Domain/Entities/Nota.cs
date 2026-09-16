using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Entities
{
    public class Nota
    {
        public int Id { get; set; }
        public int Matricula_ID { get; set; }
        public int Valor { get; set; }
        public bool Aprovado { get; set; }

        public Matricula Matricula { get; set; }
    }
}
