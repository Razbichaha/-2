using System;

namespace Конвертер_валют
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] courseMoney = { 93.7m, 102.67m, 1m };
            decimal[] userMoney = { 0, 0, 0 };
            string[] nameMoney = { "Рубль", "Долар", "Евро" };

            Random randomAmountMoney = new Random();

            int startRandom = 202;
            int stopRandom = 100000;

            for(int i=0;i<userMoney.Length;i++)
            {
                userMoney[i]=randomAmountMoney.Next(startRandom, stopRandom);
            }

            bool flagStopProgram = true;

            while (flagStopProgram)
            {
                Console.Clear();
                Console.WriteLine("Ваш баланс");

                for (int i = 0; i < userMoney.Length; i++)
                {
                    Console.WriteLine(nameMoney[i]+ " - " + (i + 1)+" " + userMoney[i]);
                }
                Console.WriteLine("Курс валют на сегодня");

                for (int i = 0; i < courseMoney.Length; i++)
                {
                    Console.WriteLine(nameMoney[i] + " - " + (i + 1)+" " + courseMoney[i]);
                }
                Console.Write("Вы хотите провести обмен? ДА нажмите Enter, НЕТ нажмите N, Для выхода наберите exit ");
                string signalKey = Console.ReadLine();

                if (signalKey == "N" || signalKey == "n" || signalKey == "Т" || signalKey == "т")
                {}
                else if (signalKey == "exit") 
                {
                    flagStopProgram = false; 
                }
                else
                {
                    Console.WriteLine("Выберите валюту которую хотите обменять\nРубль нажмите - 1\nДоллар нажмите - 2\nЕвро нажмите - 3");
                    int castToArrayCellMassiv = 1;
                    int curencySelectionToExchange = Convert.ToInt32(Console.ReadLine()) -castToArrayCellMassiv;
                    Console.Write("Сколько денег вы хотите обменять - ");
                    decimal moneyToExchage = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Выберите валюту которая вам нужна\nРубль нажмите - 1\nДоллар нажмите - 2\nЕвро нажмите - 3");
                    int desiredCurency = Convert.ToInt32(Console.ReadLine())-castToArrayCellMassiv;

                    if(moneyToExchage<=userMoney[curencySelectionToExchange])
                    {
                        userMoney[curencySelectionToExchange] = userMoney[curencySelectionToExchange] - moneyToExchage;
                        userMoney[desiredCurency] = moneyToExchage * courseMoney[desiredCurency];
                        Console.WriteLine("На своем счету после обмена вы имеете");

                        for (int i = 0; i < userMoney.Length; i++)
                        {
                            Console.WriteLine(nameMoney[i] + " - " + (i + 1) + " " + userMoney[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег выберите, меньшее колличество");
                    }
                }
                Console.WriteLine("Для продолжения нажмите Enter");
                Console.ReadLine();
            }
            

        }
    }
}
