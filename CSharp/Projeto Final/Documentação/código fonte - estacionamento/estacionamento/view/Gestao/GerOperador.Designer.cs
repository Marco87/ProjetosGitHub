﻿namespace Estacionamento.View.Gestao
{
    partial class GerOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerOperador));
            this.checkAlterarOperador = new System.Windows.Forms.CheckBox();
            this.btnApagarOperador = new System.Windows.Forms.Button();
            this.btnConsultarLogin = new System.Windows.Forms.Button();
            this.lblLoginConsulta = new System.Windows.Forms.Label();
            this.mTxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.mTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnAltOperador = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.txtConsultarLogin = new System.Windows.Forms.TextBox();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkAlterarOperador
            // 
            this.checkAlterarOperador.AutoSize = true;
            this.checkAlterarOperador.Location = new System.Drawing.Point(113, 178);
            this.checkAlterarOperador.Margin = new System.Windows.Forms.Padding(2);
            this.checkAlterarOperador.Name = "checkAlterarOperador";
            this.checkAlterarOperador.Size = new System.Drawing.Size(150, 17);
            this.checkAlterarOperador.TabIndex = 11;
            this.checkAlterarOperador.Text = "Alterar dados do Operador";
            this.checkAlterarOperador.UseVisualStyleBackColor = true;
            this.checkAlterarOperador.CheckedChanged += new System.EventHandler(this.checkAlterarOperador_CheckedChanged);
            // 
            // btnApagarOperador
            // 
            this.btnApagarOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarOperador.Location = new System.Drawing.Point(181, 295);
            this.btnApagarOperador.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagarOperador.Name = "btnApagarOperador";
            this.btnApagarOperador.Size = new System.Drawing.Size(63, 24);
            this.btnApagarOperador.TabIndex = 13;
            this.btnApagarOperador.Text = "Apaga";
            this.btnApagarOperador.UseVisualStyleBackColor = true;
            this.btnApagarOperador.Click += new System.EventHandler(this.btnApagarOperador_Click);
            // 
            // btnConsultarLogin
            // 
            this.btnConsultarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarLogin.Location = new System.Drawing.Point(247, 31);
            this.btnConsultarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarLogin.Name = "btnConsultarLogin";
            this.btnConsultarLogin.Size = new System.Drawing.Size(63, 24);
            this.btnConsultarLogin.TabIndex = 2;
            this.btnConsultarLogin.Text = "Consulta";
            this.btnConsultarLogin.UseVisualStyleBackColor = true;
            this.btnConsultarLogin.Click += new System.EventHandler(this.btnConsultarLogin_Click);
            // 
            // lblLoginConsulta
            // 
            this.lblLoginConsulta.AutoSize = true;
            this.lblLoginConsulta.Location = new System.Drawing.Point(14, 7);
            this.lblLoginConsulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginConsulta.Name = "lblLoginConsulta";
            this.lblLoginConsulta.Size = new System.Drawing.Size(130, 13);
            this.lblLoginConsulta.TabIndex = 81;
            this.lblLoginConsulta.Text = "Digite o login do Operador";
            // 
            // mTxtCelular
            // 
            this.mTxtCelular.Location = new System.Drawing.Point(83, 58);
            this.mTxtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtCelular.Mask = "(99) 00000-0000";
            this.mTxtCelular.Name = "mTxtCelular";
            this.mTxtCelular.Size = new System.Drawing.Size(203, 20);
            this.mTxtCelular.TabIndex = 6;
            // 
            // mTxtTelefone
            // 
            this.mTxtTelefone.Location = new System.Drawing.Point(83, 36);
            this.mTxtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtTelefone.Mask = "(99) 0000-0000";
            this.mTxtTelefone.Name = "mTxtTelefone";
            this.mTxtTelefone.Size = new System.Drawing.Size(203, 20);
            this.mTxtTelefone.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(83, 151);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(203, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(11, 154);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 75;
            this.lblSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(83, 128);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(203, 20);
            this.txtLogin.TabIndex = 9;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(11, 132);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 73;
            this.lblLogin.Text = "Login";
            // 
            // btnAltOperador
            // 
            this.btnAltOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltOperador.Location = new System.Drawing.Point(248, 295);
            this.btnAltOperador.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltOperador.Name = "btnAltOperador";
            this.btnAltOperador.Size = new System.Drawing.Size(63, 24);
            this.btnAltOperador.TabIndex = 14;
            this.btnAltOperador.Text = "Ok";
            this.btnAltOperador.UseVisualStyleBackColor = true;
            this.btnAltOperador.Click += new System.EventHandler(this.btnAltOperador_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(83, 106);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(203, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(11, 109);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 70;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(83, 83);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 86);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 68;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(11, 64);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 67;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(11, 41);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 66;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(83, 15);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 18);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 64;
            this.lblNome.Text = "Nome";
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(168, 31);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(63, 24);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.checkAlterarOperador);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblCelular);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.mTxtCelular);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.mTxtTelefone);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.lblSenha);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 205);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "*";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCampos.Location = new System.Drawing.Point(12, 295);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(63, 24);
            this.btnLimparCampos.TabIndex = 12;
            this.btnLimparCampos.Text = "Limpa";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // txtConsultarLogin
            // 
            this.txtConsultarLogin.Location = new System.Drawing.Point(153, 4);
            this.txtConsultarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarLogin.Name = "txtConsultarLogin";
            this.txtConsultarLogin.Size = new System.Drawing.Size(78, 20);
            this.txtConsultarLogin.TabIndex = 1;
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(15, 273);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(104, 13);
            this.lblCamposObrigatorios.TabIndex = 91;
            this.lblCamposObrigatorios.Text = "Campos Obrigatórios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(7, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "*";
            // 
            // GerOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(321, 60);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCamposObrigatorios);
            this.Controls.Add(this.txtConsultarLogin);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnApagarOperador);
            this.Controls.Add(this.btnConsultarLogin);
            this.Controls.Add(this.lblLoginConsulta);
            this.Controls.Add(this.btnAltOperador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GerOperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Operador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkAlterarOperador;
        private System.Windows.Forms.Button btnApagarOperador;
        private System.Windows.Forms.Button btnConsultarLogin;
        private System.Windows.Forms.Label lblLoginConsulta;
        private System.Windows.Forms.MaskedTextBox mTxtCelular;
        private System.Windows.Forms.MaskedTextBox mTxtTelefone;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnAltOperador;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.TextBox txtConsultarLogin;
        private System.Windows.Forms.Label lblCamposObrigatorios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}