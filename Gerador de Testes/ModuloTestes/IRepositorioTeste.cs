using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.ModuloTestes
{
    public interface IRepositorioTeste
    {
        void Cadastrar(Teste novoTeste);
        bool Editar(int id, Teste testeEditado);
        bool Excluir(int id);
        Teste SelecionarPorId(int id);
        List<Teste> SelecionarTodos();
    }
}
