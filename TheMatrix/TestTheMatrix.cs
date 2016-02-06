namespace TheMatrix
{
    using System;

    class TestTheMatrix
    {
        static void Main()
        {
            Matrix<double> test = new Matrix<double>(2, 2);
            test[1, 1] = 2.4;
            Console.WriteLine(test.ToString());
            Matrix<string> anotherTest = new Matrix<string>(3, 3);
            anotherTest[0, 0] = "The";
            anotherTest[1, 0] = "has";
            anotherTest[0, 1] = "Matrix";
            anotherTest[1, 1] = "you";
            Console.WriteLine(anotherTest.ToString());
        }
    }
}
