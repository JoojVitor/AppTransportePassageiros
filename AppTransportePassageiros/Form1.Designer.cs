namespace Domain
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.sexoCadastroLabel = new System.Windows.Forms.Label();
            this.emailCadastroLabel = new System.Windows.Forms.Label();
            this.telefoneCadastroLabel = new System.Windows.Forms.Label();
            this.enderecoCadastroLabel = new System.Windows.Forms.Label();
            this.cpfCadastroLabel = new System.Windows.Forms.Label();
            this.nomeCadastroLabel = new System.Windows.Forms.Label();
            this.txtEmailCadastrar = new System.Windows.Forms.TextBox();
            this.txtTelefoneCadastrar = new System.Windows.Forms.TextBox();
            this.txtEnderecoCadastrar = new System.Windows.Forms.TextBox();
            this.txtCPFCadastrar = new System.Windows.Forms.TextBox();
            this.txtNomeCadastrar = new System.Windows.Forms.TextBox();
            this.masculinoRadioBtn = new System.Windows.Forms.RadioButton();
            this.femininoRadioBtn = new System.Windows.Forms.RadioButton();
            this.salvarCadastroBtn = new System.Windows.Forms.Button();
            this.tabControlCadHist = new System.Windows.Forms.TabControl();
            this.Cadastros = new System.Windows.Forms.TabPage();
            this.modalidadeLabel = new System.Windows.Forms.Label();
            this.cbModalidadeCadastros = new System.Windows.Forms.ComboBox();
            this.pesquisarCadastroBtn = new System.Windows.Forms.Button();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.excluirCadastroBtn = new System.Windows.Forms.Button();
            this.editarCadastroBtn = new System.Windows.Forms.Button();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.txtCPFCadastros = new System.Windows.Forms.TextBox();
            this.txtNomeCadastros = new System.Windows.Forms.TextBox();
            this.cadastrosGrid = new System.Windows.Forms.DataGridView();
            this.nome_CadGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_CadGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_CadGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_CadGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_CadGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_CadGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Historico = new System.Windows.Forms.TabPage();
            this.modalidadeHistLabel = new System.Windows.Forms.Label();
            this.placaHistLabel = new System.Windows.Forms.Label();
            this.cpfHistLabel = new System.Windows.Forms.Label();
            this.cbModalidadeHist = new System.Windows.Forms.ComboBox();
            this.pesquisarHistBtn = new System.Windows.Forms.Button();
            this.txtPlacaHistorico = new System.Windows.Forms.TextBox();
            this.txtCPFHistorico = new System.Windows.Forms.TextBox();
            this.dataFinalHistorico = new System.Windows.Forms.DateTimePicker();
            this.dataInicialHistorico = new System.Windows.Forms.DateTimePicker();
            this.historicoGrid = new System.Windows.Forms.DataGridView();
            this.cpfMot_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfPass_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localOrig_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDest_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFim_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdePass_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagto_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelamento_HistGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculos = new System.Windows.Forms.TabPage();
            this.txtCartaoCreditoCadastrar = new System.Windows.Forms.TextBox();
            this.txtCidadeOrigemCadastrar = new System.Windows.Forms.TextBox();
            this.cartaoCreditoCadastroLabel = new System.Windows.Forms.Label();
            this.cidadeOrigemLabel = new System.Windows.Forms.Label();
            this.txtPlacaVeiculos = new System.Windows.Forms.TextBox();
            this.txtMarcaVeiculos = new System.Windows.Forms.TextBox();
            this.txtModeloVeiculos = new System.Windows.Forms.TextBox();
            this.txtAnoVeiculos = new System.Windows.Forms.TextBox();
            this.txtCorVeiculos = new System.Windows.Forms.TextBox();
            this.txtPotenciaMotorVeiculos = new System.Windows.Forms.TextBox();
            this.placaVeiculoLabel = new System.Windows.Forms.Label();
            this.marcaVeiculoLabel = new System.Windows.Forms.Label();
            this.modeloVeiculoLabel = new System.Windows.Forms.Label();
            this.anoVeiculoLabel = new System.Windows.Forms.Label();
            this.capacidadeVeiculoLabel = new System.Windows.Forms.Label();
            this.corVeiculoLabel = new System.Windows.Forms.Label();
            this.tipoCombustivelVeiculoLabel = new System.Windows.Forms.Label();
            this.potenciaVeiculoLabel = new System.Windows.Forms.Label();
            this.cbCapacidadeVeiculos = new System.Windows.Forms.ComboBox();
            this.cbTipoCombustivelVeiculos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.placaVeiculoGridCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaVeiculoGridCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloVeiculoGridCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoVeiculoGridCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadeVeiculoGridCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corVeiculoGridCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCombustivelVeiculoGridCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potenciaVeiculoGridCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCadastrar.SuspendLayout();
            this.tabControlCadHist.SuspendLayout();
            this.Cadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosGrid)).BeginInit();
            this.Historico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historicoGrid)).BeginInit();
            this.Veiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCadastrar
            // 
            this.groupBoxCadastrar.Controls.Add(this.cidadeOrigemLabel);
            this.groupBoxCadastrar.Controls.Add(this.cartaoCreditoCadastroLabel);
            this.groupBoxCadastrar.Controls.Add(this.txtCidadeOrigemCadastrar);
            this.groupBoxCadastrar.Controls.Add(this.txtCartaoCreditoCadastrar);
            this.groupBoxCadastrar.Controls.Add(this.sexoCadastroLabel);
            this.groupBoxCadastrar.Controls.Add(this.emailCadastroLabel);
            this.groupBoxCadastrar.Controls.Add(this.telefoneCadastroLabel);
            this.groupBoxCadastrar.Controls.Add(this.enderecoCadastroLabel);
            this.groupBoxCadastrar.Controls.Add(this.cpfCadastroLabel);
            this.groupBoxCadastrar.Controls.Add(this.nomeCadastroLabel);
            this.groupBoxCadastrar.Controls.Add(this.txtEmailCadastrar);
            this.groupBoxCadastrar.Controls.Add(this.txtTelefoneCadastrar);
            this.groupBoxCadastrar.Controls.Add(this.txtEnderecoCadastrar);
            this.groupBoxCadastrar.Controls.Add(this.txtCPFCadastrar);
            this.groupBoxCadastrar.Controls.Add(this.txtNomeCadastrar);
            this.groupBoxCadastrar.Controls.Add(this.masculinoRadioBtn);
            this.groupBoxCadastrar.Controls.Add(this.femininoRadioBtn);
            this.groupBoxCadastrar.Controls.Add(this.salvarCadastroBtn);
            this.groupBoxCadastrar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCadastrar.Name = "groupBoxCadastrar";
            this.groupBoxCadastrar.Size = new System.Drawing.Size(881, 111);
            this.groupBoxCadastrar.TabIndex = 0;
            this.groupBoxCadastrar.TabStop = false;
            this.groupBoxCadastrar.Text = "Cadastrar Viagem";
            // 
            // sexoCadastroLabel
            // 
            this.sexoCadastroLabel.AutoSize = true;
            this.sexoCadastroLabel.Location = new System.Drawing.Point(544, 64);
            this.sexoCadastroLabel.Name = "sexoCadastroLabel";
            this.sexoCadastroLabel.Size = new System.Drawing.Size(31, 13);
            this.sexoCadastroLabel.TabIndex = 17;
            this.sexoCadastroLabel.Text = "Sexo";
            // 
            // emailCadastroLabel
            // 
            this.emailCadastroLabel.AutoSize = true;
            this.emailCadastroLabel.Location = new System.Drawing.Point(4, 64);
            this.emailCadastroLabel.Name = "emailCadastroLabel";
            this.emailCadastroLabel.Size = new System.Drawing.Size(32, 13);
            this.emailCadastroLabel.TabIndex = 16;
            this.emailCadastroLabel.Text = "Email";
            // 
            // telefoneCadastroLabel
            // 
            this.telefoneCadastroLabel.AutoSize = true;
            this.telefoneCadastroLabel.Location = new System.Drawing.Point(364, 25);
            this.telefoneCadastroLabel.Name = "telefoneCadastroLabel";
            this.telefoneCadastroLabel.Size = new System.Drawing.Size(49, 13);
            this.telefoneCadastroLabel.TabIndex = 15;
            this.telefoneCadastroLabel.Text = "Telefone";
            // 
            // enderecoCadastroLabel
            // 
            this.enderecoCadastroLabel.AutoSize = true;
            this.enderecoCadastroLabel.Location = new System.Drawing.Point(544, 25);
            this.enderecoCadastroLabel.Name = "enderecoCadastroLabel";
            this.enderecoCadastroLabel.Size = new System.Drawing.Size(53, 13);
            this.enderecoCadastroLabel.TabIndex = 14;
            this.enderecoCadastroLabel.Text = "Endereço";
            // 
            // cpfCadastroLabel
            // 
            this.cpfCadastroLabel.AutoSize = true;
            this.cpfCadastroLabel.Location = new System.Drawing.Point(4, 25);
            this.cpfCadastroLabel.Name = "cpfCadastroLabel";
            this.cpfCadastroLabel.Size = new System.Drawing.Size(27, 13);
            this.cpfCadastroLabel.TabIndex = 13;
            this.cpfCadastroLabel.Text = "CPF";
            // 
            // nomeCadastroLabel
            // 
            this.nomeCadastroLabel.AutoSize = true;
            this.nomeCadastroLabel.Location = new System.Drawing.Point(185, 25);
            this.nomeCadastroLabel.Name = "nomeCadastroLabel";
            this.nomeCadastroLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeCadastroLabel.TabIndex = 12;
            this.nomeCadastroLabel.Text = "Nome";
            // 
            // txtEmailCadastrar
            // 
            this.txtEmailCadastrar.Location = new System.Drawing.Point(6, 80);
            this.txtEmailCadastrar.Name = "txtEmailCadastrar";
            this.txtEmailCadastrar.Size = new System.Drawing.Size(175, 20);
            this.txtEmailCadastrar.TabIndex = 5;
            // 
            // txtTelefoneCadastrar
            // 
            this.txtTelefoneCadastrar.Location = new System.Drawing.Point(367, 41);
            this.txtTelefoneCadastrar.MaxLength = 8;
            this.txtTelefoneCadastrar.Name = "txtTelefoneCadastrar";
            this.txtTelefoneCadastrar.Size = new System.Drawing.Size(174, 20);
            this.txtTelefoneCadastrar.TabIndex = 3;
            // 
            // txtEnderecoCadastrar
            // 
            this.txtEnderecoCadastrar.Location = new System.Drawing.Point(547, 41);
            this.txtEnderecoCadastrar.Name = "txtEnderecoCadastrar";
            this.txtEnderecoCadastrar.Size = new System.Drawing.Size(324, 20);
            this.txtEnderecoCadastrar.TabIndex = 4;
            // 
            // txtCPFCadastrar
            // 
            this.txtCPFCadastrar.Location = new System.Drawing.Point(7, 41);
            this.txtCPFCadastrar.MaxLength = 11;
            this.txtCPFCadastrar.Name = "txtCPFCadastrar";
            this.txtCPFCadastrar.Size = new System.Drawing.Size(174, 20);
            this.txtCPFCadastrar.TabIndex = 1;
            this.txtCPFCadastrar.Validated += new System.EventHandler(this.txtCPFCadastrar_Validated);
            // 
            // txtNomeCadastrar
            // 
            this.txtNomeCadastrar.Location = new System.Drawing.Point(187, 41);
            this.txtNomeCadastrar.Name = "txtNomeCadastrar";
            this.txtNomeCadastrar.Size = new System.Drawing.Size(174, 20);
            this.txtNomeCadastrar.TabIndex = 2;
            // 
            // masculinoRadioBtn
            // 
            this.masculinoRadioBtn.AutoSize = true;
            this.masculinoRadioBtn.Checked = true;
            this.masculinoRadioBtn.Location = new System.Drawing.Point(547, 83);
            this.masculinoRadioBtn.Name = "masculinoRadioBtn";
            this.masculinoRadioBtn.Size = new System.Drawing.Size(73, 17);
            this.masculinoRadioBtn.TabIndex = 8;
            this.masculinoRadioBtn.TabStop = true;
            this.masculinoRadioBtn.Text = "Masculino";
            this.masculinoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // femininoRadioBtn
            // 
            this.femininoRadioBtn.AutoSize = true;
            this.femininoRadioBtn.Location = new System.Drawing.Point(626, 83);
            this.femininoRadioBtn.Name = "femininoRadioBtn";
            this.femininoRadioBtn.Size = new System.Drawing.Size(67, 17);
            this.femininoRadioBtn.TabIndex = 9;
            this.femininoRadioBtn.TabStop = true;
            this.femininoRadioBtn.Text = "Feminino";
            this.femininoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // salvarCadastroBtn
            // 
            this.salvarCadastroBtn.Location = new System.Drawing.Point(727, 77);
            this.salvarCadastroBtn.Name = "salvarCadastroBtn";
            this.salvarCadastroBtn.Size = new System.Drawing.Size(144, 23);
            this.salvarCadastroBtn.TabIndex = 10;
            this.salvarCadastroBtn.Text = "Salvar";
            this.salvarCadastroBtn.UseVisualStyleBackColor = true;
            this.salvarCadastroBtn.Click += new System.EventHandler(this.salvarCadastroBtn_Click);
            // 
            // tabControlCadHist
            // 
            this.tabControlCadHist.Controls.Add(this.Cadastros);
            this.tabControlCadHist.Controls.Add(this.Historico);
            this.tabControlCadHist.Controls.Add(this.Veiculos);
            this.tabControlCadHist.Location = new System.Drawing.Point(12, 371);
            this.tabControlCadHist.Name = "tabControlCadHist";
            this.tabControlCadHist.SelectedIndex = 0;
            this.tabControlCadHist.Size = new System.Drawing.Size(881, 432);
            this.tabControlCadHist.TabIndex = 11;
            // 
            // Cadastros
            // 
            this.Cadastros.Controls.Add(this.modalidadeLabel);
            this.Cadastros.Controls.Add(this.cbModalidadeCadastros);
            this.Cadastros.Controls.Add(this.pesquisarCadastroBtn);
            this.Cadastros.Controls.Add(this.sexoLabel);
            this.Cadastros.Controls.Add(this.cpfLabel);
            this.Cadastros.Controls.Add(this.nomeLabel);
            this.Cadastros.Controls.Add(this.excluirCadastroBtn);
            this.Cadastros.Controls.Add(this.editarCadastroBtn);
            this.Cadastros.Controls.Add(this.sexoComboBox);
            this.Cadastros.Controls.Add(this.txtCPFCadastros);
            this.Cadastros.Controls.Add(this.txtNomeCadastros);
            this.Cadastros.Controls.Add(this.cadastrosGrid);
            this.Cadastros.Location = new System.Drawing.Point(4, 22);
            this.Cadastros.Name = "Cadastros";
            this.Cadastros.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastros.Size = new System.Drawing.Size(873, 406);
            this.Cadastros.TabIndex = 0;
            this.Cadastros.Text = "Cadastros";
            this.Cadastros.UseVisualStyleBackColor = true;
            // 
            // modalidadeLabel
            // 
            this.modalidadeLabel.AutoSize = true;
            this.modalidadeLabel.Location = new System.Drawing.Point(505, 6);
            this.modalidadeLabel.Name = "modalidadeLabel";
            this.modalidadeLabel.Size = new System.Drawing.Size(62, 13);
            this.modalidadeLabel.TabIndex = 11;
            this.modalidadeLabel.Text = "Modalidade";
            // 
            // cbModalidadeCadastros
            // 
            this.cbModalidadeCadastros.FormattingEnabled = true;
            this.cbModalidadeCadastros.Location = new System.Drawing.Point(506, 21);
            this.cbModalidadeCadastros.Name = "cbModalidadeCadastros";
            this.cbModalidadeCadastros.Size = new System.Drawing.Size(121, 21);
            this.cbModalidadeCadastros.TabIndex = 4;
            // 
            // pesquisarCadastroBtn
            // 
            this.pesquisarCadastroBtn.Location = new System.Drawing.Point(633, 20);
            this.pesquisarCadastroBtn.Name = "pesquisarCadastroBtn";
            this.pesquisarCadastroBtn.Size = new System.Drawing.Size(104, 23);
            this.pesquisarCadastroBtn.TabIndex = 5;
            this.pesquisarCadastroBtn.Text = "Pesquisar";
            this.pesquisarCadastroBtn.UseVisualStyleBackColor = true;
            // 
            // sexoLabel
            // 
            this.sexoLabel.AutoSize = true;
            this.sexoLabel.Location = new System.Drawing.Point(385, 6);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(31, 13);
            this.sexoLabel.TabIndex = 9;
            this.sexoLabel.Text = "Sexo";
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(194, 6);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(27, 13);
            this.cpfLabel.TabIndex = 8;
            this.cpfLabel.Text = "CPF";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(6, 6);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 7;
            this.nomeLabel.Text = "Nome";
            // 
            // excluirCadastroBtn
            // 
            this.excluirCadastroBtn.Location = new System.Drawing.Point(792, 35);
            this.excluirCadastroBtn.Name = "excluirCadastroBtn";
            this.excluirCadastroBtn.Size = new System.Drawing.Size(75, 23);
            this.excluirCadastroBtn.TabIndex = 7;
            this.excluirCadastroBtn.Text = "Excluir";
            this.excluirCadastroBtn.UseVisualStyleBackColor = true;
            this.excluirCadastroBtn.Click += new System.EventHandler(this.excluirCadastroBtn_Click);
            // 
            // editarCadastroBtn
            // 
            this.editarCadastroBtn.Location = new System.Drawing.Point(792, 6);
            this.editarCadastroBtn.Name = "editarCadastroBtn";
            this.editarCadastroBtn.Size = new System.Drawing.Size(75, 23);
            this.editarCadastroBtn.TabIndex = 6;
            this.editarCadastroBtn.Text = "Editar";
            this.editarCadastroBtn.UseVisualStyleBackColor = true;
            this.editarCadastroBtn.Click += new System.EventHandler(this.editarCadastroBtn_Click);
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Location = new System.Drawing.Point(388, 21);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(111, 21);
            this.sexoComboBox.TabIndex = 3;
            // 
            // txtCPFCadastros
            // 
            this.txtCPFCadastros.Location = new System.Drawing.Point(197, 22);
            this.txtCPFCadastros.Name = "txtCPFCadastros";
            this.txtCPFCadastros.Size = new System.Drawing.Size(185, 20);
            this.txtCPFCadastros.TabIndex = 2;
            // 
            // txtNomeCadastros
            // 
            this.txtNomeCadastros.Location = new System.Drawing.Point(6, 22);
            this.txtNomeCadastros.Name = "txtNomeCadastros";
            this.txtNomeCadastros.Size = new System.Drawing.Size(185, 20);
            this.txtNomeCadastros.TabIndex = 1;
            // 
            // cadastrosGrid
            // 
            this.cadastrosGrid.AllowUserToAddRows = false;
            this.cadastrosGrid.AllowUserToDeleteRows = false;
            this.cadastrosGrid.AllowUserToResizeRows = false;
            this.cadastrosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cadastrosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadastrosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_CadGrid,
            this.cpf_CadGrid,
            this.endereco_CadGrid,
            this.telefone_CadGrid,
            this.sexo_CadGrid,
            this.email_CadGrid});
            this.cadastrosGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.cadastrosGrid.Location = new System.Drawing.Point(6, 64);
            this.cadastrosGrid.Name = "cadastrosGrid";
            this.cadastrosGrid.Size = new System.Drawing.Size(861, 336);
            this.cadastrosGrid.TabIndex = 0;
            this.cadastrosGrid.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.cadastrosGrid_RowValidated);
            // 
            // nome_CadGrid
            // 
            this.nome_CadGrid.HeaderText = "Nome";
            this.nome_CadGrid.MaxInputLength = 50;
            this.nome_CadGrid.Name = "nome_CadGrid";
            // 
            // cpf_CadGrid
            // 
            this.cpf_CadGrid.HeaderText = "CPF";
            this.cpf_CadGrid.MaxInputLength = 12;
            this.cpf_CadGrid.Name = "cpf_CadGrid";
            this.cpf_CadGrid.ReadOnly = true;
            // 
            // endereco_CadGrid
            // 
            this.endereco_CadGrid.HeaderText = "Endereço";
            this.endereco_CadGrid.MaxInputLength = 50;
            this.endereco_CadGrid.Name = "endereco_CadGrid";
            // 
            // telefone_CadGrid
            // 
            this.telefone_CadGrid.HeaderText = "Telefone";
            this.telefone_CadGrid.Name = "telefone_CadGrid";
            // 
            // sexo_CadGrid
            // 
            this.sexo_CadGrid.FillWeight = 50F;
            this.sexo_CadGrid.HeaderText = "Sexo";
            this.sexo_CadGrid.MaxInputLength = 20;
            this.sexo_CadGrid.Name = "sexo_CadGrid";
            this.sexo_CadGrid.ReadOnly = true;
            // 
            // email_CadGrid
            // 
            this.email_CadGrid.HeaderText = "Email";
            this.email_CadGrid.MaxInputLength = 30;
            this.email_CadGrid.Name = "email_CadGrid";
            // 
            // Historico
            // 
            this.Historico.Controls.Add(this.modalidadeHistLabel);
            this.Historico.Controls.Add(this.placaHistLabel);
            this.Historico.Controls.Add(this.cpfHistLabel);
            this.Historico.Controls.Add(this.cbModalidadeHist);
            this.Historico.Controls.Add(this.pesquisarHistBtn);
            this.Historico.Controls.Add(this.txtPlacaHistorico);
            this.Historico.Controls.Add(this.txtCPFHistorico);
            this.Historico.Controls.Add(this.dataFinalHistorico);
            this.Historico.Controls.Add(this.dataInicialHistorico);
            this.Historico.Controls.Add(this.historicoGrid);
            this.Historico.Location = new System.Drawing.Point(4, 22);
            this.Historico.Name = "Historico";
            this.Historico.Padding = new System.Windows.Forms.Padding(3);
            this.Historico.Size = new System.Drawing.Size(873, 406);
            this.Historico.TabIndex = 1;
            this.Historico.Text = "Historico";
            this.Historico.UseVisualStyleBackColor = true;
            // 
            // modalidadeHistLabel
            // 
            this.modalidadeHistLabel.AutoSize = true;
            this.modalidadeHistLabel.Location = new System.Drawing.Point(357, 8);
            this.modalidadeHistLabel.Name = "modalidadeHistLabel";
            this.modalidadeHistLabel.Size = new System.Drawing.Size(62, 13);
            this.modalidadeHistLabel.TabIndex = 9;
            this.modalidadeHistLabel.Text = "Modalidade";
            // 
            // placaHistLabel
            // 
            this.placaHistLabel.AutoSize = true;
            this.placaHistLabel.Location = new System.Drawing.Point(182, 8);
            this.placaHistLabel.Name = "placaHistLabel";
            this.placaHistLabel.Size = new System.Drawing.Size(34, 13);
            this.placaHistLabel.TabIndex = 8;
            this.placaHistLabel.Text = "Placa";
            // 
            // cpfHistLabel
            // 
            this.cpfHistLabel.AutoSize = true;
            this.cpfHistLabel.Location = new System.Drawing.Point(6, 8);
            this.cpfHistLabel.Name = "cpfHistLabel";
            this.cpfHistLabel.Size = new System.Drawing.Size(27, 13);
            this.cpfHistLabel.TabIndex = 7;
            this.cpfHistLabel.Text = "CPF";
            // 
            // cbModalidadeHist
            // 
            this.cbModalidadeHist.FormattingEnabled = true;
            this.cbModalidadeHist.Location = new System.Drawing.Point(357, 27);
            this.cbModalidadeHist.Name = "cbModalidadeHist";
            this.cbModalidadeHist.Size = new System.Drawing.Size(155, 21);
            this.cbModalidadeHist.TabIndex = 3;
            // 
            // pesquisarHistBtn
            // 
            this.pesquisarHistBtn.Location = new System.Drawing.Point(791, 25);
            this.pesquisarHistBtn.Name = "pesquisarHistBtn";
            this.pesquisarHistBtn.Size = new System.Drawing.Size(75, 23);
            this.pesquisarHistBtn.TabIndex = 6;
            this.pesquisarHistBtn.Text = "Pesquisar";
            this.pesquisarHistBtn.UseVisualStyleBackColor = true;
            // 
            // txtPlacaHistorico
            // 
            this.txtPlacaHistorico.Location = new System.Drawing.Point(182, 27);
            this.txtPlacaHistorico.Name = "txtPlacaHistorico";
            this.txtPlacaHistorico.Size = new System.Drawing.Size(169, 20);
            this.txtPlacaHistorico.TabIndex = 2;
            // 
            // txtCPFHistorico
            // 
            this.txtCPFHistorico.Location = new System.Drawing.Point(6, 27);
            this.txtCPFHistorico.Name = "txtCPFHistorico";
            this.txtCPFHistorico.Size = new System.Drawing.Size(169, 20);
            this.txtCPFHistorico.TabIndex = 1;
            // 
            // dataFinalHistorico
            // 
            this.dataFinalHistorico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinalHistorico.Location = new System.Drawing.Point(650, 27);
            this.dataFinalHistorico.Name = "dataFinalHistorico";
            this.dataFinalHistorico.Size = new System.Drawing.Size(125, 20);
            this.dataFinalHistorico.TabIndex = 5;
            // 
            // dataInicialHistorico
            // 
            this.dataInicialHistorico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicialHistorico.Location = new System.Drawing.Point(519, 27);
            this.dataInicialHistorico.Name = "dataInicialHistorico";
            this.dataInicialHistorico.Size = new System.Drawing.Size(125, 20);
            this.dataInicialHistorico.TabIndex = 4;
            // 
            // historicoGrid
            // 
            this.historicoGrid.AllowUserToAddRows = false;
            this.historicoGrid.AllowUserToDeleteRows = false;
            this.historicoGrid.AllowUserToResizeRows = false;
            this.historicoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historicoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpfMot_HistGrid,
            this.cpfPass_HistGrid,
            this.placa_HistGrid,
            this.localOrig_HistGrid,
            this.localDest_HistGrid,
            this.dataInicio_HistGrid,
            this.dataFim_HistGrid,
            this.qtdePass_HistGrid,
            this.formaPagto_HistGrid,
            this.valor_HistGrid,
            this.cancelamento_HistGrid});
            this.historicoGrid.Location = new System.Drawing.Point(6, 54);
            this.historicoGrid.Name = "historicoGrid";
            this.historicoGrid.ReadOnly = true;
            this.historicoGrid.Size = new System.Drawing.Size(861, 346);
            this.historicoGrid.TabIndex = 0;
            // 
            // cpfMot_HistGrid
            // 
            this.cpfMot_HistGrid.HeaderText = "CPF Motorista";
            this.cpfMot_HistGrid.Name = "cpfMot_HistGrid";
            this.cpfMot_HistGrid.ReadOnly = true;
            // 
            // cpfPass_HistGrid
            // 
            this.cpfPass_HistGrid.HeaderText = "CPF Passageiro";
            this.cpfPass_HistGrid.Name = "cpfPass_HistGrid";
            this.cpfPass_HistGrid.ReadOnly = true;
            // 
            // placa_HistGrid
            // 
            this.placa_HistGrid.HeaderText = "Placa";
            this.placa_HistGrid.Name = "placa_HistGrid";
            this.placa_HistGrid.ReadOnly = true;
            // 
            // localOrig_HistGrid
            // 
            this.localOrig_HistGrid.HeaderText = "Local Origem";
            this.localOrig_HistGrid.Name = "localOrig_HistGrid";
            this.localOrig_HistGrid.ReadOnly = true;
            // 
            // localDest_HistGrid
            // 
            this.localDest_HistGrid.HeaderText = "Local Destino";
            this.localDest_HistGrid.Name = "localDest_HistGrid";
            this.localDest_HistGrid.ReadOnly = true;
            // 
            // dataInicio_HistGrid
            // 
            this.dataInicio_HistGrid.HeaderText = "Data Início";
            this.dataInicio_HistGrid.Name = "dataInicio_HistGrid";
            this.dataInicio_HistGrid.ReadOnly = true;
            // 
            // dataFim_HistGrid
            // 
            this.dataFim_HistGrid.HeaderText = "Data Fim";
            this.dataFim_HistGrid.Name = "dataFim_HistGrid";
            this.dataFim_HistGrid.ReadOnly = true;
            // 
            // qtdePass_HistGrid
            // 
            this.qtdePass_HistGrid.HeaderText = "Passageiros";
            this.qtdePass_HistGrid.Name = "qtdePass_HistGrid";
            this.qtdePass_HistGrid.ReadOnly = true;
            // 
            // formaPagto_HistGrid
            // 
            this.formaPagto_HistGrid.HeaderText = "Forma de Pagamento";
            this.formaPagto_HistGrid.Name = "formaPagto_HistGrid";
            this.formaPagto_HistGrid.ReadOnly = true;
            // 
            // valor_HistGrid
            // 
            this.valor_HistGrid.HeaderText = "Valor";
            this.valor_HistGrid.Name = "valor_HistGrid";
            this.valor_HistGrid.ReadOnly = true;
            // 
            // cancelamento_HistGrid
            // 
            this.cancelamento_HistGrid.HeaderText = "Cancelamento";
            this.cancelamento_HistGrid.Name = "cancelamento_HistGrid";
            this.cancelamento_HistGrid.ReadOnly = true;
            // 
            // Veiculos
            // 
            this.Veiculos.Controls.Add(this.dataGridView1);
            this.Veiculos.Controls.Add(this.button1);
            this.Veiculos.Controls.Add(this.cbTipoCombustivelVeiculos);
            this.Veiculos.Controls.Add(this.cbCapacidadeVeiculos);
            this.Veiculos.Controls.Add(this.potenciaVeiculoLabel);
            this.Veiculos.Controls.Add(this.tipoCombustivelVeiculoLabel);
            this.Veiculos.Controls.Add(this.corVeiculoLabel);
            this.Veiculos.Controls.Add(this.capacidadeVeiculoLabel);
            this.Veiculos.Controls.Add(this.anoVeiculoLabel);
            this.Veiculos.Controls.Add(this.modeloVeiculoLabel);
            this.Veiculos.Controls.Add(this.marcaVeiculoLabel);
            this.Veiculos.Controls.Add(this.placaVeiculoLabel);
            this.Veiculos.Controls.Add(this.txtPotenciaMotorVeiculos);
            this.Veiculos.Controls.Add(this.txtCorVeiculos);
            this.Veiculos.Controls.Add(this.txtAnoVeiculos);
            this.Veiculos.Controls.Add(this.txtModeloVeiculos);
            this.Veiculos.Controls.Add(this.txtMarcaVeiculos);
            this.Veiculos.Controls.Add(this.txtPlacaVeiculos);
            this.Veiculos.Location = new System.Drawing.Point(4, 22);
            this.Veiculos.Name = "Veiculos";
            this.Veiculos.Size = new System.Drawing.Size(873, 406);
            this.Veiculos.TabIndex = 2;
            this.Veiculos.Text = "Veículos";
            this.Veiculos.UseVisualStyleBackColor = true;
            // 
            // txtCartaoCreditoCadastrar
            // 
            this.txtCartaoCreditoCadastrar.Location = new System.Drawing.Point(367, 80);
            this.txtCartaoCreditoCadastrar.Name = "txtCartaoCreditoCadastrar";
            this.txtCartaoCreditoCadastrar.Size = new System.Drawing.Size(174, 20);
            this.txtCartaoCreditoCadastrar.TabIndex = 7;
            // 
            // txtCidadeOrigemCadastrar
            // 
            this.txtCidadeOrigemCadastrar.Location = new System.Drawing.Point(187, 80);
            this.txtCidadeOrigemCadastrar.Name = "txtCidadeOrigemCadastrar";
            this.txtCidadeOrigemCadastrar.Size = new System.Drawing.Size(174, 20);
            this.txtCidadeOrigemCadastrar.TabIndex = 6;
            // 
            // cartaoCreditoCadastroLabel
            // 
            this.cartaoCreditoCadastroLabel.AutoSize = true;
            this.cartaoCreditoCadastroLabel.Location = new System.Drawing.Point(364, 64);
            this.cartaoCreditoCadastroLabel.Name = "cartaoCreditoCadastroLabel";
            this.cartaoCreditoCadastroLabel.Size = new System.Drawing.Size(89, 13);
            this.cartaoCreditoCadastroLabel.TabIndex = 20;
            this.cartaoCreditoCadastroLabel.Text = "Cartão de Crédito";
            // 
            // cidadeOrigemLabel
            // 
            this.cidadeOrigemLabel.AutoSize = true;
            this.cidadeOrigemLabel.Location = new System.Drawing.Point(184, 64);
            this.cidadeOrigemLabel.Name = "cidadeOrigemLabel";
            this.cidadeOrigemLabel.Size = new System.Drawing.Size(91, 13);
            this.cidadeOrigemLabel.TabIndex = 21;
            this.cidadeOrigemLabel.Text = "Cidade de Origem";
            // 
            // txtPlacaVeiculos
            // 
            this.txtPlacaVeiculos.Location = new System.Drawing.Point(7, 27);
            this.txtPlacaVeiculos.Name = "txtPlacaVeiculos";
            this.txtPlacaVeiculos.Size = new System.Drawing.Size(99, 20);
            this.txtPlacaVeiculos.TabIndex = 1;
            // 
            // txtMarcaVeiculos
            // 
            this.txtMarcaVeiculos.Location = new System.Drawing.Point(112, 27);
            this.txtMarcaVeiculos.Name = "txtMarcaVeiculos";
            this.txtMarcaVeiculos.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaVeiculos.TabIndex = 2;
            // 
            // txtModeloVeiculos
            // 
            this.txtModeloVeiculos.Location = new System.Drawing.Point(218, 27);
            this.txtModeloVeiculos.Name = "txtModeloVeiculos";
            this.txtModeloVeiculos.Size = new System.Drawing.Size(100, 20);
            this.txtModeloVeiculos.TabIndex = 3;
            // 
            // txtAnoVeiculos
            // 
            this.txtAnoVeiculos.Location = new System.Drawing.Point(324, 27);
            this.txtAnoVeiculos.Name = "txtAnoVeiculos";
            this.txtAnoVeiculos.Size = new System.Drawing.Size(65, 20);
            this.txtAnoVeiculos.TabIndex = 4;
            // 
            // txtCorVeiculos
            // 
            this.txtCorVeiculos.Location = new System.Drawing.Point(462, 26);
            this.txtCorVeiculos.Name = "txtCorVeiculos";
            this.txtCorVeiculos.Size = new System.Drawing.Size(91, 20);
            this.txtCorVeiculos.TabIndex = 6;
            // 
            // txtPotenciaMotorVeiculos
            // 
            this.txtPotenciaMotorVeiculos.Location = new System.Drawing.Point(664, 26);
            this.txtPotenciaMotorVeiculos.Name = "txtPotenciaMotorVeiculos";
            this.txtPotenciaMotorVeiculos.Size = new System.Drawing.Size(91, 20);
            this.txtPotenciaMotorVeiculos.TabIndex = 8;
            // 
            // placaVeiculoLabel
            // 
            this.placaVeiculoLabel.AutoSize = true;
            this.placaVeiculoLabel.Location = new System.Drawing.Point(7, 8);
            this.placaVeiculoLabel.Name = "placaVeiculoLabel";
            this.placaVeiculoLabel.Size = new System.Drawing.Size(34, 13);
            this.placaVeiculoLabel.TabIndex = 1;
            this.placaVeiculoLabel.Text = "Placa";
            // 
            // marcaVeiculoLabel
            // 
            this.marcaVeiculoLabel.AutoSize = true;
            this.marcaVeiculoLabel.Location = new System.Drawing.Point(109, 8);
            this.marcaVeiculoLabel.Name = "marcaVeiculoLabel";
            this.marcaVeiculoLabel.Size = new System.Drawing.Size(37, 13);
            this.marcaVeiculoLabel.TabIndex = 1;
            this.marcaVeiculoLabel.Text = "Marca";
            // 
            // modeloVeiculoLabel
            // 
            this.modeloVeiculoLabel.AutoSize = true;
            this.modeloVeiculoLabel.Location = new System.Drawing.Point(215, 8);
            this.modeloVeiculoLabel.Name = "modeloVeiculoLabel";
            this.modeloVeiculoLabel.Size = new System.Drawing.Size(42, 13);
            this.modeloVeiculoLabel.TabIndex = 1;
            this.modeloVeiculoLabel.Text = "Modelo";
            // 
            // anoVeiculoLabel
            // 
            this.anoVeiculoLabel.AutoSize = true;
            this.anoVeiculoLabel.Location = new System.Drawing.Point(321, 8);
            this.anoVeiculoLabel.Name = "anoVeiculoLabel";
            this.anoVeiculoLabel.Size = new System.Drawing.Size(26, 13);
            this.anoVeiculoLabel.TabIndex = 1;
            this.anoVeiculoLabel.Text = "Ano";
            // 
            // capacidadeVeiculoLabel
            // 
            this.capacidadeVeiculoLabel.AutoSize = true;
            this.capacidadeVeiculoLabel.Location = new System.Drawing.Point(392, 7);
            this.capacidadeVeiculoLabel.Name = "capacidadeVeiculoLabel";
            this.capacidadeVeiculoLabel.Size = new System.Drawing.Size(64, 13);
            this.capacidadeVeiculoLabel.TabIndex = 1;
            this.capacidadeVeiculoLabel.Text = "Capacidade";
            // 
            // corVeiculoLabel
            // 
            this.corVeiculoLabel.AutoSize = true;
            this.corVeiculoLabel.Location = new System.Drawing.Point(459, 7);
            this.corVeiculoLabel.Name = "corVeiculoLabel";
            this.corVeiculoLabel.Size = new System.Drawing.Size(23, 13);
            this.corVeiculoLabel.TabIndex = 1;
            this.corVeiculoLabel.Text = "Cor";
            // 
            // tipoCombustivelVeiculoLabel
            // 
            this.tipoCombustivelVeiculoLabel.AutoSize = true;
            this.tipoCombustivelVeiculoLabel.Location = new System.Drawing.Point(556, 7);
            this.tipoCombustivelVeiculoLabel.Name = "tipoCombustivelVeiculoLabel";
            this.tipoCombustivelVeiculoLabel.Size = new System.Drawing.Size(90, 13);
            this.tipoCombustivelVeiculoLabel.TabIndex = 1;
            this.tipoCombustivelVeiculoLabel.Text = "Tipo Combustível";
            // 
            // potenciaVeiculoLabel
            // 
            this.potenciaVeiculoLabel.AutoSize = true;
            this.potenciaVeiculoLabel.Location = new System.Drawing.Point(661, 7);
            this.potenciaVeiculoLabel.Name = "potenciaVeiculoLabel";
            this.potenciaVeiculoLabel.Size = new System.Drawing.Size(94, 13);
            this.potenciaVeiculoLabel.TabIndex = 1;
            this.potenciaVeiculoLabel.Text = "Potência do Motor";
            // 
            // cbCapacidadeVeiculos
            // 
            this.cbCapacidadeVeiculos.FormattingEnabled = true;
            this.cbCapacidadeVeiculos.Location = new System.Drawing.Point(395, 26);
            this.cbCapacidadeVeiculos.Name = "cbCapacidadeVeiculos";
            this.cbCapacidadeVeiculos.Size = new System.Drawing.Size(61, 21);
            this.cbCapacidadeVeiculos.TabIndex = 5;
            // 
            // cbTipoCombustivelVeiculos
            // 
            this.cbTipoCombustivelVeiculos.FormattingEnabled = true;
            this.cbTipoCombustivelVeiculos.Location = new System.Drawing.Point(559, 26);
            this.cbTipoCombustivelVeiculos.Name = "cbTipoCombustivelVeiculos";
            this.cbTipoCombustivelVeiculos.Size = new System.Drawing.Size(99, 21);
            this.cbTipoCombustivelVeiculos.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placaVeiculoGridCol,
            this.marcaVeiculoGridCol,
            this.modeloVeiculoGridCol,
            this.anoVeiculoGridCol,
            this.capacidadeVeiculoGridCol,
            this.corVeiculoGridCol,
            this.tipoCombustivelVeiculoGridCol,
            this.potenciaVeiculoGridCol});
            this.dataGridView1.Location = new System.Drawing.Point(7, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(855, 346);
            this.dataGridView1.TabIndex = 10;
            // 
            // placaVeiculoGridCol
            // 
            this.placaVeiculoGridCol.HeaderText = "Placa";
            this.placaVeiculoGridCol.Name = "placaVeiculoGridCol";
            this.placaVeiculoGridCol.ReadOnly = true;
            // 
            // marcaVeiculoGridCol
            // 
            this.marcaVeiculoGridCol.HeaderText = "Marca";
            this.marcaVeiculoGridCol.Name = "marcaVeiculoGridCol";
            this.marcaVeiculoGridCol.ReadOnly = true;
            // 
            // modeloVeiculoGridCol
            // 
            this.modeloVeiculoGridCol.HeaderText = "Modelo";
            this.modeloVeiculoGridCol.Name = "modeloVeiculoGridCol";
            this.modeloVeiculoGridCol.ReadOnly = true;
            // 
            // anoVeiculoGridCol
            // 
            this.anoVeiculoGridCol.HeaderText = "Ano";
            this.anoVeiculoGridCol.Name = "anoVeiculoGridCol";
            this.anoVeiculoGridCol.ReadOnly = true;
            // 
            // capacidadeVeiculoGridCol
            // 
            this.capacidadeVeiculoGridCol.HeaderText = "Capacidade";
            this.capacidadeVeiculoGridCol.Name = "capacidadeVeiculoGridCol";
            this.capacidadeVeiculoGridCol.ReadOnly = true;
            // 
            // corVeiculoGridCol
            // 
            this.corVeiculoGridCol.HeaderText = "Cor";
            this.corVeiculoGridCol.Name = "corVeiculoGridCol";
            this.corVeiculoGridCol.ReadOnly = true;
            // 
            // tipoCombustivelVeiculoGridCol
            // 
            this.tipoCombustivelVeiculoGridCol.HeaderText = "Tipo de Combustível";
            this.tipoCombustivelVeiculoGridCol.Name = "tipoCombustivelVeiculoGridCol";
            this.tipoCombustivelVeiculoGridCol.ReadOnly = true;
            // 
            // potenciaVeiculoGridCol
            // 
            this.potenciaVeiculoGridCol.HeaderText = "Potência do Motor";
            this.potenciaVeiculoGridCol.Name = "potenciaVeiculoGridCol";
            this.potenciaVeiculoGridCol.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 815);
            this.Controls.Add(this.tabControlCadHist);
            this.Controls.Add(this.groupBoxCadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCadastrar.ResumeLayout(false);
            this.groupBoxCadastrar.PerformLayout();
            this.tabControlCadHist.ResumeLayout(false);
            this.Cadastros.ResumeLayout(false);
            this.Cadastros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosGrid)).EndInit();
            this.Historico.ResumeLayout(false);
            this.Historico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historicoGrid)).EndInit();
            this.Veiculos.ResumeLayout(false);
            this.Veiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCadastrar;
        private System.Windows.Forms.TabControl tabControlCadHist;
        private System.Windows.Forms.TabPage Cadastros;
        private System.Windows.Forms.TabPage Historico;
        private System.Windows.Forms.DataGridView cadastrosGrid;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.TextBox txtCPFCadastros;
        private System.Windows.Forms.TextBox txtNomeCadastros;
        private System.Windows.Forms.Button excluirCadastroBtn;
        private System.Windows.Forms.Button editarCadastroBtn;
        private System.Windows.Forms.Button pesquisarCadastroBtn;
        private System.Windows.Forms.Label sexoLabel;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox txtEmailCadastrar;
        private System.Windows.Forms.TextBox txtTelefoneCadastrar;
        private System.Windows.Forms.TextBox txtEnderecoCadastrar;
        private System.Windows.Forms.TextBox txtCPFCadastrar;
        private System.Windows.Forms.TextBox txtNomeCadastrar;
        private System.Windows.Forms.RadioButton masculinoRadioBtn;
        private System.Windows.Forms.RadioButton femininoRadioBtn;
        private System.Windows.Forms.Button salvarCadastroBtn;
        private System.Windows.Forms.Label sexoCadastroLabel;
        private System.Windows.Forms.Label emailCadastroLabel;
        private System.Windows.Forms.Label telefoneCadastroLabel;
        private System.Windows.Forms.Label enderecoCadastroLabel;
        private System.Windows.Forms.Label cpfCadastroLabel;
        private System.Windows.Forms.Label nomeCadastroLabel;
        private System.Windows.Forms.Label modalidadeLabel;
        private System.Windows.Forms.ComboBox cbModalidadeCadastros;
        private System.Windows.Forms.TextBox txtCPFHistorico;
        private System.Windows.Forms.DateTimePicker dataFinalHistorico;
        private System.Windows.Forms.DateTimePicker dataInicialHistorico;
        private System.Windows.Forms.DataGridView historicoGrid;
        private System.Windows.Forms.Button pesquisarHistBtn;
        private System.Windows.Forms.TextBox txtPlacaHistorico;
        private System.Windows.Forms.ComboBox cbModalidadeHist;
        private System.Windows.Forms.Label cpfHistLabel;
        private System.Windows.Forms.Label modalidadeHistLabel;
        private System.Windows.Forms.Label placaHistLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfMot_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfPass_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn localOrig_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDest_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFim_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdePass_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagto_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelamento_HistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_CadGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_CadGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_CadGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_CadGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_CadGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_CadGrid;
        private System.Windows.Forms.TabPage Veiculos;
        private System.Windows.Forms.Label cartaoCreditoCadastroLabel;
        private System.Windows.Forms.TextBox txtCidadeOrigemCadastrar;
        private System.Windows.Forms.TextBox txtCartaoCreditoCadastrar;
        private System.Windows.Forms.Label cidadeOrigemLabel;
        private System.Windows.Forms.TextBox txtPlacaVeiculos;
        private System.Windows.Forms.Label potenciaVeiculoLabel;
        private System.Windows.Forms.Label tipoCombustivelVeiculoLabel;
        private System.Windows.Forms.Label corVeiculoLabel;
        private System.Windows.Forms.Label capacidadeVeiculoLabel;
        private System.Windows.Forms.Label anoVeiculoLabel;
        private System.Windows.Forms.Label modeloVeiculoLabel;
        private System.Windows.Forms.Label marcaVeiculoLabel;
        private System.Windows.Forms.Label placaVeiculoLabel;
        private System.Windows.Forms.TextBox txtPotenciaMotorVeiculos;
        private System.Windows.Forms.TextBox txtCorVeiculos;
        private System.Windows.Forms.TextBox txtAnoVeiculos;
        private System.Windows.Forms.TextBox txtModeloVeiculos;
        private System.Windows.Forms.TextBox txtMarcaVeiculos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTipoCombustivelVeiculos;
        private System.Windows.Forms.ComboBox cbCapacidadeVeiculos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaVeiculoGridCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaVeiculoGridCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloVeiculoGridCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoVeiculoGridCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadeVeiculoGridCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn corVeiculoGridCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCombustivelVeiculoGridCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn potenciaVeiculoGridCol;
    }
}

