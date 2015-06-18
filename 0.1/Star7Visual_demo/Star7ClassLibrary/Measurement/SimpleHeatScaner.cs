﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Star7ClassLibrary.ResistorControl;

namespace Star7ClassLibrary.Measurement
{
    public class SimpleHeatScaner
    {
        private ComWriter com=new ComWriter();
        Agilent53131AClient agilent53131AClient = new Agilent53131AClient();
        /// <summary>
        /// задержка между изменением температуры и считыванием частоты, мсек
        /// </summary>
        private int DelayBeforeMesurement = 20000;
        public SimpleHeatScaner()
        {
     
        }
        public void Scan(int start = 140, int stop = 250, int nsteps = 10)
        {
            int step = (int)Math.Ceiling((double)((stop - start) / nsteps));
            int value = start;
            for (int i = 0; i < nsteps; i++)
            {
                
                byte bt = (byte) value;
                com.Write((byte)value);
                Thread.Sleep(DelayBeforeMesurement);
                agilent53131AClient.ReciveFrequency();
                Console.WriteLine("Time: "+DateTime.Now.ToString()+" ResistorPosition: "+value.ToString()+" Frequency: "+agilent53131AClient.ReciveFrequency());
                value += step;
            }
            Console.ReadKey();
        }
    }
}