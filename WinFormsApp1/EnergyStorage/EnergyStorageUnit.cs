﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.EnergyStorage
{
    public abstract class EnergyStorageUnit
    {
        // Properties
        public double Capacity { get; protected set; }
        public double ChargeLevel { get; protected set; }

        // Charge returns
        public abstract double Charge(double amount);
        public abstract void Discharge(double amount);
    }
}