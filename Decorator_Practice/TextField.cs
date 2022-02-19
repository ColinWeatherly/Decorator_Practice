using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Practice
{
    public class TextField : Widget
    {
        private int width;
        private int height;

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }

        void Widget.draw()
        {
            Console.WriteLine("I am a Text Field. I am " + width + " by " + height + " in size.");
        }
    }
}
