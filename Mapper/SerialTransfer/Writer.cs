using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using Mapper.Plotter;

namespace Mapper.SerialTransfer
{
    public class Writer : IWriter
    {

        static bool _continue;
       // static SerialPort _serialPort;
        public List<string> measurements = new List<string>();
        public List<double> measurement_double = new List<double>();

        public SerialPort? Port { get; set; }

        //public Writer()
        //{
        //    _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        //    _serialPort.DataReceived += new SerialDataReceivedEventHandler(port_data_received);

        //}

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

        //public void Write() { 

        //    string? message;
        //    StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

        //    _serialPort.Open();
        //    _continue = true;

        //    while (_continue)
        //    {
        //        message = Console.ReadLine();

        //        if (stringComparer.Equals("quit", message))
        //        {
        //            _serialPort.Close();
        //            PlotData();
        //            _continue = false;
        //        }
        //        else
        //        {
        //            _serialPort.Write(message);
        //        }
        //    }
        //}

        //public void port_data_received(object sender, SerialDataReceivedEventArgs e)
        //{
        //    Console.WriteLine("Response from arduino: ");
        //    var response = _serialPort.ReadLine();
            
        //    if (response != null)
        //    {
        //        double response_double = double.Parse(response, System.Globalization.CultureInfo.InvariantCulture);
        //        measurement_double.Add(response_double);

        //    }          
        //}


        //public void PlotData()
        //{

        //    double[] dataY = {};

        //    dataY = measurement_double.ToArray();

        //    foreach (var data in dataY)
        //    {
        //        Console.WriteLine(data);
        //    }

        //    double[] dataX = new double[dataY.Length];


        //    for (int i = 0; i < dataX.Length; i++)
        //    {
        //        dataX[i] = (10 / dataY.Length) * i;
        //    }

        //    ScottPlot.Plot myPlot = new();
        //    myPlot.Add.Scatter(dataX, dataY);

        //    myPlot.SavePng("quickstart.png", 400, 300);

        //}
    }

