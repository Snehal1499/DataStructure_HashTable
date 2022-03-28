using System;


namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hash Table Program");
            MyMapNode<string,string>hash = new MyMapNode<string,string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "not");
            hash.Add("3", "to");
            hash.Add("4", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th Index Value:"+hash5);
            string hash4 = hash.Get("4");
            Console.WriteLine("4th Index Value:" + hash4);

        }
    }
}
