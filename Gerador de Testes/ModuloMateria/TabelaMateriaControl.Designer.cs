namespace Gerador_de_Testes.ModuloMateria
{
    partial class TabelaMateriaControl
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
            dataGridMateria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridMateria).BeginInit();
            SuspendLayout();
            // 
            // dataGridMateria
            // 
            dataGridMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMateria.Location = new Point(73, 31);
            dataGridMateria.Name = "dataGridMateria";
            dataGridMateria.Size = new Size(240, 150);
            dataGridMateria.TabIndex = 0;
            // 
            // TabelaMateriaUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridMateria);
            Name = "TabelaMateriaUserControl";
            Size = new Size(411, 264);
            ((System.ComponentModel.ISupportInitialize)dataGridMateria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridMateria;
    }
}
