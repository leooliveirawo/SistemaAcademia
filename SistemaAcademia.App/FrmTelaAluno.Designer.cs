namespace SistemaAcademia.App
{
    partial class FrmTelaAluno
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDados = new System.Windows.Forms.TabControl();
            this.tbpDadosPessoais = new System.Windows.Forms.TabPage();
            this.btnRecarregarPlanos = new System.Windows.Forms.Button();
            this.cbbxPlano = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpLocalidade = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstadoUF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpContato = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTelefonesLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnTelefoneCancelar = new System.Windows.Forms.Button();
            this.btnTelefoneSalvar = new System.Windows.Forms.Button();
            this.chbxTelefonePossuiWhatsApp = new System.Windows.Forms.CheckBox();
            this.cbbxTelefoneTipo = new System.Windows.Forms.ComboBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.dgvTelefones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefoneNumero = new System.Windows.Forms.TextBox();
            this.txtTelefoneDDD = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.planosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tbDados.SuspendLayout();
            this.tbpDadosPessoais.SuspendLayout();
            this.tbpLocalidade.SuspendLayout();
            this.tbpContato.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(713, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
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
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbDados);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 382);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do aluno";
            // 
            // tbDados
            // 
            this.tbDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDados.Controls.Add(this.tbpDadosPessoais);
            this.tbDados.Controls.Add(this.tbpLocalidade);
            this.tbDados.Controls.Add(this.tbpContato);
            this.tbDados.Location = new System.Drawing.Point(6, 22);
            this.tbDados.Name = "tbDados";
            this.tbDados.SelectedIndex = 0;
            this.tbDados.Size = new System.Drawing.Size(764, 354);
            this.tbDados.TabIndex = 7;
            this.tbDados.SelectedIndexChanged += new System.EventHandler(this.tbDados_SelectedIndexChanged);
            // 
            // tbpDadosPessoais
            // 
            this.tbpDadosPessoais.Controls.Add(this.btnRecarregarPlanos);
            this.tbpDadosPessoais.Controls.Add(this.cbbxPlano);
            this.tbpDadosPessoais.Controls.Add(this.label4);
            this.tbpDadosPessoais.Controls.Add(this.label3);
            this.tbpDadosPessoais.Controls.Add(this.txtCPF);
            this.tbpDadosPessoais.Controls.Add(this.txtNomeCompleto);
            this.tbpDadosPessoais.Controls.Add(this.label2);
            this.tbpDadosPessoais.Location = new System.Drawing.Point(4, 24);
            this.tbpDadosPessoais.Name = "tbpDadosPessoais";
            this.tbpDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDadosPessoais.Size = new System.Drawing.Size(756, 326);
            this.tbpDadosPessoais.TabIndex = 0;
            this.tbpDadosPessoais.Text = "Dados pessoais";
            this.tbpDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // btnRecarregarPlanos
            // 
            this.btnRecarregarPlanos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecarregarPlanos.Location = new System.Drawing.Point(247, 65);
            this.btnRecarregarPlanos.Name = "btnRecarregarPlanos";
            this.btnRecarregarPlanos.Size = new System.Drawing.Size(75, 23);
            this.btnRecarregarPlanos.TabIndex = 21;
            this.btnRecarregarPlanos.Text = "Recarregar";
            this.btnRecarregarPlanos.UseVisualStyleBackColor = true;
            this.btnRecarregarPlanos.Click += new System.EventHandler(this.btnRecarregarPlanos_Click);
            // 
            // cbbxPlano
            // 
            this.cbbxPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxPlano.FormattingEnabled = true;
            this.cbbxPlano.Location = new System.Drawing.Point(6, 65);
            this.cbbxPlano.Name = "cbbxPlano";
            this.cbbxPlano.Size = new System.Drawing.Size(235, 23);
            this.cbbxPlano.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Plano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.Location = new System.Drawing.Point(540, 21);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(210, 23);
            this.txtCPF.TabIndex = 18;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCompleto.Location = new System.Drawing.Point(6, 21);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(528, 23);
            this.txtNomeCompleto.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome completo";
            // 
            // tbpLocalidade
            // 
            this.tbpLocalidade.Controls.Add(this.label9);
            this.tbpLocalidade.Controls.Add(this.txtEstadoUF);
            this.tbpLocalidade.Controls.Add(this.txtCidade);
            this.tbpLocalidade.Controls.Add(this.txtBairro);
            this.tbpLocalidade.Controls.Add(this.txtCEP);
            this.tbpLocalidade.Controls.Add(this.txtComplemento);
            this.tbpLocalidade.Controls.Add(this.txtLogradouro);
            this.tbpLocalidade.Controls.Add(this.label8);
            this.tbpLocalidade.Controls.Add(this.label7);
            this.tbpLocalidade.Controls.Add(this.label6);
            this.tbpLocalidade.Controls.Add(this.label5);
            this.tbpLocalidade.Controls.Add(this.label1);
            this.tbpLocalidade.Location = new System.Drawing.Point(4, 24);
            this.tbpLocalidade.Name = "tbpLocalidade";
            this.tbpLocalidade.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLocalidade.Size = new System.Drawing.Size(756, 326);
            this.tbpLocalidade.TabIndex = 1;
            this.tbpLocalidade.Text = "Localidade";
            this.tbpLocalidade.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(540, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Estado (UF)";
            // 
            // txtEstadoUF
            // 
            this.txtEstadoUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstadoUF.Location = new System.Drawing.Point(540, 153);
            this.txtEstadoUF.Name = "txtEstadoUF";
            this.txtEstadoUF.Size = new System.Drawing.Size(127, 23);
            this.txtEstadoUF.TabIndex = 28;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(6, 153);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(528, 23);
            this.txtCidade.TabIndex = 26;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(6, 109);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(528, 23);
            this.txtBairro.TabIndex = 24;
            // 
            // txtCEP
            // 
            this.txtCEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCEP.Location = new System.Drawing.Point(540, 65);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(127, 23);
            this.txtCEP.TabIndex = 22;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Location = new System.Drawing.Point(6, 65);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(528, 23);
            this.txtComplemento.TabIndex = 20;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Location = new System.Drawing.Point(6, 21);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(528, 23);
            this.txtLogradouro.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Complemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Logradouro";
            // 
            // tbpContato
            // 
            this.tbpContato.Controls.Add(this.groupBox2);
            this.tbpContato.Location = new System.Drawing.Point(4, 24);
            this.tbpContato.Name = "tbpContato";
            this.tbpContato.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContato.Size = new System.Drawing.Size(756, 326);
            this.tbpContato.TabIndex = 4;
            this.tbpContato.Text = "Contato";
            this.tbpContato.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnTelefonesLimpar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnTelefoneCancelar);
            this.groupBox2.Controls.Add(this.btnTelefoneSalvar);
            this.groupBox2.Controls.Add(this.chbxTelefonePossuiWhatsApp);
            this.groupBox2.Controls.Add(this.cbbxTelefoneTipo);
            this.groupBox2.Controls.Add(this.Tipo);
            this.groupBox2.Controls.Add(this.dgvTelefones);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTelefoneNumero);
            this.groupBox2.Controls.Add(this.txtTelefoneDDD);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 324);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telefones";
            // 
            // btnTelefonesLimpar
            // 
            this.btnTelefonesLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTelefonesLimpar.Location = new System.Drawing.Point(663, 66);
            this.btnTelefonesLimpar.Name = "btnTelefonesLimpar";
            this.btnTelefonesLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnTelefonesLimpar.TabIndex = 29;
            this.btnTelefonesLimpar.Text = "Limpar";
            this.btnTelefonesLimpar.UseVisualStyleBackColor = true;
            this.btnTelefonesLimpar.Click += new System.EventHandler(this.btnTelefonesLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(420, 66);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnTelefoneCancelar
            // 
            this.btnTelefoneCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTelefoneCancelar.Location = new System.Drawing.Point(582, 66);
            this.btnTelefoneCancelar.Name = "btnTelefoneCancelar";
            this.btnTelefoneCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnTelefoneCancelar.TabIndex = 27;
            this.btnTelefoneCancelar.Text = "Cancelar";
            this.btnTelefoneCancelar.UseVisualStyleBackColor = true;
            this.btnTelefoneCancelar.Click += new System.EventHandler(this.btnTelefoneCancelar_Click);
            // 
            // btnTelefoneSalvar
            // 
            this.btnTelefoneSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTelefoneSalvar.Location = new System.Drawing.Point(501, 66);
            this.btnTelefoneSalvar.Name = "btnTelefoneSalvar";
            this.btnTelefoneSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnTelefoneSalvar.TabIndex = 26;
            this.btnTelefoneSalvar.Text = "Salvar";
            this.btnTelefoneSalvar.UseVisualStyleBackColor = true;
            this.btnTelefoneSalvar.Click += new System.EventHandler(this.btnTelefoneSalvar_Click);
            // 
            // chbxTelefonePossuiWhatsApp
            // 
            this.chbxTelefonePossuiWhatsApp.AutoSize = true;
            this.chbxTelefonePossuiWhatsApp.Location = new System.Drawing.Point(355, 39);
            this.chbxTelefonePossuiWhatsApp.Name = "chbxTelefonePossuiWhatsApp";
            this.chbxTelefonePossuiWhatsApp.Size = new System.Drawing.Size(118, 19);
            this.chbxTelefonePossuiWhatsApp.TabIndex = 25;
            this.chbxTelefonePossuiWhatsApp.Text = "Possuí WhatsApp";
            this.chbxTelefonePossuiWhatsApp.UseVisualStyleBackColor = true;
            // 
            // cbbxTelefoneTipo
            // 
            this.cbbxTelefoneTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxTelefoneTipo.FormattingEnabled = true;
            this.cbbxTelefoneTipo.Items.AddRange(new object[] {
            "Telefone pessoal",
            "Telefone comercial"});
            this.cbbxTelefoneTipo.Location = new System.Drawing.Point(228, 37);
            this.cbbxTelefoneTipo.Name = "cbbxTelefoneTipo";
            this.cbbxTelefoneTipo.Size = new System.Drawing.Size(121, 23);
            this.cbbxTelefoneTipo.TabIndex = 24;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(228, 19);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(30, 15);
            this.Tipo.TabIndex = 23;
            this.Tipo.Text = "Tipo";
            // 
            // dgvTelefones
            // 
            this.dgvTelefones.AllowUserToAddRows = false;
            this.dgvTelefones.AllowUserToDeleteRows = false;
            this.dgvTelefones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTelefones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTelefones.ColumnHeadersHeight = 45;
            this.dgvTelefones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTelefones.Location = new System.Drawing.Point(6, 95);
            this.dgvTelefones.MultiSelect = false;
            this.dgvTelefones.Name = "dgvTelefones";
            this.dgvTelefones.ReadOnly = true;
            this.dgvTelefones.RowHeadersVisible = false;
            this.dgvTelefones.RowTemplate.Height = 35;
            this.dgvTelefones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefones.Size = new System.Drawing.Size(732, 223);
            this.dgvTelefones.TabIndex = 6;
            this.dgvTelefones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefones_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DDD";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Número";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Número";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "DDD";
            // 
            // txtTelefoneNumero
            // 
            this.txtTelefoneNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefoneNumero.Location = new System.Drawing.Point(117, 37);
            this.txtTelefoneNumero.Name = "txtTelefoneNumero";
            this.txtTelefoneNumero.Size = new System.Drawing.Size(105, 23);
            this.txtTelefoneNumero.TabIndex = 22;
            // 
            // txtTelefoneDDD
            // 
            this.txtTelefoneDDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefoneDDD.Location = new System.Drawing.Point(6, 37);
            this.txtTelefoneDDD.Name = "txtTelefoneDDD";
            this.txtTelefoneDDD.Size = new System.Drawing.Size(105, 23);
            this.txtTelefoneDDD.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planosToolStripMenuItem,
            this.treinosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // planosToolStripMenuItem
            // 
            this.planosToolStripMenuItem.Name = "planosToolStripMenuItem";
            this.planosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.planosToolStripMenuItem.Text = "Planos";
            this.planosToolStripMenuItem.Click += new System.EventHandler(this.planosToolStripMenuItem_Click);
            // 
            // treinosToolStripMenuItem
            // 
            this.treinosToolStripMenuItem.Name = "treinosToolStripMenuItem";
            this.treinosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.treinosToolStripMenuItem.Text = "Treinos";
            this.treinosToolStripMenuItem.Click += new System.EventHandler(this.treinosToolStripMenuItem_Click);
            // 
            // FrmTelaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTelaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.FrmTelaAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.tbDados.ResumeLayout(false);
            this.tbpDadosPessoais.ResumeLayout(false);
            this.tbpDadosPessoais.PerformLayout();
            this.tbpLocalidade.ResumeLayout(false);
            this.tbpLocalidade.PerformLayout();
            this.tbpContato.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem planosToolStripMenuItem;
        private TabControl tbDados;
        private TabPage tbpDadosPessoais;
        private Button btnRecarregarPlanos;
        private ComboBox cbbxPlano;
        private Label label4;
        private Label label3;
        private TextBox txtCPF;
        private TextBox txtNomeCompleto;
        private Label label2;
        private TabPage tbpLocalidade;
        private Label label9;
        private TextBox txtEstadoUF;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtCEP;
        private TextBox txtComplemento;
        private TextBox txtLogradouro;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private TabPage tbpContato;
        private GroupBox groupBox2;
        private Button btnTelefonesLimpar;
        private Button btnExcluir;
        private Button btnTelefoneCancelar;
        private Button btnTelefoneSalvar;
        private CheckBox chbxTelefonePossuiWhatsApp;
        private ComboBox cbbxTelefoneTipo;
        private Label Tipo;
        private DataGridView dgvTelefones;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label11;
        private Label label10;
        private TextBox txtTelefoneNumero;
        private TextBox txtTelefoneDDD;
        private ToolStripMenuItem treinosToolStripMenuItem;
    }
}