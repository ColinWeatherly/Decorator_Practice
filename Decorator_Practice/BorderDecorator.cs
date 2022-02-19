using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Practice
{
    public class BorderDecorator : Decorator, Widget
    {

        public BorderDecorator(Widget w) : base(w) 
        { }

        void Widget.draw()
        {
            Console.WriteLine("This is a Border Decorator. I am holding a:\n");
            getWid.draw();
        }
    }
}
