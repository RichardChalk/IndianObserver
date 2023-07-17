using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianObserver.Observers
{
    public interface ISubscriber
    {
        void Notify(string msg);
    }
}
