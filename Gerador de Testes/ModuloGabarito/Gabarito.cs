using Gerador_de_Testes.Compartilhado;
using Gerador_de_Testes.ModulosQuestoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModuloGabarito
{
    public class Gabarito : EntidadeBase
    {
        public Questao Questao { get; set; }
        public int RespostaCorreta { get; set; }

        public Gabarito(Questao questao, int respostaCorreta)
        {
            Questao = questao;
            RespostaCorreta = respostaCorreta;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Questao == null)
                erros.Add("A questão é obrigatória");

            if (RespostaCorreta < 0 || RespostaCorreta >= Questao.Alternativas.Count)
                erros.Add("A resposta correta deve ser um índice válido das alternativas da questão");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Gabarito g = (Gabarito)novoRegistro;
            Questao = g.Questao;
            RespostaCorreta = g.RespostaCorreta;
        }

        public override string ToString()
        {
            return $"Questão: {Questao.Enunciado}, Resposta Correta: {RespostaCorreta}";
        }
    }


}
