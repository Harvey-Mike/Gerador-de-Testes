namespace Gerador_de_Testes.ModuloTestes
{
    partial class TelaTesteForm
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
            label4 = new Label();
            checkBoxRecuperacao = new CheckBox();
            groupBox1 = new GroupBox();
            listBoxQuestoes = new ListBox();
            btnSortear = new Button();
            cmbBoxMateria = new ComboBox();
            cmbBoxDisciplina = new ComboBox();
            txtTitulo = new TextBox();
            numericUpDown1 = new NumericUpDown();
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(55, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(28, 76);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(42, 115);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Matéria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(338, 76);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "Qtd. Questões:";
            // 
            // checkBoxRecuperacao
            // 
            checkBoxRecuperacao.AutoSize = true;
            checkBoxRecuperacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxRecuperacao.Location = new Point(322, 111);
            checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            checkBoxRecuperacao.Size = new Size(176, 24);
            checkBoxRecuperacao.TabIndex = 5;
            checkBoxRecuperacao.Text = "Prova de Recuperação";
            checkBoxRecuperacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxQuestoes);
            groupBox1.Controls.Add(btnSortear);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 332);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listBoxQuestoes
            // 
            listBoxQuestoes.FormattingEnabled = true;
            listBoxQuestoes.ItemHeight = 20;
            listBoxQuestoes.Location = new Point(6, 83);
            listBoxQuestoes.Name = "listBoxQuestoes";
            listBoxQuestoes.Size = new Size(458, 244);
            listBoxQuestoes.TabIndex = 1;
            // 
            // btnSortear
            // 
            btnSortear.Location = new Point(27, 41);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(170, 36);
            btnSortear.TabIndex = 6;
            btnSortear.Text = "Sortear Questões ";
            btnSortear.UseVisualStyleBackColor = true;
            // 
            // cmbBoxMateria
            // 
            cmbBoxMateria.FormattingEnabled = true;
            cmbBoxMateria.Location = new Point(111, 112);
            cmbBoxMateria.Name = "cmbBoxMateria";
            cmbBoxMateria.Size = new Size(191, 23);
            cmbBoxMateria.TabIndex = 3;
            // 
            // cmbBoxDisciplina
            // 
            cmbBoxDisciplina.FormattingEnabled = true;
            cmbBoxDisciplina.Location = new Point(111, 73);
            cmbBoxDisciplina.Name = "cmbBoxDisciplina";
            cmbBoxDisciplina.Size = new Size(191, 23);
            cmbBoxDisciplina.TabIndex = 2;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(111, 41);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(387, 23);
            txtTitulo.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(449, 73);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(307, 528);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(96, 46);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(409, 528);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 46);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 585);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(numericUpDown1);
            Controls.Add(txtTitulo);
            Controls.Add(cmbBoxDisciplina);
            Controls.Add(cmbBoxMateria);
            Controls.Add(groupBox1);
            Controls.Add(checkBoxRecuperacao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTesteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Testes";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBoxRecuperacao;
        private GroupBox groupBox1;
        private ComboBox cmbBoxMateria;
        private ComboBox cmbBoxDisciplina;
        private TextBox txtTitulo;
        private NumericUpDown numericUpDown1;
        private Button btnSortear;
        private ListBox listBoxQuestoes;
        private Button btnGravar;
        private Button btnCancelar;
    }
}