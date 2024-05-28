using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer.Filters
{
    internal class MixedChannelFilter : PixelFilter<MixedChannelParameters>
    {
        public override Pixel ProcessPixel(Pixel p, MixedChannelParameters parameters)
        {
            var newPixel = p;
            newPixel.R = Pixel.TrimChannel(p.R * parameters.CoefficientRr + p.G * parameters.CoefficientRg + p.B * parameters.CoefficientRb);
            newPixel.G = Pixel.TrimChannel(p.G * parameters.CoefficientGr + p.G * parameters.CoefficientGg + p.B * parameters.CoefficientGb);
            newPixel.B = Pixel.TrimChannel(p.B * parameters.CoefficientBr + p.G * parameters.CoefficientBg + p.B * parameters.CoefficientBb);
            return newPixel;
        }

        public override string ToString()
        {
            return "Микширование каналов";
        }
    }
}
