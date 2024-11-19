using Mapper.Plotting;
using Mapper.SerialTransfer;
using System;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Threading;
using Mapper.Plotting;


namespace Mapper
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Writer writer = new Writer();
            Plotter plotter = new Plotter();
           // plotter.Data = [1, 2, 3];
           // plotter.PlotGraph(3);
           
            Controller controller = new Controller(writer, plotter);
            controller.StartTransfer();

        }
    }
}
