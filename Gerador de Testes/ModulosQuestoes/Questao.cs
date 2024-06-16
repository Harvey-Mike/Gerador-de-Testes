using Gerador_de_Testes.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModulosQuestoes
{
    public class Questao
    {
        public int Id { get; set; }
        public string Enunciado { get; set; }
        public List<string> Alternativas { get; set; }
        public int RespostaCorreta { get; set; } // Índice da alternativa correta
        public Materia Materia { get; set; }

        public Questao()
        {
            Alternativas = new List<string>();
        }
    }
}
