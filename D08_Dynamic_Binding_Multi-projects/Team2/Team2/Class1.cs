﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1;

namespace Team2
{
    // for 團隊二
    public class rect : iMeasurement
    {
        public double measurement;

        public rect()
        {
            measurement = 0;
        }

        public double cal(double i_edge)
        {
            measurement = i_edge * i_edge;
            return measurement;
        }
    }

}
