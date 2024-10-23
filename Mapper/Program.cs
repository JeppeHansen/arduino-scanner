using Mapper.SerialTransfer;
using System;
using System.IO.Ports;
using System.Threading;


namespace Mapper
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var writer = new Writer();

            writer.Write();

          
        }
    }
}
