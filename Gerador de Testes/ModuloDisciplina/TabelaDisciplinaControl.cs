using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Testes.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            dataGrid.Columns.AddRange(CriarColunas());
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            dataGrid.Rows.Clear();

            foreach (Disciplina d in disciplinas)
            {
                dataGrid.Rows.Add(d.Id, d.Nome);
            }
        }

        public int ObterRegistroSelecionado()
        {
            if (dataGrid.SelectedRows.Count == 0)
                return -1;

            return Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" }
            };
        }
    }
}
}
