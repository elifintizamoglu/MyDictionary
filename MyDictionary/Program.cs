using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            myDictionary<int ,string> vocabulary = new myDictionary<int ,string>();

            vocabulary.Add(1 , "ÇAY");
            vocabulary.Add(2 , "KAHVE");
            vocabulary.Add(3 , "SICAK ÇİKOLATA");

            Console.WriteLine(vocabulary.Length);
            for(int i=0;i<vocabulary.Length;i++)
                Console.WriteLine(vocabulary.Items[i] + "     " + (i + 1)  );
        }
    }
}
