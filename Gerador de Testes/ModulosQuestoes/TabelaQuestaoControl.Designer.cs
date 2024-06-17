namespace Gerador_de_Testes.ModulosQuestoes
{
    partial class TabelaQuestaoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridQuestoes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridQuestoes).BeginInit();
            SuspendLayout();
            // 
            // dataGridQuestoes
            // 
            dataGridQuestoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridQuestoes.Dock = DockStyle.Fill;
            dataGridQuestoes.Location = new Point(0, 0);
            dataGridQuestoes.Name = "dataGridQuestoes";
            dataGridQuestoes.Size = new Size(390, 237);
            dataGridQuestoes.TabIndex = 0;
            // 
            // TabelaQuestaoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridQuestoes);
            Name = "TabelaQuestaoControl";
            Size = new Size(390, 237);
            ((System.ComponentModel.ISupportInitialize)dataGridQuestoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridQuestoes;
    }
}
