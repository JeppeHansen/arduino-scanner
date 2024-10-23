using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace Mapper.SerialTransfer
{
    public class Writer
    {

        static bool _continue;
        static SerialPort _serialPort;

        public void Write() { 

            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);

            _serialPort.Open();
            _continue = true;

            while (_continue)
            {

                message = Console.ReadLine();

                if (stringComparer.Equals("quit", message))
                {
                    _continue = false;
                }
                else
                {
                    _serialPort.Write(message);
                    
                }
            }
        }

    }
}
