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
        public int RespostaCorreta { get; set; }
        public Materia Materia { get; set; }

        public Questao(string enunciado, List<string> alternativas, int respostaCorreta, Materia materia)
        {
            Enunciado = enunciado;
            Alternativas = alternativas;
            RespostaCorreta = respostaCorreta;
            Materia = materia;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"enunciado\" é obrigatório");

            if (Alternativas == null || Alternativas.Count < 2)
                erros.Add("Devem existir pelo menos duas alternativas");

            if (RespostaCorreta < 0 || RespostaCorreta >= Alternativas.Count)
                erros.Add("A resposta correta deve ser um índice válido das alternativas");

            if (Materia == null)
                erros.Add("A \"matéria\" é obrigatória");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao q = (Questao)novoRegistro;
            Enunciado = q.Enunciado;
            Alternativas = q.Alternativas;
            RespostaCorreta = q.RespostaCorreta;
            Materia = q.Materia;
        }

        public override string ToString()
        {
            return $"{Enunciado}";
        }
    }
}
