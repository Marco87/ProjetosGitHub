﻿namespace Estacionamento.View.Gestao
{
    partial class ConsuVagaAndar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsuVagaAndar));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAndar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Qual o andar que você deseja consultar?";
            // 
            // comboBoxAndar
            // 
            this.comboBoxAndar.FormattingEnabled = true;
            this.comboBoxAndar.Location = new System.Drawing.Point(85, 46);
            this.comboBoxAndar.Name = "comboBoxAndar";
            this.comboBoxAndar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAndar.TabIndex = 4;
            this.comboBoxAndar.Text = "Andar";
            this.comboBoxAndar.Click += new System.EventHandler(this.comboBoxAndar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buVoltar
            // 
            this.buVoltar.Location = new System.Drawing.Point(220, 143);
            this.buVoltar.Name = "buVoltar";
            this.buVoltar.Size = new System.Drawing.Size(63, 23);
            this.buVoltar.TabIndex = 6;
            this.buVoltar.Text = "Voltar";
            this.buVoltar.UseVisualStyleBackColor = true;
            this.buVoltar.Click += new System.EventHandler(this.buVoltar_Click);
            // 
            // ConsuVagaAndar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.buVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAndar);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsuVagaAndar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Andar";
            this.Load += new System.EventHandler(this.ConsuVagaAndar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAndar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buVoltar;
    }
}