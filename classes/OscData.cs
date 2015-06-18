using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAR5Reader
{
    class OscData
    {
        public string label { get; set; }
        public List<MeasuredPoint> records { get; set; }
        public OscData()
        {
            records=new List<MeasuredPoint>();
        }
        
        public OscData(string label)
        {
            this.label = label;
            records = new List<MeasuredPoint>();
        }


    }
}
