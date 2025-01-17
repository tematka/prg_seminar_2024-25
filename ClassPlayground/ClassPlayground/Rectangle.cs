using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        public double width;
        public double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double CalculateArea(double width, double height) 
        { 
            double area = width * height;
            return area;
        }
        public double CalculateAspectRatio(double width, double height) 
        { 
            double aspectRatio = width / height;
            return aspectRatio;
        }
        public bool ContainsPoint(double x, double y, double width, double height)
        {
            bool containsPoint = false;
            if(x <= width && y <= height) 
            { 
                containsPoint = true;
            }
            return containsPoint;
        }
    }
}
