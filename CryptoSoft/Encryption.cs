using System;
using System.Collections.Generic;
using System.Text;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;

namespace CryptoSoft
{
    class Encryption
    {


        public void EncryptFile(string sourceFile, string destinationFile)
        {

            try
            {
                string password = "yanis123";
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

 
                FileStream fsCrypt = new FileStream(destinationFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();    // Algorithme de cryptage

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(sourceFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                {
                    cs.WriteByte((byte)data);
                }


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();

                Console.WriteLine("File crypted !");
           
            }catch (Exception e)
            {
                Console.WriteLine("error",e);
            }
        }



        public void DecryptFile(string sourceFile, string destinationFile)
        {

          try  {

                string password = "yanis123";
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(sourceFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(destinationFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                {
                    fsOut.WriteByte((byte)data);
                }

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

                Console.WriteLine("File Decrypted !");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error", e);
            }
        }


    }
}
