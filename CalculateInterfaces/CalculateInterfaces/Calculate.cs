using System;

interface ISum
{
    public void Sum(double a, double b);

}
namespace CalculateInterfaces
{
    class Calculate : ISum
    {
        ILogger Logger { get;  }
        public Calculate(ILogger logger)
        {
            Logger = logger;
        }
        public void Sum(double a, double b)
        {
            Logger.Event("Запуск расчета");
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Logger.Event("Калькулятор успешно завершил работу");
        }
    }
}
