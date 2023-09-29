using System;
using CoinConvert.Convert;
using CoinConvert.Main;

namespace CoinConvert
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuConversion menu = new MenuConversion();
            menu.ChooseOptionMenu();
        }
    }
}
