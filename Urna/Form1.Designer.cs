﻿namespace Urna
{
    partial class frmUrna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlExibicao = new System.Windows.Forms.Panel();
            this.lblExibicaoTime = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNomePopular = new System.Windows.Forms.Label();
            this.lblNomeTime = new System.Windows.Forms.Label();
            this.lblNomeTime2 = new System.Windows.Forms.Label();
            this.lblNomePopular2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.pctBoxTimes = new System.Windows.Forms.PictureBox();
            this.btnCorrige = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblNumero3 = new System.Windows.Forms.Label();
            this.lblNumero4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlExibicao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnCorrige);
            this.panel1.Controls.Add(this.btnBranco);
            this.panel1.Controls.Add(this.btnConfirma);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(621, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 398);
            this.panel1.TabIndex = 0;
            // 
            // pnlExibicao
            // 
            this.pnlExibicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlExibicao.Controls.Add(this.lblNumero4);
            this.pnlExibicao.Controls.Add(this.lblNumero3);
            this.pnlExibicao.Controls.Add(this.lblNumero2);
            this.pnlExibicao.Controls.Add(this.lblNumero1);
            this.pnlExibicao.Controls.Add(this.lblNomePopular2);
            this.pnlExibicao.Controls.Add(this.lblNomeTime2);
            this.pnlExibicao.Controls.Add(this.lblNomeTime);
            this.pnlExibicao.Controls.Add(this.lblNomePopular);
            this.pnlExibicao.Controls.Add(this.lblNumero);
            this.pnlExibicao.Controls.Add(this.lblExibicaoTime);
            this.pnlExibicao.Controls.Add(this.pctBoxTimes);
            this.pnlExibicao.Location = new System.Drawing.Point(39, 179);
            this.pnlExibicao.Name = "pnlExibicao";
            this.pnlExibicao.Size = new System.Drawing.Size(548, 397);
            this.pnlExibicao.TabIndex = 1;
            // 
            // lblExibicaoTime
            // 
            this.lblExibicaoTime.AutoSize = true;
            this.lblExibicaoTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibicaoTime.Location = new System.Drawing.Point(156, 59);
            this.lblExibicaoTime.Name = "lblExibicaoTime";
            this.lblExibicaoTime.Size = new System.Drawing.Size(207, 33);
            this.lblExibicaoTime.TabIndex = 1;
            this.lblExibicaoTime.Text = "Nome do Time";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(39, 175);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(93, 25);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número:";
            // 
            // lblNomePopular
            // 
            this.lblNomePopular.AutoSize = true;
            this.lblNomePopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePopular.Location = new System.Drawing.Point(39, 300);
            this.lblNomePopular.Name = "lblNomePopular";
            this.lblNomePopular.Size = new System.Drawing.Size(154, 25);
            this.lblNomePopular.TabIndex = 3;
            this.lblNomePopular.Text = "Nome Popular:";
            // 
            // lblNomeTime
            // 
            this.lblNomeTime.AutoSize = true;
            this.lblNomeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTime.Location = new System.Drawing.Point(39, 246);
            this.lblNomeTime.Name = "lblNomeTime";
            this.lblNomeTime.Size = new System.Drawing.Size(74, 25);
            this.lblNomeTime.TabIndex = 4;
            this.lblNomeTime.Text = "Nome:";
            // 
            // lblNomeTime2
            // 
            this.lblNomeTime2.AutoSize = true;
            this.lblNomeTime2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomeTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTime2.Location = new System.Drawing.Point(119, 246);
            this.lblNomeTime2.Name = "lblNomeTime2";
            this.lblNomeTime2.Size = new System.Drawing.Size(26, 27);
            this.lblNomeTime2.TabIndex = 5;
            this.lblNomeTime2.Text = "  ";
            // 
            // lblNomePopular2
            // 
            this.lblNomePopular2.AutoSize = true;
            this.lblNomePopular2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomePopular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePopular2.Location = new System.Drawing.Point(199, 300);
            this.lblNomePopular2.Name = "lblNomePopular2";
            this.lblNomePopular2.Size = new System.Drawing.Size(26, 27);
            this.lblNomePopular2.TabIndex = 6;
            this.lblNomePopular2.Text = "  ";
            this.lblNomePopular2.Click += new System.EventHandler(this.lblNomePopular2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pctBoxLogo);
            this.panel2.Location = new System.Drawing.Point(41, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 108);
            this.panel2.TabIndex = 2;
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.BackColor = System.Drawing.Color.White;
            this.pctBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctBoxLogo.Image = global::Urna.Properties.Resources.supremo;
            this.pctBoxLogo.Location = new System.Drawing.Point(26, 8);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(104, 91);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLogo.TabIndex = 7;
            this.pctBoxLogo.TabStop = false;
            // 
            // pctBoxTimes
            // 
            this.pctBoxTimes.BackColor = System.Drawing.Color.White;
            this.pctBoxTimes.Location = new System.Drawing.Point(403, 14);
            this.pctBoxTimes.Name = "pctBoxTimes";
            this.pctBoxTimes.Size = new System.Drawing.Size(128, 122);
            this.pctBoxTimes.TabIndex = 0;
            this.pctBoxTimes.TabStop = false;
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackgroundImage = global::Urna.Properties.Resources.corrige;
            this.btnCorrige.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCorrige.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorrige.Location = new System.Drawing.Point(130, 305);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.Size = new System.Drawing.Size(98, 50);
            this.btnCorrige.TabIndex = 12;
            this.btnCorrige.UseVisualStyleBackColor = true;
            // 
            // btnBranco
            // 
            this.btnBranco.BackgroundImage = global::Urna.Properties.Resources.branco;
            this.btnBranco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBranco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBranco.Location = new System.Drawing.Point(26, 305);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(98, 50);
            this.btnBranco.TabIndex = 11;
            this.btnBranco.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::Urna.Properties.Resources.confirma;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirma.Location = new System.Drawing.Point(234, 246);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(95, 109);
            this.btnConfirma.TabIndex = 10;
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.BackgroundImage = global::Urna.Properties.Resources._0;
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Location = new System.Drawing.Point(142, 243);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 56);
            this.btn0.TabIndex = 9;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn9
            // 
            this.btn9.BackgroundImage = global::Urna.Properties.Resources._9;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Location = new System.Drawing.Point(236, 177);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(74, 56);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.BackgroundImage = global::Urna.Properties.Resources._8;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Location = new System.Drawing.Point(142, 177);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(74, 56);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.BackgroundImage = global::Urna.Properties.Resources._7;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Location = new System.Drawing.Point(50, 177);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 56);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.BackgroundImage = global::Urna.Properties.Resources._6;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Location = new System.Drawing.Point(234, 115);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(74, 56);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.BackgroundImage = global::Urna.Properties.Resources._5;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Location = new System.Drawing.Point(142, 115);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(74, 56);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = global::Urna.Properties.Resources._4;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Location = new System.Drawing.Point(50, 115);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 56);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = global::Urna.Properties.Resources._3;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Location = new System.Drawing.Point(234, 53);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(74, 56);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = global::Urna.Properties.Resources._2;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Location = new System.Drawing.Point(142, 53);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(74, 56);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = global::Urna.Properties.Resources._1;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Location = new System.Drawing.Point(50, 53);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 56);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "SUPREMO TRIBUNAL ELEITORAL DOS TIMES - STET";
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.BackColor = System.Drawing.Color.White;
            this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(138, 159);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(67, 59);
            this.lblNumero1.TabIndex = 7;
            this.lblNumero1.Text = "   ";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.BackColor = System.Drawing.Color.White;
            this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(211, 159);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(67, 59);
            this.lblNumero2.TabIndex = 8;
            this.lblNumero2.Text = "   ";
            // 
            // lblNumero3
            // 
            this.lblNumero3.AutoSize = true;
            this.lblNumero3.BackColor = System.Drawing.Color.White;
            this.lblNumero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero3.Location = new System.Drawing.Point(284, 159);
            this.lblNumero3.Name = "lblNumero3";
            this.lblNumero3.Size = new System.Drawing.Size(67, 59);
            this.lblNumero3.TabIndex = 9;
            this.lblNumero3.Text = "   ";
            // 
            // lblNumero4
            // 
            this.lblNumero4.AutoSize = true;
            this.lblNumero4.BackColor = System.Drawing.Color.White;
            this.lblNumero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero4.Location = new System.Drawing.Point(357, 159);
            this.lblNumero4.Name = "lblNumero4";
            this.lblNumero4.Size = new System.Drawing.Size(67, 59);
            this.lblNumero4.TabIndex = 10;
            this.lblNumero4.Text = "   ";
            // 
            // frmUrna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlExibicao);
            this.Controls.Add(this.panel1);
            this.Name = "frmUrna";
            this.Text = "SUPREMO TRIBUNAL ELEITORAL DOS TIMES - STET";
            this.panel1.ResumeLayout(false);
            this.pnlExibicao.ResumeLayout(false);
            this.pnlExibicao.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnCorrige;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Panel pnlExibicao;
        private System.Windows.Forms.Label lblExibicaoTime;
        private System.Windows.Forms.PictureBox pctBoxTimes;
        private System.Windows.Forms.Label lblNomeTime2;
        private System.Windows.Forms.Label lblNomeTime;
        private System.Windows.Forms.Label lblNomePopular;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNomePopular2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero4;
        private System.Windows.Forms.Label lblNumero3;
    }
}

