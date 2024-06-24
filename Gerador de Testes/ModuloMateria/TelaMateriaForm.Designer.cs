namespace Gerador_de_Testes.ModuloMateria
{
    partial class TelaMateriaForm
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
            txtId = new TextBox();
            txtNomeMateria = new TextBox();
            cmbBoxDisciplina = new ComboBox();
            rdbPrimeiraSerie = new RadioButton();
            rdbSegundaSerie = new RadioButton();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(122, 57);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(18, 89);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome da Matéria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(70, 124);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Disciplina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(102, 156);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Série:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(158, 54);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(53, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNomeMateria
            // 
            txtNomeMateria.Location = new Point(158, 86);
            txtNomeMateria.Name = "txtNomeMateria";
            txtNomeMateria.Size = new Size(386, 23);
            txtNomeMateria.TabIndex = 2;
            // 
            // cmbBoxDisciplina
            // 
            cmbBoxDisciplina.FormattingEnabled = true;
            cmbBoxDisciplina.Location = new Point(158, 121);
            cmbBoxDisciplina.Name = "cmbBoxDisciplina";
            cmbBoxDisciplina.Size = new Size(131, 23);
            cmbBoxDisciplina.TabIndex = 3;
            // 
            // rdbPrimeiraSerie
            // 
            rdbPrimeiraSerie.AutoSize = true;
            rdbPrimeiraSerie.Font = new Font("Segoe UI", 11.25F);
            rdbPrimeiraSerie.Location = new Point(158, 152);
            rdbPrimeiraSerie.Name = "rdbPrimeiraSerie";
            rdbPrimeiraSerie.Size = new Size(45, 24);
            rdbPrimeiraSerie.TabIndex = 4;
            rdbPrimeiraSerie.TabStop = true;
            rdbPrimeiraSerie.Text = " 1ª";
            rdbPrimeiraSerie.UseVisualStyleBackColor = true;
            // 
            // rdbSegundaSerie
            // 
            rdbSegundaSerie.AutoSize = true;
            rdbSegundaSerie.Font = new Font("Segoe UI", 11.25F);
            rdbSegundaSerie.Location = new Point(248, 152);
            rdbSegundaSerie.Name = "rdbSegundaSerie";
            rdbSegundaSerie.Size = new Size(41, 24);
            rdbSegundaSerie.TabIndex = 5;
            rdbSegundaSerie.TabStop = true;
            rdbSegundaSerie.Text = "2ª";
            rdbSegundaSerie.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(364, 257);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(98, 42);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(468, 257);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 42);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 311);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(rdbSegundaSerie);
            Controls.Add(rdbPrimeiraSerie);
            Controls.Add(cmbBoxDisciplina);
            Controls.Add(txtNomeMateria);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMateriaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Materias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNomeMateria;
        public ComboBox cmbBoxDisciplina;
        private RadioButton rdbPrimeiraSerie;
        private RadioButton rdbSegundaSerie;
        private Button btnGravar;
        private Button btnCancelar;
    }
}