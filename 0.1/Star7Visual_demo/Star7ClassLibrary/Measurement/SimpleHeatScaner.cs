using System;
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
        private int firstWarmUpTime = 8000;
        private int warmUpTime = 40 * 1000;//ms
        private int start = 100;    //ToDo: переделать в свойства с инициализацией в конструкторе
        private int stop = 30;
        private int nsteps = 10;


        public SimpleHeatScaner()
        {
     
        }
        public void Scan(int start = 100, int stop = 30, int nsteps = 10)
        {
            int step = (int)Math.Round((double)((stop - start) / nsteps));
            int value = start;
            Console.WriteLine("Time: " + DateTime.Now.ToString() + " ResistorPosition: " + value.ToString() + " Frequency: " + agilent53131AClient.ReciveFrequency() + " Start Warm");
            com.Write((byte)value);
            Thread.Sleep(warmUpTime);
            
            for (int i = 0; i <=nsteps; i++)
            {
                byte bt = (byte) value;
                com.Write((byte)value);
                Thread.Sleep(firstWarmUpTime);
                agilent53131AClient.ReciveFrequency();
                Console.WriteLine("Time: "+DateTime.Now.ToString()+" ResistorPosition: "+value.ToString()+" Frequency: "+agilent53131AClient.ReciveFrequency());
                value += step;
            }
            com.Write((byte)255);//Set min tempreture
            Console.ReadKey();
        }
        public void AIScan()
        {
            
        }
    }
}
