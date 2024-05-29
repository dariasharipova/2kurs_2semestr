using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    internal class MixedChannelParameters : IParameters
    {
        public double CoefficientRr { get; set; }
        public double CoefficientRg { get; set; }
        public double CoefficientRb { get; set; }
        public double CoefficientGr { get; set; }
        public double CoefficientGg { get; set; }
        public double CoefficientGb { get; set; }
        public double CoefficientBr { get; set; }
        public double CoefficientBg { get; set; }
        public double CoefficientBb { get; set; }

        public ParameterInfo[] GetDescription()
        {
            return new[]
            {
                new ParameterInfo()
                {
                    Name = "Rr",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 1,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Rg",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Rb",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Gr",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Gg",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 1,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Gb",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Br",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Bg",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Bb",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 1,
                    Increment = 0.05
                }
            };
        }

        public void SetValues(double[] values)
        {
            CoefficientRr = values[0];
            CoefficientRg = values[1];
            CoefficientRb = values[2];
            CoefficientGr = values[3];
            CoefficientGg = values[4];
            CoefficientGb = values[5];
            CoefficientBr = values[6];
            CoefficientBg = values[7];
            CoefficientBb = values[8];
        }
    }
}
