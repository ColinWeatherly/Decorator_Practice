/* Name: Colin Weatherly
 * Date: 2/18/2022
 * File: DecoratorDemo.cs
 * IDE: Visual Studio 2019
 */

using System;

namespace Decorator_Practice
{
    class DecoratorDemo
    {
        static void Main(string[] args)
        {
            TextField field = new TextField(200, 100);
            ScrollDecorator scrollDec = new ScrollDecorator(field);
            BorderDecorator borderDec = new BorderDecorator(scrollDec);

            Widget test = borderDec;
            test.draw();
        }
    }
}
