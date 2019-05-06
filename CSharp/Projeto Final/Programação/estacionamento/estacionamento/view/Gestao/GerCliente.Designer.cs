﻿namespace Estacionamento.View.Gestao
{
    partial class GerCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerCliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTipoCliente = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.checkAlterarCliente = new System.Windows.Forms.CheckBox();
            this.btnApagarCliente = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.mTxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.mTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.btnApagarVeiculo = new System.Windows.Forms.Button();
            this.btnAlterarVeiculo = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAlterarPagamento = new System.Windows.Forms.Button();
            this.lblValorPlano = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cbTipoPlano = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.lblTipoPlano = new System.Windows.Forms.Label();
            this.btnCadVeiculo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbConsultar = new System.Windows.Forms.ComboBox();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.mTxtConsultar = new System.Windows.Forms.MaskedTextBox();
            this.btnEfetuarPagamento = new System.Windows.Forms.Button();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 75);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 275);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.txtTipoCliente);
            this.tabPage1.Controls.Add(this.lblLogin);
            this.tabPage1.Controls.Add(this.txtLogin);
            this.tabPage1.Controls.Add(this.checkAlterarCliente);
            this.tabPage1.Controls.Add(this.btnApagarCliente);
            this.tabPage1.Controls.Add(this.btnAlterarCliente);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.lblTelefone);
            this.tabPage1.Controls.Add(this.lblCelular);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.lblEndereco);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.mTxtCelular);
            this.tabPage1.Controls.Add(this.mTxtTelefone);
            this.tabPage1.Controls.Add(this.lblTipoCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(330, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gerenciar Cliente";
            // 
            // txtTipoCliente
            // 
            this.txtTipoCliente.Location = new System.Drawing.Point(114, 23);
            this.txtTipoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoCliente.Name = "txtTipoCliente";
            this.txtTipoCliente.Size = new System.Drawing.Size(203, 20);
            this.txtTipoCliente.TabIndex = 5;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 162);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 13);
            this.lblLogin.TabIndex = 41;
            this.lblLogin.Text = "Login *";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(114, 159);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(203, 20);
            this.txtLogin.TabIndex = 11;
            // 
            // checkAlterarCliente
            // 
            this.checkAlterarCliente.AutoSize = true;
            this.checkAlterarCliente.Location = new System.Drawing.Point(114, 193);
            this.checkAlterarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.checkAlterarCliente.Name = "checkAlterarCliente";
            this.checkAlterarCliente.Size = new System.Drawing.Size(138, 17);
            this.checkAlterarCliente.TabIndex = 12;
            this.checkAlterarCliente.Text = "Alterar dados do Cliente";
            this.checkAlterarCliente.UseVisualStyleBackColor = true;
            this.checkAlterarCliente.Visible = false;
            this.checkAlterarCliente.CheckedChanged += new System.EventHandler(this.checkAlterarCliente_CheckedChanged);
            // 
            // btnApagarCliente
            // 
            this.btnApagarCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnApagarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarCliente.Location = new System.Drawing.Point(252, 218);
            this.btnApagarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagarCliente.Name = "btnApagarCliente";
            this.btnApagarCliente.Size = new System.Drawing.Size(63, 24);
            this.btnApagarCliente.TabIndex = 14;
            this.btnApagarCliente.Text = "Apaga";
            this.btnApagarCliente.UseVisualStyleBackColor = false;
            this.btnApagarCliente.Click += new System.EventHandler(this.btnApagarCliente_Click);
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAlterarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCliente.Location = new System.Drawing.Point(185, 218);
            this.btnAlterarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(63, 24);
            this.btnAlterarCliente.TabIndex = 13;
            this.btnAlterarCliente.Text = "Atualiza";
            this.btnAlterarCliente.UseVisualStyleBackColor = false;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 48);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome *";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 45);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 20);
            this.txtNome.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(10, 74);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(12, 96);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 6;
            this.lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 119);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 114);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(12, 141);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 10;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(114, 136);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(203, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // mTxtCelular
            // 
            this.mTxtCelular.Location = new System.Drawing.Point(114, 91);
            this.mTxtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtCelular.Mask = "(99) 00000-0000";
            this.mTxtCelular.Name = "mTxtCelular";
            this.mTxtCelular.Size = new System.Drawing.Size(203, 20);
            this.mTxtCelular.TabIndex = 8;
            // 
            // mTxtTelefone
            // 
            this.mTxtTelefone.Location = new System.Drawing.Point(114, 68);
            this.mTxtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtTelefone.Mask = "(99) 0000-0000";
            this.mTxtTelefone.Name = "mTxtTelefone";
            this.mTxtTelefone.Size = new System.Drawing.Size(203, 20);
            this.mTxtTelefone.TabIndex = 7;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(9, 24);
            this.lblTipoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(78, 13);
            this.lblTipoCliente.TabIndex = 0;
            this.lblTipoCliente.Text = "Tipo de Cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.cbPlaca);
            this.tabPage2.Controls.Add(this.btnApagarVeiculo);
            this.tabPage2.Controls.Add(this.btnAlterarVeiculo);
            this.tabPage2.Controls.Add(this.lblPlaca);
            this.tabPage2.Controls.Add(this.lblModelo);
            this.tabPage2.Controls.Add(this.txtAno);
            this.tabPage2.Controls.Add(this.txtModelo);
            this.tabPage2.Controls.Add(this.lblAno);
            this.tabPage2.Controls.Add(this.lblMarca);
            this.tabPage2.Controls.Add(this.txtMarca);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(330, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gerenciar Veículo";
            // 
            // cbPlaca
            // 
            this.cbPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(106, 12);
            this.cbPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(203, 21);
            this.cbPlaca.TabIndex = 15;
            this.cbPlaca.SelectedIndexChanged += new System.EventHandler(this.cbPlaca_SelectedIndexChanged);
            // 
            // btnApagarVeiculo
            // 
            this.btnApagarVeiculo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnApagarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarVeiculo.Location = new System.Drawing.Point(246, 130);
            this.btnApagarVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagarVeiculo.Name = "btnApagarVeiculo";
            this.btnApagarVeiculo.Size = new System.Drawing.Size(63, 24);
            this.btnApagarVeiculo.TabIndex = 20;
            this.btnApagarVeiculo.Text = "Apaga";
            this.btnApagarVeiculo.UseVisualStyleBackColor = false;
            this.btnApagarVeiculo.Click += new System.EventHandler(this.btnApagarVeiculo_Click);
            // 
            // btnAlterarVeiculo
            // 
            this.btnAlterarVeiculo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAlterarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarVeiculo.Location = new System.Drawing.Point(179, 130);
            this.btnAlterarVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarVeiculo.Name = "btnAlterarVeiculo";
            this.btnAlterarVeiculo.Size = new System.Drawing.Size(63, 24);
            this.btnAlterarVeiculo.TabIndex = 19;
            this.btnAlterarVeiculo.Text = "Atualiza";
            this.btnAlterarVeiculo.UseVisualStyleBackColor = false;
            this.btnAlterarVeiculo.Click += new System.EventHandler(this.btnAlterarVeiculo_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(9, 15);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 30;
            this.lblPlaca.Text = "Placa";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(9, 42);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 24;
            this.lblModelo.Text = "Modelo";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(106, 83);
            this.txtAno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(203, 20);
            this.txtAno.TabIndex = 18;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(106, 38);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(203, 20);
            this.txtModelo.TabIndex = 16;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(10, 87);
            this.lblAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 28;
            this.lblAno.Text = "Ano";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(9, 65);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 26;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(106, 61);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(203, 20);
            this.txtMarca.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage3.Controls.Add(this.btnAlterarPagamento);
            this.tabPage3.Controls.Add(this.lblValorPlano);
            this.tabPage3.Controls.Add(this.lblValor);
            this.tabPage3.Controls.Add(this.cbTipoPlano);
            this.tabPage3.Controls.Add(this.lblSituacao);
            this.tabPage3.Controls.Add(this.cbSituacao);
            this.tabPage3.Controls.Add(this.lblVencimento);
            this.tabPage3.Controls.Add(this.dtVencimento);
            this.tabPage3.Controls.Add(this.lblTipoPlano);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(330, 249);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pagamento";
            // 
            // btnAlterarPagamento
            // 
            this.btnAlterarPagamento.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAlterarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarPagamento.Location = new System.Drawing.Point(254, 140);
            this.btnAlterarPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarPagamento.Name = "btnAlterarPagamento";
            this.btnAlterarPagamento.Size = new System.Drawing.Size(63, 24);
            this.btnAlterarPagamento.TabIndex = 24;
            this.btnAlterarPagamento.Text = "Atualiza";
            this.btnAlterarPagamento.UseVisualStyleBackColor = false;
            this.btnAlterarPagamento.Click += new System.EventHandler(this.btnAlterarPagamento_Click);
            // 
            // lblValorPlano
            // 
            this.lblValorPlano.AutoSize = true;
            this.lblValorPlano.Location = new System.Drawing.Point(111, 57);
            this.lblValorPlano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPlano.Name = "lblValorPlano";
            this.lblValorPlano.Size = new System.Drawing.Size(76, 13);
            this.lblValorPlano.TabIndex = 27;
            this.lblValorPlano.Text = "Valor do Plano";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(16, 56);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 26;
            this.lblValor.Text = "Valor";
            // 
            // cbTipoPlano
            // 
            this.cbTipoPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPlano.FormattingEnabled = true;
            this.cbTipoPlano.Location = new System.Drawing.Point(114, 23);
            this.cbTipoPlano.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoPlano.Name = "cbTipoPlano";
            this.cbTipoPlano.Size = new System.Drawing.Size(203, 21);
            this.cbTipoPlano.TabIndex = 21;
            this.cbTipoPlano.SelectedIndexChanged += new System.EventHandler(this.cbTipoPlano_SelectedIndexChanged);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(15, 83);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 18;
            this.lblSituacao.Text = "Situação";
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(114, 80);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(2);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(203, 21);
            this.cbSituacao.TabIndex = 22;
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(15, 107);
            this.lblVencimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(63, 13);
            this.lblVencimento.TabIndex = 20;
            this.lblVencimento.Text = "Vencimento";
            // 
            // dtVencimento
            // 
            this.dtVencimento.Enabled = false;
            this.dtVencimento.Location = new System.Drawing.Point(114, 105);
            this.dtVencimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(203, 20);
            this.dtVencimento.TabIndex = 23;
            // 
            // lblTipoPlano
            // 
            this.lblTipoPlano.AutoSize = true;
            this.lblTipoPlano.Location = new System.Drawing.Point(15, 26);
            this.lblTipoPlano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPlano.Name = "lblTipoPlano";
            this.lblTipoPlano.Size = new System.Drawing.Size(73, 13);
            this.lblTipoPlano.TabIndex = 24;
            this.lblTipoPlano.Text = "Tipo de Plano";
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadVeiculo.Location = new System.Drawing.Point(9, 389);
            this.btnCadVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(85, 24);
            this.btnCadVeiculo.TabIndex = 25;
            this.btnCadVeiculo.Text = "Novo Veículo";
            this.btnCadVeiculo.UseVisualStyleBackColor = true;
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(208, 38);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(63, 24);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consulta";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultarPlaca_Click);
            // 
            // cbConsultar
            // 
            this.cbConsultar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultar.FormattingEnabled = true;
            this.cbConsultar.Location = new System.Drawing.Point(12, 11);
            this.cbConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.cbConsultar.Name = "cbConsultar";
            this.cbConsultar.Size = new System.Drawing.Size(156, 21);
            this.cbConsultar.TabIndex = 1;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCampos.Location = new System.Drawing.Point(98, 389);
            this.btnLimparCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(63, 24);
            this.btnLimparCampos.TabIndex = 26;
            this.btnLimparCampos.Text = "Limpa";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(280, 38);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(63, 24);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // mTxtConsultar
            // 
            this.mTxtConsultar.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mTxtConsultar.Location = new System.Drawing.Point(171, 12);
            this.mTxtConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtConsultar.Mask = "???-0000";
            this.mTxtConsultar.Name = "mTxtConsultar";
            this.mTxtConsultar.PromptChar = ' ';
            this.mTxtConsultar.Size = new System.Drawing.Size(106, 20);
            this.mTxtConsultar.TabIndex = 2;
            // 
            // btnEfetuarPagamento
            // 
            this.btnEfetuarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfetuarPagamento.Location = new System.Drawing.Point(284, 389);
            this.btnEfetuarPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnEfetuarPagamento.Name = "btnEfetuarPagamento";
            this.btnEfetuarPagamento.Size = new System.Drawing.Size(63, 24);
            this.btnEfetuarPagamento.TabIndex = 26;
            this.btnEfetuarPagamento.Text = "Pagar";
            this.btnEfetuarPagamento.UseVisualStyleBackColor = true;
            this.btnEfetuarPagamento.Click += new System.EventHandler(this.btnEfetuarPagamento_Click);
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(12, 368);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(111, 13);
            this.lblCamposObrigatorios.TabIndex = 48;
            this.lblCamposObrigatorios.Text = "* Campos Obrigatórios";
            // 
            // GerCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(353, 66);
            this.Controls.Add(this.lblCamposObrigatorios);
            this.Controls.Add(this.btnEfetuarPagamento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.mTxtConsultar);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.cbConsultar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadVeiculo);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GerCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Cliente";
            this.Load += new System.EventHandler(this.GerCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mTxtCelular;
        private System.Windows.Forms.MaskedTextBox mTxtTelefone;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.CheckBox checkAlterarCliente;
        private System.Windows.Forms.Button btnApagarCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Button btnApagarVeiculo;
        private System.Windows.Forms.Button btnAlterarVeiculo;
        private System.Windows.Forms.Button btnCadVeiculo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.ComboBox cbConsultar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.MaskedTextBox mTxtConsultar;
        private System.Windows.Forms.Button btnEfetuarPagamento;
        private System.Windows.Forms.TextBox txtTipoCliente;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblTipoPlano;
        private System.Windows.Forms.ComboBox cbTipoPlano;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.Label lblValorPlano;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnAlterarPagamento;
        private System.Windows.Forms.Label lblCamposObrigatorios;
    }
}