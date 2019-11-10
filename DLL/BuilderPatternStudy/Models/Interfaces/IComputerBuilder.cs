using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternStudy.Models.Interfaces
{
    public interface IComputerBuilder
    {
        void AddMotherBoard();
        void AddCPU();
        void AddCabinet();
        void AddMouse();
        void AddKeyBoard();

        void AddMonitor();

        Computer GetComputer();
    }
}
