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
        public string[] Alternativas { get; set; }
        
        public Questao(Materia materia, string enunciado)
        {
            Materia = materia;
            Enunciado = enunciado;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Materia == null)
                erros.Add("O campo \"matéria\" é obrigatório");

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"enunciado\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao questao = (Questao)novoRegistro;
            Materia = questao.Materia;
            Enunciado = questao.Enunciado;
            Alternativas = questao.Alternativas;
        }

        public override string ToString()
        {
            return $"{Enunciado} - {Materia?.Nome}";
        }
    }
}
