using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int searches = 0;
            bool bookFound = false;
            string foundit = Console.ReadLine();

            while (foundit != "No More Books")
            {
                
                if (bookName == foundit)
                {
                    bookFound = true;
                    break;
                }
                searches++;
                foundit = Console.ReadLine();
            }


            if (bookFound)
            {
                Console.WriteLine($"You checked {searches} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {searches} books.");
            }
        }
    }
}
