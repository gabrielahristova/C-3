using System;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string type = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double sum = 0;
            if(name == "Pamporovo")
            {
                if (type == "room for one person")
                {
                    sum = days * 17.50;
                } else if (type == "studio")
                {
                    sum = days * 21;
                }else if (type == "apartment")
                {
                    sum = days * 30;
                }else if (type == "president apartment")
                {
                    sum = days * 40;
                }else
                {
                    Console.WriteLine("error");
                }
            }else if (name == "Bansko")
            {
                if (type == "room for one person")
                {
                    sum = days * 18;
                }
                else if (type == "studio")
                {
                    sum = days * 22;
                }
                else if (type == "apartment")
                {
                    sum = days * 25;
                }
                else if (type == "president apartment")
                {
                    sum = days * 35;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }else if (name == "Borovets")
            {
                if (type == "room for one person")
                {
                    sum = days * 20.50;
                }
                else if (type == "studio")
                {
                    sum = days * 28.50;
                }
                else if (type == "apartment")
                {
                    sum = days * 36;
                }
                else if (type == "president apartment")
                {
                    sum = days * 50;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine($"He will rest for {days} days in {name} in {type} for {sum:F2} lv.");
        }
    }
}
