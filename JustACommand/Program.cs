using System;


namespace JustACommand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I've been executed successfully!");
        }

        static public void CallMeIfYouCan(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine($"CallMeIfYouCan says: Hello, {name}!.");
            }
            
        }

        static public void CallMeIfYouCan2(string name)
        {
            Console.WriteLine($"CallMeIfYouCan says: Hello, {name}!.");
        }
    }
}
