using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;

namespace Mapper.Plotter
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

        public void PlotGraph(int distCm, int dataPoints)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            Data = [0];
        }
      

    }
}
