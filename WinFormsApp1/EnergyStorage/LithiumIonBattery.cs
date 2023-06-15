﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace WinFormsApp1.EnergyStorage
{
    public class LithiumIonBattery : EnergyStorageUnit
    {
        // In watts
        private double _maxChargeRate;
        // give it a proper name
        private string _name;


        public string Name { get => _name; set => _name = value; }
        public double MaxChargeRate { get => _maxChargeRate; set => _maxChargeRate = value; }

        // Constructor
        public LithiumIonBattery(double capacity, double maxChargeRate, string name)
        {
            Capacity = capacity;
            ChargeLevel = capacity;
            _maxChargeRate = maxChargeRate;
            _name = name;
        }

        /// <summary>
        /// Charge the battery
        /// </summary>
        /// <param name="amount">Amount in watts</param>
        /// <returns>Energy unalbe to be charged</returns>
        public override double Charge(double amount)
        {
            double maxChargeAmount = _maxChargeRate * Capacity;
            double actualChargeAmount = Math.Min(amount, maxChargeAmount);
            double old_charge = ChargeLevel;
            ChargeLevel = Math.Min(ChargeLevel + actualChargeAmount, Capacity);
            
            //return wasted energy
            return ChargeLevel - old_charge;
        }

        /// <summary>
        /// Discharges a battry
        /// </summary>
        /// <param name="amount">Returns energy that was discharged</param>
        public override double Discharge(double amount)
        {
            double efficiency = 0.95;
            double effectiveReturn = amount * efficiency;
            double old_charge = ChargeLevel;
            ChargeLevel = Math.Max(ChargeLevel - effectiveReturn, 0);
            return old_charge- ChargeLevel;
        }
    }
}