/* Name: Colin Weatherly
 * Date: 2/18/2022
 * File: ScrollDecorator.cs
 * IDE: Visual Studio 2019
 */

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
