﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Helper;
namespace FuzzyLogic.Model
{
    class Weather:ObservableCollection<ChartItemWeatherItem>
    {
        private Random rnd = new Random();
        private double temp,before;
        public Weather()
        {
            this.Add(new ChartItemWeatherItem() { X = 0, Y = 20, Text = "X=0" + Environment.NewLine + "Y=20" });
        }

        public void AddNext()
        {
            before = this.ElementAt(this.Count - 1).Y;
            do
            {
                temp = rnd.NextDouble() * ((before + 2) - (before - 2)) + (before - 2);
            }
            while (temp < StartValues.TempMin || temp > StartValues.TempMax);
            this.Add(new ChartItemWeatherItem() { X = this.Count - 1, Y = temp, Text = "X=" + (this.Count - 1) + Environment.NewLine + "Y="+temp });
        }
    }
}