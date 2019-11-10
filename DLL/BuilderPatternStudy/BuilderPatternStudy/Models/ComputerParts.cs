using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuilderPatternStudy.Models
{
    public class ComputerParts
    {
        public int Id { get; set; }
        public string UseType { get; set; }
        public string Part { get; set; }
        public string PartCode { get; set; }
    }
}