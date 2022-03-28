using System;

namespace Конвертер_валют
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dollarExchangeRate= 93.7m;
            decimal euroExchangeRate= 102.67m;
            decimal rubleExchangeRate = 1m;

            Random randomAmountMoney = new Random();

            int startRandom = 202;
            int stopRandom = 100000;

            decimal userDollar=randomAmountMoney.Next(startRandom,stopRandom);
            decimal userEuro = randomAmountMoney.Next(startRandom, stopRandom);
            decimal userRuble = randomAmountMoney.Next(startRandom, stopRandom);

            bool flagStopProgram = true;

            while(flagStopProgram)
            {
                Console.Clear();
                Console.WriteLine("Ваш баланс\nРублей - " + userRuble + " Евро - " + userEuro + " Доллар - " + userDollar);
                Console.WriteLine();
                Console.WriteLine("Курс валют на сегодня \nрубль - " + rubleExchangeRate + " доллар - " + dollarExchangeRate);
                Console.WriteLine("рубль - " + rubleExchangeRate + " евро - " + euroExchangeRate);
                Console.Write("Вы хотите провести обмен? ДА Enter, НЕТ нажмите N ");
                string signalKey = Console.ReadLine();

                if(signalKey=="N"||signalKey=="n"||signalKey=="Т"||signalKey=="т")
                {
                    flagStopProgram = false;
                }    
                else
                {
                    Console.WriteLine("Выберите валюту которую хотите обменять\nРубль нажмите - 1\nДоллар нажмите - 2\nЕвро нажмите - 3");
                    string curencySelectionToExchange = Console.ReadLine();
                    Console.Write("Сколько денег вы хотите обменять - ");
                    string moneyToExchange = Console.ReadLine();
                    decimal moneyToExchageDecimal = Convert.ToDecimal(moneyToExchange);
                    Console.WriteLine("Выберите валюту которая вам нужна\nРубль нажмите - 1\nДоллар нажмите - 2\nЕвро нажмите - 3");
                    string desiredCurency = Console.ReadLine();

                    switch (curencySelectionToExchange)
                    {
                        case "1":
                            switch(desiredCurency)
                            {
                                case "1":

                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                            }
                            break;
                        case "2":
                            switch (desiredCurency)
                            {
                                case "1":
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                            }
                            break;
                        case "3":
                            switch (desiredCurency)
                            {
                                case "1":
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                            }
                            break;
                        default:

                            break;

                    }

                }
            }
        }

        private decimal Exchange(decimal moneyToExchange, decimal amountMoney,decimal rate)
        {
            decimal returnMoney = 0;



            return returnMoney;
        }

    }
}
