using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Calculator> mylist = new List<Calculator>();
            Jiafa jiafa = new Jiafa();
            Jianfa jianfa=new Jianfa();
            Cheng cheng = new Cheng();
            Chu chu = new Chu();
            Quyu quyu = new Quyu();
            Yu yu = new Yu();
            mylist.Add(jiafa);
            mylist.Add(jianfa);
            mylist.Add(cheng);
            mylist.Add(chu);
            mylist.Add(quyu);
            mylist.Add(yu);
            Console.WriteLine("请输入第一个数");
            foreach(Calculator calculator in mylist){
                calculator._x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入第二个数");
                calculator._y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入要进行的运算:+,-,*,/,&,%");
                calculator._A = Console.ReadLine();
                if (calculator._A == "+")
                {
                    jiafa.ShiXian(calculator._x, calculator._y);
                    jiafa.LianJie(calculator._x, calculator._y);
                }
                else if (calculator._A == "-")
                {
                    jianfa.ShiXian(calculator._x, calculator._y);
                    jianfa.QuChu(calculator._x, calculator._y);
                }
                else if (calculator._A == "*")
                    cheng.ShiXian(calculator._x, calculator._y);

                else if (calculator._A == "/")
                    chu.ShiXian(calculator._x, calculator._y);
                else if (calculator._A == "%")
                    quyu.ShiXian(calculator._x, calculator._y);
                else if (calculator._A == "&")
                    yu.ShiXian(calculator._x, calculator._y);

                else
                    Console.WriteLine("您的输入有误");

                if (Calculator.Equals(calculator._x, calculator._y))
                    Console.WriteLine("两个数相等");
                else
                    Console.WriteLine("两个数不相等");
            }
        }
    }
}
