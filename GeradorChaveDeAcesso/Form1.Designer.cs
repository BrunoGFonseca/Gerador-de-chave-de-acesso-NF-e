﻿namespace GeradorChaveDeAcesso
{
    partial class GeradorChaveDeAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeradorChaveDeAcesso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.dtpMes = new System.Windows.Forms.DateTimePicker();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.btnGerarChave = new System.Windows.Forms.Button();
            this.txtChaveAcesso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mês";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Série";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Número";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(49, 6);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(60, 21);
            this.cmbEstado.TabIndex = 0;
            // 
            // dtpAno
            // 
            this.dtpAno.CustomFormat = "yy";
            this.dtpAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAno.Location = new System.Drawing.Point(147, 6);
            this.dtpAno.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpAno.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.Size = new System.Drawing.Size(60, 20);
            this.dtpAno.TabIndex = 1;
            this.dtpAno.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dtpMes
            // 
            this.dtpMes.CustomFormat = "MM";
            this.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMes.Location = new System.Drawing.Point(246, 7);
            this.dtpMes.Name = "dtpMes";
            this.dtpMes.Size = new System.Drawing.Size(52, 20);
            this.dtpMes.TabIndex = 2;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Location = new System.Drawing.Point(49, 36);
            this.mtbCNPJ.Mask = "00.000.000/0000-00";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(112, 20);
            this.mtbCNPJ.TabIndex = 3;
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(246, 33);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(52, 21);
            this.cmbModelo.TabIndex = 4;
            // 
            // btnGerarChave
            // 
            this.btnGerarChave.Location = new System.Drawing.Point(12, 104);
            this.btnGerarChave.Name = "btnGerarChave";
            this.btnGerarChave.Size = new System.Drawing.Size(62, 23);
            this.btnGerarChave.TabIndex = 7;
            this.btnGerarChave.Text = "Gerar";
            this.btnGerarChave.UseVisualStyleBackColor = true;
            this.btnGerarChave.Click += new System.EventHandler(this.BtnGerarChave_Click);
            // 
            // txtChaveAcesso
            // 
            this.txtChaveAcesso.Location = new System.Drawing.Point(12, 157);
            this.txtChaveAcesso.Name = "txtChaveAcesso";
            this.txtChaveAcesso.Size = new System.Drawing.Size(287, 20);
            this.txtChaveAcesso.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Chave de acesso";
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(164, 104);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(67, 23);
            this.btnLimp.TabIndex = 8;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(80, 104);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(78, 23);
            this.btnInfo.TabIndex = 9;
            this.btnInfo.Text = "Informações";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(49, 66);
            this.txtserie.MaxLength = 3;
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(78, 20);
            this.txtserie.TabIndex = 19;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(220, 66);
            this.txtNum.MaxLength = 9;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(78, 20);
            this.txtNum.TabIndex = 20;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(237, 104);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(62, 23);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // GeradorChaveDeAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 183);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChaveAcesso);
            this.Controls.Add(this.btnGerarChave);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.dtpMes);
            this.Controls.Add(this.dtpAno);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeradorChaveDeAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de chave de acesso NF-e";
            this.Load += new System.EventHandler(this.GeradorChaveDeAcesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dtpAno;
        private System.Windows.Forms.DateTimePicker dtpMes;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Button btnGerarChave;
        private System.Windows.Forms.TextBox txtChaveAcesso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnNovo;
    }
}

