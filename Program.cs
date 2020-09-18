using System;
using TestIFormatable.Entities;

namespace TestIFormatable
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Id = 1;
            user.Firstname = "Max";
            user.Lastname = "Mustermann";

            Console.WriteLine(user);
            Console.WriteLine(user.ToString());
            Console.WriteLine(user.ToString("O", null));
            Console.WriteLine(user.ToString("J", null));
        }
    }
}
