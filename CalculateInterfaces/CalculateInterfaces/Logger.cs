using System;

/// <summary>
/// 1. Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел. Определите интерфейс для функции сложения числа и реализуйте его.
/// Дополнительно: добавьте конструкцию Try / Catch / Finally для проверки корректности введённого значения.
/// 2. Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
/// Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.
/// </summary>
namespace CalculateInterfaces
{
    /// <summary>
    /// Интерфейс, определяющий логгирование
    /// </summary>
    interface ILogger 
    {
        void Error(string message);
        void Event(string message);
    }

    /// <summary>
    /// Класс для логирования событий и ошибок, реализующий интерфейс ILogger
    /// </summary>
    class Logger : ILogger
    {
        /// <summary>
        /// Функция для логгирования в консоль ошибок
        /// </summary>
        /// <param name="message"></param>
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Произошла ошибка: {0}", message);
            Console.ForegroundColor = ConsoleColor.White;

        }

        /// <summary>
        /// Функция для логгирования в консоль событий
        /// </summary>
        /// <param name="message"></param>
        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Произошло событие: {0}", message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
