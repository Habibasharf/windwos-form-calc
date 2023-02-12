using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTask7
{
    internal class calculateoperator
    {
        public string CalculateFunction(string x,string y , string op)
        {
            int f = int.Parse(x);
            int g = int.Parse(y);
            int result = 0;
            try
            {
                switch (op)
                {
                    case "+":
                        result = f + g;
                        break;
                    case "-":
                        result = f - g;
                        break;
                    case "*":
                        result = f * g;
                        break;
                    case "/":
                        result = f / g;
                        break;
                    default:
                        result = 0;
                        break;
                }
                return result.ToString();
            }
            catch (OverflowException )
            {
                return "Overflow";
            }
            catch (DivideByZeroException )
            {
                return "Can not divide by zero";
            }
            catch (FormatException )
            {
               return "You have entered non-numeric characters";
            }

        }
    }
}
