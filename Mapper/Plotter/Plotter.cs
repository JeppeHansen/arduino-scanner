using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;

namespace Mapper.Plotting
{
    public class Plotter : IPlotter
    {

        public List<double> Data { get; set; }

        public Plotter() 
        {
            Data = [0];
        }
        
        public double[] Parse(List<string> input)
        {
            throw new NotImplementedException();

        }

        public void PlotGraph(int distCm)
        {
            double[] dataY = {};

            dataY = Data.ToArray();

            double[] dataX = new double[dataY.Length];

            for (int i = 0; i < dataX.Length; i++)
            {
                dataX[i] = (distCm / dataY.Length) * i;
            }

            ScottPlot.Plot myPlot = new();
            myPlot.Add.Scatter(dataX, dataY);

            myPlot.SavePng("quickstart.png", 400, 300);
        }

        public void Clear()
        {
            Data = [0];
        }
      

    }
}
