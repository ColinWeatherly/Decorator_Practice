/* Name: Colin Weatherly
 * Date: 2/18/2022
 * File: Decorator.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Practice
{
    public abstract class Decorator : Widget
    {
        private Widget wid;

        public Decorator(Widget w)
        {
            wid = w;
        }

        void Widget.draw()
        {
            wid.draw();
        }

        public Widget getWid
        {
            get { return wid; }
        }

    }
}
