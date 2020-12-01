using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    class Window
    {
        public string model;
        public double width;
        public double height;
        public Window(string model, double width, double height)
        {
            this.model = model;
            this.width = width;
            this.height = height;
        }
    }
}