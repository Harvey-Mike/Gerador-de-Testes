using Gerador_de_Testes.ModuloDisciplina;
using Gerador_de_Testes.ModuloMateria;
using Gerador_de_Testes.ModulosQuestoes;
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
    public partial class TelaTesteForm : Form
    {
        private Teste teste;

        public Teste Teste
        {
            set
            {

                txtTitulo.Text = value.Titulo;
                cmbBoxDisciplina.SelectedItem = value.Disciplina;
                cmbBoxMateria.SelectedItem = value.Materia;
                numericUpDown1.Value = value.Questoes.Count;
                checkBoxRecuperacao.Checked = value.Materia == null; // Prova de Recuperação considera todas as matérias
            }

            get => teste;
        }

        public TelaTesteForm()
        {
            InitializeComponent();
        }

        public void PreencherComboBoxDisciplinas(List<Disciplina> disciplinas)
        {
            cmbBoxDisciplina.Items.Clear();
            foreach (var disciplina in disciplinas)
            {
                cmbBoxDisciplina.Items.Add(disciplina);
            }
        }

        public void PreencherComboBoxMaterias(List<Materia> materias)
        {
            cmbBoxMateria.Items.Clear();
            foreach (var materia in materias)
            {
                cmbBoxMateria.Items.Add(materia);
            }
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            Disciplina disciplina = (Disciplina)cmbBoxDisciplina.SelectedItem;
            Materia materia = checkBoxRecuperacao.Checked ? null : (Materia)cmbBoxMateria.SelectedItem;
            int quantidadeQuestoes = (int)numericUpDown1.Value;

            teste = new Teste(titulo)
            {
                Disciplina = disciplina,
                Materia = materia,
                Questoes = new List<Questao>() 
            };

            List<string> erros = teste.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
