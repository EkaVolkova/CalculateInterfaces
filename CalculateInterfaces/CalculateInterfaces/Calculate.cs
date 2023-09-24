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
    /// Интерфейс, описывающий функцию суммирования
    /// </summary>
    interface ISum
    {
        public void Sum(double a, double b);

    }
   
    /// <summary>
    /// Калькулятор для подсчета суммы
    /// </summary>
    class Calculate : ISum
    {
        /// <summary>
        /// Экземпляр класса, реализующего интерфейс ILogger
        /// </summary>
        ILogger Logger { get;  }

        /// <summary>
        /// Конструктор принимающий экземпляр класса, реализующего интерфейс ILogger
        /// </summary>
        /// <param name="logger"></param>
        public Calculate(ILogger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Функция суммирования
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Sum(double a, double b)
        {
            Logger.Event("Запуск расчета");
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Logger.Event("Калькулятор успешно завершил работу");
        }
    }
}
