using System;

namespace CalculateInterfaces
{
    interface ILogger 
    {
        void Error(string message);
        void Event(string message);
    }

    class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Произошла ошибка: {0}", message);
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Произошло событие: {0}", message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
