using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Circle : DrawingShape, IDraw, IColor
    {
        private int diameter;
        private int locX = 0, locY = 0;
        private Ellipse circle = null;

        public Circle(int diameter)
            : base(diameter)
        {
        }

        void IDraw.Draw(Canvas canvas)
        {
            if (this.circle != null)
                canvas.Children.Remove(this.shape);
            else
                this.shape = new Ellipse();

            base.Draw(canvas);
        }        
    }
}
