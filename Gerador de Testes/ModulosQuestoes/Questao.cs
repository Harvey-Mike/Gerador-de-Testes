using Gerador_de_Testes.Compartilhado;
using Gerador_de_Testes.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModulosQuestoes
{
    public class Questao : EntidadeBase
    {
        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; }
        public Alternativa RespostaCorreta { get; set; }

        public Questao(Materia materia, string enunciado)
        {
            Materia = materia;
            Enunciado = enunciado;
            Alternativas = new List<Alternativa>();
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Materia == null)
                erros.Add("O campo \"matéria\" é obrigatório");

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"enunciado\" é obrigatório");

            if (Alternativas.Count < 2)
                erros.Add("A questão deve ter pelo menos duas alternativas");

            if (RespostaCorreta == null)
                erros.Add("A questão deve ter uma alternativa correta");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao questao = (Questao)novoRegistro;
            Materia = questao.Materia;
            Enunciado = questao.Enunciado;
            Alternativas = questao.Alternativas;
            RespostaCorreta = questao.RespostaCorreta;
        }

        public override string ToString()
        {
            return $"{Enunciado} - {Materia?.Nome}";
        }
    }

    public class Alternativa
    {
        public string Texto { get; set; }
        public bool Correta { get; set; }

        public Alternativa(string texto, bool correta)
        {
            Texto = texto;
            Correta = correta;
        }

        public override string ToString()
        {
            return Texto;
        }
    }
}
