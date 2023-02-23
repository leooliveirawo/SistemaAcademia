namespace SistemaAcademia.App
{
    partial class FrmTelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirTreinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.treinosToolStripMenuItem,
            this.pagamentosToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // treinosToolStripMenuItem
            // 
            this.treinosToolStripMenuItem.Name = "treinosToolStripMenuItem";
            this.treinosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.treinosToolStripMenuItem.Text = "Treinos";
            this.treinosToolStripMenuItem.Click += new System.EventHandler(this.treinosToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planosToolStripMenuItem,
            this.exerciciosToolStripMenuItem,
            this.formasDePagamentosToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimirTreinoToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // planosToolStripMenuItem
            // 
            this.planosToolStripMenuItem.Name = "planosToolStripMenuItem";
            this.planosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.planosToolStripMenuItem.Text = "Planos";
            this.planosToolStripMenuItem.Click += new System.EventHandler(this.planosToolStripMenuItem_Click);
            // 
            // exerciciosToolStripMenuItem
            // 
            this.exerciciosToolStripMenuItem.Name = "exerciciosToolStripMenuItem";
            this.exerciciosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exerciciosToolStripMenuItem.Text = "Exercicios";
            this.exerciciosToolStripMenuItem.Click += new System.EventHandler(this.exerciciosToolStripMenuItem_Click);
            // 
            // formasDePagamentosToolStripMenuItem
            // 
            this.formasDePagamentosToolStripMenuItem.Name = "formasDePagamentosToolStripMenuItem";
            this.formasDePagamentosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.formasDePagamentosToolStripMenuItem.Text = "Formas de pagamentos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // imprimirTreinoToolStripMenuItem
            // 
            this.imprimirTreinoToolStripMenuItem.Name = "imprimirTreinoToolStripMenuItem";
            this.imprimirTreinoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.imprimirTreinoToolStripMenuItem.Text = "Imprimir treino";
            this.imprimirTreinoToolStripMenuItem.Click += new System.EventHandler(this.imprimirTreinoToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            this.pagamentosToolStripMenuItem.Click += new System.EventHandler(this.pagamentosToolStripMenuItem_Click);
            // 
            // FrmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem treinosToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem planosToolStripMenuItem;
        private ToolStripMenuItem exerciciosToolStripMenuItem;
        private ToolStripMenuItem formasDePagamentosToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imprimirTreinoToolStripMenuItem;
        private ToolStripMenuItem pagamentosToolStripMenuItem;
    }
}