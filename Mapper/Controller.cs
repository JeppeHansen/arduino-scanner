using Mapper.Plotter;
using Mapper.SerialTransfer;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class Controller
    {
        static SerialPort? _serialPort;
        private IPlotter _plotter;
        private IWriter _writer;


        public Controller(IWriter writer, IPlotter plotter)
        {
            _writer = writer;
            _plotter = plotter;

            _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(port_data_received);



            _writer.Port = _serialPort;

        }


        public void StartTransfer()
        {
            _writer.Write();

        }

        public void port_data_received(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("Response from arduino: ");
            var response = _serialPort.ReadLine();

            if (response != null)
            {
                double response_double = double.Parse(response, System.Globalization.CultureInfo.InvariantCulture);
                _plotter.Data.Add(response_double);
               // measurement_double.Add(response_double);

            }
        }



    }
}
