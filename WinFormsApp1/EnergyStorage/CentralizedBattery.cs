using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.EnergyStorage;

namespace WinFormsApp1.EnergyStorage
{
    internal class CentralizedBattery : EnergyStorageUnit
    {
        // Fields
        private double _maxChargeRate;

        // Constructor
        public CentralizedBattery(double capacity, double maxChargeRate)
        {
            Capacity = capacity;
            ChargeLevel = 0;
            _maxChargeRate = maxChargeRate;
        }

        public override double Charge(double amount)
        {
            double maxChargeAmount = _maxChargeRate * Capacity;
            double actualChargeAmount = Math.Min(amount, maxChargeAmount);
            double old_charge = ChargeLevel;
            ChargeLevel = Math.Min(ChargeLevel + actualChargeAmount, Capacity);
            //return wasted energy
            return ChargeLevel - old_charge;
        }

        public override double Discharge(double amount)
        {
            ChargeLevel = Math.Max(ChargeLevel - amount, 0);
            return ChargeLevel;
        }
    }
}
