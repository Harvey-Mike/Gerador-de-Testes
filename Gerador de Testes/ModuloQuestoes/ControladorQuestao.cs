using Gerador_de_Testes.Compartilhado;
using Gerador_de_Testes.ModuloTestes;
using Gerador_de_Testes.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerador_de_Testes.ModuloDisciplina;

namespace Gerador_de_Testes.ModulosQuestoes
{
    public class ControladorQuestao : ControladorBase
    {
        private TabelaQuestaoControl tabelaQuestao;
        private IRepositorioQuestao repositorioQuestao;
        private IRepositorioTeste repositorioTeste;
        private IRepositorioMateria repositorioMateria;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioTeste repositorioTeste, IRepositorioMateria repositorioMateria)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioTeste = repositorioTeste;
            this.repositorioMateria = repositorioMateria;
        }

        public override string TipoCadastro { get { return "Questões"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova questão"; } }

        public override string ToolTipEditar { get { return "Editar uma questão existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma questão existente"; } }

        public override void Adicionar()
        {
            TelaQuestoesForm telaQuestoes = new TelaQuestoesForm();

            PreencherComboBox(telaQuestoes);

            DialogResult resultado = telaQuestoes.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questao novaQuestao = telaQuestoes.Questao;

            repositorioQuestao.Cadastrar(novaQuestao);

            CarregarQuestoes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novaQuestao.Enunciado}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem selecionar algo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TelaQuestoesForm telaQuestoes = new TelaQuestoesForm();

            PreencherComboBox(telaQuestoes);

            telaQuestoes.Questao = questaoSelecionada;

            DialogResult resultado = telaQuestoes.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questao questaoEditada = telaQuestoes.Questao;

            repositorioQuestao.Editar(idSelecionado, questaoEditada);

            CarregarQuestoes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{questaoEditada.Enunciado}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool questaoEmUso = repositorioTeste.SelecionarTodos().Any(teste => teste.Questoes.Contains(questaoSelecionada));
            if (questaoEmUso)
            {
                MessageBox.Show("Não é possível excluir uma questão que está relacionada a um teste.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{questaoSelecionada.Enunciado}\"?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioQuestao.Excluir(questaoSelecionada.Id);

            CarregarQuestoes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{questaoSelecionada.Enunciado}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestao == null)
                tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();
            return tabelaQuestao;
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();
            tabelaQuestao.AtualizarRegistros(questoes);
        }
        public List<Materia> SelecionarMateria()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            return materias;
        }
        private void PreencherComboBox(TelaQuestoesForm telaQuestoes)
        {
            List<Materia> materias = SelecionarMateria();

            foreach (Materia materia in materias)
            {
                telaQuestoes.cmbBoxMateria.Items.Add(materia.Nome);
            }
        }
    }
}

