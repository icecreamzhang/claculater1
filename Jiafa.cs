using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Jiafa:Calculator
    {
        public void LianJie(int x,int y) {
            string x1= x.ToString();
            string y1 = y.ToString();
            string str = string.Empty;
            str = x1;
            str = str + y1;
            Console.WriteLine(str);
            Console.ReadKey();
         
        }
        public override void ShiXian(int x, int y)
        {
            _result = x + y;
            Console.WriteLine("x+y=" + _result);
        }
    }
}
