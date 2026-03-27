using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // Ovo je komentar 74823749748
    public class MassConventer : IConvert
    {
        public double Convert(double value)
        {
            return Math.Round(value * 0.453592, 3);
        }
    }
}
