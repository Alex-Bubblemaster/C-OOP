//this is Problem 8 - Create a class Call to hold a call performed through a GSM.
//It should contain date, time, dialled phone number and duration (in seconds).
namespace _01.DefineClass
{
    using System;
    using System.Text;

    public class Call
    {
        private DateTime dateTime;              //chose to combine Datetime so you need to create a new instance of DateTime
        private string dialedNumber;
        private int duration;

        public Call(DateTime callDateTime, string calledNumber, int callDuration)
        {
            this.dateTime = callDateTime;
            this.dialedNumber = calledNumber;
            this.duration = callDuration;
        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set { this.dateTime = value; }
        }
        public string DialedNumber
        {
            get { return dialedNumber; }
            set { this.dialedNumber = value; }
        }
        public int Duration
        {
            get { return duration; }
            set { this.duration = value; }
        }
        public string PrintCalls()
        {
            StringBuilder result = new StringBuilder();

            result.Append('-', 80);
            result.AppendLine();
            result.AppendFormat("| Call Date: {0:MM/dd/yy} | Call Time: {0:H:mm:ss} | Call ID: {1} | Duration: {2} seconds |", this.dateTime, this.dialedNumber, this.duration);
            string resultStr = String.Join(" ", result);
            return resultStr;

        }
    }
}
