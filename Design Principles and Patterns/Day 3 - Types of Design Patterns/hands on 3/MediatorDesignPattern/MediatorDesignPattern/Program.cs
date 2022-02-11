using System;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chatMediator = new ChatMediator();

            IUser user1 = new User();
            user1.Name = "Sushant";
            chatMediator.AddUser(user1);


            IUser user2 = new ProUser();
            user2.Name = "Sujeet";
            chatMediator.AddUser(user2);


            IUser user3 = new User();
            user3.Name = "Shubham";
            chatMediator.AddUser(user3);

            chatMediator.SendMessage(user2, "Hello Everyone");

            Console.ReadLine();
        }
    }
}
