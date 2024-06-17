using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerador_de_Testes.ModuloDisciplina;

namespace Gerador_de_Testes.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia;
        public Materia Materia
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNomeMateria.Text = value.Nome;
                cmbBoxDisciplina.Text = value.Disciplina.ToString();

                if (rdbPrimeiraSerie.Checked)
                    rdbPrimeiraSerie.Text = value.Serie.ToString();
                else if (rdbSegundaSerie.Checked)
                    rdbSegundaSerie.Text = value.Serie.ToString();
            }

            get => materia;
        }
        public TelaMateriaForm()
        {
            InitializeComponent();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeMateria.Text;
            string Disciplina = cmbBoxDisciplina.Text;
            string serie = "";

            if (rdbPrimeiraSerie.Checked)
                serie = rdbPrimeiraSerie.Text;

            else if (rdbSegundaSerie.Checked)
                serie = rdbSegundaSerie.Text;

            materia = new Materia(nome, Disciplina, serie);

            List<string> erros = materia.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
            else
                DialogResult = DialogResult.OK;
        }
        public void PreencherComboBox(List<Disciplina> disciplinas)
        {
            foreach (Disciplina disciplina in disciplinas)
            {
                cmbBoxDisciplina.Items.Add(disciplina.Nome);
            }
        }
    }
}
