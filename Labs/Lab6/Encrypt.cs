using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public delegate string EncryptDelegate(string s);
    public class Encrypt
    {
        // simple Caeser cipher 
        public static string Cipher1(String plaintext)
        {
            const int key = 1;          // shift by 1 char
            StringBuilder ciphertext = new StringBuilder(plaintext);

            // Unicode max value is (2 ^ 16) - 1
            int wrap = (int)(char.MaxValue);

            // shift each character forwards by key amount
            for (int i = 0; i < ciphertext.Length; i++)
            {
                ciphertext[i] = (char)((ciphertext[i] + key) % wrap);
            }
            return ciphertext.ToString();

        }

        // simple cipher which reverses a string
        public static string Cipher2(String plaintext)
        {
            char[] text = plaintext.ToCharArray();
            string ciphertext = String.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                ciphertext += text[i];
            }
            return ciphertext;

        }
    }
}
