namespace SistemaAcademia.App
{
    partial class FrmTelaPlanos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbxCobradoMensalmente = new System.Windows.Forms.CheckBox();
            this.lbMesesMaximoParcelamento = new System.Windows.Forms.Label();
            this.nmMesesCobrados = new System.Windows.Forms.NumericUpDown();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmNumeroDias = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvPlanos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMesesCobrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumeroDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chbxCobradoMensalmente);
            this.groupBox1.Controls.Add(this.lbMesesMaximoParcelamento);
            this.groupBox1.Controls.Add(this.nmMesesCobrados);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmNumeroDias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do plano";
            // 
            // chbxCobradoMensalmente
            // 
            this.chbxCobradoMensalmente.AutoSize = true;
            this.chbxCobradoMensalmente.Location = new System.Drawing.Point(268, 83);
            this.chbxCobradoMensalmente.Name = "chbxCobradoMensalmente";
            this.chbxCobradoMensalmente.Size = new System.Drawing.Size(147, 19);
            this.chbxCobradoMensalmente.TabIndex = 11;
            this.chbxCobradoMensalmente.Text = "Cobrado mensalmente";
            this.chbxCobradoMensalmente.UseVisualStyleBackColor = true;
            this.chbxCobradoMensalmente.CheckedChanged += new System.EventHandler(this.chbxCobradoMensalmente_CheckedChanged);
            // 
            // lbMesesMaximoParcelamento
            // 
            this.lbMesesMaximoParcelamento.AutoSize = true;
            this.lbMesesMaximoParcelamento.Location = new System.Drawing.Point(421, 63);
            this.lbMesesMaximoParcelamento.Name = "lbMesesMaximoParcelamento";
            this.lbMesesMaximoParcelamento.Size = new System.Drawing.Size(91, 15);
            this.lbMesesMaximoParcelamento.TabIndex = 13;
            this.lbMesesMaximoParcelamento.Text = "Meses cobradas";
            this.lbMesesMaximoParcelamento.Visible = false;
            // 
            // nmMesesCobrados
            // 
            this.nmMesesCobrados.Location = new System.Drawing.Point(421, 81);
            this.nmMesesCobrados.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMesesCobrados.Name = "nmMesesCobrados";
            this.nmMesesCobrados.Size = new System.Drawing.Size(120, 23);
            this.nmMesesCobrados.TabIndex = 12;
            this.nmMesesCobrados.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMesesCobrados.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(132, 81);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(130, 23);
            this.txtValor.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor (R$)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nº de dias";
            // 
            // nmNumeroDias
            // 
            this.nmNumeroDias.Location = new System.Drawing.Point(6, 81);
            this.nmNumeroDias.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nmNumeroDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNumeroDias.Name = "nmNumeroDias";
            this.nmNumeroDias.Size = new System.Drawing.Size(120, 23);
            this.nmNumeroDias.TabIndex = 7;
            this.nmNumeroDias.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(6, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(764, 23);
            this.txtDescricao.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(632, 142);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(551, 142);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(713, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvPlanos
            // 
            this.dgvPlanos.AllowUserToAddRows = false;
            this.dgvPlanos.AllowUserToDeleteRows = false;
            this.dgvPlanos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanos.ColumnHeadersHeight = 45;
            this.dgvPlanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPlanos.Location = new System.Drawing.Point(12, 171);
            this.dgvPlanos.MultiSelect = false;
            this.dgvPlanos.Name = "dgvPlanos";
            this.dgvPlanos.ReadOnly = true;
            this.dgvPlanos.RowHeadersVisible = false;
            this.dgvPlanos.RowTemplate.Height = 35;
            this.dgvPlanos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanos.Size = new System.Drawing.Size(776, 267);
            this.dgvPlanos.TabIndex = 4;
            this.dgvPlanos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanos_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle1.Format = "C2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Valor (R$)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmTelaPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPlanos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "FrmTelaPlanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planos";
            this.Load += new System.EventHandler(this.FrmTelaPlanos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMesesCobrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumeroDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lbMesesMaximoParcelamento;
        private NumericUpDown nmMesesCobrados;
        private TextBox txtValor;
        private Label label3;
        private Label label2;
        private NumericUpDown nmNumeroDias;
        private Label label1;
        private TextBox txtDescricao;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private DataGridView dgvPlanos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private CheckBox chbxCobradoMensalmente;
    }
}