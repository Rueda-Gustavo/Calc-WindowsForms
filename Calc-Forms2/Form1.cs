using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Forms2
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0, total, control = 0;
        string operacao = "";        
        public Form1()
        {
            InitializeComponent();            
        }        

        private void button0_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "9";
        }
        byte control2 = 0;
        private void buttonfloat_Click(object sender, EventArgs e)
        {
            if(control2 == 0)
            {
                lblResultado.Text += ",";
                control2 += 1;
            }                           
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                valor1 = double.Parse(lblResultado.Text);
                lblResultado.Text = "";
                operacao = "+";
                lblOperacao.Text = Convert.ToString(valor1) + " +";
            }
            if (operacao != "")
                operacao = "+";
                lblOperacao.Text = Convert.ToString(valor1) + " +";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                valor1 = double.Parse(lblResultado.Text);
                lblResultado.Text = "";
                operacao = "-";
                lblOperacao.Text = Convert.ToString(valor1) + " -";
            }
            if (operacao != "")
                operacao = "-";
                lblOperacao.Text = Convert.ToString(valor1) + " -";
        }

        private void buttonmult_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                valor1 = double.Parse(lblResultado.Text);
                lblResultado.Text = "";                
                operacao = "*";
                lblOperacao.Text = Convert.ToString(valor1) + " ×";
            }
            if (operacao != "")
                operacao = "*";
                lblOperacao.Text = Convert.ToString(valor1) + " ×";
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "÷")
            {
                valor1 = double.Parse(lblResultado.Text);
                lblResultado.Text = "";
                operacao = "/";
                lblOperacao.Text = Convert.ToString(valor1) + " ÷";
            }   
            if (operacao != "")
                operacao = "/";
                lblOperacao.Text = Convert.ToString(valor1) + " ÷";
        }

        private void buttonraiz_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                valor1 = double.Parse(lblResultado.Text);
                lblResultado.Text = Convert.ToString(Math.Sqrt(valor1));
            }
        }
        private void buttone_Click(object sender, EventArgs e)
        {
            double euler = Math.E;
            lblResultado.Text = euler.ToString("#.0000000000");
        }

        private void buttonpi_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            lblResultado.Text = pi.ToString("#.0000000000");
        }

        private void button_potencia_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                valor1 = double.Parse(lblResultado.Text);
                lblResultado.Text = "";
                lblOperacao.Text = Convert.ToString(valor1) + " ^";
                total = valor1;
                operacao = "^";
            }
        }

        private void buttonn_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                valor1 = double.Parse(lblResultado.Text);
                for (double i = valor1 - 1; i >= 1; i--)
                {
                    valor1 *= i;
                }
                lblResultado.Text = Convert.ToString(valor1);
            }
        }

        private void buttonce_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";            
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
            control = 0;
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {          
            if (lblResultado.Text != "")
            {
                if (control == 0)
                {
                    valor2 = double.Parse(lblResultado.Text);
                    control = 1;
                    control2 = 0;
                }
                else
                {
                    valor1 = double.Parse(lblResultado.Text);
                    control2 = 0;
                }
                switch (operacao)
                {
                    case "+":
                        total = valor1 + valor2;
                        lblOperacao.Text = ($"{valor1} + {valor2} = ");
                        lblResultado.Text = Convert.ToString(total);
                        break;
                    case "-":
                        total = valor1 - valor2;                        
                        lblOperacao.Text = ($"{valor1} - {valor2} = ");                        
                        lblResultado.Text = Convert.ToString(total);
                        
                        break;
                    case "*":
                        total = valor1 * valor2;
                        lblOperacao.Text = ($"{valor1} × {valor2} = ");
                        lblResultado.Text = Convert.ToString(total);
                        break;
                    case "/":
                        total = valor1 / valor2;
                        lblOperacao.Text = ($"{valor1} ÷ {valor2} = ");
                        lblResultado.Text = Convert.ToString(total);
                        break;
                    case "^":
                        for (int i = 1; i < valor2; i++)
                        {
                            total *= valor1;
                        }
                        lblOperacao.Text = ($"{valor1} ^ {valor2} = ");
                        lblResultado.Text = Convert.ToString(total);
                        break;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        int numero, usernum, usernum1 = 0, tentativa = 0;
        private void button_inicio_Click(object sender, EventArgs e)
        {
            Random numrand = new();
            numero = Convert.ToInt32(numrand.Next(1, 1000));
            button_inicio.Enabled = false;
            txtNum.ReadOnly = false;           
        }

        private void button_numRand_Click(object sender, EventArgs e)
        {            
            usernum = Int32.Parse(txtNum.Text);            
            if (usernum != numero)
            {
                if (usernum < numero)
                {
                    lblResult.Text = "Muito baixo";
                    if (tentativa == 0)
                    {
                        usernum1 = usernum;
                        tentativa += 1;
                    }
                    else
                    {
                        if (usernum1 < usernum)
                        {
                            NumRandom.BackColor = Color.OrangeRed;
                            lblDica.Text = "Mais Quente";
                            usernum1 = usernum;
                        }
                        else if (usernum1 > usernum)
                        {
                            NumRandom.BackColor = Color.DeepSkyBlue;
                            lblDica.Text = "Mais Frio";
                            usernum1 = usernum;
                        }
                    }
                }
                else if (usernum > numero)
                {
                    lblResult.Text = "Muito alto";
                    if (tentativa == 0)
                    {
                        usernum1 = usernum;
                        tentativa += 1;
                    }
                    else
                    {
                        if (usernum1 > usernum)
                        {
                            NumRandom.BackColor = Color.OrangeRed;
                            lblDica.Text = "Mais Quente";
                            usernum1 = usernum;
                        }
                        else if (usernum1 < usernum)
                        {
                            NumRandom.BackColor = Color.DeepSkyBlue;
                            lblDica.Text = "Mais Frio";
                            usernum1 = usernum;
                        }
                    }
                }               
            }
            else
            {
                txtNum.ReadOnly = true;
                NumRandom.BackColor = Color.LawnGreen;
                lblResult.Text = "Parabéns, você acertour!!!";
                lblDica.Text = "Para jogar novamente clique no botão \"Reset/Reiniciar\"";
            }
        }             

        private void button_reset_Click(object sender, EventArgs e)
        {
            txtNum.ReadOnly = false;
            button_inicio.Enabled = true;
            lblResult.Text = "";
            lblDica.Text = "";
            txtNum.Clear();
            NumRandom.BackColor = Color.Transparent;
        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {

        }               
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
