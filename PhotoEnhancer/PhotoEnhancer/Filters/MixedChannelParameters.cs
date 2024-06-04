using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class MixedChannelParameters : IParameters
    {
        [
               ParameterInfo(
                   Name = "Rr",
                           MinValue = 0,
                           MaxValue = 1,
                           DefaultValue = 1,
                           Increment = 0.05

               )]
        public double CoefficientRr { get; set; }
        [ParameterInfo(
                    Name = "Rg",
                            MinValue = 0,
                            MaxValue = 1,
                            DefaultValue = 0,
                            Increment = 0.05
                        )]
        public double CoefficientRg { get; set; }
        [ParameterInfo(
                
                    Name = "Rb",
                            MinValue = 0,
                            MaxValue = 1,
                            DefaultValue = 0,
                            Increment = 0.05
                        )]
        public double CoefficientRb { get; set; }
        [ParameterInfo(
                
                    Name = "Gr",
                            MinValue = 0,
                            MaxValue = 1,
                            DefaultValue = 0,
                            Increment = 0.05
                        )]
        public double CoefficientGr { get; set; }
        [ParameterInfo(
                
                    Name = "Gg",
                            MinValue = 0,
                            MaxValue = 1,
                            DefaultValue = 1,
                            Increment = 0.05
                        )]
        public double CoefficientGg { get; set; }
        [ParameterInfo(
                
                    Name = "Gb",
                            MinValue = 0,
                            MaxValue = 1,
                            DefaultValue = 0,
                            Increment = 0.05
                        )]
        public double CoefficientGb { get; set; }
        [ParameterInfo(
                
                    Name = "Br",
                            MinValue = 0,
                            MaxValue = 1,
                            DefaultValue = 0,
                            Increment = 0.05
                        )]
        public double CoefficientBr { get; set; }
        [ParameterInfo(
                
                    Name = "Bg",
                            MinValue = 0,
                            MaxValue = 1,
                            DefaultValue = 0,
                            Increment = 0.05
                        )]
        public double CoefficientBg { get; set; }
        [ParameterInfo(
                
                    Name = "Bb",
                            MinValue = 0,
                            MaxValue = 1,
                            DefaultValue = 1,
                            Increment = 0.05
                )]
        public double CoefficientBb { get; set; }
    }
}
