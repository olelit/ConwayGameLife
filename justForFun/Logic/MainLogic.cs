using justForFun.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace justForFun.Logic
{
    class MainLogic : ILogic
    {
        public ILogic BackTo => null;

        public IView View => new MainView();

        public bool IsValid(int opt)
        {
            return true;
        }
        public void Options(int opt)
        {
            switch (opt)
            {
                case 0:

                    break;
                case 1:
                    break;
            }
        }

        public void Return()
        {
            throw new NotImplementedException();
        }

        public void ShowView()
        {
            View.Show();
        }
    }
}
