using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerador_de_Testes.Compartilhado;

namespace Gerador_de_Testes.ModulosQuestoes
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
            dataGridQuestoes.Columns.AddRange(CriarColunas());
            dataGridQuestoes.ConfigurarGridSomenteLeitura();
            dataGridQuestoes.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            dataGridQuestoes.Rows.Clear();

            foreach (Questao q in questoes)
            {
                dataGridQuestoes.Rows.Add(q.Id, q.Enunciado, q.Materia?.Nome);
            }
        }

        public int ObterRegistroSelecionado()
        {
            if (dataGridQuestoes.SelectedRows.Count == 0)
                return -1;

            return Convert.ToInt32(dataGridQuestoes.SelectedRows[0].Cells[0].Value);
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]
       {
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Matéria" }
            //new DataGridViewTextBoxColumn { DataPropertyName = "RespostaCorreta", HeaderText = "Resposta Correta" }
       };
        }
    }
}
