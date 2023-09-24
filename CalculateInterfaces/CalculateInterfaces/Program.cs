using System;

namespace CalculateInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            ISum sum = new Calculate(logger);
            NumberReader numberReader = new NumberReader(logger);
            numberReader.NumberEnteredEvent += sum.Sum;
            logger.Event("Калькулятор запущен");

            for (; ;)
            {
                try
                {
                    
                    numberReader.Read();

                }
                catch (Exception ex)
                {
                    
                    logger.Error(ex.Message);
                }
                

                
            }
        }
    }
    
}
