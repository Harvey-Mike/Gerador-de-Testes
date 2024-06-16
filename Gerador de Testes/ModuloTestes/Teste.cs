using Gerador_de_Testes.ModulosQuestoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModuloTestes
{
    public class Teste
    {
        public int Id { get; set; }
        public DateTime DataGeracao { get; set; }
        public List<Questao> Questoes { get; set; }

        public Teste()
        {
            Questoes = new List<Questao>();
        }
    }

}
