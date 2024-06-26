﻿using Gerador_de_Testes.Compartilhado;
using Gerador_de_Testes.ModuloMateria;
  
namespace Gerador_de_Testes.ModuloDisciplina
{

    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; }

        public Disciplina() { }
        public Disciplina(string nome)
        {
            Nome = nome;
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
