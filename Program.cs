using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> persons = new MyDictionary<string, int>();
            persons.Add("Selman Şenol", 22);
            persons.Add("Ayça Temur", 20);
            
            Console.WriteLine("Ad Soyad: " + persons.Items1[0] + " " + "Yaş: " + persons.Items2[0]);
            Console.WriteLine("Ad Soyad: " + persons.Items1[1] + " " + "Yaş: " + persons.Items2[1]);
            
        }
    }
}
