﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ArtemihinND.Sprint3.Task0.V11.Lib
{
    public class DataService : ISprint3Task0V11
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = 9 * i * Math.Sin(1) - 2 * i;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
