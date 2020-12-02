using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoSoft
{
    class File
    {
        public string getExtention(string File)
        {
             return System.IO.Path.GetExtension(File);    
        }
    }
}
