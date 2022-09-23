using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator_SOLID
{
    internal class Calculator
    {
       
        internal virtual string  CharAnaliz(char Action, double Num1, double Num2, string text)
        {
            
            switch (Action)
            {
                case '+':
                    text = Convert.ToString(Plus(Num1, Num2));
                    break;
                case '-':
                    text = Convert.ToString(Minus(Num1, Num2));
                    break;
                case '*':
                    text = Convert.ToString(Multiplication(Num1, Num2));
                    break;
                case '/':
                    text = Convert.ToString(Divide(Num1, Num2));
                    break;
                default:
                    
                    break;
            }
            return text;
        }

       internal virtual double Plus(double Num1, double Num2)
        {
            return Num1 += Num2;
        }
        internal virtual double Minus(double Num1, double Num2)
        {
            return Num1 -= Num2;
        }
        internal virtual double Multiplication(double Num1, double Num2)
        {
            return Num1 *= Num2;
        }
        internal virtual double Divide(double Num1, double Num2)
        {
            return Num1 /= Num2;
        }

        
    }
}
