using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
  abstract class Calculator
    {
        public int _result;
        public int _x;
        public int _y;
        public bool _are;
        public string _A;
        #region 属性
        public string A
        {
            get { return _A; }
            set { _A = value; }
        }
        public bool Are
        {
            get { return _are; }
            set { _are = value; }
        }
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int Sum
        {
            get { return _result; }
            set { _result = value; }
        }
        #endregion
        public bool Equals()
        {
            return _are = Equals(_x, _y);

        } 
      abstract public void ShiXian(int x, int y);
    }
}
