using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class ZoomParameters : IParameters
    {
        public double k { get; set; }

        public ParameterInfo[] GetDescription()
        {
            return new[]
            {
                new ParameterInfo()
                {
                    Name = "Коэффициэнт масштабирование",
                    MinValue = 0.2,
                    MaxValue = 5.0,
                    DefaultValue = 1,
                    Increment = 0.1
                }
            };
        }

        public void SetValues(double[] values)
        {
            k = values[0];
        }
    }
}