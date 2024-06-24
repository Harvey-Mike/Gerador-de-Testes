using Gerador_de_Testes.Compartilhado.Extensoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Testes.ModuloTestes
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();
            dataGridTeste.Columns.AddRange(CriarColunas());
            dataGridTeste.ConfigurarGridSomenteLeitura();
            dataGridTeste.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Teste> testes)
        {
            dataGridTeste.Rows.Clear();

            foreach (Teste t in testes)
            {
                dataGridTeste.Rows.Add(t.Id, t.Titulo, t.Disciplina.Nome, t.Materia?.Nome ?? "Recuperação", t.Questoes.Count);
            }
        }

        public int ObterRegistroSelecionado()
        {
            if (dataGridTeste.SelectedRows.Count == 0)
                return -1;

            return Convert.ToInt32(dataGridTeste.SelectedRows[0].Cells[0].Value);
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Título" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Matéria" },
            new DataGridViewTextBoxColumn { DataPropertyName = "QuantidadeQuestoes", HeaderText = "Quantidade de Questões" }
            };
        }
    }
}

