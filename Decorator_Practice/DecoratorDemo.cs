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
