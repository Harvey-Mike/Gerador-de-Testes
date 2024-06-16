using Gerador_de_Testes.Compartilhado.GeradorDeTestes.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivo : RepositorioBaseEmArquivo<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Disciplina> ObterRegistros()
        {
            return contexto.Disciplinas;
        }
    }
}
