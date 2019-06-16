using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalc
{
    public partial class IgGoCalc : Form
    {
        public IgGoCalc()
        {
            InitializeComponent();
        }

        public double a = 0; // хранение первого числа
        public double b = 0; // хранение второго числа
        public string c = "";   // хранение знака математического действия
        bool tochka = false;  // признак наличия точки при вводе чисел

        private void Btn_0_Click(object sender, EventArgs e)
        {
            if (displey.Text == "0")
            {
                displey.Text = "0";
            }
            else displey.Text += "0";
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            displey.Text += "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            displey.Text += "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            displey.Text += "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            displey.Text += "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            displey.Text += "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            displey.Text += "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            displey.Text += "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            displey.Text += "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            displey.Text += "9";
        }

        private void Btn_dot_Click(object sender, EventArgs e)
        {
            // надо вставить проверку на наличие точки
            if (tochka == false)
            {
                tochka = true;
                displey.Text += ".";
            }
            else { }
        }

        private void Btn_plus_Click(object sender, EventArgs e)
        {
            string s = displey.Text;
            if ((s.Length) == 0)   // no numbers on display
            {
                displey.Text += "";             

            }
            else
            {
                a = Convert.ToDouble(displey.Text); // first number from display
                displey.Text = "";                  // than make display empty
                tochka = false;
                c = "+";                            // what to do
            }
                      
            
            
        }

        private void Btn_minus_Click(object sender, EventArgs e)
        {
            // надо подумать о вводе А как отрицательного числа 
            string s = displey.Text;
            if ((s.Length) == 0)
            {
                displey.Text += "-";          // set display as negative "-"   

            }
            else if (s == "-") // смена знака
            {
                displey.Text = "";          // convert display from negative (clear "-")
            }
            
            else  // делаем операцию вычитания 
            {
                
                a = Convert.ToDouble(displey.Text); // first number from display
                displey.Text = "";                  // than make display empty
                tochka = false;
                c = "-";                            // what to do

            }
        }

        private void Btn_mult_Click(object sender, EventArgs e)
        {
            string s = displey.Text;
            if ((s.Length) == 0)   // no numbers on display
            {
                displey.Text += "";

            }
            else
            {
                a = Convert.ToDouble(displey.Text); // first number from display
                displey.Text = "";                  // than make display empty
                tochka = false;
                c = "*";                            // what to do
            }
        }

        private void Btn_div_Click(object sender, EventArgs e)
        {
            string s = displey.Text;
            if ((s.Length) == 0)   // no numbers on display
            {
                displey.Text += "";

            }
            else
            {
                a = Convert.ToDouble(displey.Text); // first number from display
                displey.Text = "";                  // than make display empty
                tochka = false;
                c = "/";                            // what to do
            }
        }

        private void Btn_do_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(displey.Text); // second number from display
            displey.Text = "";                  // than make display empty
            switch (c)
            {
                case "+":
                    displey.Text = Convert.ToString(a + b);
                    break;
                case "-":
                    displey.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    displey.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    if (b == 0)  // деление на ноль
                    {
                        displey.Text = "Помилка";
                        break;
                    }
                    displey.Text = Convert.ToString(a / b);
                    break;

            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            displey.Text = "";                  // than make display empty
            c = "";                            // what to do
            tochka = false;
        }

        private void Btn_ce_Click(object sender, EventArgs e)
        {
            string s = displey.Text;
            if ((s.Length) > 0)        // проверка = есть ли что удалить? 
            {
                s = s.Substring(0, s.Length - 1);
            }
            displey.Text = s;
        }
    }
}
