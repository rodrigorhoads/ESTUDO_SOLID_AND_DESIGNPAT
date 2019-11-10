using BuilderPatternStudy.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuilderPatternStudy.Models
{
    public class ComputerAssembler
    {
        private IComputerBuilder computerBuilder;

        
        public ComputerAssembler(IComputerBuilder pComputerBuilder)
        {
            this.computerBuilder = pComputerBuilder;
        }

        /// <summary>
        /// Coordena a construção de um computador
        /// </summary>
        /// <returns>Computer</returns>
        public Computer AssembleComputer()
        {
            computerBuilder.AddCabinet();
            computerBuilder.AddMotherBoard();
            computerBuilder.AddCPU();
            computerBuilder.AddKeyBoard();
            computerBuilder.AddMouse();
            computerBuilder.AddMonitor();
            return computerBuilder.GetComputer();
        }
    }
}