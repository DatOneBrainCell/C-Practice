//Write a program to reverse a string in place

using System.ComponentModel;

namespace StringThings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write something: ");
            string ip = Console.ReadLine();

            List<char> chLi = new List<char>(ip);

            chLi.Reverse();

            ip = new string(chLi.ToArray());

            Console.WriteLine(ip);
        }
    }
}

//O/P:
//Write something: Hello, how are you doing?
//?gniod uoy era woh , olleH
