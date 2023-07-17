using IndianObserver.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianObserver.Subject
{
    public class Group
    {
        private List<ISubscriber> _users = new List<ISubscriber>();

        // SUBSCRIBE//////////////////////////////////////////////////////////
        // Option 1: Normal
        //public void Subscribe(ISubscriber user)
        //{
        //    _users.Add(user);
        //}

        // Option 2: Lamnda anyone?
        public void Subscribe(ISubscriber user) => _users.Add(user);

        // UNSUBSCRIBE////////////////////////////////////////////////////////
        // Option 1: Normal
        //public void UnSubscribe(ISubscriber user)
        //{
        //    _users.Remove(user);
        //}

        // Option 2: Lamnda anyone?
        public void UnSubscribe(ISubscriber user) => _users.Remove(user);

        // NOTIFY/////////////////////////////////////////////////////////////
        public void Notify(string msg)
        {
            foreach (var user in _users)
            {
                user.Notify(msg);
            }
        }
    }
}
