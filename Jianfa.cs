using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Calculator
{
    class Jianfa:Calculator
    {
        public void QuChu(int x,int y) {
            string x1 = x.ToString();
            string y1 = y.ToString();
            string newstr = x1.Replace(y1," ");
            Console.WriteLine("删除后的字符串为："+newstr);


        }
        public override void ShiXian(int x, int y)
        {
            _result = x - y;
            Console.WriteLine("x-y=" + _result);
        }
    }
}
