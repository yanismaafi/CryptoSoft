using System;
using System.Collections.Generic;
using System.Text;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.IO;

namespace CryptoSoft
{
    class Encryption
    {

        public void EncryptFile(string sourceFile, string destinationPath)
        {

            File file = new File();
            
            if ( file.checkExistance(sourceFile) == true )
            {
                try
                {
                    string password = "yanis123";
                    UnicodeEncoding UE = new UnicodeEncoding();
                    byte[] key = UE.GetBytes(password);         // Encodes password into a sequence of bytes.


                    FileStream fsCrypt = new FileStream(destinationPath, FileMode.Create);     // Create fsCrypt into destination Path

                    RijndaelManaged RMCrypto = new RijndaelManaged();

                    CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write);   //  Cryptage Algorithm

                    FileStream fsIn = new FileStream(sourceFile, FileMode.Open);      // Open the source File  

                    int data;
                    while ((data = fsIn.ReadByte()) != -1)          //Loop on the source file Byte by Byte
                    {
                        cs.WriteByte((byte)data);                  // Encrypt and write into fsCrypt
                    }


                    fsIn.Close();    // Close all files
                    cs.Close();
                    fsCrypt.Close();

                    Console.WriteLine("\n File Crypted !");

                }
                catch (Exception e)
                {
                    Console.WriteLine("\n Error", e);
                }

            }
        }



        public void DecryptFile(string sourceFile, string destinationPath)
        {
            File file = new File();

            if (file.checkExistance(sourceFile) == true )
            {

                try
                {
                    string password = "yanis123";
                    UnicodeEncoding UE = new UnicodeEncoding();
                    byte[] key = UE.GetBytes(password);

                    FileStream fsCrypt = new FileStream(sourceFile, FileMode.Open);

                    RijndaelManaged RMCrypto = new RijndaelManaged();

                    CryptoStream cs = new CryptoStream(fsCrypt,
                        RMCrypto.CreateDecryptor(key, key),
                        CryptoStreamMode.Read);

                    FileStream fsOut = new FileStream(destinationPath, FileMode.Create);

                    int data;
                    while ((data = cs.ReadByte()) != -1)
                    {
                        fsOut.WriteByte((byte)data);
                    }

                    fsOut.Close();
                    cs.Close();
                    fsCrypt.Close();

                    Console.WriteLine("\n File Decrypted !");

                }
                catch (Exception e)
                {
                    Console.WriteLine("\n Error", e);
                }
            }

       
        }


    }
}
