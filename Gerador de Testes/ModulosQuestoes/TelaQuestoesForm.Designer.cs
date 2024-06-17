namespace Gerador_de_Testes.ModulosQuestoes
{
    partial class TelaQuestoesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEnunciado = new TextBox();
            txtResposta = new TextBox();
            txtMaterias = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            listaRespostas = new CheckedListBox();
            btnRemover = new Button();
            btnAdicionar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(40, 71);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Matéria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(22, 137);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Enunciado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(31, 216);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Resposta:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(109, 109);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(314, 83);
            txtEnunciado.TabIndex = 2;
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(109, 213);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(196, 23);
            txtResposta.TabIndex = 3;
            // 
            // txtMaterias
            // 
            txtMaterias.FormattingEnabled = true;
            txtMaterias.Location = new Point(109, 68);
            txtMaterias.Name = "txtMaterias";
            txtMaterias.Size = new Size(121, 23);
            txtMaterias.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(207, 487);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 50);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(323, 487);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 50);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(listaRespostas);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(53, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas:";
            // 
            // listaRespostas
            // 
            listaRespostas.FormattingEnabled = true;
            listaRespostas.Location = new Point(6, 58);
            listaRespostas.Name = "listaRespostas";
            listaRespostas.Size = new Size(144, 114);
            listaRespostas.TabIndex = 6;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(6, 26);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(144, 23);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(311, 212);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // TelaQuestoesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 569);
            Controls.Add(btnAdicionar);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtMaterias);
            Controls.Add(txtResposta);
            Controls.Add(txtEnunciado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestoesForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Questões";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEnunciado;
        private TextBox txtResposta;
        private ComboBox txtMaterias;
        private Button btnGravar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private Button btnRemover;
        private CheckedListBox listaRespostas;
        private Button btnAdicionar;
    }
}