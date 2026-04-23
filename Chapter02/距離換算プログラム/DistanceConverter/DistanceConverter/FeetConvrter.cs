using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter{
    public class FeetConvrter
    {
        public static double FeetMeter(double metre){
            return metre / 0.3048;
        }
        public static double ToMeter(double feet){
            return feet * 0.3048;
        }
    }
}
