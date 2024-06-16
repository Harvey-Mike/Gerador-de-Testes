using Gerador_de_Testes.Compartilhado;
using Gerador_de_Testes.ModuloDisciplina;
using Gerador_de_Testes.ModulosQuestoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModuloMateria
{
    public class Materia : EntidadeBase
    {
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public int Serie { get; set; }
        public List<Questao> Questoes { get; set; }

        public Materia(string nome, string disciplina, int serie)
        {
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;
            Questoes = new List<Questao>();
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (Disciplina == null)
                erros.Add("A \"disciplina\" é obrigatória");

            if (Serie <= 0)
                erros.Add("A \"série\" deve ser maior que zero");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia m = (Materia)novoRegistro;
            Nome = m.Nome;
            Disciplina = m.Disciplina;
            Serie = m.Serie;
        }

        public override string ToString()
        {
            return $"{Nome} (Série: {Serie})";
        }
    }
}
