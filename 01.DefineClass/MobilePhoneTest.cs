namespace _01.DefineClass
{
   
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using Phones;
    using _01.DefineClass;
 //Problem 12 Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.
    class MobilePhoneTest
    {
        static void Main()
        {
            Console.WriteLine("Creating a new phone");
            MobilePhone yourPhone = new MobilePhone("tPhone", "Telerik", 250, "Pesho");
            Call firstCall = new Call(new DateTime(2015,03,12,21,15,59),"0887654321", 123);
            Call secondCall = new Call(new DateTime(2015, 03, 12, 22, 37, 01), "Mum", 1235);
            Call thirdCall = new Call(new DateTime(2015, 03, 13, 02, 49, 10), "Ex girlfriend", 30);
            
            yourPhone.AddCall(firstCall);
            yourPhone.AddCall(secondCall);
            yourPhone.AddCall(thirdCall);
           
            var result = yourPhone.SomeCalls;
            foreach (var call in result)
            {
                Console.WriteLine(call.PrintCalls());
            }

            double billToPay = yourPhone.CalculateInvoice(0.37, yourPhone.SomeCalls);
            Console.WriteLine();
            Console.WriteLine("Your invoice to pay is {0:C}",billToPay);
            var longestCall = yourPhone.SomeCalls.OrderBy(x => x.Duration).Last();
            yourPhone.RemoveCall(longestCall);
            billToPay = yourPhone.CalculateInvoice(0.37, yourPhone.SomeCalls);
            Console.WriteLine("Your invoice to pay after removing the call to your mother is {0:C}", billToPay);
            yourPhone.ClearHistory(yourPhone.SomeCalls);
            billToPay = yourPhone.CalculateInvoice(0.37, yourPhone.SomeCalls);
            Console.WriteLine("Your invoice after last payment is {0:C}", billToPay);

        }
    }
}
