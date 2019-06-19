using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalc
{
    public class ButnClic
    {
        public double a = 0; // хранение первого числа
        public double b = 0; // хранение второго числа
        public string c = "";   // хранение знака математического действия

        // =============================
        private string _displShow = ""; //show this string on Calculator-Display

        // метод для вывода на Дислей
        public string DisplShow()
        {
            return this._displShow;
        }
        // =====end to Displey , start button-Click========================

        public void AnyBtnClic(string anyBtn)
        {
            switch (anyBtn)
            {
                case "0":
                    if (_displShow.Equals("0")) // вывод только одного нуля
                    {
                    }
                    else _displShow += "0";

                    break;
                case "1":
                    _displShow += "1";
                    break;
                case "2":
                    _displShow += "2";
                    break;
                case "3":
                    _displShow += "3";
                    break;
                case "4":
                    _displShow += "4";
                    break;
                case "5":
                    _displShow += "5";
                    break;
                case "6":
                    _displShow += "6";
                    break;
                case "7":
                    _displShow += "7";
                    break;
                case "8":
                    _displShow += "8";
                    break;
                case "9":
                    _displShow += "9";
                    break;
                case "dot":
                    if (_displShow.Contains(".")) // вывод только одной точки
                    {
                    }
                    else _displShow += ".";
                    break;
                case "Clear":
                    a = 0;
                    b = 0;
                    _displShow = "";                  // than make display empty
                    c = "";                            // what to do
                    break;
                case "ClearLast":
                    string s = _displShow;
                    if ((s.Length) > 0)        // проверка = есть ли что удалить? 
                    {
                        s = s.Substring(0, s.Length - 1);
                    }
                    _displShow = s;
                    break;
                case "plus":
                    if ((_displShow.Length) == 0)   // no numbers on display
                    {
                        _displShow += "";
                        // here need to add extension 
                    }
                    else
                    {
                        a = Convert.ToDouble(_displShow); // first number from display
                        _displShow = "";                  // than make display empty
                        c = "+";                            // what to do
                    }
                    break;
                case "minus":
                    // надо подумать о вводе А как отрицательного числа 
                    if ((_displShow.Length) == 0)
                    {
                        _displShow += "-";          // set display as negative "-"   
                    }
                    else if (_displShow.StartsWith("-")) // смена знака
                    {
                        _displShow = "";          // convert display from negative (clear "-")
                    }

                    else  // делаем операцию вычитания 
                    {

                        a = Convert.ToDouble(_displShow); // first number from display
                        _displShow = "";                  // than make display empty
                        c = "-";                            // what to do

                    }
                    break;
                case "mult":
                    if ((_displShow.Length) == 0)   // no numbers on display
                    {
                        _displShow += "";
                    }
                    else
                    {
                        a = Convert.ToDouble(_displShow); // first number from display
                        _displShow = "";                  // than make display empty
                        c = "*";                            // what to do
                    }
                    break;
                case "div":
                    if ((_displShow.Length) == 0)   // no numbers on display
                    {
                        _displShow += "";
                    }
                    else
                    {
                        a = Convert.ToDouble(_displShow); // first number from display
                        _displShow = "";                  // than make display empty
                        c = "/";                          // what to do
                    }
                    break;
                case "do":
                    if ((_displShow.Length) == 0)   // no numbers on display
                    {
                        _displShow += "";
                        b = a;
                    }
                    else
                    {
                        b = Convert.ToDouble(_displShow); // second number from display
                        _displShow = "";                  // than make display empty
                    }
                    switch (c)
                    {
                        case "+":
                            _displShow = Convert.ToString(Sum(a, b));
                            break;
                        case "-":
                            _displShow = Convert.ToString(Vych(a, b));
                            break;
                        case "*":
                            _displShow = Convert.ToString(Umno(a, b));
                            break;
                        case "/":
                            if (b == 0)  // деление на ноль
                            {
                                _displShow = "Помилка";
                                break;
                            }
                            _displShow = Convert.ToString(Delen(a, b));
                            break;
                    }
                    break;
            }


        }
        // end button-Click
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Vych(double a, double b)
        {
            return a - b;
        }
        public double Umno(double a, double b)
        {
            return a * b;
        }
        public double Delen(double a, double b)
        {
            return a / b;
        }
    }
}
