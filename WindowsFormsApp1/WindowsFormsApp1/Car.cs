﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Car
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public Car(string parambrand, int paramyear)
        {
            this.Brand = parambrand;
            this.Year = paramyear;
        }
    }
}
