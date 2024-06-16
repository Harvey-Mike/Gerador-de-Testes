using Gerador_de_Testes.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.Compartilhado
{
    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; }
        public List<Materia> Materias { get; set; }

        public Disciplina(string nome)
        {
            Nome = nome;
            Materias = new List<Materia>();
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina d = (Disciplina)novoRegistro;
            Nome = d.Nome;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }

}
