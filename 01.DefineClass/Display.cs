namespace Phones
{
    using System;
    using System.Collections.Generic;
    //Here you can find Problem 5 - encapsulate Properties
    public class Display
    {
        private double size;
        private int colous;

        public Display(double displaySize, int numberOfColous)
        {
            this.size = displaySize;
            this.colous = numberOfColous;
        }

        public double Size 
        {
            get { return size; }
            set 
            {
                if (value < 3 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Phone size is in inches. Please enter a value in the range 3 to 10");
                }
                this.size = value;
            }
        }
        public int Colours
        {
            get { return colous; }
            set 
            {
                if (value < 64 || value > 401)
                {
                    throw new ArgumentOutOfRangeException("Display colours are in ppi and for now they are in the range 64 to 401"); 
                }
                this.colous = value; 
            }
        }
    }
}
