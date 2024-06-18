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
    public partial class TelaDisciplinaForm : Form
    {
        private Disciplina disciplina;
        public Disciplina Disciplina
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtDisciplina.Text = value.Nome;
            }

            get => disciplina;
        }

        public TelaDisciplinaForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtDisciplina.Text;

            disciplina = new Disciplina(nome);

            List<string> erros = disciplina.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                MessageBox.Show(
                    "Não é possível gravar um objeto com erros, cheque o rodapé para mais informações",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                
                DialogResult = DialogResult.None;

            }
        }
    }
}
