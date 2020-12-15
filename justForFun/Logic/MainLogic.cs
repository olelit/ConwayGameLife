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

        public void Options()
        {
            throw new NotImplementedException();
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
