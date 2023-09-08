using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.EnergyStorage
{
    public abstract class EnergyStorageUnit
    {
        // Capacity of storage in W
        public double Capacity { get; protected set; }
        //Current charge level (from 0W to capacity typically)
        public double ChargeLevel { get; protected set; }
        //price of asset
        public decimal Price { get; protected set; }
        // Charge returns energy not charged
        public abstract double Charge(double amount);
        //Discharge returns discharged energy
        public abstract double Discharge(double amount);
        //get description of unit
        public abstract string getDescription();
    }
}
