using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fazel87.IO
{
    static class BinaryWriterHelper
    {
        public static void WriteCharBin(this BinaryWriter bin, char Char,int num = 5)
        {
            bin.Write((int)Char * num);
        }
        public static void WriteStringBin(this BinaryWriter bin,string str,int num = 5)
        {
            bin.Write(str.Length);
            foreach(char c in str)
            {
                bin.WriteCharBin(c, num);
            }
        }
    }
}
