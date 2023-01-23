using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графический_редактор
{
    internal class CircleBrush : Brush
    {
        public CircleBrush(Color BrushColor, int size) : base(BrushColor, size) { }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {

                    if (((x - x0) * (x - x0)) + ((y - y0) * (y - y0)) < (Size * Size))
                    {
                        if (x0 > 0 & y0 > 0 & x0 < W & y0 < H)
                        {
                            image.SetPixel(x0, y0, BrushColor);
                        }
                    }
                }
            }
        }
    }
}
