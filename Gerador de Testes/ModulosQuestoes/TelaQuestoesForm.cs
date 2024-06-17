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


        public TelaQuestoesForm()
        {
            InitializeComponent();
        }


        //private void btnGravar_Click(object sender, EventArgs e)
        //{
        //    // Lógica para salvar a questão
        //    TextBox txtEnunciado = (TextBox)this.Controls["txtEnunciado"];
        //    string enunciado = txtEnunciado.Text;

        //    if (string.IsNullOrWhiteSpace(enunciado))
        //    {
        //        MessageBox.Show("O enunciado é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    Questao = new Questao(null, enunciado);
        //    this.DialogResult = DialogResult.OK;
        //    this.Close();
        //}

        
    }
}