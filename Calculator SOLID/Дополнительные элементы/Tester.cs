using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_SOLID
{
    internal class Tester
    {
        public bool TestActived = false;
        Random r = new Random();

        public string TesterWork(string Text)
        {
            if (Text == ",,,,") { TestActived = true; }

            
                string text = "";
                int action = 0;
            if(TestActived&&Text=="")
            {

                text += Convert.ToString(r.Next(0, 999));
                text += ",";
                text += Convert.ToString(r.Next(0, 999));

                switch (action = r.Next(1, 5))
                {
                    case 1:
                        text += "+";
                        break;
                    case 2:
                        text += "-";
                        break;
                    case 3:
                        text += "*";
                        break;
                    case 4:
                        text += "/";
                        break;
                    default:
                        text += "+";
                        break;
                }

                text += Convert.ToString(r.Next(0, 999));
                text += ",";
                text += Convert.ToString(r.Next(0, 999));


            }
            return text;
        }
    }
}
