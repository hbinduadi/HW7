using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeConsole
{
    class Program
    {
        public static void GetStringReversed()
        {
            string Text, revsText = "";

            Console.WriteLine("Enter text to see if it's Palindrome");
            Text = Console.ReadLine();
            bool checkNum = Text.All(char.IsDigit);
            if (checkNum == true)
                throw new Exception("Exception Caught!");
            for (int counter = Text.Length - 1; counter >= 0; counter--)
            {
                revsText += Text[counter].ToString();
            }
            if (Text.Equals(revsText, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("String is Palindrome ");
            }
            else
            {
                Console.WriteLine("String is not Palindrome ");
            }
        }




        static void Main(string[] args)
        {
            try
            {
                GetStringReversed();
                while (true)
                {
                    Console.WriteLine("\n Do you still want to Continue?");
                    Console.WriteLine("Press yes to continue and exit to quit....");
                    string input = Console.ReadLine();


                    if ((input == "yes") || (input == "Yes") || (input == "YES"))
                    {
                        GetStringReversed();
                    }
                    else if ((input == "exit") || (input == "Exit") || (input == "EXIT"))
                    {
                        Console.WriteLine("Thank You");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please press carefully...yes to enter and exit to quit");
                    }
                }   

            }
                    catch (IndexOutOfRangeException iex)
                    {
                        Console.WriteLine("Index Out of Range Exception" + iex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("EXCEPTION CAUGHT!...USER SHOULD ENTER ONLY TEXT");
                    }
                    finally
                    {
                        Console.ReadLine();
                   }
                
               
        }
    }
}
