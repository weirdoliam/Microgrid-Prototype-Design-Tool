using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;

namespace WinFormsApp1.EnergyStorage
{
    public class LithiumIonBattery : EnergyStorageUnit
    {
        // Rated Efficiency
        public double Efficiency { get; set; }
        // Store the rated Amps 
        public int Currnt { get; set; }
        // Store the rated Voltage
        public int Voltage { get; set; }
        // String description (typically model number)
        public string Name { get; set; }
        // The max charge rate (for per half-hour), which is calculated ouside the class def, to make internal calculations simpler. 
        public double MaxChargeRate { get; set; }

        // Constructor
        public LithiumIonBattery(double capacity, double maxChargeRate, string name, decimal price)
        {
            Capacity = capacity;
            ChargeLevel = capacity;
            MaxChargeRate = maxChargeRate;
            Name = name;
            Price = price;
            Efficiency = 0.95;
        }

        /// <summary>
        /// Charge the battery
        /// </summary>
        /// <param name="amount">Amount in watts</param>
        /// <returns>Energy unalbe to be charged</returns>
        public override double Charge(double amount)
        {
            double not_charged = 0;
            double old_charge = ChargeLevel;

            if(amount > MaxChargeRate)
            {
                not_charged += amount - MaxChargeRate;
                amount = MaxChargeRate;
            }

            ChargeLevel = Math.Min(ChargeLevel + amount, Capacity);
            double difference = ChargeLevel - old_charge;
            if (difference != amount)
            {
                not_charged = Math.Abs(difference-amount);
            }
            //return not charged energy
            return not_charged;
        }

        /// <summary>
        /// Discharges a battry
        /// </summary>
        /// <param name="amount">Returns energy that was discharged</param>
        public override double Discharge(double amount)
        {
            if(amount > MaxChargeRate) amount = MaxChargeRate;
            double effectiveReturn = amount * Efficiency;
            double old_charge = ChargeLevel;
            ChargeLevel = Math.Max(ChargeLevel - effectiveReturn, 0);
            return old_charge - ChargeLevel;
        }

        public override string getDescription()
        {
            return $"{Name}, {Capacity} W";
        }

        public void overrideCharge(int cap)
        {
            this.ChargeLevel = cap;
        }
    }
}
