using Gerador_de_Testes.ModulosQuestoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModuloGabarito
{
    public class Gabarito
    {
        public int Id { get; set; }
        public Questao Questao { get; set; }
        public int RespostaCorreta { get; set; }
    }

}
