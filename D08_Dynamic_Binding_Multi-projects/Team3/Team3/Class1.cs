﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1;

namespace Team3
{
    // for 團隊三
    public class cube : iMeasurement
    {
        public double measurement;

        public cube()
        {
            measurement = 0;
        }
        public double cal(double i_edge)
        {
            measurement = i_edge * i_edge * i_edge;
            return measurement;
        }
    }
}
