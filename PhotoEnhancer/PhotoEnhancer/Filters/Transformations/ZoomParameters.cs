using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class ZoomParameters : IParameters
    {
        [ParameterInfo(Name = "Коэффициэнт масштабирование",
                    MinValue = 0.2,
                    MaxValue = 5.0,
                    DefaultValue = 1,
                    Increment = 0.1)]
        public double k { get; set; }
    }
}