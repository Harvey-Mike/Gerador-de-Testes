using Gerador_de_Testes.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gerador_de_Testes.ModulosQuestoes.Questao;

namespace Gerador_de_Testes.ModulosQuestoes
{
    public partial class TelaQuestoesForm : Form
    {
        private Questao questao;

        public TelaQuestoesForm()
        {
            InitializeComponent();
        }

        public Questao Questao
        {
            get { return questao; }
            set
            {
                questao = value;
                txtEnunciado.Text = questao.Enunciado;
                listaRespostas.Items.Clear();
                foreach (string alternativa in questao.Alternativas)
                {
                    listaRespostas.Items.Add(alternativa, alternativa == questao.RespostaCorreta);
                }
                cmbBoxMateria.SelectedItem = questao.Materia;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string novaAlternativa = txtResposta.Text.Trim();
            if (!string.IsNullOrEmpty(novaAlternativa))
            {
                listaRespostas.Items.Add(novaAlternativa, false);
                txtResposta.Clear();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listaRespostas.SelectedItem != null)
            {
                listaRespostas.Items.Remove(listaRespostas.SelectedItem);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string enunciado = txtEnunciado.Text;
            List<string> alternativas = listaRespostas.Items.Cast<string>().ToList();
            string respostaCorreta = listaRespostas.CheckedItems.Cast<string>().FirstOrDefault();
            Materia materia = cmbBoxMateria.SelectedItem as Materia;

            if (materia == null)
            {
                MessageBox.Show("Selecione uma matéria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (alternativas.Count < 2)
            {
                MessageBox.Show("Devem ser fornecidas pelo menos duas alternativas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(respostaCorreta))
            {
                MessageBox.Show("Selecione a resposta correta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            questao = new Questao(enunciado, alternativas, respostaCorreta, materia);

            if (questao == null)
            {
                MessageBox.Show("Erro ao criar a questão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
