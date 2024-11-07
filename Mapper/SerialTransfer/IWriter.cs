using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.SerialTransfer
{
    
    public interface IWriter
    {

        public SerialPort Port { get; set; }

        void Write();

    }
}
