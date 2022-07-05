using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace observer_pattern
{
    public interface Observer
    {
        void Update();
    }

    public interface Observer<T>{
        void Update(T value);
    }
}