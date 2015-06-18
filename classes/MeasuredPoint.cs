using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAR5Reader
{
    public class  MeasuredPoint
    {
        public string label { get; set; }
        public double Vcc { get; set; }
        public double F { get ; set; }
        public DateTime Time { get; set; }
    }
}
