using System;


namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hash Table Program");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "beacuse");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "beacuse");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");

            string hash5 = hash.Get("3");
            Console.WriteLine("5th index Value is : " + hash5);


            string hash2 = hash.Get("15");
            Console.WriteLine("2th index Value is : " + hash2);

            string hash17 = hash.Remove("15");

            Console.WriteLine("After Removing ");

            string hashremove = hash.Get("15");
            Console.WriteLine("15th index Value is : " + hashremove);
        }
    }
}
