using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AdapterStructural.Interfaces
{
    public interface IChart
    {
        string Title { get; set; }
        List<string> XData { get; set; }
        List<string> YData { get; set; }
        Bitmap GeneralChart { get; set; }
    }
}
