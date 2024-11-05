using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;

namespace Mapper.Plotter
{
    public class Plotter
    {

        double[] dataX = {};
        
        public double[] Parse(List<string> input)
        {
            throw new NotImplementedException();

        }


        public void Draw(float distance, double data)
        {

            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };

            ScottPlot.Plot myPlot = new();
            myPlot.Add.Scatter(dataX, dataY);

            myPlot.SavePng("quickstart.png", 400, 300);
        }

    }
}
