using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_fifteen
{
    public interface IPlayable
    {
        void Shift(int value);
        bool Winner();
    }
}
