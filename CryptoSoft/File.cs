using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CryptoSoft
{
    class File
    {

        public string getExtention(string File)
        {
             return System.IO.Path.GetExtension(File);    
        }


        public bool checkExistance(string File)
        {
           if(System.IO.File.Exists(File) == true)
            {
                return true;
            }

            return false;
        }
    }
}
