using System;
using System.Globalization;

namespace CoinConvert.Convert
{
    public class Converter
    {

        public decimal NumberOriginal { get; set; }

        public decimal NumberToConvert { get; private set; }

        public short ModeOperation { get; set; }

        private bool canShowResultConversion;

        public Converter()
        {

        }

        

        public decimal ConvertCoin(decimal numberOriginal, short modeOperation)
        {
            NumberOriginal = numberOriginal;

            do
            {
                switch (modeOperation)
                {
                    case 0://Real To Dolar
                        NumberToConvert = numberOriginal / 5m;
                        Console.WriteLine($"{System.Environment.NewLine} Valor convertido para dolar com sucesso!{System.Environment.NewLine}");
                        break;

                    case 1://Dolar To Real
                        NumberToConvert = numberOriginal * 5m;
                        Console.WriteLine($"{System.Environment.NewLine}Valor convertido para real com sucesso!{System.Environment.NewLine}");
                        break;

                    default:
                        Console.WriteLine($"{System.Environment.NewLine}Opcao inválida, tente novamente digitando um valor válido{System.Environment.NewLine}");
                        modeOperation = short.Parse(Console.ReadLine());

                        break;
                }
            } while (modeOperation!= 0 && modeOperation!=1);

            canShowResultConversion = true;
            ModeOperation = modeOperation;

            return NumberToConvert;
            
        }

        public void ShowResultOfConversion()
        {

            if(canShowResultConversion)
            {
                CultureInfo eua = new CultureInfo("en-US");
                CultureInfo br = CultureInfo.CreateSpecificCulture("pt-BR");
                string textNumberConverted = "";

                if (ModeOperation==0)
                {
                   textNumberConverted = String.Format(eua,"\nValor Convertido: {0:C}\n",NumberToConvert);
                }
                else if(ModeOperation==1)
                {
                   textNumberConverted = String.Format(br, "\nValor Convertido: {0:C}\n", NumberToConvert);
                }

                Console.WriteLine(textNumberConverted);
                return;
            }
            Console.WriteLine($"{System.Environment.NewLine}Não há valores para conferir{System.Environment.NewLine}");
        }
    }
}


