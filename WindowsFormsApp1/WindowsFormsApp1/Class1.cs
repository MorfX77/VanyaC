using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Class1
    {
        int Num1;
        int Num2;
        public Class1(int num1,int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public void Num1Num2(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public int Calculate()
        {
           int sum = Num1 + Num2;
            return sum;
        }
    }
}
