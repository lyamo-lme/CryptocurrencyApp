﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;

namespace TestTask
{
    public class DataApp
    {
        public static List<Cryptocurrency> cryptocurrencies = new List<Cryptocurrency>();
        public static List<Cryptocurrency> GetCountFromBegin(int count)
        {
            if (count <= cryptocurrencies.Count)
                return cryptocurrencies.GetRange(0, count);
            return default(List<Cryptocurrency>);
        }

    }
}
