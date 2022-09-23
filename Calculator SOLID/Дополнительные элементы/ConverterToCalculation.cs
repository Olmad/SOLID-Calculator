using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_SOLID
{
    internal class ConverterToCalculation
    {
        public double Num1 = 0, Num2 = 0; 
        public bool PointIs = false, FirstNumIsEmpty = false, ActionIsEmpty = false, SecondNumIsEmpty = false;
        public char Action = ' ';
        internal virtual void Convertation(string text)
        {
            string TextForNum = "";
            PointIs = false; FirstNumIsEmpty = false; ActionIsEmpty = false; SecondNumIsEmpty = false;

            int i = 0;
            int LengthText = -1 + text.Length;
            if (LengthText < 0) { FirstNumIsEmpty = true; return; }
            else
            if (text[LengthText] == ',') { text += "0"; }
            else
            {
                while (text[i] != '*' && text[i] != '/' && text[i] != '+' && text[i] != '-')
                {
                    if (i == LengthText) { ActionIsEmpty = true;return; }
                    if (text[i] == ',' && !PointIs) { PointIs = true; }
                    else
                        if (text[i] == ',' && PointIs)
                    {
                        while (text[i] == ',')
                        { i++; }
                       
                    }
                    if (text[i] != '*' && text[i] != '/' && text[i] != '+' && text[i] != '-')
                    {
                        TextForNum += text[i];
                        i++;
                    }

                }

                Num2=i;
                i--;
                if (text[i] ==','&& text[Convert.ToInt32(Num2)]=='+'|| text[Convert.ToInt32(Num2)] == '-' || text[Convert.ToInt32(Num2)] == '*' || text[Convert.ToInt32(Num2)] == '/') 
                { TextForNum += "0"; }
                i++;
                PointIs = false;
                Action = text[i];
                if (i == LengthText) { SecondNumIsEmpty = true; return; }
                i++;
                LengthText++;
                Num1 = Convert.ToDouble(TextForNum);
                TextForNum = "";
                while (i != LengthText)
                {
                    if (text[i] == ',' && !PointIs) { PointIs = true; }
                    else
                       if (text[i] == ',' && PointIs)
                    {
                        while (text[i] == ',')
                        { i++; }
                    }
                    TextForNum += text[i];
                    i++;
                }
                Num2 = Convert.ToDouble(TextForNum);

                
            }
        }
    }
}
