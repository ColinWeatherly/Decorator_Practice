using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Practice
{
    public class ScrollDecorator : Decorator, Widget
    {
        public ScrollDecorator(Widget w) : base(w) 
        { }

        void Widget.draw()
        {
            Console.WriteLine("This is a Scroll Decorator. I am holding a:\n");
            getWid.draw();
        }
    }
}
