namespace GenericClass
{
    using System;
    
    //here is a link to the HW tasks https://github.com/TelerikAcademy/Object-Oriented-Programming/blob/master/02.%20Defining%20Classes%20-%20Part%202/README.md
    class TestWithMain
    {
        static void Main()
        {
            //GenericList<string> test = new GenericList<string>();
            //test.AddElement("Testing");
            //test.AddElement("string");
            //Console.WriteLine(test.ToString()); //before inserting a new element
            //test.InsertAtIndex(0, "sf");
            //Console.WriteLine(test.ToString());    //after inserting a new element
            //var testAccessByIndex = test.AccessByIndex(1);
            //Console.WriteLine("I am the element at index 1 = {0}", testAccessByIndex);

           GenericList<double> anotherTest = new GenericList<double>();
           anotherTest.AddElement(1);
           anotherTest.AddElement(2);
           anotherTest.AddElement(3);
           anotherTest.AddElement(4);
          
           Console.WriteLine("Numbers = {0}", anotherTest.ToString());
           var minElement = anotherTest.Min();
           Console.WriteLine("MIN element is {0}", minElement);
           var maxElement = anotherTest.Max();
           Console.WriteLine("MAX element is {0}", maxElement);
           Console.WriteLine("Element[1] using indexer = {0}", anotherTest[1]);
           Console.WriteLine("Element AccessByIndex(1) = {0}", anotherTest.AccessByIndex(1));
           anotherTest.RemoveByIndex(1);
           Console.WriteLine("Removed element[1], result = {0}", anotherTest.ToString());
           anotherTest.InsertAtIndex(1, 5);
           Console.WriteLine("Insert 5 at index[1],result = {0}",anotherTest.ToString());
           anotherTest.ClearList();
           Console.WriteLine("Elements ClearList() = {0}", anotherTest.ToString());
           Console.WriteLine("Check if list contains 0: {0}",anotherTest.FindByValue(0));
        }
    }
}
