using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interator_pattern
{
    public interface Iterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}