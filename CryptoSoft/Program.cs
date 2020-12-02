using System;

namespace CryptoSoft
{
    class Program
    {
        static void Main(string[] args)
        {

            Encryption E = new Encryption();

           E.EncryptFile("C:\\Users\\ASUS\\Desktop\\ok\\haha.txt", "C:\\Users\\ASUS\\Desktop\\test\\haha.txt");
            
          // E.DecryptFile("C:\\Users\\ASUS\\Desktop\\test\\haha.txt", "C:\\Users\\ASUS\\Desktop\\temp\\haha.txt");
        }
    }
}
