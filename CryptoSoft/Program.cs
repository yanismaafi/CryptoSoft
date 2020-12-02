using System;

namespace CryptoSoft
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Encryption E = new Encryption();

           E.EncryptFile("C:\\Test\\test.txt", "C:\\New\\test.txt");

          // E.DecryptFile"C:\\Test\\test.txt", "C:\\New\\test.txt");

        }
    }
}
