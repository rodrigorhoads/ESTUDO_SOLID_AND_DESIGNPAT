using BuilderPatternStudy.Data;
using BuilderPatternStudy.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuilderPatternStudy.Models
{
    public class HomeComputerBuilder : IComputerBuilder
    {
        private Computer computer;

        public HomeComputerBuilder()
        {
            this.computer = new Computer();
            this.computer.Parts = new List<ComputerParts>();
        }

        public void AddCabinet()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var query = from p in dbContext.Parts
                            where p.UseType == "HOME" && p.Part == "CABINET"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddCPU()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var query = from p in dbContext.Parts
                            where p.UseType == "HOME" && p.Part == "CPU"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddKeyBoard()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var query = from p in dbContext.Parts
                            where p.UseType == "HOME" && p.Part == "KEYBOARD"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddMonitor()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var query = from p in dbContext.Parts
                            where p.UseType == "HOME" && p.Part == "MONITOR"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddMotherBoard()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var query = from p in dbContext.Parts
                            where p.UseType == "HOME" && p.Part == "MOTHERBOARD"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddMouse()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var query = from p in dbContext.Parts
                            where p.UseType == "HOME" && p.Part == "MOUSE"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}