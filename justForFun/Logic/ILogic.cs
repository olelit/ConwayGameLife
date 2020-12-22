using justForFun.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace justForFun.Logic
{
    interface ILogic
    {
        public ILogic BackTo { get;  }
        public IView View { get; }
        public void ShowView();
        public void Options(int opt);
        public bool IsValid(int opt);
        public void Return();

    }
}
