using System;
using System.ComponentModel;

namespace Practice
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Write Smth: ");
            string ip = Console.ReadLine().ToLower();

            ip = ip.Replace(",", "");
            ip = ip.Replace(".", "");
            ip = ip.Replace("?", "");

            string[] ipStr = ip.Split(' ');

            Dictionary<string, int> di = new Dictionary<string, int>();

            foreach(string el in ipStr) {

                di[el] = el.Length;
            }
            List<KeyValuePair<string, int>> kvp = new List<KeyValuePair<string, int>>(di);

            kvp.Sort((a, b) => a.Key.CompareTo(b.Key));
            kvp.Sort((a, b) => a.Value.CompareTo(b.Value));

            foreach (KeyValuePair<string, int> kv in kvp) {

                Console.Write(kv.Key + "" + kv.Value + "" + kv.Key + " ");
            }
        }
    }
}

//O/P:
//Write Smth: Hello, how are you doing this fine morning?
//are3are how3how you3you fine4fine this4this doing5doing hello5hello morning7morning
