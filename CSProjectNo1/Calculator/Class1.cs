using System;
using System.Collections.Generic;
using System.Text;

namespace CSProjectNo1.Calculator
{
    class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Substract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }
        public static int Percentage(int num, int percentage)
        {
            return (num * percentage) / 100;
        }
       
    }
}
