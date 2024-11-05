using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.SerialTransfer
{
    public class Reader
    {

        private SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);

        public Reader() 
        {
            port.DataReceived += new SerialDataReceivedEventHandler(port_data_received);
            port.Open();

        }

        public void port_data_received(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("Response from arduino: ");
            Console.WriteLine(port.ReadExisting());
        }
    }
}
