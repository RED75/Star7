using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows;

namespace Star7ClassLibrary.Measurement
{
    class Agilent53131AClient
    {
        private SerialPort serialPort;
        
        void InitializeCom()
        {
            //serialPort.BaudRate = 9600;
            //serialPort.DataBits = 8;
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 2000;
        }
        /// <summary>
        /// Инициализируется работа ком порта для связи с Agilent53131A, открывается порт
        /// </summary>
        /// <param name="serialPortName"></param>
        public Agilent53131AClient(string serialPortName="Com10")
        {
            serialPort=new SerialPort(serialPortName);
            InitializeCom();
             try
            {
                serialPort.Open();
            }
            catch (Exception e)
            {
                if (MessageBox.Show("Порт "+serialPort.PortName+" не может быть открыт"+e.Message) == MessageBoxResult.OK)
                {
                }
                throw;
            }
        }

        public double ReciveFrequency()
        {
            if (serialPort.BytesToRead != 0)
                serialPort.DiscardInBuffer();
            double frequency;
            while (serialPort.BytesToRead <= 10)
            {
                Thread.Sleep(100);
            }
            double.TryParse(serialPort.ReadLine().Replace(",", "").Split(' ')[0].Replace('.', ','), out frequency);
            //Console.WriteLine(frequency.ToString());
            return frequency;
        }


    }
}
