﻿using System;
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
                dataGridMateria.Rows.Add(m.Id, m.Nome, m.Disciplina.Nome, m.Serie);
            }
        }

        internal int ObterRegistroSelecionado()
        {
            throw new NotImplementedException();
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