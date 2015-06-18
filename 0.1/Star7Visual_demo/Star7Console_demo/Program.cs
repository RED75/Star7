using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star7ClassLibrary.Measurement;

//using Star7ClassLibrary;

namespace Star7Console_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var heatScaner=new SimpleHeatScaner();
            heatScaner.Scan();
        }
    }
}
