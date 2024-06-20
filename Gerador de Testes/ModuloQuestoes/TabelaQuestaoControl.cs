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
            ConfigurarColunas();
            dataGridQuestoes.ConfigurarGridSomenteLeitura();
            dataGridQuestoes.ConfigurarGridZebrado();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { Name = "enunciado", HeaderText = "Enunciado" },
                new DataGridViewTextBoxColumn { Name = "materia", HeaderText = "Matéria" },
                new DataGridViewTextBoxColumn { Name = "respostaCorreta", HeaderText = "Resposta Correta" }
            };

            dataGridQuestoes.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            dataGridQuestoes.Rows.Clear();

            foreach (Questao questao in questoes)
            {
                dataGridQuestoes.Rows.Add(questao.Id, questao.Enunciado, questao.Materia.Nome, questao.RespostaCorreta);
            }
        }

        public int ObterRegistroSelecionado()
        {
            if (dataGridQuestoes.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(dataGridQuestoes.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
