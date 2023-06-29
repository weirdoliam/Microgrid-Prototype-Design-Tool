using Microsoft.ML.Data;
using System;

namespace WinFormsApp1.ml
{
    //heatpump,electric_cooking,gas_cooking,bottled_gas_cooking,electric_water_heating,gas_water_heating,wood_water_heating,electric_heating,gas_heating
    //,wood_heating,fossil_fuels_heating,adults,children,income,location,datetime,consumpiton_data

    internal class DataItem
    {
        [LoadColumn(0)]
        public bool heatpump { get; set; }

        [LoadColumn(1)]
        public bool electric_cooking { get; set; }

        [LoadColumn(2)]
        public bool gas_cooking { get; set; }

        [LoadColumn(3)]
        public bool bottled_gas_cooking { get; set; }

        [LoadColumn(4)]
        public bool electric_water_heating { get; set; }

        [LoadColumn(5)]
        public bool gas_water_heating { get; set; }

        [LoadColumn(6)]
        public bool wood_water_heating { get; set; }

        [LoadColumn(7)]
        public bool electric_heating { get; set; }

        [LoadColumn(8)]
        public bool gas_heating { get; set; }

        [LoadColumn(8)]
        public bool wood_heating { get; set; }

        [LoadColumn(9)]
        public bool fossil_fuels_heating { get; set; }

        [LoadColumn(10)]
        public int adults { get; set; }

        [LoadColumn(11)]
        public int children { get; set; }

        [LoadColumn(12)]
        public string income { get; set; }

        [LoadColumn(13)]
        public string location { get; set; }

        [LoadColumn(14)]
        public int time { get; set; }

        [LoadColumn(15), ColumnName("Label")]
        public float power_consumption { get; set; }
    }
}