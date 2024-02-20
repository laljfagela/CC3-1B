using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Web;

namespace CaesarCypher
{
    public class Program
    {
        public static char Cypher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch; 
            }
            char d = char.IsUpper(ch)? 'A': 'a';
            return (char)
            (((ch + key - d) % 26 + 26) % 26 + d);
        }
        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += Cypher(ch, key);

            return output;
        }
        public static string Decipher(string input, int key) 
        {
            return Encipher(input, 26 - key);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string to encrypt ");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Enter your key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Encrypted Data: ");

            string cypherText = Encipher(UserString, key);
            Console.WriteLine(cypherText);
            Console.WriteLine("\n");

            Console.WriteLine("Decrypted data: ");

            string t = Decipher(cypherText, key);
            Console.WriteLine(t);
            Console.Write("\n");

            Console.ReadLine();
        }
    }
}
