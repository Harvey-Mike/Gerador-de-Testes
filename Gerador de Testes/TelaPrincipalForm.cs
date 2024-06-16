using Gerador_de_Testes.ModuloDisciplina;

namespace Gerador_de_Testes
{
    public partial class TelaPrincipalForm : Form
    {
        private TabelaDisciplinaControl tabelaDisciplinaControl;
        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            Instancia = this;
            InitializeComponent();
            tabelaDisciplinaControl = new TabelaDisciplinaControl();
            tabelaDisciplinaControl.Dock = DockStyle.Fill;
            this.Controls.Add(tabelaDisciplinaControl);
        }

        public void AtualizarRodape(string mensagem)
        {
            // Implementa��o para atualizar o rodap� com a mensagem fornecida
            // Voc� pode adicionar um StatusStrip ou similar ao formul�rio e definir sua mensagem
        }
    }
}
