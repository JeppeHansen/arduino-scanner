using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using Mapper.Plotting;

namespace Mapper.SerialTransfer
{
    public class Writer : IWriter
    {

        static bool _continue;
        public List<string> measurements = new List<string>();
        public List<double> measurement_double = new List<double>();

        public SerialPort? Port { get; set; }

        public void Write()
        {
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            Port.Open();
            _continue = true;

            while (_continue)
            {
                message = Console.ReadLine();

                if (stringComparer.Equals("quit", message))
                {
                    Port.Close();                   
                    _continue = false;
                    
                }
                else
                {
                    Port.Write(message);
                }
            }
        }
    }
}

