
namespace Calc_Forms2
{
    partial class Form1
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
            this.NumRandom = new System.Windows.Forms.TabPage();
            this.lblDica = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_inicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_numRand = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.Calculadora = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.buttone = new System.Windows.Forms.Button();
            this.button_potencia = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonraiz = new System.Windows.Forms.Button();
            this.buttonce = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonfloat = new System.Windows.Forms.Button();
            this.buttonn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonmult = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttonequal = new System.Windows.Forms.Button();
            this.buttonpi = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.NumRandom.SuspendLayout();
            this.Calculadora.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumRandom
            // 
            this.NumRandom.BackColor = System.Drawing.Color.Transparent;
            this.NumRandom.Controls.Add(this.lblDica);
            this.NumRandom.Controls.Add(this.lblResult);
            this.NumRandom.Controls.Add(this.label2);
            this.NumRandom.Controls.Add(this.button_reset);
            this.NumRandom.Controls.Add(this.button_inicio);
            this.NumRandom.Controls.Add(this.label1);
            this.NumRandom.Controls.Add(this.button_numRand);
            this.NumRandom.Controls.Add(this.txtNum);
            this.NumRandom.Location = new System.Drawing.Point(4, 24);
            this.NumRandom.Name = "NumRandom";
            this.NumRandom.Padding = new System.Windows.Forms.Padding(3);
            this.NumRandom.Size = new System.Drawing.Size(294, 310);
            this.NumRandom.TabIndex = 0;
            this.NumRandom.Text = "NumRandom";
            // 
            // lblDica
            // 
            this.lblDica.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDica.Location = new System.Drawing.Point(0, 207);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(294, 53);
            this.lblDica.TabIndex = 7;
            this.lblDica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(0, 174);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(294, 20);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 66);
            this.label2.TabIndex = 5;
            this.label2.Text = "Para iniciar o jogo clique no botão \"Começar\" e tente adivinhar o número entre 1 " +
    "e 1000.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_reset.Location = new System.Drawing.Point(180, 273);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(111, 34);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "Reset/Reiniciar";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_inicio
            // 
            this.button_inicio.BackColor = System.Drawing.Color.Transparent;
            this.button_inicio.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_inicio.Location = new System.Drawing.Point(109, 76);
            this.button_inicio.Name = "button_inicio";
            this.button_inicio.Size = new System.Drawing.Size(75, 34);
            this.button_inicio.TabIndex = 3;
            this.button_inicio.Text = "Começar";
            this.button_inicio.UseVisualStyleBackColor = false;
            this.button_inicio.Click += new System.EventHandler(this.button_inicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o número:";
            // 
            // button_numRand
            // 
            this.button_numRand.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_numRand.Location = new System.Drawing.Point(203, 119);
            this.button_numRand.Name = "button_numRand";
            this.button_numRand.Size = new System.Drawing.Size(88, 30);
            this.button_numRand.TabIndex = 1;
            this.button_numRand.Text = "Enviar";
            this.button_numRand.UseVisualStyleBackColor = true;
            this.button_numRand.Click += new System.EventHandler(this.button_numRand_Click);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum.Location = new System.Drawing.Point(150, 119);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(47, 29);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calculadora
            // 
            this.Calculadora.Controls.Add(this.panel1);
            this.Calculadora.Controls.Add(this.buttone);
            this.Calculadora.Controls.Add(this.button_potencia);
            this.Calculadora.Controls.Add(this.buttondiv);
            this.Calculadora.Controls.Add(this.button4);
            this.Calculadora.Controls.Add(this.buttonraiz);
            this.Calculadora.Controls.Add(this.buttonce);
            this.Calculadora.Controls.Add(this.button2);
            this.Calculadora.Controls.Add(this.buttonfloat);
            this.Calculadora.Controls.Add(this.buttonn);
            this.Calculadora.Controls.Add(this.button3);
            this.Calculadora.Controls.Add(this.button5);
            this.Calculadora.Controls.Add(this.button1);
            this.Calculadora.Controls.Add(this.buttonplus);
            this.Calculadora.Controls.Add(this.buttonc);
            this.Calculadora.Controls.Add(this.button0);
            this.Calculadora.Controls.Add(this.button7);
            this.Calculadora.Controls.Add(this.buttonmult);
            this.Calculadora.Controls.Add(this.button6);
            this.Calculadora.Controls.Add(this.button8);
            this.Calculadora.Controls.Add(this.button9);
            this.Calculadora.Controls.Add(this.buttonminus);
            this.Calculadora.Controls.Add(this.buttonequal);
            this.Calculadora.Controls.Add(this.buttonpi);
            this.Calculadora.Location = new System.Drawing.Point(4, 24);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Padding = new System.Windows.Forms.Padding(3);
            this.Calculadora.Size = new System.Drawing.Size(294, 310);
            this.Calculadora.TabIndex = 1;
            this.Calculadora.Text = "Calculadora";
            this.Calculadora.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.lblOperacao);
            this.panel1.Location = new System.Drawing.Point(4, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 67);
            this.panel1.TabIndex = 29;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoEllipsis = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(-1, 33);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(283, 33);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacao.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOperacao.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOperacao.Location = new System.Drawing.Point(282, 0);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 26);
            this.lblOperacao.TabIndex = 1;
            this.lblOperacao.Click += new System.EventHandler(this.lblOperacao_Click);
            // 
            // buttone
            // 
            this.buttone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttone.Location = new System.Drawing.Point(120, 81);
            this.buttone.Name = "buttone";
            this.buttone.Size = new System.Drawing.Size(52, 40);
            this.buttone.TabIndex = 28;
            this.buttone.Text = "e";
            this.buttone.UseVisualStyleBackColor = true;
            this.buttone.Click += new System.EventHandler(this.buttone_Click);
            // 
            // button_potencia
            // 
            this.button_potencia.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_potencia.Location = new System.Drawing.Point(236, 81);
            this.button_potencia.Name = "button_potencia";
            this.button_potencia.Size = new System.Drawing.Size(52, 40);
            this.button_potencia.TabIndex = 27;
            this.button_potencia.Text = "^";
            this.button_potencia.UseVisualStyleBackColor = true;
            this.button_potencia.Click += new System.EventHandler(this.button_potencia_Click);
            // 
            // buttondiv
            // 
            this.buttondiv.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttondiv.Location = new System.Drawing.Point(178, 265);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(52, 40);
            this.buttondiv.TabIndex = 15;
            this.buttondiv.Text = "÷";
            this.buttondiv.UseVisualStyleBackColor = true;
            this.buttondiv.Click += new System.EventHandler(this.buttondiv_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(4, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonraiz
            // 
            this.buttonraiz.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonraiz.Location = new System.Drawing.Point(62, 81);
            this.buttonraiz.Name = "buttonraiz";
            this.buttonraiz.Size = new System.Drawing.Size(52, 40);
            this.buttonraiz.TabIndex = 26;
            this.buttonraiz.Text = "√";
            this.buttonraiz.UseVisualStyleBackColor = true;
            this.buttonraiz.Click += new System.EventHandler(this.buttonraiz_Click);
            // 
            // buttonce
            // 
            this.buttonce.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonce.Location = new System.Drawing.Point(236, 127);
            this.buttonce.Name = "buttonce";
            this.buttonce.Size = new System.Drawing.Size(52, 40);
            this.buttonce.TabIndex = 18;
            this.buttonce.Text = "CE";
            this.buttonce.UseVisualStyleBackColor = true;
            this.buttonce.Click += new System.EventHandler(this.buttonce_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(62, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonfloat
            // 
            this.buttonfloat.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonfloat.Location = new System.Drawing.Point(120, 265);
            this.buttonfloat.Name = "buttonfloat";
            this.buttonfloat.Size = new System.Drawing.Size(52, 40);
            this.buttonfloat.TabIndex = 2;
            this.buttonfloat.Text = ".";
            this.buttonfloat.UseVisualStyleBackColor = true;
            this.buttonfloat.Click += new System.EventHandler(this.buttonfloat_Click);
            // 
            // buttonn
            // 
            this.buttonn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonn.Location = new System.Drawing.Point(4, 81);
            this.buttonn.Name = "buttonn";
            this.buttonn.Size = new System.Drawing.Size(52, 40);
            this.buttonn.TabIndex = 20;
            this.buttonn.Text = "n!";
            this.buttonn.UseVisualStyleBackColor = true;
            this.buttonn.Click += new System.EventHandler(this.buttonn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(120, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(62, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(4, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 40);
            this.button1.TabIndex = 25;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonplus
            // 
            this.buttonplus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonplus.Location = new System.Drawing.Point(178, 127);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(52, 40);
            this.buttonplus.TabIndex = 12;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // buttonc
            // 
            this.buttonc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonc.Location = new System.Drawing.Point(236, 173);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(52, 40);
            this.buttonc.TabIndex = 17;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(4, 265);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(110, 40);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(4, 127);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 40);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonmult
            // 
            this.buttonmult.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonmult.Location = new System.Drawing.Point(178, 219);
            this.buttonmult.Name = "buttonmult";
            this.buttonmult.Size = new System.Drawing.Size(52, 40);
            this.buttonmult.TabIndex = 14;
            this.buttonmult.Text = "×";
            this.buttonmult.UseVisualStyleBackColor = true;
            this.buttonmult.Click += new System.EventHandler(this.buttonmult_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(120, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 40);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(62, 127);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 40);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(120, 127);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 40);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonminus
            // 
            this.buttonminus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonminus.Location = new System.Drawing.Point(178, 173);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(52, 40);
            this.buttonminus.TabIndex = 13;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.buttonminus_Click);
            // 
            // buttonequal
            // 
            this.buttonequal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonequal.Location = new System.Drawing.Point(236, 219);
            this.buttonequal.Name = "buttonequal";
            this.buttonequal.Size = new System.Drawing.Size(52, 86);
            this.buttonequal.TabIndex = 16;
            this.buttonequal.Text = "=";
            this.buttonequal.UseVisualStyleBackColor = true;
            this.buttonequal.Click += new System.EventHandler(this.buttonequal_Click);
            // 
            // buttonpi
            // 
            this.buttonpi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonpi.Location = new System.Drawing.Point(178, 81);
            this.buttonpi.Name = "buttonpi";
            this.buttonpi.Size = new System.Drawing.Size(52, 40);
            this.buttonpi.TabIndex = 23;
            this.buttonpi.Text = "π";
            this.buttonpi.UseVisualStyleBackColor = true;
            this.buttonpi.Click += new System.EventHandler(this.buttonpi_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Calculadora);
            this.tabControl1.Controls.Add(this.NumRandom);
            this.tabControl1.Location = new System.Drawing.Point(8, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(302, 338);
            this.tabControl1.TabIndex = 24;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 354);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Calculadora  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NumRandom.ResumeLayout(false);
            this.NumRandom.PerformLayout();
            this.Calculadora.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage NumRandom;
        private System.Windows.Forms.TabPage Calculadora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button buttone;
        private System.Windows.Forms.Button button_potencia;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonraiz;
        private System.Windows.Forms.Button buttonce;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonfloat;
        private System.Windows.Forms.Button buttonn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonmult;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttonequal;
        private System.Windows.Forms.Button buttonpi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button_numRand;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDica;
    }
}

