using System;

namespace StaticConstructorMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User(1, "Enes", "Bayram");
            u1.bilgileriGoster();
            u1.zamYap(700);

            Console.ReadLine();

        }
    }
}
