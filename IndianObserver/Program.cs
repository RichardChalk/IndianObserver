using IndianObserver.Observers;
using System.Text.RegularExpressions;

namespace IndianObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vi behöver en publisher
            var group = new Subject.Group();

            // Skapa några observers
            // Bättre med en list?
            var users = new List<User>()
            {
                new User(1),
                new User(2),
                new User(3)
            };

            // Lägg till våra nya users som subscribers
            group.Subscribe(users[0]);
            group.Subscribe(users[1]);
            group.Subscribe(users[2]);

            // Vår subject 'state' har ändrat (fått ett nytt meddelande)
            // Så nu måste vi informera alla våra users
            group.Notify("First New message!");

            // User1 är missnöjd.
            group.UnSubscribe(users[0]);

            // Informera om ett nytt meddelande
            // User1 är inte iunkluderat i listan längre :)
            group.Notify("Second New message!");
        }
    }
}