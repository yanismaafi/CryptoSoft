using System;

namespace CryptoSoft
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Encryption E = new Encryption();

           E.EncryptFile("C:\\Source\\myFile.txt", "C:\\Crypted\\myFile.txt");        // Encrypt

           // E.DecryptFile("C:\\Crypted\\myFile.txt", "C:\\Dest\\myFile.txt");      // Decrypt

        }
    }
}
