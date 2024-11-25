using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalProject
{
    internal class CapnCrunchEncoder
    {
        static void Main2(string[] args)
        {
            string original = "Hello World";
            string encoded = CaptainCrunchEncode(original, 13);
            string decoded = CaptainCrunchEncode(encoded, -13);

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Encoded: {encoded}");
            Console.WriteLine($"Decoded: {decoded}");
        }

        static string CaptainCrunchEncode(string input, int shift)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)(((letter + shift - offset + 26) % 26) + offset);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}

