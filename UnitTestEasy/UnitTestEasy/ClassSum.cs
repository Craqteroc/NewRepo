using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestEasy
{
    public class ClassSum
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        public int Mult_Sum(int a, int b, int c)
        {
            return a + c * b;
        }

        public int Mult_Div(int a, int b, int c)
        {
            return a + b / c;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}
