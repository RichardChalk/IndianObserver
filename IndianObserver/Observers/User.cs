using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianObserver.Observers
{
    public class User : ISubscriber
    {
        private int _userId;
        public User(int userId)
        {
            _userId = userId;   
        }
        public void Notify(string msg)
        {
            Console.WriteLine($"UserId {_userId} received message: {msg}");
        }
    }
}
