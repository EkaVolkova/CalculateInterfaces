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
    /// Класс для получения введенных пользователем чисел 
    /// </summary>
    class NumberReader
    {
        ILogger Logger { get;  }
        //Делегат для оповещении о наступлении события
        public delegate void NumberEnteredDelegate(double num1, double num2);
        //Событие ввода пользователем способа сортировки
        public event NumberEnteredDelegate NumberEnteredEvent;

        public NumberReader(ILogger logger)
        {
            Logger = logger;
        }
        /// <summary>
        /// Считывание давннх о введенном пользователем методе сортировки
        /// </summary>
        public void Read()
        {
            Console.Write("Введите первое число: ");

            //Считываем из консоли сивол
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");

            //Считываем из консоли сивол
            double num2 = double.Parse(Console.ReadLine());

            //Вызываем оповещение о событии
            NumberEntered(num1, num2);

        }

        /// <summary>
        /// Метод, вызывающий событие
        /// </summary>
        /// <param name="num">способ сортировки</param>
        private void NumberEntered(double num1, double num2)
        {
            
            Logger.Event("Данные приняты");
            NumberEnteredEvent?.Invoke(num1, num2);
            

        }
    }
}
