using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> entrada1 = new List<string>();
        string textoLabel = "";
        double resultado = 0.0;
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textoLabel);
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void atualizaLabel()
        {
            textoLabel = "";
            
            foreach (string caractere in entrada1)
            {
                textoLabel += caractere;
            }
            
            //label1.Text = entrada1.Where(e => e == "1").Select(e => e).FirstOrDefault();
            label1.Text = textoLabel;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            entrada1.Add("1");
            atualizaLabel();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            entrada1.Add("2");
            atualizaLabel();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            entrada1.Add("3");
            atualizaLabel();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            entrada1.Add("4");
            atualizaLabel();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            entrada1.Add("5");
            atualizaLabel();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            entrada1.Add("6");
            atualizaLabel();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            entrada1.Add("7");
            atualizaLabel();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            entrada1.Add("8");
            atualizaLabel();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            entrada1.Add("9");
            atualizaLabel();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            entrada1.Add("0");
            atualizaLabel();
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (entrada1.Contains(".")) return;
            entrada1.Add(".");
            atualizaLabel();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Array.Clear(entrada1, 0, entrada1.Count);
            entrada1.RemoveRange(0, entrada1.Count);
            atualizaLabel();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            entrada1.Add("+");
            atualizaLabel();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            entrada1.Add("-");
            atualizaLabel();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            entrada1.Add("*");
            atualizaLabel();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            entrada1.Add("/");
            atualizaLabel();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            calculaResultado();
            //mostraResultado();
        }


        private void calculaResultado()
        {
            string[] operadores = {"*", "/", "+", "-" };
            List<Object> operadoresPresentes = new List<Object>();


            if (!possuiOperador(entrada1, operadores)) return;
            
                        //int index = entrada1.Select((elem, index) => new { elem, index })
                        //   .First(p => p.elem == operadores[0])
                        //   .index;

            int index = entrada1.IndexOf(operadores[0]);
            MessageBox.Show(operadores[0], index.ToString());

            string[] primeiraParte = new string[index];
            string[] segundaParte = new string[entrada1.Count() - primeiraParte.Length];

            entrada1.CopyTo(0, primeiraParte, 0,  index);

            foreach (string st in primeiraParte)
                {
                    MessageBox.Show(st);
                }
        }


        private bool possuiOperador(List<String> lista, string[] operadores)
        {
            var possuiOp = lista.Where(x => x.Contains(operadores.ToString())).FirstOrDefault(); ;
            foreach (string operador in operadores)
                {
                    possuiOp = lista.Where(x => x.Equals(operador)).FirstOrDefault();
                if (possuiOp != null)
                {
                    return true;
                }
            }

            return false;
        }

        private void mostraResultado()
        {
            label1.Text = resultado.ToString();
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (entrada1.Count < 1) return;
            entrada1.RemoveAt(entrada1.Count-1);
            atualizaLabel();
        }
    }
}
