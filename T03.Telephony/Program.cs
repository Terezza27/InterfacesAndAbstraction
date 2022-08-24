using System;

namespace T03.Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNimbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            Smartphone sp = new Smartphone();

            foreach (var number in phoneNimbers)
            {
                try
                {
                    Console.WriteLine(sp.Call(number));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            foreach (var website in websites)
            {
                try
                {
                    Console.WriteLine(sp.Browsing(website));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}
