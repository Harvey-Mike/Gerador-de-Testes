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
        public string Enunciado { get; set; }
        public List<string> Alternativas { get; set; }
        public string RespostaCorreta { get; set; }
        public Materia Materia { get; set; }

        public Questao()
        {
            Alternativas = new List<string>();
        }

        public Questao(string enunciado, List<string> alternativas, string respostaCorreta, Materia materia)
        {
            Enunciado = enunciado;
            Alternativas = alternativas ?? new List<string>();
            RespostaCorreta = respostaCorreta;
            Materia = materia;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao questaoAtualizada = (Questao)novoRegistro;
            Enunciado = questaoAtualizada.Enunciado;
            Alternativas = questaoAtualizada.Alternativas;
            RespostaCorreta = questaoAtualizada.RespostaCorreta;
            Materia = questaoAtualizada.Materia;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo enunciado não pode ser vazio");

            if (Alternativas == null || Alternativas.Count < 2)
                erros.Add("Devem ser fornecidas pelo menos duas alternativas");

            if (string.IsNullOrEmpty(RespostaCorreta.Trim()))
                erros.Add("O campo resposta correta não pode ser vazio");

            return erros;
        }
    }
}

