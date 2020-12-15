using justForFun.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace justForFun.View
{
    class MainView: IView
    {
        public ILogic Logic => new MainLogic();

        public void Show()
        {
            Console.WriteLine("Выберите опцию: ");
            Console.WriteLine("1 - Обновления в социальных сетях");
            Console.WriteLine("2 - Настройки");


        }
    }
}
