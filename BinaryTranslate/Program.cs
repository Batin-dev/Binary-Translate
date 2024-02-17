using System;
using System.Text;

namespace BinaryTranslate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something to translate");
            string originalText = Convert.ToString(Console.ReadLine());

            string binaryText = TextToBinary(originalText);
            Console.Clear();

            Console.WriteLine("Original text : " + originalText);
            Console.WriteLine("Text Converted to Binary Format : " + binaryText);
            Console.ReadLine();
        }

        static string TextToBinary(string text)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(text);
            return string.Join(" ", byteArray);
        }
    }
}
