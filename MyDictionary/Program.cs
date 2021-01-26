using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.Add("Berkay", 17);
            myDictionary.Add("Ali",15);
            myDictionary.Add("Hasan",21);

            myDictionary.List();
        }
    }
}
