using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int myNumber = 1;
            Boolean numIsOne = myNumber == 1;
            if (numIsOne) {
                Console.Write("You have the number 1\n");
            }
            else {
                Console.Write("You don't have hte number 1.....");
            }

            String myString = "CIS";
            int len = myString.Length;
            Console.WriteLine(len);
            if (myString == "CIS") {
                Console.WriteLine("Your string says CIS");
            }
            else {
                Console.WriteLine("Lame: " + myString);
            }

            // int[] numArr2 = new int[4];
            int[] numArr = {1, 4, 7 , 8};
            for(int i = 0; i < numArr.Length; i++) {
                Console.WriteLine(numArr[i]);
            }

            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(4);
            numList.Add(3);
            numList.Add(1);

            foreach (var i in numList) {
                Console.WriteLine(i);
            }

            Dictionary<int, String> myDict = new Dictionary<int, string>();
            myDict.Add(1, "One");
            myDict.Add(2, "Two");
            myDict.Add(324352, "Not a real adsjfk;ljddsjfkss");


            Console.WriteLine(myDict[324352]);

            Animal myAnimal = new Animal("George", 10);
            Console.WriteLine(myAnimal);

        }
    }
}
