//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner,
//battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
//Here you can find Problem 5 - encapsulate Properties
namespace Phones
{
    using _01.DefineClass;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MobilePhone
    {
        public static readonly MobilePhone iPhone4S = new MobilePhone("Iphone 4S", "Apple", 99, "Pesho");
        private string model;
        private string manufacturer;
        private string owner;
        private double price;
        private List<Call> someCalls;



        public MobilePhone(string phoneModel, string madeBy, double priceTag = 0, string ownerPhone = null) //Problem 2 - making only phoneModel and madeBy obligatory
        {
            this.Model = phoneModel;
            this.Manufacturer = madeBy;
            this.Owner = ownerPhone;
            this.Price = priceTag;
            this.someCalls = new List<Call>();
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Phone model cannot be empty!");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Manufacturer cannot be empty!");
                }
                this.manufacturer = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 8000000)
                {
                    throw new ArgumentOutOfRangeException("You are trying to get a phone so expensive, nonone even sells at this price. Are you feeling unwell?");
                }
                else if (value < 10)
                {
                    throw new ArgumentOutOfRangeException("Sorry. This is a business. We don't give things away");
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get { return owner; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Owner cannot be empty!");
                }
                this.owner = value;
            }
        }
        public List<Call> SomeCalls
        {
            get
            {
                return this.someCalls;
            }
        }
        public static MobilePhone IPhone
        {
            get { return iPhone4S; }
        }

        public override string ToString()      //Problem 4 - ToString Override bonus - with addition of optional arguments if they are not null or 0
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("| Phone Model: {0} | Manufacturer:{1} |", model, manufacturer);
            if (price != 0)
            {
                result.AppendFormat(" Price: {0:C} |", price);
            }
            if (owner != null)
            {
                result.AppendFormat(" Owned by: {0} |", owner);
            }

            string resultStr = String.Join(" ", result);
            return resultStr.ToString();
        }
        public void AddCall(Call someCall)                                    //Problem 10 - add calls
        {
            someCalls.Add(someCall);
        }
        public void RemoveCall(Call someCall)                          //Problem 10 - delete calls
        {
            someCalls.Remove(someCall);
            //return someCalls;
        }
        public void ClearHistory(List<Call> callHistory)               //Problem 10 -clear calls
        {
            callHistory.Clear();
            // return callHistory;
        }
        public double CalculateInvoice(double price, List<Call> callHistory)      //Problem 11 - total price with fixed parameter
        {
            double result = 0;
            foreach (var call in callHistory)
            {
                result += price * call.Duration / 60;

            }
            return result;
        }
        
        //Display samsungDisplay = new Display(7, 365); // Problem 1 - GSM holding an instance of Display (here I have size in inches and number of colours for the display)
        //Battery samsungBattery = new Battery("Vytec", 24.5, 15, BatteryType.LiIon); // Problem 1 - GSM holding an Instance of Battery with implemented BatteryType
        //MobilePhone galaxy4 = new MobilePhone("Galaxy 4", "Samsung", 250.5);  //  Problem 2 test that the constructor works with 1 optional argument
    }
}