using justForFun.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace justForFun.View
{
    interface IView
    {
        public ILogic Logic { get; }
        public void Show();
    }
}
