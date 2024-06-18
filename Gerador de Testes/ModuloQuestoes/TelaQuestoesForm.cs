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
    public partial class TelaQuestoesForm : Form
    {

        public Questao Questao { get; set; }

        private string[] alternativaas;

        int contador = 0;
        public TelaQuestoesForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Lógica para salvar a questão
            TextBox txtEnunciado = (TextBox)this.Controls["txtEnunciado"];
            string enunciado = txtEnunciado.Text;

            if (string.IsNullOrWhiteSpace(enunciado))
            {
                MessageBox.Show("O enunciado é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Questao = new Questao(null, enunciado);

            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            listaRespostas.Items.Add(txtResposta.Text);
            //alternativaas[contador] = txtResposta.Text;
            //contador++;

            txtResposta.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            listaRespostas.Items.Remove(listaRespostas.SelectedItem);
        }

    }
}