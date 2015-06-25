using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows;

namespace Star7ClassLibrary.ResistorControl
{
    class ComWriter
    {
        private SerialPort serialPort;

        void InitializeCom()
        {
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;
        }
        public ComWriter(string comPortNumber="Com7")
        {
            serialPort = new SerialPort(comPortNumber);
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

        public void Write(byte rPosition)
        {
            byte[] buffer = { (byte)0, (byte)0, (byte)0, (byte)0 };
            ;
            buffer[0] = 1;          //Todo: Вынести режим в параметры   
            buffer[1] = 162;        //Todo: Вынести адресс устройства в параметры 
            buffer[2] = 3;          //Todo: Вынести адресс регистра в параметры     2 - 30 kOm, 3 - 50 kOm
            buffer[3] = rPosition;
            if(rPosition<26) return; //Защита от перегрева 5кОм
            serialPort.Write(buffer, 0, 4);
        }



    }

}
