using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = "My name is arif";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Dilara";



            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name i");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2,5);


            Console.WriteLine(result13);
          
        }
    }
}
