using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Testes.ModulosQuestoes
{
    public partial class TabelaQuestaoControl : UserControl
    {
        private DataGridView dataGridQuestao;

        public TabelaQuestaoControl()
        {
            InitializeComponent();
            dataGridQuestoes.Columns.AddRange(CriarColunas());
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            dataGridQuestao.Rows.Clear();

            foreach (Questao q in questoes)
            {
                dataGridQuestao.Rows.Add(q.Id, q.Enunciado, q.Materia?.Nome, q.RespostaCorreta?.Texto);
            }
        }

        public int ObterRegistroSelecionado()
        {
            if (dataGridQuestao.SelectedRows.Count == 0)
                return -1;

            return Convert.ToInt32(dataGridQuestao.SelectedRows[0].Cells[0].Value);
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]
       {
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Matéria" },
            new DataGridViewTextBoxColumn { DataPropertyName = "RespostaCorreta", HeaderText = "Resposta Correta" }
       };
        }
    }
}
