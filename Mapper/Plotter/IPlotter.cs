using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.Plotting
{
    public interface IPlotter
    {
        List<double> Data {  get; set; }

        void PlotGraph(int distCm);

        void Clear();
    }
}
