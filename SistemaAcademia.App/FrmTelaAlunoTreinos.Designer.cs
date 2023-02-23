namespace SistemaAcademia.App
{
    partial class FrmTelaAlunoTreinos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbbxTreino = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nmExercicioRepeticoes = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nmExercicioSeries = new System.Windows.Forms.NumericUpDown();
            this.chbxTreinoAtivo = new System.Windows.Forms.CheckBox();
            this.btnExerciciosLimpar = new System.Windows.Forms.Button();
            this.btnExercicioIncluir = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvExercicios = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbxExercicio = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTreinoTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imprimirTreinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmExercicioRepeticoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmExercicioSeries)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercicios)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treino do aluno";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.cbbxTreino);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(764, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Treinos";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(240, 36);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbbxTreino
            // 
            this.cbbxTreino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxTreino.FormattingEnabled = true;
            this.cbbxTreino.Location = new System.Drawing.Point(6, 37);
            this.cbbxTreino.Name = "cbbxTreino";
            this.cbbxTreino.Size = new System.Drawing.Size(227, 23);
            this.cbbxTreino.TabIndex = 1;
            this.cbbxTreino.SelectedIndexChanged += new System.EventHandler(this.cbbxTreino_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Treino";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.nmExercicioRepeticoes);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.nmExercicioSeries);
            this.groupBox4.Controls.Add(this.chbxTreinoAtivo);
            this.groupBox4.Controls.Add(this.btnExerciciosLimpar);
            this.groupBox4.Controls.Add(this.btnExercicioIncluir);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.cbbxExercicio);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtTreinoTipo);
            this.groupBox4.Location = new System.Drawing.Point(6, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(764, 214);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Treino";
            // 
            // nmExercicioRepeticoes
            // 
            this.nmExercicioRepeticoes.Location = new System.Drawing.Point(86, 110);
            this.nmExercicioRepeticoes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmExercicioRepeticoes.Name = "nmExercicioRepeticoes";
            this.nmExercicioRepeticoes.Size = new System.Drawing.Size(55, 23);
            this.nmExercicioRepeticoes.TabIndex = 31;
            this.nmExercicioRepeticoes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(67, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "x";
            // 
            // nmExercicioSeries
            // 
            this.nmExercicioSeries.Location = new System.Drawing.Point(6, 110);
            this.nmExercicioSeries.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmExercicioSeries.Name = "nmExercicioSeries";
            this.nmExercicioSeries.Size = new System.Drawing.Size(55, 23);
            this.nmExercicioSeries.TabIndex = 29;
            this.nmExercicioSeries.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // chbxTreinoAtivo
            // 
            this.chbxTreinoAtivo.AutoSize = true;
            this.chbxTreinoAtivo.Location = new System.Drawing.Point(179, 111);
            this.chbxTreinoAtivo.Name = "chbxTreinoAtivo";
            this.chbxTreinoAtivo.Size = new System.Drawing.Size(54, 19);
            this.chbxTreinoAtivo.TabIndex = 28;
            this.chbxTreinoAtivo.Text = "Ativo";
            this.chbxTreinoAtivo.UseVisualStyleBackColor = true;
            this.chbxTreinoAtivo.CheckedChanged += new System.EventHandler(this.chbxTreinoAtivo_CheckedChanged);
            // 
            // btnExerciciosLimpar
            // 
            this.btnExerciciosLimpar.Location = new System.Drawing.Point(159, 139);
            this.btnExerciciosLimpar.Name = "btnExerciciosLimpar";
            this.btnExerciciosLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnExerciciosLimpar.TabIndex = 27;
            this.btnExerciciosLimpar.Text = "Limpar";
            this.btnExerciciosLimpar.UseVisualStyleBackColor = true;
            this.btnExerciciosLimpar.Click += new System.EventHandler(this.btnExerciciosLimpar_Click);
            // 
            // btnExercicioIncluir
            // 
            this.btnExercicioIncluir.Location = new System.Drawing.Point(6, 139);
            this.btnExercicioIncluir.Name = "btnExercicioIncluir";
            this.btnExercicioIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnExercicioIncluir.TabIndex = 26;
            this.btnExercicioIncluir.Text = "Incluir";
            this.btnExercicioIncluir.UseVisualStyleBackColor = true;
            this.btnExercicioIncluir.Click += new System.EventHandler(this.btnExercicioIncluir_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dgvExercicios);
            this.groupBox5.Location = new System.Drawing.Point(240, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(518, 186);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exercicios";
            // 
            // dgvExercicios
            // 
            this.dgvExercicios.AllowUserToAddRows = false;
            this.dgvExercicios.AllowUserToDeleteRows = false;
            this.dgvExercicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExercicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExercicios.ColumnHeadersHeight = 45;
            this.dgvExercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dgvExercicios.Location = new System.Drawing.Point(6, 22);
            this.dgvExercicios.MultiSelect = false;
            this.dgvExercicios.Name = "dgvExercicios";
            this.dgvExercicios.ReadOnly = true;
            this.dgvExercicios.RowHeadersVisible = false;
            this.dgvExercicios.RowTemplate.Height = 35;
            this.dgvExercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExercicios.Size = new System.Drawing.Size(506, 158);
            this.dgvExercicios.TabIndex = 7;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nome";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cbbxExercicio
            // 
            this.cbbxExercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxExercicio.FormattingEnabled = true;
            this.cbbxExercicio.Location = new System.Drawing.Point(7, 81);
            this.cbbxExercicio.Name = "cbbxExercicio";
            this.cbbxExercicio.Size = new System.Drawing.Size(227, 23);
            this.cbbxExercicio.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Exercicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Tipo";
            // 
            // txtTreinoTipo
            // 
            this.txtTreinoTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTreinoTipo.Location = new System.Drawing.Point(6, 37);
            this.txtTreinoTipo.Name = "txtTreinoTipo";
            this.txtTreinoTipo.ReadOnly = true;
            this.txtTreinoTipo.Size = new System.Drawing.Size(227, 23);
            this.txtTreinoTipo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.Location = new System.Drawing.Point(546, 64);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(210, 23);
            this.txtCPF.TabIndex = 22;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCompleto.Location = new System.Drawing.Point(12, 64);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.ReadOnly = true;
            this.txtNomeCompleto.Size = new System.Drawing.Size(528, 23);
            this.txtNomeCompleto.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome completo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(713, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(632, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirTreinoToolStripMenuItem,
            this.exerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imprimirTreinoToolStripMenuItem
            // 
            this.imprimirTreinoToolStripMenuItem.Name = "imprimirTreinoToolStripMenuItem";
            this.imprimirTreinoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.imprimirTreinoToolStripMenuItem.Text = "Imprimir treino";
            this.imprimirTreinoToolStripMenuItem.Click += new System.EventHandler(this.imprimirTreinoToolStripMenuItem_Click);
            // 
            // exerciciosToolStripMenuItem
            // 
            this.exerciciosToolStripMenuItem.Name = "exerciciosToolStripMenuItem";
            this.exerciciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exerciciosToolStripMenuItem.Text = "Exercicios";
            this.exerciciosToolStripMenuItem.Click += new System.EventHandler(this.exerciciosToolStripMenuItem_Click);
            // 
            // FrmTelaAlunoTreinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTelaAlunoTreinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Treinos - Aluno";
            this.Load += new System.EventHandler(this.FrmTelaAlunoTreinos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmExercicioRepeticoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmExercicioSeries)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercicios)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnLimpar;
        private ComboBox cbbxTreino;
        private Label label12;
        private GroupBox groupBox4;
        private NumericUpDown nmExercicioRepeticoes;
        private Label label15;
        private NumericUpDown nmExercicioSeries;
        private CheckBox chbxTreinoAtivo;
        private Button btnExerciciosLimpar;
        private Button btnExercicioIncluir;
        private GroupBox groupBox5;
        private DataGridView dgvExercicios;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cbbxExercicio;
        private Label label14;
        private Label label13;
        private TextBox txtTreinoTipo;
        private Label label3;
        private TextBox txtCPF;
        private TextBox txtNomeCompleto;
        private Label label2;
        private Button btnCancelar;
        private Button btnSalvar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem imprimirTreinoToolStripMenuItem;
        private ToolStripMenuItem exerciciosToolStripMenuItem;
    }
}