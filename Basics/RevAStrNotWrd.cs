namespace StringThings {

    internal class Program {

        static void Main() {

            Console.Write("Write something else: ");
            string ip = Console.ReadLine();

            string[] words = ip.Split(" ");

            ip = string.Join(" ", words.Reverse());

            Console.WriteLine(ip);
        }
    }
}

//O/P:
//Write something else: Hi my friend, how are you doing today?
//today? doing you are how friend, my Hi
