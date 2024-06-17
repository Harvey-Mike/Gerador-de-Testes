using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Testes.ModuloMateria
{
    public partial class TabelaMateriaControl : UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();
            dataGridMateria.Columns.AddRange(CriarColunas());
        }

        public void AtualizarRegistros(List<Materia> materias)
        {
            dataGridMateria.Rows.Clear();

            foreach (Materia m in materias)
            {
                dataGridMateria.Rows.Add(m.Id, m.Nome, m.Disciplina, m.Serie);
            }
        }

        internal int ObterRegistroSelecionado()
        {
            if (dataGridMateria.SelectedRows.Count == 0)
                return -1;

            return Convert.ToInt32(dataGridMateria.SelectedRows[0].Cells[0].Value);
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]
        {
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Serie", HeaderText = "Série" }
        };
        }
    }
}
