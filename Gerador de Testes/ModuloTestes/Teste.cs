using Gerador_de_Testes.Compartilhado;
using Gerador_de_Testes.ModulosQuestoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModuloTestes
{
    public class Teste : EntidadeBase
    {
        public DateTime DataGeracao { get; set; }
        public List<Questao> Questoes { get; set; }

        public Teste(DateTime dataGeracao, List<Questao> questoes)
        {
            DataGeracao = dataGeracao;
            Questoes = questoes;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Questoes == null || Questoes.Count == 0)
                erros.Add("O teste deve conter pelo menos uma questão");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste t = (Teste)novoRegistro;
            DataGeracao = t.DataGeracao;
            Questoes = t.Questoes;
        }

        public override string ToString()
        {
            return $"Teste gerado em: {DataGeracao}";
        }
    }

}
