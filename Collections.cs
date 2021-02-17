using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class Collections
    {
        public void func()
        {
            //ArrayList
            var varset = new ArrayList();
            varset.Add("Hello");
            int[] arr = { 100, 200, 300, 400 };
            varset.AddRange(arr);
            varset[0] = "World!";
            Console.WriteLine(varset[0]);
            varset.Insert(0, "Hellow ");
            varset.Remove(0); //Removes element at index 0
            varset.RemoveRange(0, 2); //Removes two elements starting from 1st item (0 index)
            Console.WriteLine(varset.Contains(300)); //true

            //List
            List<int> Numbers = new List<int>();
            Numbers.Add(1);
            var cities = new List<string>();
            cities.Add("Dhakka");
            Numbers.AddRange(arr);
            Numbers.Insert(1, 11);
            // using foreach LINQ method
            Numbers.ForEach(num => Console.WriteLine(num + ", "));
            Numbers.Remove(10); // removes the first 10 from a list
            Numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //SortedList-Generic(Recommended)
            var numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            Console.WriteLine(numberNames[1]);
            numberNames.Remove(1);//removes key 1 pair
            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }
    }
}
