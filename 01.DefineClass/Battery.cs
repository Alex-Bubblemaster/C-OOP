using System;
using System.Collections.Generic;
 //Here you can find Problem 5 - encapsulate Properties
namespace Phones
{
   
    public class Battery
    {
        private string batteryModel;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType battType;
        
        public Battery (string battModel)
        {
            this.BatteryModel = battModel;
        }
        public Battery(string battModel, double idleHours, double talkHours) : this(battModel) //here I am using inheritance so I don't have to repeat code
        {
            this.HoursIdle = idleHours;
            this.HoursTalk = talkHours;
        }
        public Battery(string battModel, double idleHours, double talkHours, BatteryType batteryType): this(battModel,idleHours,talkHours)   //avoids DRY
        {
            this.BattType = batteryType;
        }

        public string BatteryModel
        {
            get { return batteryModel; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Battery model cannot be empty!"); 
                }
                this.batteryModel = value;
            }
        }
        public double HoursIdle 
        {
            get { return hoursIdle; }
            set 
            {
                if (value < 12 || value > 240)
                {
                    throw new ArgumentOutOfRangeException("Battery idle hours should be in the range 12 - 240");  
                }
                this.hoursIdle = value; 
            }
        }
        public double HoursTalk 
        {
            get { return hoursTalk; }
            set
            {
                if (value < 5 || value > 120)
                {
                     throw new ArgumentOutOfRangeException("Battery talk hours should be in the range 5 - 120");  
                }
                this.hoursTalk = value;
            }
        }
        public BatteryType BattType
        {
            get { return this.battType; }
            set { this.battType = value; }
    }
    }
    public enum BatteryType       //problem 3. enum..it could be a separate .cs as well but is only used here
    {
        SlimBattery, StandardBattery, ExtendedBattery, NiCD, NiMH, LiIon, LiPoly
    }
}
                                                                                           
