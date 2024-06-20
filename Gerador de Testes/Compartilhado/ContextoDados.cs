using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Testes.Compartilhado
{
    using Gerador_de_Testes.ModuloDisciplina;
    using Gerador_de_Testes.ModuloMateria;
    using Gerador_de_Testes.ModulosQuestoes;
    using Gerador_de_Testes.ModuloTestes;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    namespace GeradorDeTestes.WinApp.Compartilhado
    {
        public class ContextoDados
        {
            private string caminho = $"C:\\temp\\GeradorDeTestes\\dados.json";

            public List<Disciplina> Disciplinas { get; set; }
            public List<Materia> Materias { get; set; }
            public List<Questao> Questoes { get; set; }
            public List<Teste> Testes { get; set; }

            public ContextoDados()
            {
                Disciplinas = new List<Disciplina>();
                Materias = new List<Materia>();
                Questoes = new List<Questao>();
                Testes = new List<Teste>();
            }

            public ContextoDados(bool carregarDados) : this()
            {
                if (carregarDados)
                    CarregarDados();
            }

            public void Gravar()
            {
                FileInfo arquivo = new FileInfo(caminho);

                arquivo.Directory.Create();

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true,
                   // ReferenceHandler = ReferenceHandler.Preserve
                };

                byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

                File.WriteAllBytes(caminho, registrosEmBytes);
            }

            protected void CarregarDados()
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (!arquivo.Exists)
                    return;

                byte[] registrosEmBytes = File.ReadAllBytes(caminho);

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                };

                ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosEmBytes, options);

                if (ctx == null)
                    return;

                Disciplinas = ctx.Disciplinas;
                Materias = ctx.Materias;
                Questoes = ctx.Questoes;
                Testes = ctx.Testes;
            }
        }
    }

}
