using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Quyu:Calculator
    {
        public override void ShiXian(int x, int y)
        {
            _result = x % y;
            Console.WriteLine("x%y=" + _result);
        }
    }
}
