using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Main.Interfaces
{
    public interface ITillController
    {
        void Scan(string item);
        decimal Total();
    }
}
