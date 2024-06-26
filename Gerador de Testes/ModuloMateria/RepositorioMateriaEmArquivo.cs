﻿using Gerador_de_Testes.Compartilhado.GeradorDeTestes.WinApp.Compartilhado;
using Gerador_de_Testes.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioBaseEmArquivo<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Materia> ObterRegistros()
        {
            return contexto.Materias;
        }

    }
}
