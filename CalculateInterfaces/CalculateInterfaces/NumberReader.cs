using System;

namespace CalculateInterfaces
{
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
