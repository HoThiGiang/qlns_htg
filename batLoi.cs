using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{
    public class Catch
    {

        // TextBox trong thi tra ve gt true.
        public static bool cNullTB(string _textBox)
        {
            bool check = false;
            if (_textBox == "")
            {

                check = true;
            }
            return check;
        }


    }
}
