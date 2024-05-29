using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer.Filters.Transformations
{
    public class ZoomTransformer : ITransformer<ZoomParameters>
    {
        double k;
        Size oldSize;
        public Size ResultSize { get; private set; }

        public void Initialize(Size oldSize, ZoomParameters parameters)
        {
            k = parameters.k;
            this.oldSize = oldSize;
            ResultSize = new Size((int)(oldSize.Width * k),
            (int)(oldSize.Height * k));
             
        }

        public Point? MapPoint(Point newPoint)
        {
            return new Point((int)(newPoint.X / k), (int)(newPoint.Y / k));
        }
    }
}
