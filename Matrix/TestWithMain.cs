using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace TheMatrix
{
    class TestWithMain
    {
        static void Main(string[] args)
        {
            Matrix<int> test = new Matrix<int>(2, 2);
            test.GetCol(3);
            
            Console.WriteLine(test.ToString());

        }
    }
}
