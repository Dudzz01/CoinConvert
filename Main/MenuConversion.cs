using System;
using CoinConvert.Convert;

namespace CoinConvert.Main
{
    public class MenuConversion
    {
        public void ChooseOptionMenu()
        {
            Converter convert = new Converter();

            short? option = null;


            while(option != 0)
            {
                Console.WriteLine($"Selecione as seguintes opcoes =>  0: Encerrar Programa || 1:Converter Moedas || 2:Mostrar Resultado da Conversao");
                option = short.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                            System.Environment.Exit(0);
                        break;

                    case 1:

                        Console.WriteLine($"{System.Environment.NewLine}Digite o valor númerico que deseja converter{System.Environment.NewLine}");
                        convert.NumberOriginal = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"{System.Environment.NewLine}Digite 0: Converter Real para Dolar  ||  Digite 1: Converter Dolar para Real{System.Environment.NewLine}");
                        convert.ModeOperation = short.Parse(Console.ReadLine());

                        convert.ConvertCoin(convert.NumberOriginal,convert.ModeOperation);
                        break;

                    case 2:
                        convert.ShowResultOfConversion();
                        break;

                    default:
                        Console.WriteLine("Opcao inválida, tente novamente");
                        break;
                }
            }
             


        }
    }
}
