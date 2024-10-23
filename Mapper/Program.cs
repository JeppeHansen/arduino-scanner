using System;
using System.IO.Ports;
using System.Threading;


namespace Mapper
{
    public class Program
    {

        static bool _continue;
        static SerialPort _serialPort;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



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
