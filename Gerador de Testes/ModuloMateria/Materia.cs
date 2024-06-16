using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModuloMateria
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }
        public int Serie { get; set; }
        public List<Questao> Questoes { get; set; }

        public Materia()
        {
            Questoes = new List<Questao>();
        }
    }
}
