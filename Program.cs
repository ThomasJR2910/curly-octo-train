using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Top //
            Console.WriteLine("This month surly couldn't have gotten any worse,");
            Thread.Sleep(750);
            Console.WriteLine("Started today at rock bottom....");
            Thread.Sleep(500);
            Console.WriteLine("now im deeper.");
            Thread.Sleep(500);
            Console.WriteLine("lets hope tomorrow is better");
            Thread.Sleep(500);
            Console.WriteLine("but I have a exam tomrrow");
            Thread.Sleep(500);
            Console.WriteLine("and tomorrows monday");
            // Middle //
            Console.ReadLine();
            Console.WriteLine("Indeed tomorrow was Monday");
            Console.WriteLine("But Jimmy was a little to tired to realise that it was monday");
            Console.WriteLine("So Jimmy went down to the zoo");
            Console.WriteLine("Not realising that it was monday");
            Console.WriteLine("The zoo is closed on monday");
            Console.WriteLine("The animals roam free on a monday");
            Console.WriteLine("Jimmy opened the gates and slipped inside");
            Console.WriteLine("It was quiet");
            Console.WriteLine("Almost too quiet");
            Console.WriteLine("But Jimmy didn't care");
            Console.WriteLine("He wanted an ice cream from the ice cream cart");
            Console.WriteLine("And then there was a bear!");
            // Bottom //
            Console.ReadLine();
            Console.WriteLine("The bear (not from the TV show 'The bear') sold me a new guitar.");
            Console.WriteLine("It was a baritone electric guitar. The bear's son's name was Jimmy I think.");
            Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"I am {i * 3} years old");
            }
            Console.ReadLine();
            
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            // Lab 1 //
            string input;
            int uppercase = 0, lowercase = 0, other = 0;
            Console.WriteLine("Please Enter Text");
            input = Console.ReadLine();

            foreach (char i in input)
            {
                if (char.IsLower(i))
                {
                    //Console.WriteLine("lowercase detected");
                    lowercase += 1;
                }
                else if (char.IsUpper(i))
                {
                    //Console.WriteLine("Uppercase detected");
                    uppercase += 1;
                }
                else
                {
                    //Console.WriteLine("Other Char");
                    other += 1;
                }
            }
            Console.WriteLine($"\nThere are {uppercase} uppercase letters\nThere are {lowercase} lowercase letters\nThere are {other} other characters");
            Console.ReadLine();
            // Lab 2 //
            int totalSeconds, hours, minutes, seconds;
            string temp;

            Console.Write("How many seconds do you want converted into Hours, Minutes and Seconds? ");
            temp = Console.ReadLine();
            totalSeconds = Convert.ToInt32(temp);

            hours = totalSeconds / 3600;
            minutes = (totalSeconds % 3600) / 60;
            seconds = totalSeconds % 60;

            Console.Write($"{totalSeconds} seconds is {hours} hours, {minutes} minutes and {seconds} seconds!");
            Console.ReadLine();
            // Lab 3 //

        }
    }
}
