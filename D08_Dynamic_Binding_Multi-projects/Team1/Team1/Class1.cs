using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1
{
    // for 團隊一
    // for contract (契約)
    public interface iMeasurement
    {
        double cal(double edge);
    }

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
