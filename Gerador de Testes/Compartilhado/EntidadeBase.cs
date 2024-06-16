using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public abstract List<string> Validar();

        public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
    }
}
