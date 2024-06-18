using Gerador_de_Testes.Compartilhado;
using Gerador_de_Testes.ModuloDisciplina;
using Gerador_de_Testes.ModuloMateria;
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
        public string Titulo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public List<Questao> Questoes { get; set; }
        public DateTime DataGeracao { get; set; }

        public Teste(string titulo)
        {
            Titulo = titulo;
            DataGeracao = DateTime.Now;
            Questoes = new List<Questao>();
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"Título\" é obrigatório");

            if (Disciplina == null)
                erros.Add("O campo \"Disciplina\" é obrigatório");

            if (Materia == null)
                erros.Add("O campo \"Matéria\" é obrigatório");

            if (Questoes == null || Questoes.Count == 0)
                erros.Add("O teste deve conter pelo menos uma questão");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste teste = (Teste)novoRegistro;
            Titulo = teste.Titulo;
            Disciplina = teste.Disciplina;
            Materia = teste.Materia;
            Questoes = teste.Questoes;
        }
    }

}
