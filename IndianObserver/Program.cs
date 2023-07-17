using IndianObserver.Observers;
using System.Text.RegularExpressions;

namespace IndianObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var group = new Subject.Group();

            // Bättre med en list?
            var users = new List<User>()
            {
                new User(1),
                new User(2),
                new User(3)
            };

            group.Subscribe(users[0]);
            group.Subscribe(users[1]);
            group.Subscribe(users[2]);

            group.Notify("First New message!");

            group.UnSubscribe(users[0]);

            group.Notify("Second New message!");
        }
    }
}